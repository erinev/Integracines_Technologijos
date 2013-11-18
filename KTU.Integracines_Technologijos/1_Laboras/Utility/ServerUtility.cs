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
            IPAddress ip = IPAddress.Parse(ConstantsUtility.ServerIpAddress);
            var serverSocket = new TcpListener(ip, ConstantsUtility.PortNumber);
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

        public byte[] CountSumFromNetworkStream(NetworkStream networkStream)
        {
            networkStream.Read(ConstantsUtility.BufferSize, 0, 100);
            int firstNumber = BitConverter.ToInt16(ConstantsUtility.BufferSize, 0);

            networkStream.Read(ConstantsUtility.BufferSize, 0, 100);
            int secondNumber = BitConverter.ToInt16(ConstantsUtility.BufferSize, 0);

            int sum = firstNumber + secondNumber;
            byte[] result = BitConverter.GetBytes(sum);

            return result;
        }

        public void WriteSumToNetworkStream(NetworkStream networkStream, byte[] resultInBytes)
        {
            networkStream.Write(resultInBytes, 0, 1);
        }

        public NetworkStream CreateNetworkStreamForServer()
        {
            TcpClient clientSocket = CreateClientSocket();
            NetworkStream networkStream = clientSocket.GetStream();
            return networkStream;
        }

        public TcpClient CreateClientSocket()
        {
            TcpClient clientSocket = _serverSocket.AcceptTcpClient();
            return clientSocket;
        }
    }
}