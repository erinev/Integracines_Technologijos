using System;
using System.IO;
using System.Net.Sockets;
using Utility;

namespace Serveris
{
    internal static class ServerisProgram
    {
        private static void Main()
        {
            var serverUtility = new ServerUtility();

            serverUtility.StartServerSocket();
            Console.WriteLine("Vieno kliento serveris paleistas. Laukiama naujų žinučių...");

            while (true)
            {
                NetworkStream networkStream = serverUtility.CreateNetworkStreamForServer();
                var streamWriter = new StreamWriter(networkStream);
                var streamReader = new StreamReader(networkStream);

                Console.WriteLine();
                Console.WriteLine("Gauta nauja žinutė iš kliento:");
                string gautaZinute = streamReader.ReadLine();
                Console.WriteLine(gautaZinute);

                Console.WriteLine("Nauja žinutė klientui:");
                string naujaZinute = Console.ReadLine();
                streamWriter.WriteLine(naujaZinute);
                streamWriter.Flush();

                streamReader.Close();
                streamWriter.Close();
                networkStream.Close();
                serverUtility.CloseServerSocket();
            }
        }
    }
}