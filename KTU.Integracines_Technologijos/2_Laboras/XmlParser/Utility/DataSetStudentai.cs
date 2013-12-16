using System;
using System.Collections.Generic;
using XmlParser.Model;

namespace XmlParser.Utility
{
    public class DataSetStudentai
    {
        public readonly List<Studentas> Studentai = new List<Studentas>();

        public void Display()
        {
            Console.WriteLine("DataSet results:");

            foreach (Studentas studentas in Studentai)
            {
                Console.Write("{0} {1} {2} ", studentas.Id, studentas.Vardas, studentas.Paz1);
                Console.WriteLine("{0} {1} {2} {3}", studentas.Paz2, studentas.Paz11, studentas.Paz22,
                    studentas.Vidurkis);
            }

            Console.WriteLine("");
        }
    }
}