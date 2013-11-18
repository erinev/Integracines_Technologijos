using System;
using System.Net.Sockets;
using Utility;

namespace Klientas
{
    internal static class KlientasProgram
    {
        private static void Main()
        {
            var clientUtility = new ClientUtility();

            while (true)
            {
                NetworkStream networkStream = clientUtility.CreateNetworkStreamForClient();

                Console.WriteLine("Iveskite pirma skaiciu:");
                string firstNumberInput = Console.ReadLine();
                byte[] firstNumberBytes = clientUtility.ProcessFirstNumber(firstNumberInput);
                clientUtility.WriteNumberToNetworkStream(networkStream, firstNumberBytes);

                Console.WriteLine("Iveskite antra skaiciu:");
                string secondNumberInput = Console.ReadLine();
                byte[] secondNumberBytes = clientUtility.ProcessSecondNumber(secondNumberInput);
                clientUtility.WriteNumberToNetworkStream(networkStream, secondNumberBytes);

                int result = clientUtility.GetResultFromNetworkStream(networkStream);
                Console.WriteLine("Atsakymas:");
                Console.WriteLine(result);

                Console.ReadLine();
            }
        }
    }
}