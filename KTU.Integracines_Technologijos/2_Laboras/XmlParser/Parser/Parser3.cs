using System.Data;
using XmlParser.Model;
using XmlParser.Utility;

namespace XmlParser.Parser
{
    public class Parser3
    {
        public void ParseXmlUsingDataSet()
        {
            var dataSet = new DataSet(); //sukuriamas Dataset objektas

            dataSet.ReadXml(
                "C:\\Users\\Erikas\\Documents\\GitHub\\Integracines_Technologijos\\KTU.Integracines_Technologijos\\2_Laboras\\XmlParser\\Uzduotis.xml");
                //nuskaitomas XML failas ir suformuojamos lentelės

            var dataSetStudentai = new DataSetStudentai(); //sukuriamas objektas nuskaitytu studentu saugojimui

            //dataSetStudentai.DisplayDataSetInfo(dataSet); //atvaizduojami nuskaityti duomenys

            foreach (DataRow dataSetRow in dataSet.Tables["Vakarinis"].Rows)
                //imamos vakariniu studentu lenteles eilutes
            {
                var vakarinisStudentas = new Studentas(); //sukuriamas objektas vakarinio studento informacijai saugoti

                string vakarinisId = dataSetRow["Vakarinis_Id"].ToString();
                    //paimame lenteles vakarinis id numerius sarysiui su pazymiu lentele
                vakarinisStudentas.Id = dataSetRow["Id"].ToString(); //nuskaitoma "id" reiksme
                vakarinisStudentas.Vardas = dataSetRow["Vardas"].ToString(); //nuskaitoma "Vardas" reiksme
                vakarinisStudentas.Vidurkis = dataSetRow["vidurkis"].ToString(); //nuskaitoma "vidurkis" reiksme

                foreach (
                    DataRow row in dataSet.Tables["pazymiai"].Select(string.Format("Vakarinis_Id={0}", vakarinisId)))
                    //einame per pazymiu lenteles kurios siejasi su vakarinis_id
                {
                    DataRow[] children = row.GetChildRows("pazymiai_matematika");
                        //imamas pazymiu ir matematikos eiluciu sarysis duomenu nuskaitymui
                    vakarinisStudentas.Paz1 = (children[0]["paz1"]).ToString(); //nuskaitomas matematikos paz1
                    vakarinisStudentas.Paz2 = (children[0]["paz2"]).ToString(); //nuskaitomas matematikos paz2

                    children = row.GetChildRows("pazymiai_technologija");
                        //imamas pazymiu ir technologijos eiluciu sarysis duomenu nuskaitymui
                    vakarinisStudentas.Paz11 = (children[0]["paz1"]).ToString(); //nuskaitomas technologijos paz1
                    vakarinisStudentas.Paz22 = (children[0]["paz2"]).ToString(); //nuskaitomas technologijos paz1
                }
                dataSetStudentai.Studentai.Add(vakarinisStudentas);
            }

            foreach (DataRow dataSetRow in dataSet.Tables["Dieninis"].Rows) //imam atitinkamos lentelės eilutes
            {
                var dieninisStudentas = new Studentas();

                string dieninisId = dataSetRow["Dieninis_Id"].ToString();
                dieninisStudentas.Id = dataSetRow["Id"].ToString();
                dieninisStudentas.Vardas = dataSetRow["Vardas"].ToString();
                dieninisStudentas.Vidurkis = dataSetRow["vidurkis"].ToString();

                foreach (DataRow row1 in dataSet.Tables["pazymiai"].Select("Dieninis_Id=" + dieninisId))
                {
                    DataRow[] children = row1.GetChildRows("pazymiai_matematika");
                    dieninisStudentas.Paz1 = (children[0]["paz1"]).ToString();
                    dieninisStudentas.Paz2 = (children[0]["paz2"]).ToString();

                    children = row1.GetChildRows("pazymiai_fizika");
                    dieninisStudentas.Paz11 = (children[0]["paz1"]).ToString();
                    dieninisStudentas.Paz22 = (children[0]["paz2"]).ToString();
                }
                dataSetStudentai.Studentai.Add(dieninisStudentas);
            }
            dataSetStudentai.Display(); //metodas skirtas atvaizduoti nuskaityta xml informacija
        }
    }
}