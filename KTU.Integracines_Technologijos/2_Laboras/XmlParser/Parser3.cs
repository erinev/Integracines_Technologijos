using System.Data;

namespace XmlParser
{
    public class Parser3
    {
        public void ParseXmlUsingDataSet()
        {
            var dataSet = new DataSet(); //sukuriamas Dataset objektas

            dataSet.ReadXml(
                "C:\\Users\\Erikas\\Documents\\GitHub\\Integracines_Technologijos\\KTU.Integracines_Technologijos\\2_Laboras\\XmlParser\\Uzduotis.xml");
            //nuskaitomas XML failas ir suformuojamos lentelės

            DataSetInfo.DisplayInfo(dataSet); //atvaizduojam nuskaitytus duomenis

            var dataSetStudentai = new DataSetStudentai(); //sukuriamas objektas studentų saugojimui

            foreach (DataRow dataSetRow in dataSet.Tables["Vakarinis"].Rows) //imam atitinkamos lentelės eilutes
            {
                var dataSetStudentas = new DataSetStudentas(); //sukuriamas objektas studentų duomenų saugojimui
                string vakarinisId = dataSetRow["Vakarinis_Id"].ToString();
                    //paimame lenteles vakarinis Id numerius sarysiui su pazymiu lentele
                dataSetStudentas.Id = dataSetRow["Id"].ToString(); //nuskaitom "Id" reikšmę
                dataSetStudentas.Vardas = dataSetRow["Vardas"].ToString(); //nuskaitom "Vardas" reikšmę
                dataSetStudentas.Vidurkis = dataSetRow["vidurkis"].ToString(); //nuskaitom "vidurkis" reikšmę

                foreach (DataRow row in dataSet.Tables["pazymiai"].Select("Vakarinis_Id=" + vakarinisId))
                    //einame per pazymiu lenteles kurios risasi su vakarinis_id
                {
                    DataRow[] children = row.GetChildRows("pazymiai_matematika");
                        //imame pazymiu ir matematikos eiluciu sarysi duomenu nuskaitymui
                    dataSetStudentas.Paz1 = (children[0]["paz1"]).ToString();
                        //imame pirmaja vaiko eilute is matematikos
                    dataSetStudentas.Paz2 = (children[0]["paz2"]).ToString(); //imame antra vaiko eilute is matematikos

                    children = row.GetChildRows("pazymiai_technologija");
                        //imame pazymiu ir technologijos eiluciu sarysi duomenu nuskaitymui
                    dataSetStudentas.Paz11 = (children[0]["paz1"]).ToString();
                        //imame pirma vaiko eilute is technologijos
                    dataSetStudentas.Paz22 = (children[0]["paz2"]).ToString();
                        //imame antra vaiko eilute is technologijos
                }

                dataSetStudentai.Studentai.Add(dataSetStudentas);
            }

            foreach (DataRow dataSetRow in dataSet.Tables["Dieninis"].Rows) //imam atitinkamos lentelės eilutes
            {
                var dataSetStudentas = new DataSetStudentas(); //sukuriamas objektas studentų duomenų saugojimui
                string dieninisId = dataSetRow["Dieninis_Id"].ToString();
                    //paimame lenteles dieninis_id numerius sarysiui su pazymiu lentele
                dataSetStudentas.Id = dataSetRow["Id"].ToString(); //nuskaitom "Id" reikšmę
                dataSetStudentas.Vardas = dataSetRow["Vardas"].ToString(); //nuskaitom "Vardas" reikšmę
                dataSetStudentas.Vidurkis = dataSetRow["vidurkis"].ToString(); //nuskaitom "vidurkis" reikšmę

                foreach (DataRow row1 in dataSet.Tables["pazymiai"].Select("Dieninis_Id=" + dieninisId))
                    //einame per pazymiu lenteles kurios risasi su dieninis_id
                {
                    DataRow[] children = row1.GetChildRows("pazymiai_matematika");
                    dataSetStudentas.Paz1 = (children[0]["paz1"]).ToString();
                        //imame pirmaja vaiko eilute is matematikos
                    dataSetStudentas.Paz2 = (children[0]["paz2"]).ToString();
                        //imame antraja vaiko eilute is matematikos

                    children = row1.GetChildRows("pazymiai_fizika");
                        //imame pazymiu ir fizikos eiluciu sarysi duomenu nuskaitymui
                    dataSetStudentas.Paz11 = (children[0]["paz1"]).ToString(); //imame pirmaja vaiko eilute is fizikos
                    dataSetStudentas.Paz22 = (children[0]["paz2"]).ToString(); //imame antraja vaiko eilute is fizikos
                }

                dataSetStudentai.Studentai.Add(dataSetStudentas);
            }

            dataSetStudentai.Display();
        }
    }
}