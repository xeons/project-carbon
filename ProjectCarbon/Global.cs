using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using ProjectCarbon.Properties;
using ProjectCarbon.Protocols;
using Tamir.IPLib;


namespace ProjectCarbon
{
    static class Global
    {
        public static System.Net.IPAddress[] LocalIPAddresses =
            Dns.GetHostEntry(Dns.GetHostName()).AddressList;

        public static PacketCaptureInterface[] PacketCaptureArray;

        public static PcapDeviceList DeviceList = SharpPcap.GetAllDevices();

        public static List<Tamir.IPLib.Packets.Packet> CapturedPackets = 
            new List<Tamir.IPLib.Packets.Packet>();

        public static List<int> FilteredPortList = new List<int>();
        public static bool PortFilterInclusive = true;
        public static List<string> FilteredProtocolList = new List<string>();
        public static bool ProtocolFilterInclusive = true;

        public delegate void PacketCapturedEvent(Tamir.IPLib.Packets.Packet packet);
    }
}
