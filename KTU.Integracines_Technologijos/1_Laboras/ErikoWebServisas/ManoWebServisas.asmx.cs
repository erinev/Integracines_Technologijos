using System.ComponentModel;
using System.Data;
using System.Web.Services;

namespace ErikoWebServisas
{
    [WebService(Namespace = "http://ktu.lt/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class ManoWebServisas : WebService
    {
        private readonly PaskaitosTableAdapter _paskaitosTableAdapter;
        private readonly StudentaiTableAdapter _studentaiTableAdapter;
        private readonly Studiju_planasTableAdapter _studijuPlanasTableAdapter;

        public ManoWebServisas()
        {
            _paskaitosTableAdapter = new PaskaitosTableAdapter();
            _studentaiTableAdapter = new StudentaiTableAdapter();
            _studijuPlanasTableAdapter = new Studiju_planasTableAdapter();
        }

        // ---------------------- Paskaitos table methods --------------------- //

        [WebMethod]
        public DataTable GautiPaskaitas()
        {
            Duomenis.PaskaitosDataTable paskaitos = _paskaitosTableAdapter.GautiPaskaitas();
            return paskaitos;
        }

        [WebMethod]
        public int IrasytiNaujaPaskaita(string kodas, string pavadinimas)
        {
            int rowInserted = _paskaitosTableAdapter.IrasytiNaujaPaskaita(kodas, pavadinimas);
            return rowInserted;
        }

        [WebMethod]
        public int AtnaujintiPaskaitosPavadinimaPagalKoda(string naujasPavadinimas,
            string paskaitosKodas)
        {
            int rowUpdated = _paskaitosTableAdapter.AtnaujintiPaskaitosPavadinimaPagalKoda(naujasPavadinimas, paskaitosKodas);
            return rowUpdated;
        }

        [WebMethod]
        public int IstrintiPaskaitaPagalKoda(string kodas)
        {
            int rowDeleted = _paskaitosTableAdapter.IstrintiPaskaitaPagalKoda(kodas);
            return rowDeleted;
        }

        // ---------------------- Studentai table methods --------------------- //

        [WebMethod]
        public DataTable GautiStudentus()
        {
            Duomenis.StudentaiDataTable studentai = _studentaiTableAdapter.GautiStudentus();
            return studentai;
        }

        // ---------------------- Studiju_planas table methods --------------------- //

        [WebMethod]
        public DataTable GautiDuomenisApieStudijuPlana()
        {
            Duomenis.Studiju_planasDataTable duomenis = _studijuPlanasTableAdapter.GautiVisuStudentuStudijuPlanus();
            return duomenis;
        }

        [WebMethod]
        public string GautiPaskaitaPagalLaikaIrStudentoId(string diena, string laikas, string studentoId)
        {
            var paskaitosPavadinimas = (string)_studijuPlanasTableAdapter.GautiPaskaitaPagalLaikaIrStudentoID(diena, laikas, studentoId);
            return paskaitosPavadinimas;
        }

        [WebMethod]
        public int PriskirtiPaskaitaStudentui(string studentoId, string paskaitosKodas, string diena, string laikas)
        {
            int rowInserted = _studijuPlanasTableAdapter.PriskirtiPaskaitaStudentui(studentoId, diena, laikas, paskaitosKodas);
            return rowInserted;
        }

        [WebMethod]
        public int AtnaujintiPaskaitosDataPagalPaskaitosKoda(string diena, string laikas, string paskaitosKodas)
        {
            int rowUpdated = _studijuPlanasTableAdapter.AtnaujintiPaskaitosData(diena, laikas, paskaitosKodas);
            return rowUpdated;
        }

        [WebMethod]
        public int IstrintiPaskaitaIsStudijuPlanoPagalPaskaitosKoda(string paskaitosKodas)
        {
            int rowDeleted = _studijuPlanasTableAdapter.IstrintiPaskaitaIsStudijuPlano(paskaitosKodas);
            return rowDeleted;
        }
    }
}