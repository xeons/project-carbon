using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCarbon.Protocols
{
    class UdpProtocol : IpSubProtocol
    {
        public UdpProtocol()
            : base(Protocol.Udp, "UDP", "User Datagram Protocol")
        {
        }

        public override void ProcessData(byte[] bufferData)
        {
            // The UDP protocol uses big-endian.
            BigEndianConverter endianConverter = new BigEndianConverter();
            
            // Read the header information
            int sourcePort = endianConverter.ToUInt16(bufferData, 0);
            int destinationPort = endianConverter.ToUInt16(bufferData, 2);
            int length = endianConverter.ToUInt16(bufferData, 4);
            int checksum = endianConverter.ToUInt16(bufferData, 6);
            byte[] payload = new byte[length - 8];
            
            // Copy the buffer
            Array.Copy(bufferData, 8, payload, 0, length - 8);

            // Add the properties
            m_protocolProperties.Add("SourcePort", sourcePort);
            m_protocolProperties.Add("DestinationPort", destinationPort);
            m_protocolProperties.Add("Length", length);
            m_protocolProperties.Add("Checksum", checksum);
            m_protocolProperties.Add("Payload", payload);
        }
    }
}
