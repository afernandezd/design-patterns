using System;

namespace TemplateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Document htmlDocument = new HtmlDocument();
            htmlDocument.Print();

            Console.WriteLine();

            Document xmlDocument = new XmlDocument();
            xmlDocument.Print();

            Console.Read();
        }
    }
}
