using System;
using System.Collections.Generic;
using System.Data;
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

        public void DisplayDataSetInfo(DataSet dataSet) //metodas DataSet objekto duomenu atvaizdavimui
        {
            foreach (DataTable dataTable in dataSet.Tables)
            {
                Console.WriteLine("\n===============================================");
                Console.WriteLine("Table={0}\n", dataTable.TableName);

                foreach (DataColumn dataColumn in dataTable.Columns)
                {
                    Console.Write("{0,-14}", dataColumn.ColumnName);
                }
                Console.WriteLine("\n-----------------------------------------------");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    foreach (object data in dataRow.ItemArray)
                    {
                        Console.Write("{0,-14}", data);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("===============================================");
            }

            foreach (DataRelation dataRelation in dataSet.Relations)
            {
                Console.WriteLine("\nRelations:");
                Console.WriteLine("{0}\n", dataRelation.RelationName);
            }
        }
    }
}