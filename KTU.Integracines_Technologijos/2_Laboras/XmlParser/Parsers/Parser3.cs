using System.Data;
using XmlParser.Model;
using XmlParser.Utility;

namespace XmlParser.Parsers
{
    public class Parser3
    {
        public void ParseXmlUsingDataSet()
        {
            var dataSet = new DataSet(); //sukuriamas Dataset objektas

            dataSet.ReadXml(
                "C:\\Users\\Erikas\\Documents\\GitHub\\Integracines_Technologijos\\KTU.Integracines_Technologijos\\2_Laboras\\XmlParser\\Uzduotis.xml");
            //nuskaitomas XML failas ir suformuojamos lentelės

            //DataSetInfo.DisplayInfo(dataSet); //atvaizduojam nuskaitytus duomenis

            var dataSetStudentai = new DataSetStudentai(); //sukuriamas objektas studentų saugojimui

            foreach (DataRow dataSetRow in dataSet.Tables["Vakarinis"].Rows) //imam atitinkamos lentelės eilutes
            {
                var vakarinisStudentas = new Studentas(); //sukuriamas objektas studentų duomenų saugojimui
                string vakarinisId = dataSetRow["Vakarinis_Id"].ToString();
                //paimame lenteles vakarinis Id numerius sarysiui su pazymiu lentele
                vakarinisStudentas.Id = dataSetRow["Id"].ToString(); //nuskaitom "Id" reikšmę
                vakarinisStudentas.Vardas = dataSetRow["Vardas"].ToString(); //nuskaitom "Vardas" reikšmę
                vakarinisStudentas.Vidurkis = dataSetRow["vidurkis"].ToString(); //nuskaitom "vidurkis" reikšmę

                foreach (DataRow row in dataSet.Tables["pazymiai"].Select("Vakarinis_Id=" + vakarinisId))
                    //einame per pazymiu lenteles kurios risasi su vakarinis_id
                {
                    DataRow[] children = row.GetChildRows("pazymiai_matematika");
                    //imame pazymiu ir matematikos eiluciu sarysi duomenu nuskaitymui
                    vakarinisStudentas.Paz1 = (children[0]["paz1"]).ToString();
                    //imame pirmaja vaiko eilute is matematikos
                    vakarinisStudentas.Paz2 = (children[0]["paz2"]).ToString(); //imame antra vaiko eilute is matematikos

                    children = row.GetChildRows("pazymiai_technologija");
                    //imame pazymiu ir technologijos eiluciu sarysi duomenu nuskaitymui
                    vakarinisStudentas.Paz11 = (children[0]["paz1"]).ToString();
                    //imame pirma vaiko eilute is technologijos
                    vakarinisStudentas.Paz22 = (children[0]["paz2"]).ToString();
                    //imame antra vaiko eilute is technologijos
                }

                dataSetStudentai.Studentai.Add(vakarinisStudentas);
            }

            foreach (DataRow dataSetRow in dataSet.Tables["Dieninis"].Rows) //imam atitinkamos lentelės eilutes
            {
                var dieninisStudentas = new Studentas(); //sukuriamas objektas studentų duomenų saugojimui
                string dieninisId = dataSetRow["Dieninis_Id"].ToString();
                //paimame lenteles dieninis_id numerius sarysiui su pazymiu lentele
                dieninisStudentas.Id = dataSetRow["Id"].ToString(); //nuskaitom "Id" reikšmę
                dieninisStudentas.Vardas = dataSetRow["Vardas"].ToString(); //nuskaitom "Vardas" reikšmę
                dieninisStudentas.Vidurkis = dataSetRow["vidurkis"].ToString(); //nuskaitom "vidurkis" reikšmę

                foreach (DataRow row1 in dataSet.Tables["pazymiai"].Select("Dieninis_Id=" + dieninisId))
                    //einame per pazymiu lenteles kurios risasi su dieninis_id
                {
                    DataRow[] children = row1.GetChildRows("pazymiai_matematika");
                    dieninisStudentas.Paz1 = (children[0]["paz1"]).ToString();
                    //imame pirmaja vaiko eilute is matematikos
                    dieninisStudentas.Paz2 = (children[0]["paz2"]).ToString();
                    //imame antraja vaiko eilute is matematikos

                    children = row1.GetChildRows("pazymiai_fizika");
                    //imame pazymiu ir fizikos eiluciu sarysi duomenu nuskaitymui
                    dieninisStudentas.Paz11 = (children[0]["paz1"]).ToString(); //imame pirmaja vaiko eilute is fizikos
                    dieninisStudentas.Paz22 = (children[0]["paz2"]).ToString(); //imame antraja vaiko eilute is fizikos
                }

                dataSetStudentai.Studentai.Add(dieninisStudentas);
            }

            dataSetStudentai.Display();
        }
    }
}