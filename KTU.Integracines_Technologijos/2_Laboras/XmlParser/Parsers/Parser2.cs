using System.Xml;
using XmlParser.Model;
using XmlParser.Utility;

namespace XmlParser.Parsers
{
    public class Parser2
    {
        public void ParseXmlUsingXmlDocument()
        {
            var studentai = new Studentai(); //sukuriamas objektas studentų saugojimui

            var xd = new XmlDocument(); //sukuriamas XmlDocument objektas
            xd.Load(
                "C:\\Users\\Erikas\\Documents\\GitHub\\Integracines_Technologijos\\KTU.Integracines_Technologijos\\2_Laboras\\XmlParser\\Uzduotis.xml");
            //uzkraunamas XML failas

            XmlNodeList vakariniaiNodeList = xd.SelectNodes("/studentai/Vakarinis");
            // gaunam visus <vakarinis> elementus

            foreach (XmlNode node in vakariniaiNodeList) // kiekvienam <vakarinis> elementui
            {
                var vakarinisStudentas = new Studentas(); //sukuriamas objektas studentų duomenų saugojimui

                vakarinisStudentas.Id = node.Attributes.GetNamedItem("id").Value; //nuskaitom "Id" reikšmę
                vakarinisStudentas.Vardas = node.Attributes.GetNamedItem("vardas").Value; //nuskaitom "Vardas" reikšmę

                XmlNode matematikaSingleNode = node.SelectSingleNode("pazymiai/matematika");
                // gaunam <matematika> elementą

                vakarinisStudentas.Paz1 = matematikaSingleNode.ChildNodes.Item(0).InnerText; //nuskaitome pirma pazymi
                vakarinisStudentas.Paz2 = matematikaSingleNode.ChildNodes.Item(1).InnerText; //nuskaitome antrą pažymį

                XmlNode technologijaSingleNode = node.SelectSingleNode("pazymiai/technologija");
                // gaunam <technologija> elementą
                vakarinisStudentas.Paz11 = technologijaSingleNode.ChildNodes.Item(0).InnerText;
                //nuskaitome pirma pazymi
                vakarinisStudentas.Paz22 = technologijaSingleNode.ChildNodes.Item(1).InnerText;
                //nuskaitome antrą pažymį

                vakarinisStudentas.Vidurkis = node.ChildNodes.Item(1).InnerText; //gauname vidurkį

                studentai.VakariniaiStudentai.Add(vakarinisStudentas);
            }

            XmlNodeList dieniniaiNodeList = xd.SelectNodes("/studentai/Dieninis"); // gaunam visus <dieninis> elementus

            foreach (XmlNode node in dieniniaiNodeList) // kiekvienam <dieninis> elementui
            {
                var dieninis = new Studentas();
                dieninis.Id = node.Attributes.GetNamedItem("id").Value; //nuskaitom "Id" reikšmę
                dieninis.Vardas = node.Attributes.GetNamedItem("vardas").Value; //nuskaitom "Vardas" reikšmę

                XmlNode matematikaSingleNode = node.SelectSingleNode("pazymiai/matematika");
                // gaunam <matematika> elementą
                dieninis.Paz1 = matematikaSingleNode.ChildNodes.Item(0).InnerText; //nuskaitome pirma pazymi
                dieninis.Paz2 = matematikaSingleNode.ChildNodes.Item(1).InnerText; //nuskaitome antra pazymi

                XmlNode fizikaSingleNode = node.SelectSingleNode("pazymiai/fizika");
                dieninis.Paz11 = fizikaSingleNode.ChildNodes.Item(0).InnerText; //nuskaitome pirma pazymi
                dieninis.Paz22 = fizikaSingleNode.ChildNodes.Item(1).InnerText; //nuskaitome antra pazymi

                dieninis.Vidurkis = node.ChildNodes.Item(1).InnerText; //gauname vidurkį

                studentai.DieniniaiStudentai.Add(dieninis);
            }
            studentai.Display(2);
        }
    }
}