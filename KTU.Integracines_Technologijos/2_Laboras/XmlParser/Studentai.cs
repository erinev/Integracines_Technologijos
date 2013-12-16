using System;
using System.Collections;

namespace XmlParser
{
    public class Studentai
    {
        public readonly ArrayList VakariniaiStudentai = new ArrayList();
        public readonly ArrayList DieniniaiStudentai = new ArrayList();

        public void Display(int parserIndex)
        {
            switch (parserIndex)
            {
                case 1:
                    Console.WriteLine("XmlTextReader results:");
                    break;
                case 2:
                    Console.WriteLine("XmlDocument results:");
                    break;
                default:
                    Console.WriteLine("Unknow xml parser");
                    break;
            }

            foreach (Vakarinis studentas in VakariniaiStudentai)
            {
                Console.Write("{0} {1} {2} ", studentas.Id, studentas.Vardas, studentas.Paz1);
                Console.WriteLine("{0} {1} {2} {3}", studentas.Paz2, studentas.Paz11, studentas.Paz22,
                    studentas.Vidurkis);
            }

            foreach (Dieninis studentas in DieniniaiStudentai)
            {
                Console.Write("{0} {1} {2} ", studentas.Id, studentas.Vardas, studentas.Paz1);
                Console.WriteLine("{0} {1} {2} {3}", studentas.Paz2, studentas.Paz11, studentas.Paz22,
                    studentas.Vidurkis);
            }

            Console.WriteLine("");
        }
    }
}