using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using SecureServiceLibrary;

namespace ServiceHost
{
    internal static class Program
    {
        private static void Main()
        {
            System.ServiceModel.ServiceHost host = null; //inicijuojamas tuscias ServiceHost objektas

            try
            {
                //i sukurta tuscia objekta irasome Service1 sukurta hosta
                host = new System.ServiceModel.ServiceHost(typeof (Service1));

                //atsiradus klaidoms jos suvaldomos EventHandler pagalba metode: Host_Faulted
                host.Faulted += new EventHandler(Host_Faulted);

                //paleidziamas WCF servisas
                host.Open();

                Console.WriteLine("Servisas paleistas, klausomasi:");

                foreach (ServiceEndpoint endpoint in host.Description.Endpoints)
                {
                    //atspausdinami visi pasiekiami end point'u adresai ir ju rysiai
                    Console.WriteLine("{0} ({1})", endpoint.Address, endpoint.Binding.Name);
                }

                Console.WriteLine();
                Console.WriteLine("Paspauskit bet kokį mygtuką, kad sustabdytumėt servisą.");
                Console.ReadLine();
            }
            finally
            {
                if (host != null && host.State == CommunicationState.Faulted)
                {
                    host.Abort(); //jei ivyko klaida sustabdomas servisas
                }
                else
                {
                    if (host != null)
                    {
                        host.Close(); //jei nera klaidos bet servisas egizstuoja, jis uzdaromas
                    }
                }
            }
        }

        private static void Host_Faulted(object sender, EventArgs e) //jei ivyko klaida parasomas pranesimas
        {
            Console.WriteLine("Servisas nepaleistas, įvyko klaida");
        }
    }
}
