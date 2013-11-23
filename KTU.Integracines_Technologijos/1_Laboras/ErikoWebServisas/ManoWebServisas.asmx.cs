using System.ComponentModel;
using System.Web.Services;

namespace ErikoWebServisas
{
    [WebService(Namespace = "http://ktu.lt/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class ManoWebServisas : WebService
    {
        [WebMethod]
        public string GautiPavadinimaPagalKoda(string kodas)
        {
            var tableAdapter = new PaskaitosTableAdapter();
            string pavadinimas = tableAdapter.GautiPavadinimaPagalKoda(kodas);
            return pavadinimas;
        }
    }
}