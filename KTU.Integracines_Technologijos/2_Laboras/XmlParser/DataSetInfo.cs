using System;
using System.Data;

namespace XmlParser
{
    public static class DataSetInfo
    {
        public static void DisplayInfo(DataSet ds) //metodas DataSet objekto duomenų atvaizdavimui
        {
            foreach (DataTable dt in ds.Tables)
            {
                Console.WriteLine("\n===============================================");
                Console.WriteLine("Table = " + dt.TableName + "\n");
                foreach (DataColumn dc in dt.Columns)
                {
                    Console.Write("{0,-14}", dc.ColumnName);
                }
                Console.WriteLine("\n-----------------------------------------------");

                foreach (DataRow dr in dt.Rows)
                {
                    foreach (object data in dr.ItemArray)
                    {
                        Console.Write("{0,-14}", data);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("===============================================");
            }

            foreach (DataRelation dr in ds.Relations)
            {
                Console.WriteLine("\n\nRelations:");
                Console.WriteLine(dr.RelationName + "\n\n");
            }
        }
    }
}