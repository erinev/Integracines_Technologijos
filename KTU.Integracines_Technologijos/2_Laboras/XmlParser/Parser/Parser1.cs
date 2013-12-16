using System.Xml;
using XmlParser.Model;
using XmlParser.Utility;

namespace XmlParser.Parser
{
    public class Parser1
    {
        public void ReadXmlUsingXmlTextReader()
        {
            var studentai = new Studentai(); //sukuriamas objektas studentu informacijos atvaizdavimui

            var xmlTextReader = new XmlTextReader(
                "C:\\Users\\Erikas\\Documents\\GitHub\\Integracines_Technologijos\\KTU.Integracines_Technologijos\\2_Laboras\\XmlParser\\Uzduotis.xml")
                //uzkraunamas Uzduotis.xml failas
            {
                WhitespaceHandling = WhitespaceHandling.None
            };

            xmlTextReader.Read(); //atsiduriam ties <studentai> elementu

            while (!xmlTextReader.EOF) //skaitom xml teksta iki pabaigos
            {
                if (xmlTextReader.Name == "studentai" && !xmlTextReader.IsStartElement())
                    break; //jei randam <studentai> elementa ir tai nera pradzios elementas iseinam is skaitymo

                while (xmlTextReader.Name != "Vakarinis" && xmlTextReader.Name != "Dieninis" ||
                       !xmlTextReader.IsStartElement())
                {
                    xmlTextReader.Read(); //skaitoma iki kol randamas <Vakarinis> arb <Dieninis> pradzios elementai
                }

                if (xmlTextReader.Name == "Vakarinis" && xmlTextReader.IsStartElement())
                    //jei pradzios elementas <Vakarinis>
                {
                    var vakarinis = new Studentas //sukuriamas objektas vakariniui studentui saugoti
                    {
                        Id = xmlTextReader.GetAttribute("id"), //nuskaitomas <Vakarinis> elemento pozymis id  
                        Vardas = xmlTextReader.GetAttribute("vardas") //nuskaitomas <Vakarinis> elemento pozymis vardas
                    };

                    xmlTextReader.Read(); //atsiduriama ties <pazymiai> elemeto zyme
                    xmlTextReader.Read(); //atsiduriama ties <matematika> elemeto zyme
                    xmlTextReader.Read(); //atsiduriama ties <paz1> elemeto zyme
                    vakarinis.Paz1 = xmlTextReader.ReadElementString("paz1"); //nuskaitoma <paz1> reiksme
                    vakarinis.Paz2 = xmlTextReader.ReadElementString("paz2"); //nuskaitoma <paz2> reiksme
                    xmlTextReader.Read(); //atsiduriama ties uzdaromoja <matematika> elemeto zyme
                    xmlTextReader.Read(); //atsiduriama ties <technologija> elemeto zyme
                    vakarinis.Paz11 = xmlTextReader.ReadElementString("paz1"); //nuskaitoma <paz1> reiksme
                    vakarinis.Paz22 = xmlTextReader.ReadElementString("paz2"); //nuskaitoma <paz2> reiksme
                    xmlTextReader.Read(); //atsiduriama ties uzdaromoja <technologija> elemeto zyme
                    xmlTextReader.Read(); //atsiduriama ties uzdaromoja <pazymiai> elemeto zyme
                    vakarinis.Vidurkis = xmlTextReader.ReadElementString("vidurkis");
                    //nuskaitoma <vidurkis> elemento reiksme 
                    xmlTextReader.Read(); //atsiduriama ties </vakarinis> elemento pabaigos zyme

                    studentai.VakariniaiStudentai.Add(vakarinis);
                    //itraukiamas nuskaitytas vakarinis studentas i sarasa 
                }

                if (xmlTextReader.Name == "Dieninis" && xmlTextReader.IsStartElement())
                    //jei pradzios elementas <Dieninis>
                {
                    var dieninis = new Studentas
                    {
                        Id = xmlTextReader.GetAttribute("id"),
                        Vardas = xmlTextReader.GetAttribute("vardas")
                    };

                    xmlTextReader.Read(); //atsiduriama ties <pazymiai> elemento zyme
                    xmlTextReader.Read(); //atsiduriama ties <matematika> elemento zyme
                    xmlTextReader.Read(); //atsiduriama ties <paz1> elemento zyme
                    dieninis.Paz1 = xmlTextReader.ReadElementString("paz1");
                    dieninis.Paz2 = xmlTextReader.ReadElementString("paz2");
                    xmlTextReader.Read(); //atsiduriama ties uzdaromoja <matematika> elemeto zyme
                    xmlTextReader.Read(); //atsiduriama ties <technologija> elemeto zyme
                    dieninis.Paz11 = xmlTextReader.ReadElementString("paz1");
                    dieninis.Paz22 = xmlTextReader.ReadElementString("paz2");
                    xmlTextReader.Read(); //atsiduriama ties uzdaromoja <technologija> elemeto zyme
                    xmlTextReader.Read(); //atsiduriama ties uzdaromoja <pazymiai> elemeto zyme
                    dieninis.Vidurkis = xmlTextReader.ReadElementString("vidurkis");
                    xmlTextReader.Read(); //atsiduriama ties </dieninis> elemento pabaigos zyme

                    studentai.DieniniaiStudentai.Add(dieninis); //itraukiamas nuskaitytas dieninis studentas i sarasa 
                }
            }
            studentai.Display(XmlParseMethod.XmlTextReader);
            //metodas skirtas i konsoles langa atvaizduoti nuskaityta xml informacija
        }
    }
}