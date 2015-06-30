using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

using ProjectCarbon.Properties;
using ProjectCarbon.Protocols;

using Tamir.IPLib;
using Tamir.IPLib.Packets;

namespace ProjectCarbon
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (PcapDevice dev in Global.DeviceList)
            {
                tscbInterface.Items.Add(dev.PcapDescription);
            }
            tscbInterface.SelectedIndex = 0;

            spynetStatusPanel.Text = "Status: Idle...";
            cboDisplayMode.SelectedIndex = 0;

            ApplySettings();

            // This event is fired when the properties are saving
            Settings.Default.SettingsSaving += 
                new System.Configuration.SettingsSavingEventHandler(Default_SettingsSaving);
        }


        void Default_SettingsSaving(object sender, CancelEventArgs e)
        {
            ApplySettings();
            if (Settings.Default.StartUpWindows)
                Functions.SetStartup();
            else
                Functions.RemoveStartup();
            
        }

        private void ApplySettings()
        {
            // Let's load the options
            rtbDisplay.BackColor =
                Settings.Default.PacketDisplayBackgroundColor;
            rtbDisplay.ForeColor =
                Settings.Default.PacketDisplayFontColor;
            rtbDisplay.Font =
                Settings.Default.PacketDisplayFontFace;
            packetCaptureList.BackColor =
                Settings.Default.PacketListBackgroundColor;
            packetCaptureList.ForeColor =
                Settings.Default.PacketListTextColor;
        }

        private void device_PcapOnPacketArrival(object sender, Packet packet)
        {
            try
            {
                Global.PacketCapturedEvent packetCapturedEvent
                     = new Global.PacketCapturedEvent(OnPacketCaptured);

                this.BeginInvoke(packetCapturedEvent, new object[] { packet });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void OnPacketCaptured(Packet packet)
        {
            ListViewItem listViewItem = 
                packetCaptureList.Items.Add(packetCaptureList.Items.Count.ToString());
            
            listViewItem.SubItems.Add(packet.Timeval.Date.ToString());
            listViewItem.SubItems.Add(((EthernetPacket)packet).SourceHwAddress.ToUpper());
            listViewItem.SubItems.Add(((EthernetPacket)packet).DestinationHwAddress.ToUpper());

            if (packet is IPPacket)
            {
                listViewItem.SubItems.Add(((IPPacket)packet).IPProtocol.ToString());
                listViewItem.SubItems.Add(((IPPacket)packet).SourceAddress.ToString());
                listViewItem.SubItems.Add(((IPPacket)packet).DestinationAddress.ToString());
            }
            else
            {
                listViewItem.SubItems.Add("--");
                listViewItem.SubItems.Add("--");
                listViewItem.SubItems.Add("--");
            }

            if (packet is TCPPacket)
            {
                listViewItem.SubItems.Add(((TCPPacket)packet).SourcePort.ToString());
                listViewItem.SubItems.Add(((TCPPacket)packet).DestinationPort.ToString());
            }
            else if (packet is UDPPacket)
            {
                listViewItem.SubItems.Add(((UDPPacket)packet).SourcePort.ToString());
                listViewItem.SubItems.Add(((UDPPacket)packet).DestinationPort.ToString());
            }
            else
            {
                listViewItem.SubItems.Add("--");
                listViewItem.SubItems.Add("--");
            }


            // Add this captured packet to the list.
            Global.CapturedPackets.Add(packet);

            // Update the packet list.
            packetsInBufferStatus.Text = "Captured Packets: " + Global.CapturedPackets.Count;

            // Scroll if autoscroll is enabled.
            if (Settings.Default.AutoScrollPacketList == true)
            {
                //lvi.Selected = true;
                listViewItem.EnsureVisible();
            }
        }

        private void DisplayCapture(byte[] buffer)
        {
            rtbDisplay.Clear();
            switch (cboDisplayMode.SelectedIndex)
            {
                case 0:
                    rtbDisplay.AppendText(Functions.GetHexBlock(buffer));
                    break;
                case 1:
                    rtbDisplay.AppendText(Functions.GetHexOnly(buffer));
                    break;
                case 2:
                    rtbDisplay.AppendText(Functions.GetDecBlock(buffer));
                    break;
                case 3:
                    rtbDisplay.AppendText(Functions.GetDecOnly(buffer));
                    break;
                case 4:
                    rtbDisplay.AppendText(Functions.GetSafeString(buffer));
                    break;
            }
        }

        #region Form Events
        private void btnStartCapture_Click(object sender, EventArgs e)
        {
            StartCapture();
        }

        private void packetCaptureList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Packet packet = Global.CapturedPackets[e.ItemIndex];
            lblPacketSize.Text = "Packet Size: " + ((EthernetPacket)packet).Bytes.Length.ToString();
            if (chkStripHeaders.Checked == true)
                DisplayCapture(packet.Data);
            else
                DisplayCapture(((EthernetPacket)packet).Bytes);

        }

        private void btnStopCapture_Click(object sender, EventArgs e)
        {
            StopCapture();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAboutDialog aboutDialog = new frmAboutDialog();
            aboutDialog.ShowDialog();
        }

        private void btnClearCaptureLog_Click(object sender, EventArgs e)
        {
            ClearCaptureLog();
        }

        private void btnSaveCaptureFile_Click(object sender, EventArgs e)
        {
            SaveCaptureFile();
        }

        private void btnLoadCaptureFile_Click(object sender, EventArgs e)
        {
            LoadCaptureFile(false);
        }

        private void btnCaptureFilters_Click(object sender, EventArgs e)
        {
            ShowCaptureFiltersDialog();
        }

        private void chkStripTCPIPHeaders_CheckStateChanged(object sender, EventArgs e)
        {
            if (packetCaptureList.SelectedItems.Count > 0)
                packetCaptureList_ItemSelectionChanged(packetCaptureList, new ListViewItemSelectionChangedEventArgs(packetCaptureList.SelectedItems[0], packetCaptureList.SelectedItems[0].Index, true));
        }

        private void mnuOpenCaptureFile_Click(object sender, EventArgs e)
        {
            LoadCaptureFile(false);
        }

        private void mnuOpenAndAppend_Click(object sender, EventArgs e)
        {
            LoadCaptureFile(true);
        }

        private void mnuStartCapture_Click(object sender, EventArgs e)
        {
            StartCapture();
        }

        private void mnuStopCapture_Click(object sender, EventArgs e)
        {
            StopCapture();
        }

        private void mnuClearCapturedPackets_Click(object sender, EventArgs e)
        {
            ClearCaptureLog();
        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            ShowCaptureSettings();
        }

        private void mnuFilters_Click(object sender, EventArgs e)
        {
            ShowCaptureFiltersDialog();
        }

        private void mnuSaveCaptureFile_Click(object sender, EventArgs e)
        {
            SaveCaptureFile();
        }

        private void btnCaptureSettings_Click(object sender, EventArgs e)
        {
            ShowCaptureSettings();
        }


        private void mnuDisplayWinsockInfo_Click(object sender, EventArgs e)
        {
            frmSocketInformation socketInformation = new frmSocketInformation();
            socketInformation.ShowDialog();
        }

        private void mnuAdapterPerformance_Click(object sender, EventArgs e)
        {
        }

        private void mnuVisitWebsite_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "http://www.xeons.net/");
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void niTrayIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            // Start capturing at startup
            if (Settings.Default.StartUpCapture)
                StartCapture();

            // Startup Minimized to tray
            if (Settings.Default.StartUpMinimized)
                WindowState = FormWindowState.Minimized;
        }

        private void savePacketDumpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePacketDump();
        }

        private void mnuTrayStartCapture_Click(object sender, EventArgs e)
        {
            StartCapture();
        }

        private void mnuTrayStopCapture_Click(object sender, EventArgs e)
        {
            StopCapture();
        }

        private void mnuTraySettings_Click(object sender, EventArgs e)
        {
            ShowCaptureSettings();
        }

        private void mnuTrayFilters_Click(object sender, EventArgs e)
        {
            ShowCaptureFiltersDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuDnsLookup_Click(object sender, EventArgs e)
        {
            frmDnsLookup dnsLookup = new frmDnsLookup();
            dnsLookup.ShowDialog();
        }

        private void chkStripTCPIPHeaders_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboDisplayModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (packetCaptureList.SelectedItems.Count > 0)
                packetCaptureList_ItemSelectionChanged(packetCaptureList, new ListViewItemSelectionChangedEventArgs(packetCaptureList.SelectedItems[0], packetCaptureList.SelectedItems[0].Index, true));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void packetCaptureList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void StartCapture()
        {
            Global.DeviceList[tscbInterface.SelectedIndex].PcapOnPacketArrival += 
                new SharpPcap.PacketArrivalEvent(device_PcapOnPacketArrival);
            
            Global.DeviceList[tscbInterface.SelectedIndex].PcapOpen(true, 1000);
            
            Global.DeviceList[tscbInterface.SelectedIndex].PcapStartCapture();

            tscbInterface.Enabled = false;
            btnStartCapture.Enabled = false;
            mnuStartCapture.Enabled = false;

            spynetStatusPanel.Text = "Status: Capturing Packets...";
        }

        private void StopCapture()
        {
            Global.DeviceList[tscbInterface.SelectedIndex].PcapStopCapture();
            
            Global.DeviceList[tscbInterface.SelectedIndex].PcapClose();
            
            tscbInterface.Enabled = true;
            btnStartCapture.Enabled = true;
            mnuStartCapture.Enabled = true;
            
            spynetStatusPanel.Text = "Status: Capture Stopped.";
        }

        private void ClearCaptureLog()
        {
            if (MessageBox.Show("Are you sure you want to clear the captured packets list?", 
                "Project Carbon", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                packetCaptureList.Items.Clear();
                Global.CapturedPackets.Clear();
                packetsInBufferStatus.Text = "Captured Packets: " + Global.CapturedPackets.Count;
            }
        }

        private void LoadCaptureFile(bool append)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Title = "Load Capture";
            openFileDialog.Filter = "ProjectCarbon Capture File (*.cap2)|*.cap2|CaptureNet Files (*.cap)|*.cap|All Files (*.*)|*.*";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                // Let's open the capture file and start reading it.
                using (FileStream fs = new FileStream(openFileDialog.FileName, 
                    FileMode.Open))
                {
                    BinaryReader br = new BinaryReader(fs);

                    byte nameLength = br.ReadByte();
                    byte[] fileIdentifier = new byte[5];

                    if (nameLength > 1 && nameLength < 20)
                        fileIdentifier = br.ReadBytes(nameLength);

                    if (Encoding.ASCII.GetString(fileIdentifier).IndexOf("SpyNet") != -1)
                    {
                        do
                        {
                            ushort packetLength = br.ReadUInt16();
                            byte[] preData = br.ReadBytes(28);
                            byte[] packetData = br.ReadBytes(packetLength - 14);
                            if (packetData.Length > 0)
                            {
                                //PacketCaptured();
                                // TODO: Fix
                            }
                        }
                        while (br.BaseStream.Position < br.BaseStream.Length);
                        return;
                    }

                    fs.Position = 0;

                    try
                    {
                        if (!append)
                        {
                            packetCaptureList.Items.Clear();
                            Global.CapturedPackets.Clear();
                        }

                        //List<IpProtocol> capturedPacketsLoaded = (List<IpProtocol>)bf.Deserialize(fs);
                        //foreach (IpProtocol ipp in capturedPacketsLoaded.ToArray())
                        //{
                        //    PacketCaptured(ipp);
                        //}
                    }
                    catch (FileLoadException)
                    {
                    }
                    catch (SerializationException)
                    {
                        MessageBox.Show("There was an error while attempting to load this capture file. It may have become corrupted or obsolete.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private static void SaveCaptureFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.Title = "Save Capture";
            saveFileDialog.Filter = "ProjectCarbon Capture File (*.cap2)|*.cap2|All Files|*.*";
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream(saveFileDialog.FileName,
                    FileMode.OpenOrCreate))
                {
                    bf.Serialize(fs, Global.CapturedPackets);
                }
            }
        }

        private static void SavePacketDump()
        {
        }

        private static void ShowCaptureFiltersDialog()
        {
            frmCaptureFilters captureFilters = new frmCaptureFilters();
            captureFilters.ShowDialog();
        }

        private static void ShowCaptureSettings()
        {
            frmCaptureSettings captureSettings = new frmCaptureSettings();
            captureSettings.ShowDialog();
        }
    }
}