using System;
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
                Console.WriteLine("Iveskite pirma skaiciu:");
                string firstNumberInput = Console.ReadLine();
                byte[] firstNumberBytes = clientUtility.ProcessFirstNumber(firstNumberInput);
                clientUtility.WriteNumberToNetworkStream(firstNumberBytes);

                Console.WriteLine("Iveskite antra skaiciu:");
                string secondNumberInput = Console.ReadLine();
                byte[] secondNumberBytes = clientUtility.ProcessSecondNumber(secondNumberInput);
                clientUtility.WriteNumberToNetworkStream(secondNumberBytes);

                int result = clientUtility.GetResultFromNetworkStream();
                Console.WriteLine("Atsakymas:");
                Console.WriteLine(result);

                Console.ReadLine();
            }
        }
    }
}