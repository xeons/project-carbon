using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCarbon.Protocols
{
    [Serializable]
    public class IpProtocol
    {

        /// <summary>
        /// Provides a list of properties for this protocol.
        /// </summary>
        private Dictionary<string, object> m_protocolProperties =
            new Dictionary<string, object>();

        public IpProtocol(byte[] packetBuffer)
        {
            BigEndianConverter endianConverter = new BigEndianConverter();

            if (packetBuffer == null)
                throw new ArgumentException("Incoming Packet is null.");

            if (packetBuffer.Length < 20)
                throw new ArgumentException("Incomplete IP Header");

            int version = (packetBuffer[0] & 0xF0) >> 4;
            int headerLength = (packetBuffer[0] & 0x0F) * 4;

            if ((packetBuffer[0] & 0x0F) < 5)
                throw new ArgumentException("Smaller then 5");

            Precedence precedence = (Precedence)((packetBuffer[1] & 0xE0) >> 5);
            Delay delay = (Delay)((packetBuffer[1] & 0x10) >> 4);
            Throughput throughput = (Throughput)((packetBuffer[1] & 0x08) >> 3);
            Reliability reliability = (Reliability)((packetBuffer[1] & 0x04) >> 2);

            int totalLength = (packetBuffer[2] * 256) + packetBuffer[3];
            int identification = (packetBuffer[4] * 256) + packetBuffer[5];
            int timeToLive = packetBuffer[8];

            Protocol protocol = (Protocol)packetBuffer[9];

            ushort checksum = endianConverter.ToUInt16(packetBuffer, 10);

            string sourceAddress = String.Format("{0}.{1}.{2}.{3}",
                packetBuffer[12], packetBuffer[13], packetBuffer[14], packetBuffer[15]);
            string destinationAddress = String.Format("{0}.{1}.{2}.{3}",
                packetBuffer[16], packetBuffer[17], packetBuffer[18], packetBuffer[19]);
            
            byte[] payload = new byte[packetBuffer.Length - headerLength];
            
            Array.Copy(packetBuffer, headerLength, payload, 0, payload.Length);

            DateTime packetTime = System.DateTime.Now;

            // add all these to the properties
            m_protocolProperties.Add("Version", version);
            m_protocolProperties.Add("HeaderLength", headerLength);
            m_protocolProperties.Add("Precedence", precedence);
            m_protocolProperties.Add("Delay", delay);
            m_protocolProperties.Add("Throughput", throughput);
            m_protocolProperties.Add("Reliability", reliability);
            m_protocolProperties.Add("TotalLength", totalLength);
            m_protocolProperties.Add("Identification", identification);
            m_protocolProperties.Add("TimeToLive", timeToLive);
            m_protocolProperties.Add("Protocol", protocol);
            m_protocolProperties.Add("Checksum", checksum);
            m_protocolProperties.Add("SourceAddress", sourceAddress);
            m_protocolProperties.Add("DestinationAddress", destinationAddress);
            m_protocolProperties.Add("Payload", payload);

            m_protocolProperties.Add("PacketTime", packetTime);
            m_protocolProperties.Add("PacketPayload", packetBuffer);
        }

        /// <summary>
        /// Allows you to access the properties of this protocol
        /// </summary>
        public Dictionary<string, object> Properties
        {
            get { return m_protocolProperties; }
        }
    }
}
