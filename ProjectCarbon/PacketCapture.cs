using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Timers;
using System.Collections;
using System.Collections.Generic;

namespace ProjectCarbon
{
    class PacketCapturedEventArgs : EventArgs
    {
        private DateTime timestamp;
        private byte[] buffer;

        public PacketCapturedEventArgs(byte[] buffer)
        {
            this.timestamp = DateTime.Now;
            this.buffer = buffer;
        }

        public DateTime TimeStamp
        {
            get { return timestamp; }
        }

        public byte[] Buffer
        {
            get { return buffer; }
        }
    }

    class PacketCaptureInterface: IDisposable
    {
        public delegate void PacketCapturedEventHandler(object sender, PacketCapturedEventArgs e);

        public event PacketCapturedEventHandler OnPacketCaptured;

        private Socket socket;
        private IPAddress ipAddress;
        private byte[] packetBuffer;
        private NetworkInterface[] networkInterfaces;
        private IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
        private AsyncCallback receiveCallback;
        private bool isCapturing = false;

        public PacketCaptureInterface (IPAddress ip)
	    {
            this.ipAddress = ip;
            this.networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            this.packetBuffer = new byte[2000]; // default max mtu is 1500, allow for 500 bytes of extra
            this.receiveCallback = new AsyncCallback(OnReceiveCallback);
	    }

        public NetworkInterface[] NetworkInterfaces
        {
            get { return networkInterfaces; }
        }

        public IPAddress[] AddressList
        {
            get { return addressList; }
        }

        public void StartCapture()
        {
            if (isCapturing)
                return;

            try
            {
                socket = new Socket(ipAddress.AddressFamily,
                    SocketType.Raw, ProtocolType.IP);

                socket.Bind(new IPEndPoint(ipAddress, 0));

                socket.IOControl(IOControlCode.ReceiveAll,
                    BitConverter.GetBytes(1), null);

                isCapturing = true;

                BeginReceive();
            }
            catch
            {
                socket.Close();
            }
        }

        public void StopCapture()
        {
            if (isCapturing)
            {
                if (socket != null)
                    socket.Close();
                isCapturing = false;
            }
        }

        private void BeginReceive()
        {
            try
            {
                socket.BeginReceive(packetBuffer,
                    0,
                    packetBuffer.Length,
                    SocketFlags.None,
                    receiveCallback,
                    null);
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("BeginReceive: Socket has been closed.");
            }
        }

        private void OnReceiveCallback(IAsyncResult ar)
        {
            try
            {
                int bytesReceived = socket.EndReceive(ar);
                
                byte[] receivedBuffer = new byte[bytesReceived];
                
                Array.Copy(packetBuffer, 0, receivedBuffer, 0, bytesReceived);

                Console.WriteLine(bytesReceived);
                
                if(OnPacketCaptured != null)
                    OnPacketCaptured(this, new PacketCapturedEventArgs(receivedBuffer));

                BeginReceive();
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("OnReceiveCallback: Socket has been closed.");
            }
        }

        #region IDisposable Members
        public void Dispose()
        {
            if (socket != null)
                socket.Close();
        }
        #endregion
    }
}