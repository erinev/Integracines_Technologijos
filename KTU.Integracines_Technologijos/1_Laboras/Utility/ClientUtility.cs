using System.Net.Sockets;

namespace Utility
{
    public class ClientUtility
    {
        public NetworkStream CreateNetworkStreamForClient()
        {
            var clientSocket = new TcpClient(ConstantsUtility.ClientHostName, ConstantsUtility.PortNumber);
            NetworkStream networkStream = clientSocket.GetStream();
            return networkStream;
        }
    }
}