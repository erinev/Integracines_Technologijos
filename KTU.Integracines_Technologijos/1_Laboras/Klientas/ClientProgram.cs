using System.Net.Sockets;
using Utility;

namespace Klientas
{
    internal static class ClientProgram
    {
        private static void Main()
        {
            var clientUtility = new ClientUtility();
            var chatHandler = new ClientChatHandler();

            NetworkStream networkStream = clientUtility.CreateNetworkStreamForClient();
            chatHandler.StartChat(networkStream);
        }
    }
}