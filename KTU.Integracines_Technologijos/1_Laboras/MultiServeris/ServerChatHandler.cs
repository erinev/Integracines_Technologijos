using System;
using System.Collections.Generic;
using System.Net.Sockets;
using Utility;

namespace MultiServeris
{
    public class ServerChatHandler
    {
        public void HandleClients(TcpListener serverSocket)
        {
            var clients = new List<TcpClient>(ConstantsUtility.ClientCount);
            for (int i = 0; i < clients.Capacity; i++)
            {
                TcpClient client = serverSocket.AcceptTcpClient();
                clients.Add(client);
                Console.WriteLine("Priimtas {0} klientas, laukiama {1} kliento", ++i, ++i);
            }
            Console.WriteLine("Klientai priimti, galima pradėti susirašinėjimą!");

            var clientHandler = new ClientHandler();
            clientHandler.StartChat(clients);
        }
    }
}