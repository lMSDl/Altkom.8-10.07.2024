namespace Altkom._8_10._07._2024.SOLID.I
{
    internal interface IExcelFormatter
    {
        void ToExcel();
    }
    internal interface IPdfFormatter
    { 
        void ToPdf();
    }

    class Report : IExcelFormatter, IPdfFormatter
    {
        public void ToExcel()
        {
            Console.WriteLine("Excel generated");
        }

        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }

    class Poem : IPdfFormatter
    {
        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }

    /*internal interface IFormatter
    {
        void ToExcel();
        void ToPdf();
    }
    
    class Report : IFormatter
    {
        public void ToExcel()
        {
            Console.WriteLine("Excel generated");
        }

        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }

    class Poem : IFormatter
    {
        public void ToExcel()
        {
            throw new NotSupportedException();
        }

        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }*/
}
