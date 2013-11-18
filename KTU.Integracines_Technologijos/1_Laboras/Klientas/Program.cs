using System;
using System.Net.Sockets;

namespace Klientas
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                var clientSocket = new TcpClient("localhost", 1000);

                NetworkStream networkStream = clientSocket.GetStream();

                var buffer = new byte[100];

                Console.WriteLine("Iveskite pirma skaiciu:");
                string firstNumberInput = Console.ReadLine();
                int firstNumber = Convert.ToInt16(firstNumberInput, 10);
                byte[] firstNumberBytes = BitConverter.GetBytes(firstNumber);
                networkStream.Write(firstNumberBytes, 0, 1); 

                Console.WriteLine("Iveskite antra skaiciu:");
                string secondNumberInput = Console.ReadLine();
                int secondNumber = Convert.ToInt16(secondNumberInput, 10);
                byte[] secondNumberBytes = BitConverter.GetBytes(secondNumber);
                networkStream.Write(secondNumberBytes, 0, 1); 


                networkStream.Read(buffer, 0, 1);

                int result = BitConverter.ToInt16(buffer, 0);

                Console.WriteLine("Atsakymas:");
                Console.WriteLine(result);

                Console.ReadLine();
            }
        }
    }
}