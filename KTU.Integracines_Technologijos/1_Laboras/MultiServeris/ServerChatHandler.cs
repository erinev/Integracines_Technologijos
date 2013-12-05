using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace MultiServeris
{
    public class ServerChatHandler
    {
        public void StartChat(TcpClient firstClient, TcpClient secondClient)
        {
            NetworkStream firstNetworkStream = firstClient.GetStream();
            NetworkStream secondNetworkStream = secondClient.GetStream();

            var firstClientThread = new Thread(() => ProccessFirstChat(secondNetworkStream, firstNetworkStream));
            firstClientThread.Start();

            var secondClientThread = new Thread(() => ProccessSecondChat(firstNetworkStream, secondNetworkStream));
            secondClientThread.Start();
        }

        private void ProccessFirstChat(NetworkStream secondNetworkStream, NetworkStream firstNetworkStream)
        {
            var streamReader = new StreamReader(secondNetworkStream);
            var streamWriter = new StreamWriter(firstNetworkStream);

            while (true)
            {
                string message = streamReader.ReadLine();
                streamWriter.WriteLine("Klientas_2: {0}", message);
                streamWriter.Flush();
            }
        }

        private void ProccessSecondChat(NetworkStream firstNetworkStream, NetworkStream secondNetworkStream)
        {
            var streamReader = new StreamReader(firstNetworkStream);
            var streamWriter = new StreamWriter(secondNetworkStream);

            while (true)
            {
                string message = streamReader.ReadLine();
                streamWriter.WriteLine("Klientas_1: {0}", message);
                streamWriter.Flush();
            }
        }
    }
}