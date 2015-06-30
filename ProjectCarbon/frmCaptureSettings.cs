using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectCarbon
{
    public partial class frmCaptureSettings : Form
    {
        public frmCaptureSettings()
        {
            InitializeComponent();
        }

        private void CaptureSettings_Load(object sender, EventArgs e)
        {
            chkStartCaptureAtStartup.Checked =
                ProjectCarbon.Properties.Settings.Default.StartUpCapture;
            
            chkStartMinimized.Checked =
                ProjectCarbon.Properties.Settings.Default.StartUpMinimized;
            
            chkStartWithWindows.Checked =
                ProjectCarbon.Properties.Settings.Default.StartUpWindows;
            
            picPacketDisplayBackground.BackColor =
                ProjectCarbon.Properties.Settings.Default.PacketDisplayBackgroundColor;
            
            picPacketDisplayFontColor.BackColor =
                ProjectCarbon.Properties.Settings.Default.PacketDisplayFontColor;

            picPacketListBackgroundColor.BackColor =
                ProjectCarbon.Properties.Settings.Default.PacketListBackgroundColor;

            picPacketListTextColor.BackColor =
                ProjectCarbon.Properties.Settings.Default.PacketListTextColor;
            
            btnPacketListFont.Font = 
                ProjectCarbon.Properties.Settings.Default.PacketDisplayFontFace;

            chkAutoScrollPacketList.Checked =
                ProjectCarbon.Properties.Settings.Default.AutoScrollPacketList;

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ProjectCarbon.Properties.Settings.Default.StartUpCapture =
                chkStartCaptureAtStartup.Checked;
            
            ProjectCarbon.Properties.Settings.Default.StartUpMinimized =
                chkStartMinimized.Checked;
            
            ProjectCarbon.Properties.Settings.Default.StartUpWindows =
                chkStartWithWindows.Checked;
            
            ProjectCarbon.Properties.Settings.Default.PacketDisplayBackgroundColor =
                picPacketDisplayBackground.BackColor;
            
            ProjectCarbon.Properties.Settings.Default.PacketDisplayFontColor =
                picPacketDisplayFontColor.BackColor;

            ProjectCarbon.Properties.Settings.Default.PacketDisplayFontFace =
                btnPacketListFont.Font;
            
            ProjectCarbon.Properties.Settings.Default.PacketListBackgroundColor =
                picPacketListBackgroundColor.BackColor;

            ProjectCarbon.Properties.Settings.Default.PacketListTextColor =
                picPacketListTextColor.BackColor;

            ProjectCarbon.Properties.Settings.Default.AutoScrollPacketList =
                chkAutoScrollPacketList.Checked;

            ProjectCarbon.Properties.Settings.Default.Save();

            this.Close();
        }

        private void picPacketListBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() != DialogResult.Cancel)
                picPacketListBackgroundColor.BackColor = colorDlg.Color;
        }

        private void picPacketListTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() != DialogResult.Cancel)
                picPacketListTextColor.BackColor = colorDlg.Color;
        }

        private void picPacketDisplayFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() != DialogResult.Cancel)
                picPacketDisplayFontColor.BackColor = colorDlg.Color;
        }

        private void picPacketDisplayBackground_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() != DialogResult.Cancel)
                picPacketDisplayBackground.BackColor = colorDlg.Color;
        }

        private void btnPacketListFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = btnPacketListFont.Font;
            fontDialog.AllowVectorFonts = false;
            fontDialog.FontMustExist = true;
            fontDialog.ShowEffects = true;
            fontDialog.AllowVerticalFonts = false;
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
                btnPacketListFont.Font = fontDialog.Font;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}