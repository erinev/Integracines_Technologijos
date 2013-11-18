using System;
using System.Net.Sockets;

namespace Klientas.Utility
{
    public class NetworkStreamUtility
    {
        private readonly NetworkStream _networkStream;

        public NetworkStreamUtility()
        {
            _networkStream = CreateNetworkStream();
        }

        public int GetResultFromNetworkStream()
        {
            var buffer = new byte[100];
            _networkStream.Read(buffer, 0, 1);
            int result = BitConverter.ToInt16(buffer, 0);
            return result;
        }

        public void WriteNumberToNetworkStream(byte[] numberInBytes)
        {
            _networkStream.Write(numberInBytes, 0, 1);
        }

        private NetworkStream CreateNetworkStream()
        {
            var clientSocket = new TcpClient("localhost", 1000);
            NetworkStream networkStream = clientSocket.GetStream();
            return networkStream;
        }
    }
}