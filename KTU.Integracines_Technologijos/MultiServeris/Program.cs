using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MultiServeris
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
                TcpClient clientSocket = serverSocket.AcceptTcpClient(); // wait for client to make request

                var client = new HandleClient(); // handle each client
                client.StartClient(clientSocket);
            }
// ReSharper disable once FunctionNeverReturns
        }
    }

    public class HandleClient
    {
        private TcpClient _clientSocket; // client socket

        public void StartClient(TcpClient inClientSocket)
        {
            _clientSocket = inClientSocket;
            var ctThread = new Thread(Sum); // start thread for each client
            ctThread.Start();
        }


        private void Sum()
        {
            var buf = new byte[100]; // create byte array to receive data

            while (true)
            {
                NetworkStream ns = _clientSocket.GetStream(); // access stream to send data to client

                ns.Read(buf, 0, 100); // read data from stream into byte array
                int j1 = BitConverter.ToInt16(buf, 0); // convert byte array to int

                ns.Read(buf, 0, 100); // read data from stream into byte array
                int j2 = BitConverter.ToInt16(buf, 0); // convert byte array to int

                int j = j1 + j2; // calculate sum
                byte[] bytes = BitConverter.GetBytes(j); // convert int to byte array 

                ns.Write(bytes, 0, 1); // write to stream
            }
// ReSharper disable once FunctionNeverReturns
        }
    }
}