using System;
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
        public int IrasytiNaujaPaskaita(string kodas, string pavadinimas, DateTime laikas)
        {
            var tableAdapter = new PaskaitosTableAdapter();
            int rowInserted = tableAdapter.IrasytiNaujaPaskaita(kodas, pavadinimas, laikas);
            return rowInserted;
        }

        [WebMethod]
        public string GautiPaskaitaPagalLaika(DateTime laikas)
        {
            var tableAdapter = new PaskaitosTableAdapter();
            var pavadinimas = (string)tableAdapter.GautiPaskaitaPagalLaika(laikas);
            return pavadinimas;
        }

        [WebMethod]
        public int AtnaujintiPaskaitaPagalKoda(string naujasPavadinimas, DateTime naujasLaikas, string naujasKodas, string dabartinisKodas)
        {
            var tableAdapter = new PaskaitosTableAdapter();
            int rowUpdated = tableAdapter.AtnaujintiPaskaitaPagalKoda(naujasPavadinimas, naujasLaikas, naujasKodas, dabartinisKodas);
            return rowUpdated;
        }

        [WebMethod]
        public int IstrintiPaskaitaPagalKoda(string kodas)
        {
            var tableAdapter = new PaskaitosTableAdapter();
            int rowDeleted = tableAdapter.IstrintiPaskaitaPagalKoda(kodas);
            return rowDeleted;
        }
    }
}