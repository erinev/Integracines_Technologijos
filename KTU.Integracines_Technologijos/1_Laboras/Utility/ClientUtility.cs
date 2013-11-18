using System;
using System.Net.Sockets;

namespace Utility
{
    public class ClientUtility
    {
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

        public int GetResultFromNetworkStream(NetworkStream networkStream)
        {
            networkStream.Read(ConstantsUtility.BufferSize, 0, 1);
            int result = BitConverter.ToInt16(ConstantsUtility.BufferSize, 0);
            return result;
        }

        public void WriteNumberToNetworkStream(NetworkStream networkStream, byte[] numberInBytes)
        {
            networkStream.Write(numberInBytes, 0, 1);
        }

        public NetworkStream CreateNetworkStreamForClient()
        {
            var clientSocket = new TcpClient(ConstantsUtility.ClientHostName, ConstantsUtility.PortNumber);
            NetworkStream networkStream = clientSocket.GetStream();
            return networkStream;
        }
    }
}