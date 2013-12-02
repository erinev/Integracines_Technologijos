using System.Net.Sockets;
using Utility;

namespace Klientas
{
    internal static class KlientasProgram
    {
        private static void Main()
        {
            var clientUtility = new ClientUtility();
            var clientChat = new ClientChat();

            NetworkStream networkStream = clientUtility.CreateNetworkStreamForClient();
            clientChat.StartChat(networkStream);
        }
    }
}