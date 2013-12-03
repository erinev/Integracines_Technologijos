using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Klientas
{
    public class ClientChatHandler
    {
        public void StartChat(NetworkStream networkStream)
        {
            var streamReader = new StreamReader(networkStream);
            var readThread = new Thread(() => ReadChat(streamReader));
            readThread.Start();

            var streamWriter = new StreamWriter(networkStream);
            var writeThread = new Thread(() => WriteToChat(streamWriter));
            writeThread.Start();
        }

        private void ReadChat(StreamReader streamReader)
        {
            while (true)
            {
                string message = streamReader.ReadLine();
                Console.WriteLine(message);
            }
        }

        private void WriteToChat(StreamWriter streamWriter)
        {
            while (true)
            {
                string message = Console.ReadLine();
                streamWriter.WriteLine(message);
                streamWriter.Flush();
            }
        }
    }
}