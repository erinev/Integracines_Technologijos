using System;
using System.Net.Sockets;
using Utility;

namespace Serveris
{
    internal static class ServerisProgram
    {
        private static void Main()
        {
            var serverUtility = new ServerUtility();

            serverUtility.StartServerSocket();
            Console.WriteLine("Serveris paleistas. Laukiama klientu...");

            while (true)
            {
                NetworkStream networkStream = serverUtility.CreateNetworkStreamForServer();

                byte[] resultBytes = serverUtility.CountSumFromNetworkStream(networkStream);

                networkStream.Write(resultBytes, 0, 1);

                networkStream.Close();
                serverUtility.CloseServerSocket();
            }
        }
    }
}