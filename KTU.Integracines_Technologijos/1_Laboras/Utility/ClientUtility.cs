using System;
using System.Net.Sockets;

namespace Utility
{
    public class ClientUtility
    {
        private readonly NetworkStream _networkStream;

        public ClientUtility()
        {
            _networkStream = CreateNetworkStreamForClient();
        }

        public byte[] ProcessFirstNumber(string firstNumberInput)
        {
            int firstNumber = Convert.ToInt16(firstNumberInput, 10);
            byte[] firstNumberBytes = BitConverter.GetBytes(firstNumber);
            return firstNumberBytes;
        }

        public byte[] ProcessSecondNumber(string secondNumberInput)
        {
            int secondNumber = Convert.ToInt16(secondNumberInput, 10);
            byte[] secondNumberBytes = BitConverter.GetBytes(secondNumber);
            return secondNumberBytes;
        }

        public int GetResultFromNetworkStream()
        {
            _networkStream.Read(ConfigsUtility.BufferSize, 0, 1);
            int result = BitConverter.ToInt16(ConfigsUtility.BufferSize, 0);
            return result;
        }

        public void WriteNumberToNetworkStream(byte[] numberInBytes)
        {
            _networkStream.Write(numberInBytes, 0, 1);
        }

        private NetworkStream CreateNetworkStreamForClient()
        {
            var clientSocket = new TcpClient(ConfigsUtility.ClientHostName, ConfigsUtility.PortNumber);
            NetworkStream networkStream = clientSocket.GetStream();
            return networkStream;
        }
    }
}