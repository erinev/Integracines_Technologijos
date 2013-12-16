using System;
using XmlParser.Parser;

namespace XmlParser
{
    internal static class Program
    {
        private static void Main()
        {
            var xmlTextReaderParser = new Parser1();
            var xmlDocumentParser = new Parser2();
            var xmlDataSetParser = new Parser3();

            xmlTextReaderParser.ReadXmlUsingXmlTextReader();
            xmlDocumentParser.ParseXmlUsingXmlDocument();
            xmlDataSetParser.ParseXmlUsingDataSet();

            Console.ReadLine();
        }
    }
}