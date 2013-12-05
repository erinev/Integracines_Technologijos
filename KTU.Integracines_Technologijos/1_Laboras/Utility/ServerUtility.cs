using System.Net;
using System.Net.Sockets;

namespace Utility
{
    public class ServerUtility
    {
        private readonly TcpListener _serverSocket;

        public ServerUtility()
        {
            _serverSocket = CreateServerSocket();
        }

        private TcpListener CreateServerSocket()
        {
            IPAddress ip = IPAddress.Parse(ConstantsUtility.ServerIpAddress);
            var serverSocket = new TcpListener(ip, ConstantsUtility.PortNumber);
            return serverSocket;
        }

        public TcpListener StartServerSocket()
        {
            _serverSocket.Start();
            return _serverSocket;
        }

        public void CloseServerSocket()
        {
            _serverSocket.Stop();
        }
    }
}