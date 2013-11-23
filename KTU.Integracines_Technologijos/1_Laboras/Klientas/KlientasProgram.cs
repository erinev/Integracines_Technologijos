using System;
using System.IO;
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
                var streamWriter = new StreamWriter(networkStream);
                var streamReader = new StreamReader(networkStream);

                Console.WriteLine("Nauja žinutė:");
                string messageInput = Console.ReadLine();
                streamWriter.WriteLine(messageInput);
                streamWriter.Flush();

                Console.WriteLine("Gautas atsakymas:");
                string gautaZinute = streamReader.ReadLine();
                Console.WriteLine(gautaZinute);
                Console.WriteLine();

                streamReader.Close();
                streamWriter.Close();
                networkStream.Close();
            }
        }
    }
}