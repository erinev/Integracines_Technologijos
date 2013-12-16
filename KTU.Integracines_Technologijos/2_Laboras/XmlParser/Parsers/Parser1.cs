using System.Xml;
using XmlParser.Model;
using XmlParser.Utility;

namespace XmlParser.Parsers
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
                    var vakarinis = new Studentas //sukuriamas objektas vakariniams studentams saugoti
                    {
                        Id = xmlTextReader.GetAttribute("vardas"),
                        Vardas = xmlTextReader.GetAttribute("id")
                    };

                    xmlTextReader.Read(); // atsiduriam ties <pazymiai> elemento žyme
                    xmlTextReader.Read(); // atsiduriam  ties <matematika>
                    xmlTextReader.Read(); //atsiduriam ties <paz1> elemento žyme
                    vakarinis.Paz1 = xmlTextReader.ReadElementString("paz1"); //nuskaitom "paz1" reikšmę
                    vakarinis.Paz2 = xmlTextReader.ReadElementString("paz2"); //nuskaitom "paz2" reikšmę
                    xmlTextReader.Read();
                    xmlTextReader.Read();
                    vakarinis.Paz11 = xmlTextReader.ReadElementString("paz1"); //nuskaitom "paz1" reikšmę
                    vakarinis.Paz22 = xmlTextReader.ReadElementString("paz2"); //nuskaitom "paz2" reikšmę
                    xmlTextReader.Read();
                    xmlTextReader.Read();
                    vakarinis.Vidurkis = xmlTextReader.ReadElementString("vidurkis"); // nuskaitom  reikšmę 

                    studentai.VakariniaiStudentai.Add(vakarinis); // įtraukiam studento objektą į studentai objektą 
                    xmlTextReader.Read();
                    // dabar ties </vakarinis> elemento pabaigos žyme
                }

                if (xmlTextReader.Name == "Dieninis" && xmlTextReader.IsStartElement())
                {
                    var dieninis = new Studentas() //sukuriamas objektas studentų duomenų saugojimui
                    {
                        Id = xmlTextReader.GetAttribute("vardas"),
                        Vardas = xmlTextReader.GetAttribute("id")
                    };

                    xmlTextReader.Read(); // atsiduriam ties <pazymiai> elemento žyme
                    xmlTextReader.Read(); // atsiduriam  ties <matematika>
                    xmlTextReader.Read(); //atsiduriam ties <paz1> elemento žyme
                    dieninis.Paz1 = xmlTextReader.ReadElementString("paz1"); //nuskaitom "paz1" reikšmę
                    dieninis.Paz2 = xmlTextReader.ReadElementString("paz2"); //nuskaitom "paz2" reikšmę
                    xmlTextReader.Read(); // atsiduriam  ties <technologija>
                    xmlTextReader.Read(); //atsiduriam ties <paz1> elemento žyme
                    dieninis.Paz11 = xmlTextReader.ReadElementString("paz1"); //nuskaitom "paz1" reikšmę
                    dieninis.Paz22 = xmlTextReader.ReadElementString("paz2"); //nuskaitom "paz2" reikšmę
                    xmlTextReader.Read(); // atsiduriam ties <vidurkis> elemento žyme
                    xmlTextReader.Read();
                    dieninis.Vidurkis = xmlTextReader.ReadElementString("vidurkis"); // nuskaitom "vidurkis" reikšmę 
                    // dabar ties </studentas> elemento pabaigos žyme
                    studentai.DieniniaiStudentai.Add(dieninis); // įtraukiam studento objektą į studentai objektą 
                    xmlTextReader.Read();
                    // dabar ties </Dieninis> elemento žyme  
                }
            }
            studentai.Display(1);
        }
    }
}