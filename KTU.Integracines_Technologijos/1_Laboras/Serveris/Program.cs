using System;
using System.Net;
using System.Net.Sockets;

namespace Serveris
{
    internal static class Program
    {
        private static void Main()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            var serverSocket = new TcpListener(ip, 1000);
            serverSocket.Start();
            Console.WriteLine("Serveris paleistas. Laukiama klientu...");
            while (true)
            {
                TcpClient clientSocket = serverSocket.AcceptTcpClient();
                NetworkStream ns = clientSocket.GetStream();

                var buf = new byte[100];

                ns.Read(buf, 0, 100);
                int j1 = BitConverter.ToInt16(buf, 0);

                ns.Read(buf, 0, 100);
                int j2 = BitConverter.ToInt16(buf, 0);

                int j = j1 + j2;
                byte[] bytes = BitConverter.GetBytes(j);

                ns.Write(bytes, 0, 1);

                ns.Close();
                clientSocket.Close();
            }
// ReSharper disable once FunctionNeverReturns
        }
    }
}