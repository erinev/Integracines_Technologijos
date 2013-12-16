using System;
using System.Data;

namespace XmlParser
{
    public static class DataSetInfo
    {
        public static void DisplayInfo(DataSet dataSet) //metodas DataSet objekto duomenų atvaizdavimui
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