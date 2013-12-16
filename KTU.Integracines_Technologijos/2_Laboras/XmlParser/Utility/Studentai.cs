using System;
using System.Collections.Generic;
using XmlParser.Model;

namespace XmlParser.Utility
{
    public class Studentai
    {
        public readonly List<Studentas> VakariniaiStudentai = new List<Studentas>();
        public readonly List<Studentas> DieniniaiStudentai = new List<Studentas>();

        public void Display(XmlParseMethod method)
        {
            switch (method)
            {
                case XmlParseMethod.XmlTextReader:
                    Console.WriteLine("XmlTextReader results:");
                    break;
                case XmlParseMethod.XmlDocument:
                    Console.WriteLine("XmlDocument results:");
                    break;
                default:
                    Console.WriteLine("Unknow xml parser");
                    break;
            }

            foreach (Studentas studentas in VakariniaiStudentai)
            {
                Console.Write("{0} {1} {2} ", studentas.Id, studentas.Vardas, studentas.Paz1);
                Console.WriteLine("{0} {1} {2} {3}", studentas.Paz2, studentas.Paz11, studentas.Paz22,
                    studentas.Vidurkis);
            }

            foreach (Studentas studentas in DieniniaiStudentai)
            {
                Console.Write("{0} {1} {2} ", studentas.Id, studentas.Vardas, studentas.Paz1);
                Console.WriteLine("{0} {1} {2} {3}", studentas.Paz2, studentas.Paz11, studentas.Paz22,
                    studentas.Vidurkis);
            }

            Console.WriteLine("");
        }
    }

    public enum XmlParseMethod
    {
        XmlTextReader = 1,
        XmlDocument = 2
    }
}