using System;
using System.Net.Sockets;

namespace Klientas
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                var clientSocket = new TcpClient("localhost", 1000);
                    // connect to server running on localhost at port no. 1000
                NetworkStream ns = clientSocket.GetStream(); // get stream

                var buf = new byte[100]; // create byte array to receive data

                Console.WriteLine("Iveskite pirma skaiciu");
                string g = Console.ReadLine(); // read from console
                int k1 = Convert.ToInt16(g, 10); // convert string to int        
                byte[] bytes1 = BitConverter.GetBytes(k1); // convert int to byte array
                ns.Write(bytes1, 0, 1); // write to stream

                Console.WriteLine("Iveskite antra skaiciu");
                string gg = Console.ReadLine(); // read from console
                int k2 = Convert.ToInt16(gg, 10); // convert string to int 
                byte[] bytes2 = BitConverter.GetBytes(k2); // convert int to byte array
                ns.Write(bytes2, 0, 1); // write to stream


                ns.Read(buf, 0, 1); // read data from stream into byte array

                int j = BitConverter.ToInt16(buf, 0); // convert byte array to int

                Console.WriteLine("Atsakymas:");
                Console.WriteLine(j); // write to console

                Console.ReadLine();
            }
        }
    }
}
