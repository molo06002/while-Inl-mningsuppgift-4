// See https://aka.ms/new-console-template for more information
using System;
namespace while_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Subtraktion");
            Console.WriteLine("2. Division");
            Console.WriteLine("3. Avsluta programmet");
            Console.WriteLine("Välj en kalkulation: ");
            string svar = Console.ReadLine();
            switch (svar)
            {
                case "1":
                    Console.WriteLine("Skriv in ett tal: ");
                    string tal1 = Console.ReadLine();
                    int talint = Convert.ToInt32(tal1);
                    Console.WriteLine("Skriv in ett annat tal: ");
                    string tal2 = Console.ReadLine();
                    int talint2 = Convert.ToInt32(tal2);
                    Console.Clear();
                    Console.WriteLine("Svar: ");
                    Console.WriteLine(talint - talint2);
                    break;
                case "2":
                    Console.WriteLine("skriv in ett tal: ");
                    string division = Console.ReadLine();
                    int divisionint = Convert.ToInt32(division);
                    Console.WriteLine("Skriv in ett annat tal: ");
                    string division2 = Console.ReadLine();
                    int divisionint2 = Convert.ToInt32(division2);
                    Console.WriteLine("Svar: ");
                    Console.WriteLine(divisionint / divisionint2);
                    break;
                case "3":
                    Console.WriteLine("Programmet avslutat");
                    break;
            }
        }
    }
}