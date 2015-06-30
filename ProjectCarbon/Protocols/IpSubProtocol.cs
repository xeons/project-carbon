using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCarbon.Protocols
{
    /// <summary>
    /// All protocols within the IP protocol should derive from this
    /// class.
    /// </summary>
    abstract class IpSubProtocol
    {
        /// <summary>
        /// Provides a list of properties for this protocol.
        /// </summary>
        protected Dictionary<string, object> m_protocolProperties =
            new Dictionary<string, object>();

        /// <summary>
        /// Stores what protocol this handles.
        /// </summary>
        protected Protocol m_protocol;

        /// <summary>
        /// This will get you the protocol name.
        /// </summary>
        protected string m_name = null;

        /// <summary>
        /// You may optionally provide a protocol description
        /// </summary>
        protected string m_description = null;

        /// <summary>
        /// Creates a new protocol
        /// </summary>
        /// <param name="protocol">The protocol this class will handle.</param>
        public IpSubProtocol(Protocol protocol, string name, string description)
        {
            m_protocol = protocol;
            m_name = name;
            m_description = description;
        }

        /// <summary>
        /// Allows you to access the properties of this protocol
        /// </summary>
        public Dictionary<string, object> Properties
        {
            get { return m_protocolProperties; }
        }

        /// <summary>
        /// Returns the protocol name
        /// </summary>
        public string Name
        {
            get { return m_name; }
        }

        /// <summary>
        /// Returns a short description of this protocol
        /// </summary>
        public string Description
        {
            get { return m_description; }
        }

        /// <summary>
        /// This must be implemented, it's the parsing routine for this protocol.
        /// </summary>
        /// <param name="bufferData">Incoming packet data</param>
        public abstract void ProcessData(byte[] bufferData);

        /// <summary>
        /// Returns the correct processor for the protocol, but
        /// it might return null if it has no processor.
        /// </summary>
        /// <param name="protocol"></param>
        /// <returns>A new instance of the protocol</returns>
        public static IpSubProtocol GetProtocolInstance(Protocol protocol)
        {
            switch (protocol)
            {
                case Protocol.Tcp:
                    return new TcpProtocol();
                case Protocol.Udp: 
                    return new UdpProtocol();
                case Protocol.Icmp:
                    return new IcmpProtocol();
                default:
                    return new GenericProtocol();
            }
            //return null;
        }
    }
}
