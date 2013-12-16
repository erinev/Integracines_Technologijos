using System;
using System.Collections.Generic;

namespace XmlParser
{
    public class DataSetStudentai
    {
        public readonly List<DataSetStudentas> Studentai = new List<DataSetStudentas>();

        public void Display()
        {
            foreach (DataSetStudentas studentas in Studentai)
            {
                Console.Write("{0} {1} {2} ", studentas.Id, studentas.Vardas, studentas.Paz1);
                Console.WriteLine("{0} {1} {2} {3}", studentas.Paz2, studentas.Paz11, studentas.Paz22,
                    studentas.Vidurkis);
            }

            Console.WriteLine("");
        }
    }
}