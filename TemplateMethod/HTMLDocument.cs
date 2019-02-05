using System;

namespace TemplateDesignPattern
{
    public class HtmlDocument : Document
    {
        public override void PrintHeader()
        {
            Console.WriteLine("<head><title>Title of the document</title></head>");
        }

        public override void PrintBody()
        {
            Console.WriteLine("<body>The content of the document...</body>");
        }

        public override void PrintFooter()
        {
            Console.WriteLine("<footer>The footer of the document</footer>");
        }
    }
}