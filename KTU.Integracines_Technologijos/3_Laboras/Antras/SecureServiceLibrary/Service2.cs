using System.Security.Principal;

namespace SecureServiceLibrary
{
    public class Service2 : IService2
    {
        public string Labas()
        {
            //gaunamas dabar prisijunges windows vartotojas
            var currentUser = new WindowsPrincipal((WindowsIdentity) System.Threading.Thread.CurrentPrincipal.Identity);
            if (currentUser.IsInRole(WindowsBuiltInRole.User)) //jei vartotojas priklauso Users grupei
            {
                return string.Format("Labas {0}", System.Threading.Thread.CurrentPrincipal.Identity.Name); //pasisveikinam
            }

            return string.Format("Neautorizuotas"); //jei nepriklauso grazinam zinute: "Neautorizuotas"

            //Galėtumėm autorizuoti ir panaudojant "PrincipalPermission"
            //[PrincipalPermission(SecurityAction.Demand,Role="BUILTIN\\User")]
            //public string Labas()
            //{
            //    return string.Format("Labas {0}", System.Threading.Thread.CurrentPrincipal.Identity.Name);
            //}
        }
    }
}
