using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCarbon.Protocols
{
    enum IcmpCode
    {
        NetUnreachable = 0,
        HostUnreachable = 1,
        ProtocolUnreachable = 2,
        PortUnreachable = 3,
        FragmentationNeeded = 4,
        SourceRouteFailed = 5
    }

    class IcmpProtocol: IpSubProtocol
    {
        public IcmpProtocol()
            : base(Protocol.Icmp, "ICMP", "Internet Control Message Protocol")
        {
        }

        public override void ProcessData(byte[] bufferData)
        {
            BigEndianConverter endianConverter = new BigEndianConverter();
            byte type = bufferData[0];
            byte code = bufferData[1];
            int checksum = endianConverter.ToUInt16(bufferData, 2);
            m_protocolProperties.Add("Type", type);
            m_protocolProperties.Add("Code", code);
            m_protocolProperties.Add("Checksum", checksum);

            m_protocolProperties.Add("Payload", bufferData);
        }
    }
}
