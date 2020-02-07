using System;
using System.Threading;
using static ExpertSystem.toolbox;
using System.Collections.Generic;

namespace ExpertSystem
{
    class Program
    {
        FactParser factParser = new FactParser();
        RuleParser ruleParser = new RuleParser();
        static ESProvider eSProvider;

        public Program()
        {
            eSProvider = new ESProvider(factParser, ruleParser);
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
            Console.WriteLine("                Welcome to the Raj Mahal! ");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("           'Experts of the year' awarded service");
            Console.WriteLine();
            Console.WriteLine("           Choose one of the available expert...");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("         Status                 Experts");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("(1) -   Available   - Anand Lal Krisz from Mumbai");
            Console.WriteLine("(2) -   Available   - Mukherjee Bawa Viktor from Raipur");
            Console.WriteLine("(3) -   Available   - Gupta Kumar Zoltan from Bangalore");
            Console.WriteLine("(4) -   Available   - Kapoor Singh Erik from Rajasthan");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("(5) - Not Available - Rajesh Ramayan Koothrappali from New Delhi");
            Console.WriteLine("(6) - Not Available - Byomkesh Bakshi from Mangalore");
            Console.WriteLine("(7) - Not Available - Apu Nahasapeemapetilon from Jabalpur");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("(0) Exit (in that case you just wanted to Google 'Raj Mahal')");
            Console.WriteLine();
        }
        static bool Choose()
        {
            string choice = AnyInput("Choose an option...: ");
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Please answer 'yes' or 'no'.");
                    eSProvider.collectAnswers();
                    Console.WriteLine();
                    Console.WriteLine(eSProvider.evaluate());
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadKey();
                    return true;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Please answer 'yes' or 'no'.");
                    eSProvider.collectAnswers();
                    Console.WriteLine();
                    eSProvider.evaluate2();
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Please answer 'yes' or 'no'.");
                    eSProvider.collectAnswers();
                    Console.WriteLine();
                    Console.WriteLine(eSProvider.evaluate1());
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Please answer 'yes' or 'no'.");                   
                    eSProvider.collectAnswers();
                    Console.WriteLine();
                    Console.WriteLine(eSProvider.evaluate1());
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadKey();
                    return true;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Currently sitting in the jacuzzi of Howard Wolowitz with Stuart.");
                    Console.ReadKey();
                    return true;
                case "6":
                    Console.Clear();
                    Console.WriteLine("Ask Sherlock Holmes. Maybe he has a clue.");
                    Console.ReadKey();
                    return true;
                case "7":
                    Console.Clear();
                    Console.WriteLine("Drinking with Homer.");
                    Console.ReadKey();
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
        public static void TestXml()
        {
            List<Fact> myfacts = eSProvider.factRepo.addide();
            foreach (Fact fact in myfacts)
            {
                Console.WriteLine(fact.ToString());
            }


        }
        public static void TestXmlrule()
        {
            List<Question> myQue = eSProvider.ruleRepo.addide();
            foreach (Question que in myQue)
            {
                //Console.WriteLine(que.GetID());
                Console.WriteLine(que.GetQuestion());
                Console.WriteLine(que.GetAnswer().ToString());
                Console.WriteLine();

            }


        }
    }
}