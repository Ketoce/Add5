using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lang = "ru";

            switch (lang)
            {
                case "ru":
                    Console.WriteLine("Алина сломала проект!");
                    break;
                case "en":
                    Console.WriteLine("Alina broke the project!");
                    break;
                case "ua":
                    Console.WriteLine("Аліна зламала проект!");
                    break;
                case "az":
                    Console.WriteLine("Alina layihəni pozdu!");
                    break;
                case "de":
                    Console.WriteLine("Alina hat das Projekt abgebrochen!");
                    break;
                case "sw":
                    Console.WriteLine("Alina bröt projektet!");
                    break;
                case "ar":
                    Console.WriteLine("كسرت ألينا المشروع!");
                    break;
                case "tt":
                    Console.WriteLine("Алина проектны бозды!");
                    break;
                case "gr":
                    Console.WriteLine("ალინამ პროექტი დაარღვია");
                    break;





            }
        }
    }
}

