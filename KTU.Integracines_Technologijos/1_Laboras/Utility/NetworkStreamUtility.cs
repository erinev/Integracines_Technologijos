using System;
using System.Net;
using System.Net.Sockets;

namespace Utility
{
    public class NetworkStreamUtility
    {
        private readonly NetworkStream _networkStream;
        private readonly TcpListener _serverSocket;
        private const string HostName = "localhost";
        private const string IpAddress = "127.0.0.1";
        private const int PortNumber = 1000;
        private readonly byte[] _bufferSize = new byte[100];

        public NetworkStreamUtility()
        {
            _networkStream = CreateNetworkStreamForClient();
            _serverSocket = CreateServerSocket();
        }

        public int GetResultFromNetworkStream()
        {
            _networkStream.Read(_bufferSize, 0, 1);
            int result = BitConverter.ToInt16(_bufferSize, 0);
            return result;
        }

        public void WriteNumberToNetworkStream(byte[] numberInBytes)
        {
            _networkStream.Write(numberInBytes, 0, 1);
        }

        private TcpListener CreateServerSocket()
        {
            IPAddress ip = IPAddress.Parse(IpAddress);
            var serverSocket = new TcpListener(ip, PortNumber);
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
            networkStream.Read(_bufferSize, 0, 100);
            int firstNumber = BitConverter.ToInt16(_bufferSize, 0);

            networkStream.Read(_bufferSize, 0, 100);
            int secondNumber = BitConverter.ToInt16(_bufferSize, 0);

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

        private NetworkStream CreateNetworkStreamForClient()
        {
            var clientSocket = new TcpClient(HostName, PortNumber);
            NetworkStream networkStream = clientSocket.GetStream();
            return networkStream;
        }
    }
}