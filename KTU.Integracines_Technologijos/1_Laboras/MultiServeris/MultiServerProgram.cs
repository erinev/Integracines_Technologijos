using System;
using System.Net.Sockets;
using Utility;

namespace MultiServeris
{
    internal static class MultiServerProgram
    {
        static void Main()
        {
            var serverUtility = new ServerUtility();
            var chatHandler = new ServerChatHandler();

            TcpListener serverSocket = serverUtility.StartServerSocket();
            Console.WriteLine("Serveris paleistas. Laukiama klientu...");

            chatHandler.HandleClients(serverSocket);
        }
    }
}