using System;
using System.Net.Sockets;
using Utility;

namespace Serveris
{
    internal static class Program
    {
        private static void Main()
        {
            var networkStreamUtility = new NetworkStreamUtility();

            networkStreamUtility.StartServerSocket();
            Console.WriteLine("Serveris paleistas. Laukiama klientu...");

            while (true)
            {
                NetworkStream networkStream = networkStreamUtility.CreateNetworkStreamForServer();

                byte[] resultBytes = networkStreamUtility.GetSumFromNetworkStream(networkStream);
                networkStream.Write(resultBytes, 0, 1);

                networkStream.Close();
                networkStreamUtility.CloseServerSocket();
            }
        }
    }
}