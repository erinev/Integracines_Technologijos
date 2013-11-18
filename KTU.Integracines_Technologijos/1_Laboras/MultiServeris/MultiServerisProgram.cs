using System;
using System.Net.Sockets;
using Utility;

namespace MultiServeris
{
    internal static class MultiServerisProgram
    {
        private static void Main()
        {
            var serverUtility = new ServerUtility();

            serverUtility.StartServerSocket();
            Console.WriteLine("Serveris paleistas. Laukiama klientu...");

            while (true)
            {
                TcpClient clientSocket = serverUtility.CreateClientSocket();

                var multiClientHandler = new MultiClientHandler();
                multiClientHandler.StartClient(clientSocket);
            }
        }
    }
}