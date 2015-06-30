using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace ProjectCarbon
{
    public partial class frmSocketInformation : Form
    {
        public frmSocketInformation()
        {
            InitializeComponent();
        }

        private void frmSocketInformation_Load(object sender, EventArgs e)
        {
            PopulateSocketInformation();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateSocketInformation()
        {
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            lstSocketInformation.Items.Clear();
            lstSocketInformation.Items.Add(String.Format("Interface information for {0}.{1}",
                    computerProperties.HostName, computerProperties.DomainName));
            
            if (nics == null || nics.Length < 1)
            {
                lstSocketInformation.Items.Add("  No network interfaces found.");
                return;
            }

            lstSocketInformation.Items.Add(String.Format("  Number of interfaces .................... : {0}", nics.Length));
            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                lstSocketInformation.Items.Add("");
                lstSocketInformation.Items.Add(adapter.Description);
                lstSocketInformation.Items.Add(String.Empty.PadLeft(adapter.Description.Length, '='));
                lstSocketInformation.Items.Add(String.Format("  Interface type .......................... : {0}", adapter.NetworkInterfaceType));
                lstSocketInformation.Items.Add(String.Format("  Physical Address ........................ : {0}",
                           adapter.GetPhysicalAddress().ToString()));
                lstSocketInformation.Items.Add(String.Format("  Operational status ...................... : {0}",
                    adapter.OperationalStatus));
                string versions = "";

                // Create a display string for the supported IP versions.
                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    versions = "IPv4";
                }
                if (adapter.Supports(NetworkInterfaceComponent.IPv6))
                {
                    if (versions.Length > 0)
                    {
                        versions += " ";
                    }
                    versions += "IPv6";
                }
                lstSocketInformation.Items.Add(String.Format("  IP version .............................. : {0}", versions));
                PopulateIPAddresses(properties);

                // The following information is not useful for loopback adapters.
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                {
                    continue;
                }
                lstSocketInformation.Items.Add(String.Format("  DNS suffix .............................. : {0}",
                    properties.DnsSuffix));

                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    IPv4InterfaceProperties ipv4 = properties.GetIPv4Properties();
                    lstSocketInformation.Items.Add(String.Format("  MTU...................................... : {0}", ipv4.Mtu));
                    if (ipv4.UsesWins)
                    {

                        IPAddressCollection winsServers = properties.WinsServersAddresses;
                        if (winsServers.Count > 0)
                        {
                            //label = "  WINS Servers ............................ :";
                            foreach (IPAddress wins in winsServers)
                            {
                                lstSocketInformation.Items.Add(String.Format("  WINS Servers ............................ : {0}",
                                    wins.ToString()
                               ));
                            }
                        }
                    }
                }

                lstSocketInformation.Items.Add(String.Format("  DNS enabled ............................. : {0}",
                    properties.IsDnsEnabled));
                lstSocketInformation.Items.Add(String.Format("  Dynamically configured DNS .............. : {0}",
                    properties.IsDynamicDnsEnabled));
                lstSocketInformation.Items.Add(String.Format("  Receive Only ............................ : {0}",
                    adapter.IsReceiveOnly));
                lstSocketInformation.Items.Add(String.Format("  Multicast ............................... : {0}",
                    adapter.SupportsMulticast));

                //adapter.
                //ShowInterfaceStatistics(adapter);
            }
        }

        public void PopulateIPAddresses(IPInterfaceProperties adapterProperties)
        {
            IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
            if (dnsServers != null)
            {
                foreach (IPAddress dns in dnsServers)
                {
                    lstSocketInformation.Items.Add(String.Format("  DNS Servers ............................. : {0}",
                        dns.ToString()
                   ));
                }
            }
            IPAddressInformationCollection anyCast = adapterProperties.AnycastAddresses;
            if (anyCast != null)
            {
                foreach (IPAddressInformation any in anyCast)
                {
                    lstSocketInformation.Items.Add(String.Format("  Anycast Address .......................... : {0} {1} {2}",
                        any.Address,
                        any.IsTransient ? "Transient" : "",
                        any.IsDnsEligible ? "DNS Eligible" : ""
                    ));
                }
                lstSocketInformation.Items.Add("");
            }

            MulticastIPAddressInformationCollection multiCast = adapterProperties.MulticastAddresses;
            if (multiCast != null)
            {
                foreach (IPAddressInformation multi in multiCast)
                {
                    lstSocketInformation.Items.Add(String.Format("  Multicast Address ....................... : {0} {1} {2}",
                        multi.Address,
                        multi.IsTransient ? "Transient" : "",
                        multi.IsDnsEligible ? "DNS Eligible" : ""
                    ));
                }
                lstSocketInformation.Items.Add("");
            }
            UnicastIPAddressInformationCollection uniCast = adapterProperties.UnicastAddresses;
            if (uniCast != null)
            {
                string lifeTimeFormat = "dddd, MMMM dd, yyyy  hh:mm:ss tt";
                foreach (UnicastIPAddressInformation uni in uniCast)
                {
                    DateTime when;

                    lstSocketInformation.Items.Add(String.Format("  Unicast Address ......................... : {0}", uni.Address));
                    lstSocketInformation.Items.Add(String.Format("     Prefix Origin ........................ : {0}", uni.PrefixOrigin));
                    lstSocketInformation.Items.Add(String.Format("     Suffix Origin ........................ : {0}", uni.SuffixOrigin));
                    lstSocketInformation.Items.Add(String.Format("     Duplicate Address Detection .......... : {0}",
                        uni.DuplicateAddressDetectionState));

                    // Format the lifetimes as Sunday, February 16, 2003 11:33:44 PM
                    // if en-us is the current culture.

                    // Calculate the date and time at the end of the lifetimes.    
                    when = DateTime.UtcNow + TimeSpan.FromSeconds(uni.AddressValidLifetime);
                    when = when.ToLocalTime();
                    lstSocketInformation.Items.Add(String.Format("     Valid Life Time ...................... : {0}",
                        when.ToString(lifeTimeFormat, System.Globalization.CultureInfo.CurrentCulture)
                    ));
                    when = DateTime.UtcNow + TimeSpan.FromSeconds(uni.AddressPreferredLifetime);
                    when = when.ToLocalTime();
                    lstSocketInformation.Items.Add(String.Format("     Preferred life time .................. : {0}",
                        when.ToString(lifeTimeFormat, System.Globalization.CultureInfo.CurrentCulture)
                    ));

                    when = DateTime.UtcNow + TimeSpan.FromSeconds(uni.DhcpLeaseLifetime);
                    when = when.ToLocalTime();
                    lstSocketInformation.Items.Add(String.Format("     DHCP Leased Life Time ................ : {0}",
                        when.ToString(lifeTimeFormat, System.Globalization.CultureInfo.CurrentCulture)
                    ));
                }
                lstSocketInformation.Items.Add("");
            }
        }

    }
}