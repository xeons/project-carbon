using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjectCarbon.Properties;

namespace ProjectCarbon
{
    public partial class frmCaptureFilters : Form
    {
        public frmCaptureFilters()
        {
            InitializeComponent();
        }

        private void cmdApply_Click(object sender, EventArgs e)
        {
            Global.FilteredProtocolList.Clear();
            for (int i = 0; i < clbProtocolFilters.CheckedIndices.Count; i++)
            {
                Global.FilteredProtocolList.Add((string)clbProtocolFilters.Items[clbProtocolFilters.CheckedIndices[i]]);
            }
            Global.ProtocolFilterInclusive = rbInclusiveProtocolFilter.Checked;

            Global.FilteredPortList.Clear();
            for (int i = 0; i < lstFilteredPorts.Items.Count; i++)
                Global.FilteredPortList.Add((int)lstFilteredPorts.Items[i]);
            Global.PortFilterInclusive = rbInclusivePortFilter.Checked;

            this.Close();
        }

        private void CaptureFilters_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Global.FilteredProtocolList.Count; i++)
            {
                int itemIndex = clbProtocolFilters.FindString(Global.FilteredProtocolList[i]);
                clbProtocolFilters.SetItemChecked(itemIndex, true);
            }

            if (Global.ProtocolFilterInclusive)
                rbInclusiveProtocolFilter.Checked = true;
            else
                rbExclusiveProtocolFilter.Checked = true;

            if (Global.PortFilterInclusive)
                rbInclusivePortFilter.Checked = true;
            else
                rbExclusivePortFilter.Checked = true;

            for (int i = 0; i < Global.FilteredPortList.Count; i++)
                lstFilteredPorts.Items.Add((int)(Global.FilteredPortList[i]));
        }

        private void btnAddCustomPort_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (txtPort.Text.Length > 0)
            {
                try
                {
                    i = int.Parse(txtPort.Text);
                    if (i > 0)
                        lstFilteredPorts.Items.Add((int)i);
                }
                catch (FormatException)
                {
                    MessageBox.Show("There was a problem with the port you attempted to add.", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddPort_Click(object sender, EventArgs e)
        {
            if(lstCommonPorts.SelectedItem != null)
                lstFilteredPorts.Items.Add(int.Parse((string)lstCommonPorts.SelectedItem));
        }

        private void btnRemovePort_Click(object sender, EventArgs e)
        {
            if (lstFilteredPorts.SelectedItem != null)
                lstFilteredPorts.Items.RemoveAt(lstFilteredPorts.SelectedIndex);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lstFilteredPorts.Items.Clear();
        }
    }
}