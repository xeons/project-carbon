using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCarbon.Protocols
{
    class GenericProtocol: IpSubProtocol
    {
        public GenericProtocol()
            : base(Protocol.None, "Generic", "This is not a real protocol!")
        {
        }

        public override void ProcessData(byte[] bufferData)
        {
            m_protocolProperties.Add("Payload", bufferData);
            m_protocolProperties.Add("PacketPayload", bufferData);
        }
    }
}
