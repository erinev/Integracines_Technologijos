using System;
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
            IPAddress ip = IPAddress.Parse(ConfigsUtility.ServerIpAddress);
            var serverSocket = new TcpListener(ip, ConfigsUtility.PortNumber);
            return serverSocket;
        }

        public void StartServerSocket()
        {
            _serverSocket.Start();
        }

        public void CloseServerSocket()
        {
            _serverSocket.Stop();
        }

        public byte[] GetSumFromNetworkStream(NetworkStream networkStream)
        {
            networkStream.Read(ConfigsUtility.BufferSize, 0, 100);
            int firstNumber = BitConverter.ToInt16(ConfigsUtility.BufferSize, 0);

            networkStream.Read(ConfigsUtility.BufferSize, 0, 100);
            int secondNumber = BitConverter.ToInt16(ConfigsUtility.BufferSize, 0);

            int sum = firstNumber + secondNumber;
            byte[] result = BitConverter.GetBytes(sum);

            return result;
        }

        public NetworkStream CreateNetworkStreamForServer()
        {
            TcpClient clientSocket = _serverSocket.AcceptTcpClient();
            NetworkStream networkStream = clientSocket.GetStream();
            return networkStream;
        }
    }
}