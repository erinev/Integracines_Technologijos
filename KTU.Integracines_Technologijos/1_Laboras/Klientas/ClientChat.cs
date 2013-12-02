using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Klientas
{
    public class ClientChat
    {
        private NetworkStream _networkStream;

        public void StartChat(NetworkStream networkStream)
        {
            _networkStream = networkStream;

            var readThread = new Thread(ReadChat);
            readThread.Start();

            var writeThread = new Thread(WriteToChat);
            writeThread.Start();
        }

        private void ReadChat()
        {
            var streamReader = new StreamReader(_networkStream);

            while (true)
            {
                string message = streamReader.ReadLine();
                Console.WriteLine(message);
            }
        }

        private void WriteToChat()
        {
            var streamWriter = new StreamWriter(_networkStream);

            while (true)
            {
                string zinute = Console.ReadLine();
                streamWriter.WriteLine(zinute);
                streamWriter.Flush();
            }
        }
    }
}