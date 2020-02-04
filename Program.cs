using System;
using System.Threading;
using static ExpertSystem.toolbox;

namespace ExpertSystem
{
    class Program
    {
        FactParser factParser = new FactParser();
        RuleParser ruleParser = new RuleParser();

        public Program()
        {
            ESProvider eSProvider = new ESProvider(factParser, ruleParser);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            bool loop = true;
            while (loop)
            {
                Menu();
                loop = Choose();
            }
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Raj Mahal!");
            Console.WriteLine();
            Console.WriteLine("(1) option 1");
            Console.WriteLine("(2) option 2");
            Console.WriteLine("(3) option 3");
            Console.WriteLine("(4) option 4");
            Console.WriteLine("(5) option 5");
            Console.WriteLine("(6) option 6");
            Console.WriteLine("(7) option 7");
            Console.WriteLine("(8) option 8");
            Console.WriteLine("(9) option 9");
            Console.WriteLine("(0) Exit Program");
            Console.WriteLine();
        }
        static bool Choose()
        {
            string choice = AnyInput("Choose an option...: ");
            switch (choice)
            {
                case "1":
                    //ide hogy mit csinal
                    return true;
                case "2":
                    //ide hogy mit csinal
                    return true;
                case "3":
                    //ide hogy mit csinal
                    return true;
                case "4":
                    //ide hogy mit csinal
                    return true;
                case "5":
                    //ide hogy mit csinal
                    return true;
                case "6":
                    //ide hogy mit csinal
                    return true;
                case "7":
                    //ide hogy mit csinal
                    return true;
                case "8":
                    //ide hogy mit csinal
                    return true;
                case "9":
                    //ide hogy mit csinal
                    return true;
                case "0":
                    Console.WriteLine("Bye, bye...");
                    return false;
                default:
                    Console.WriteLine("Wrong option...");
                    Thread.Sleep(500);
                    return true;
            }
        }
    }
}
