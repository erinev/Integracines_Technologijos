using System.Xml;
using XmlParser.Model;
using XmlParser.Utility;

namespace XmlParser.Parser
{
    public class Parser2
    {
        public void ParseXmlUsingXmlDocument()
        {
            var studentai = new Studentai(); //sukuriamas objektas studentu informacijos atvaizdavimui

            var xmlDocument = new XmlDocument(); //sukuriamas XmlDocument objektas
            xmlDocument.Load(
                "C:\\Users\\Erikas\\Documents\\GitHub\\Integracines_Technologijos\\KTU.Integracines_Technologijos\\2_Laboras\\XmlParser\\Uzduotis.xml");
            //uzkraunamas XML failas

            XmlNodeList vakariniaiNodeList = xmlDocument.SelectNodes("/studentai/Vakarinis");
            //gaunami visi <vakarinis> elementai

            foreach (XmlNode node in vakariniaiNodeList) //kiekvienam <vakarinis> elementui
            {
                var vakarinisStudentas = new Studentas //sukuriamas objektas vakariniu studentu duomenu saugojimui
                {
                    Id = node.Attributes.GetNamedItem("id").Value,
                    Vardas = node.Attributes.GetNamedItem("vardas").Value
                };

                XmlNode matematikaSingleNode = node.SelectSingleNode("pazymiai/matematika");
                //gaunamas <matematika> elementas

                vakarinisStudentas.Paz1 = matematikaSingleNode.ChildNodes.Item(0).InnerText;
                //nuskaitomas pirmas pazymys
                vakarinisStudentas.Paz2 = matematikaSingleNode.ChildNodes.Item(1).InnerText; //nuskaitomas antrs pazymys

                XmlNode technologijaSingleNode = node.SelectSingleNode("pazymiai/technologija");
                //gaunamas <technologija> elementas
                vakarinisStudentas.Paz11 = technologijaSingleNode.ChildNodes.Item(0).InnerText;
                //nuskaitomas pirmas pazymys
                vakarinisStudentas.Paz22 = technologijaSingleNode.ChildNodes.Item(1).InnerText;
                //nuskaitomas antras pazymys

                vakarinisStudentas.Vidurkis = node.ChildNodes.Item(1).InnerText; //gaunamas vidurkis

                studentai.VakariniaiStudentai.Add(vakarinisStudentas);
                //i sarasa pridedamas nuskaitytas vakarinis studentas
            }

            XmlNodeList dieniniaiNodeList = xmlDocument.SelectNodes("/studentai/Dieninis");
            //gaunami visi <dieninis> elementai

            foreach (XmlNode node in dieniniaiNodeList) //kiekvienam <dieninis> elementui
            {
                var dieninis = new Studentas //sukuriamas objektas dieniniu studentu duomenu saugojimui
                {
                    Id = node.Attributes.GetNamedItem("id").Value,
                    Vardas = node.Attributes.GetNamedItem("vardas").Value
                };

                XmlNode matematikaSingleNode = node.SelectSingleNode("pazymiai/matematika");
                //gaunami <matematika> elementai

                dieninis.Paz1 = matematikaSingleNode.ChildNodes.Item(0).InnerText; //nuskaitomas pirmas pazymys
                dieninis.Paz2 = matematikaSingleNode.ChildNodes.Item(1).InnerText; //nuskaitomas antras pazymys

                XmlNode fizikaSingleNode = node.SelectSingleNode("pazymiai/fizika"); //gaunami <fizika> elementai

                dieninis.Paz11 = fizikaSingleNode.ChildNodes.Item(0).InnerText; //nuskaitomas pirmas pazymys
                dieninis.Paz22 = fizikaSingleNode.ChildNodes.Item(1).InnerText; //nuskaitomas antras pazymys

                dieninis.Vidurkis = node.ChildNodes.Item(1).InnerText; //gaunamas vidurkis

                studentai.DieniniaiStudentai.Add(dieninis); //i sarasa pridedamas nuskaitytas dieninis studentas
            }
            studentai.Display(XmlParseMethod.XmlDocument);
            //metodas skirtas i konsoles langa atvaizduoti nuskaityta xml informacija
        }
    }
}