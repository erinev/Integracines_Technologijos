using System.Net.Sockets;
using System.Threading;
using Utility;

namespace MultiServeris
{
    public class MultiClientHandler
    {
        private TcpClient _clientSocket;
        private readonly ServerUtility _serverUtility = new ServerUtility();

        public void StartClient(TcpClient inClientSocket)
        {
            _clientSocket = inClientSocket;
            var clientThread = new Thread(Sum);
            clientThread.Start();
        }

        private void Sum()
        {
            while (true)
            {
                NetworkStream networkStream = _clientSocket.GetStream();

                byte[] resultBytes = _serverUtility.CountSumFromNetworkStream(networkStream);

                _serverUtility.WriteSumToNetworkStream(networkStream, resultBytes);
            }
        }
    }
}