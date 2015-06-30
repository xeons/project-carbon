using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCarbon
{
    public enum Precedence
    {
        Routine = 0,
        Priority = 1,
        Immediate = 2,
        Flash = 3,
        FlashOverride = 4,
        CRITICECP = 5,
        InternetworkControl = 6,
        NetworkControl = 7
    }
    public enum Delay
    {
        NormalDelay = 0,
        LowDelay = 1
    }
    public enum Throughput
    {
        NormalThroughput = 0,
        HighThroughput = 1
    }
    public enum Reliability
    {
        NormalReliability = 0,
        HighReliability = 1
    }
    public enum Protocol
    {
        None = -1,
        Hopopt = 0,
        Icmp = 1,
        Igmp = 2,
        Ggp = 3,
        Ip = 4,
        St = 5,
        Tcp = 6,
        Cbt = 7,
        Egp = 8,
        Igp = 9,
        Bbnrrcmon = 10,
        Nvp2 = 11,
        Pup = 12,
        Udp = 17,
        Idp = 22,
        Nd = 77
    }
    public enum ControlBit
    {
        Urg = 0,
        Ack = 1,
        Psh = 2,
        Rst = 3,
        Syn = 4,
        Fin = 5
    }
}
