using System;
using WebServisoKlientas.WebServisas;

namespace WebServisoKlientas
{
    internal static class Program
    {
        private static void Main()
        {
            var klientas = new ManoWebServisasSoapClient();
            
            Console.ReadLine();
        }
    }
}