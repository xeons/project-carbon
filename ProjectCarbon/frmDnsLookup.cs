using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace ProjectCarbon
{
    public partial class frmDnsLookup : Form
    {
        public frmDnsLookup()
        {
            InitializeComponent();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            char[] alpha = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ-".ToCharArray();
            try
            {
                IPHostEntry ipHostEntry = Dns.GetHostEntry(txtHostname.Text);
                lstResults.Items.Clear();
                if (txtHostname.Text.IndexOfAny(alpha) != -1)
                {
                    foreach (IPAddress ip in ipHostEntry.AddressList)
                        lstResults.Items.Add(ip.ToString());
                }
                else
                {
                    lstResults.Items.Add(ipHostEntry.HostName);
                }
            }
            catch (System.Net.Sockets.SocketException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
    }
}