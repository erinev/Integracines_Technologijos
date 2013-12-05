using System;
using System.Net.Sockets;
using Utility;

namespace MultiServeris
{
    internal static class MultiServerProgram
    {
        private static void Main()
        {
            var serverUtility = new ServerUtility();
            var serverChat = new ServerChatHandler();

            TcpListener serverSocket = serverUtility.StartServerSocket();
            Console.WriteLine("Serveris paleistas. Laukiama klientu...");

            TcpClient firstClient = serverSocket.AcceptTcpClient();
            Console.WriteLine("Priimtas pirmas klientas, laukiamas antras...");

            TcpClient secondClient = serverSocket.AcceptTcpClient();
            Console.WriteLine("Priimtas antras klientas, susirašinėjimas paleistas.");

            serverChat.StartChat(firstClient, secondClient);
            serverChat.StartChat(secondClient, firstClient);
        }
    }
}