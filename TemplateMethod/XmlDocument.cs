using System;

namespace TemplateDesignPattern
{
    public sealed class XmlDocument : Document
    {
        public override void PrintHeader()
        {
            Console.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
        }

        public override void PrintBody()
        {
            Console.WriteLine("<note><to>Tove</to></note>");
        }

        public override void PrintFooter()
        {
           Console.WriteLine("");
        }
    }
}