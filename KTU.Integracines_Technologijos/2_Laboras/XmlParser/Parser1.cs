using System.Xml;

namespace XmlParser
{
    public class Parser1
    {
        public void ReadXmlUsingXmlTextReader()
        {
            var studentai = new Studentai(); //sukuriame objekta studentu duomenims saugoti

            var xmlTextReader =
                new XmlTextReader(
                    "C:\\Users\\Erikas\\Documents\\GitHub\\Integracines_Technologijos\\KTU.Integracines_Technologijos\\2_Laboras\\XmlParser\\Uzduotis.xml")
                    //uzkrauname faila
                {
                    WhitespaceHandling = WhitespaceHandling.None
                };

            xmlTextReader.Read(); //perskaitom XML failo deklaraciją ir atsiduriam ties <studentai> elemento žyme

            while (!xmlTextReader.EOF)
            {
                if (xmlTextReader.Name == "studentai" && !xmlTextReader.IsStartElement())
                    break;

                while (xmlTextReader.Name != "Vakarinis" && xmlTextReader.Name != "Dieninis" ||
                       !xmlTextReader.IsStartElement())
                {
                    xmlTextReader.Read();
                }

                if (xmlTextReader.Name == "Vakarinis" && xmlTextReader.IsStartElement())
                {
                    var vakariniai = new Vakarinis //sukuriamas objektas vakariniams studentams saugoti
                    {
                        Id = xmlTextReader.GetAttribute("Vardas"),
                        Vardas = xmlTextReader.GetAttribute("Id")
                    };

                    xmlTextReader.Read(); // atsiduriam ties <pazymiai> elemento žyme
                    xmlTextReader.Read(); // atsiduriam  ties <matematika>
                    xmlTextReader.Read(); //atsiduriam ties <paz1> elemento žyme
                    vakariniai.Paz1 = xmlTextReader.ReadElementString("paz1"); //nuskaitom "paz1" reikšmę
                    vakariniai.Paz2 = xmlTextReader.ReadElementString("paz2"); //nuskaitom "paz2" reikšmę
                    xmlTextReader.Read();
                    xmlTextReader.Read();
                    vakariniai.Paz11 = xmlTextReader.ReadElementString("paz1"); //nuskaitom "paz1" reikšmę
                    vakariniai.Paz22 = xmlTextReader.ReadElementString("paz2"); //nuskaitom "paz2" reikšmę
                    xmlTextReader.Read();
                    xmlTextReader.Read();
                    vakariniai.Vidurkis = xmlTextReader.ReadElementString("vidurkis"); // nuskaitom  reikšmę 

                    studentai.VakariniaiStudentai.Add(vakariniai); // įtraukiam studento objektą į studentai objektą 
                    xmlTextReader.Read();
                    // dabar ties </vakarinis> elemento pabaigos žyme
                }

                if (xmlTextReader.Name == "Dieninis" && xmlTextReader.IsStartElement())
                {
                    var dieniniai = new Dieninis //sukuriamas objektas studentų duomenų saugojimui
                    {
                        Id = xmlTextReader.GetAttribute("Vardas"),
                        Vardas = xmlTextReader.GetAttribute("Id")
                    };

                    xmlTextReader.Read(); // atsiduriam ties <pazymiai> elemento žyme
                    xmlTextReader.Read(); // atsiduriam  ties <matematika>
                    xmlTextReader.Read(); //atsiduriam ties <paz1> elemento žyme
                    dieniniai.Paz1 = xmlTextReader.ReadElementString("paz1"); //nuskaitom "paz1" reikšmę
                    dieniniai.Paz2 = xmlTextReader.ReadElementString("paz2"); //nuskaitom "paz2" reikšmę
                    xmlTextReader.Read(); // atsiduriam  ties <technologija>
                    xmlTextReader.Read(); //atsiduriam ties <paz1> elemento žyme
                    dieniniai.Paz11 = xmlTextReader.ReadElementString("paz1"); //nuskaitom "paz1" reikšmę
                    dieniniai.Paz22 = xmlTextReader.ReadElementString("paz2"); //nuskaitom "paz2" reikšmę
                    xmlTextReader.Read(); // atsiduriam ties <vidurkis> elemento žyme
                    xmlTextReader.Read();
                    dieniniai.Vidurkis = xmlTextReader.ReadElementString("vidurkis"); // nuskaitom "vidurkis" reikšmę 
                    // dabar ties </studentas> elemento pabaigos žyme
                    studentai.DieniniaiStudentai.Add(dieniniai); // įtraukiam studento objektą į studentai objektą 
                    xmlTextReader.Read();
                    // dabar ties </Dieninis> elemento žyme  
                }
            }
            studentai.Display(1);
        }
    }
}