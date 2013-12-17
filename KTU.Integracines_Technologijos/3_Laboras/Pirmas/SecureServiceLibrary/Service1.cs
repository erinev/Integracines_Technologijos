using System.Security.Principal;
using System.Threading;

namespace SecureServiceLibrary
{
    public class Service1 : IService1
    {
        public string Labas() //metodas pasisveikinimuis
        {
            //gaunamas dabar prisijunges windows vartotojas
            var currentUser = new WindowsPrincipal((WindowsIdentity)Thread.CurrentPrincipal.Identity);
            if (currentUser.IsInRole(WindowsBuiltInRole.User)) //jei prisijunges vartotojas priklauso Users grupei
            {
                return string.Format("Labas, {0}", Thread.CurrentPrincipal.Identity.Name);
                    //parasom jo prisijungimo varda
            }

            return string.Format("Neautorizuotas"); //jei nepriklauso grazinam zinute: "Neautorizuotas" 

            //Galėtumėm autorizuoti ir panaudojant "PrincipalPermission"
            //[PrincipalPermission(SecurityAction.Demand,Role="BUILTIN\\User")]
            //public string Labas()
            //{
            //    return string.Format("Labas {0}", System.Threading.Thread.CurrentPrincipal.Identity.Name);
            //}
        }

        public string Suma(int a, int b) //metodas suskaiciuoti suma
        {
            //gaunamas dabar prisijunges windows vartotojas
            var currentUser = new WindowsPrincipal((WindowsIdentity)Thread.CurrentPrincipal.Identity);
            //jei prisijunges vartotojas priklauso BackupOperator rolei
            if (currentUser.IsInRole(WindowsBuiltInRole.BackupOperator))
            {
                int suma = a + b; //grazinam duotu skaiciu suma
                return string.Format("Suma yra: {0}", suma);
            }

            return string.Format("Neautorizuotas"); //jei nepriklauso grazinam zinute: "Neautorizuotas"
        }
    }
}