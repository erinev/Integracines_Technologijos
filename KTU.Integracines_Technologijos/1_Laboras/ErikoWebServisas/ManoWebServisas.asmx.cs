using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            int rowUpdated = _paskaitosTableAdapter.AtnaujintiPaskaitosPavadinimaPagalKoda(naujasPavadinimas,
                paskaitosKodas);
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
            string connectionString =
                ConfigurationManager.ConnectionStrings["Integracines_TechnologijosConnectionString"].ConnectionString;

            DataTable table = CreateEmptyDataTable();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText =
                    "SELECT Paskaitos.Pavadinimas, Studiju_planas.Diena, Studiju_planas.Laikas, Studentai.Vardas, Studentai.Pavarde " +
                    "FROM Paskaitos " +
                    "INNER JOIN Studiju_planas " +
                    "ON Paskaitos.Kodas = Studiju_planas.Paskaitos_kodas " +
                    "INNER JOIN Studentai " +
                    "ON Studiju_planas.ID_Studentas = Studentai.ID_Studentas";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();

                        row["Pavadinimas"] = reader["Pavadinimas"].ToString();
                        row["Diena"] = reader["Diena"].ToString();
                        row["Laikas"] = reader["Laikas"].ToString();
                        row["Vardas"] = reader["Vardas"].ToString();
                        row["Pavarde"] = reader["Pavarde"].ToString();

                        table.Rows.Add(row);
                    }
                }
            }

            return table;
        }

        private DataTable CreateEmptyDataTable()
        {
            var table = new DataTable("Rezultatai");

            var pavadinimasColumn = new DataColumn("Pavadinimas");
            var dienaColumn = new DataColumn("Diena");
            var laikasColumn = new DataColumn("Laikas");
            var vardasColumn = new DataColumn("Vardas");
            var pavardeColumn = new DataColumn("Pavarde");

            pavadinimasColumn.DataType = Type.GetType("System.String");
            dienaColumn.DataType = Type.GetType("System.String");
            laikasColumn.DataType = Type.GetType("System.String");
            vardasColumn.DataType = Type.GetType("System.String");
            pavardeColumn.DataType = Type.GetType("System.String");

            table.Columns.Add(pavadinimasColumn);
            table.Columns.Add(dienaColumn);
            table.Columns.Add(laikasColumn);
            table.Columns.Add(vardasColumn);
            table.Columns.Add(pavardeColumn);

            return table;
        }

        [WebMethod]
        public string GautiPaskaitaPagalLaikaIrStudentoId(string diena, string laikas, string studentoId)
        {
            string paskaitosPavadinimas = _studijuPlanasTableAdapter.GautiPaskaitaPagalLaikaIrStudentoID(diena, laikas,
                studentoId);
            return paskaitosPavadinimas;
        }

        [WebMethod]
        public int PriskirtiPaskaitaStudentui(string studentoId, string paskaitosKodas, string diena, string laikas)
        {
            int rowInserted = _studijuPlanasTableAdapter.PriskirtiPaskaitaStudentui(studentoId, paskaitosKodas, diena,
                laikas);
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