using System;
using Klientas.Utility;

namespace Klientas
{
    internal static class KlientasProgram
    {
        private static void Main()
        {
            var networkStreamUtility = new NetworkStreamUtility();
            var inputStreamUtility = new InputStreamUtility();

            while (true)
            {
                Console.WriteLine("Iveskite pirma skaiciu:");
                string firstNumberInput = Console.ReadLine();
                byte[] firstNumberBytes = inputStreamUtility.ProcessFirstNumber(firstNumberInput);
                networkStreamUtility.WriteNumberToNetworkStream(firstNumberBytes);

                Console.WriteLine("Iveskite antra skaiciu:");
                string secondNumberInput = Console.ReadLine();
                byte[] secondNumberBytes = inputStreamUtility.ProcessSecondNumber(secondNumberInput);
                networkStreamUtility.WriteNumberToNetworkStream(secondNumberBytes);

                int result = networkStreamUtility.GetResultFromNetworkStream();
                Console.WriteLine("Atsakymas:");
                Console.WriteLine(result);

                Console.ReadLine();
            }
        }
    }
}