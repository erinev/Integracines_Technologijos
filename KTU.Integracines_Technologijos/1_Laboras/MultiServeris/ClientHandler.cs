using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace MultiServeris
{
    public class ClientHandler
    {
        private StreamReader _streamReader;
        private StreamWriter _streamWriter;

        public void StartChat(List<TcpClient> clients)
        {
            NetworkStream client1NetworkStream = clients[0].GetStream();
            NetworkStream client2NetworkStream = clients[1].GetStream();

            this.StartChat(client1NetworkStream, client2NetworkStream);
            this.StartChat(client2NetworkStream, client1NetworkStream);
        }

        private void StartChat(NetworkStream client1NetworkStream, NetworkStream client2NetworkStream)
        {
            _streamReader = new StreamReader(client1NetworkStream);
            _streamWriter = new StreamWriter(client2NetworkStream);

            var readThread = new Thread(ReadChat);
            readThread.Start();

            var writeThread = new Thread(WriteToChat);
            writeThread.Start();
        }

        private void ReadChat()
        {
            while (true)
            {
                string zinute = _streamReader.ReadLine();
                _streamWriter.WriteLine(zinute);
                _streamWriter.Flush();
            }
        }

        private void WriteToChat()
        {
            while (true)
            {
                string zinute = _streamReader.ReadLine();
                _streamWriter.WriteLine(zinute);
                _streamWriter.Flush();
            }
        }
    }
}
