using System;

namespace StertaStos
{
    //Klasa przechowuje referencje na stosie
    //zmienić class na struct by zobaczyć co się stanie
    public struct Report
    {
        public string Nazwa { get; set; }
        public int LiczbaStron { get; set; }

        public override string ToString()
        {
            return string.Format($"\"{Nazwa}\" ma stron {LiczbaStron}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = x;

            y = 20;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {x}");

            Report report = new Report();
            report.Nazwa = "Raport dnia";
            report.LiczbaStron = 10;
       
            Report report2 = report;
            report2.LiczbaStron = 12;

            Process(y, report2);

            Console.WriteLine($"y = {y}");
            Console.WriteLine(report.ToString());
            Console.WriteLine(report2.ToString());

            Console.ReadKey();
        }

        static void Process(int s, Report report)
        {
            s = 30;
            report.LiczbaStron = 101;
        }
    }
}
