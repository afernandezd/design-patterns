namespace TemplateDesignPattern
{
    public abstract class Document
    {
        public void Print()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        public abstract void PrintHeader();
        public abstract void PrintBody();
        public abstract void PrintFooter();
    }
}