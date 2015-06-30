using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCarbon.Protocols
{
    class TcpProtocol: IpSubProtocol
    {
        public TcpProtocol()
            : base(Protocol.Tcp, "TCP", "Transmission Control Protocol")
        {
        }

        public override void ProcessData(byte[] bufferData)
        {
            BigEndianConverter endianConverter = new BigEndianConverter();

            int sourcePort = endianConverter.ToUInt16(bufferData, 0);
            int destinationPort = endianConverter.ToUInt16(bufferData, 2);
            uint sequenceNumber = endianConverter.ToUInt32(bufferData, 4);
            uint packNumber = endianConverter.ToUInt32(bufferData, 8);
            int dataOffset = ((bufferData[12] & 0xF0) >> 4) * 4;
            byte[] payload = new byte[bufferData.Length - dataOffset];

            Array.Copy(bufferData, dataOffset, payload, 0, payload.Length);

            // These are all the properties for TCP.
            m_protocolProperties.Add("SourcePort", sourcePort);
            m_protocolProperties.Add("DestinationPort", destinationPort);
            m_protocolProperties.Add("SequenceNumber", sequenceNumber);
            m_protocolProperties.Add("AckNumber", packNumber);
            m_protocolProperties.Add("DataOffset", dataOffset);
            m_protocolProperties.Add("Payload", payload);
        }
    }
}
