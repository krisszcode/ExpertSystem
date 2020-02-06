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
            Console.WriteLine("Welcome to the Raj Mahal!");
            Console.WriteLine();
            Console.WriteLine("(1) Run Krisz");
            Console.WriteLine("(2) Run Viktor");
            Console.WriteLine("(3) Run Zoli");
            Console.WriteLine("(0) Exit Program");
            Console.WriteLine();
        }
        static bool Choose()
        {
            string choice = AnyInput("Choose an option...: ");
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    eSProvider.collectAnswers();
                    Console.WriteLine(eSProvider.evaluate());
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadKey();
                    return true;
                case "2":
                    Console.Clear();
                    eSProvider.collectAnswers();
                    eSProvider.evaluate2();
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadKey();
                    //ide hogy mit csinal
                    return true;
                case "3":
                    Console.Clear();
                    eSProvider.collectAnswers();
                    Console.WriteLine(eSProvider.evaluate1());
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadKey();
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
