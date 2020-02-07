using System;

namespace ExpertSystem
{
    public static class toolbox
    {
        public static int JustNumber(string inputMessage)
        {
            int number;
            string input;
            while (true)
            {
                Console.Write(inputMessage);
                input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    return int.Parse(input);
                }
                else
                {
                    Console.WriteLine("It is not a number!");
                }
            }
        }
        public static float JustFloat(string inputMessage)
        {
            float number;
            string input;
            while (true)
            {
                Console.Write(inputMessage);
                input = Console.ReadLine();
                if (float.TryParse(input, out number))
                {
                    return float.Parse(input);
                }
                else
                {
                    Console.WriteLine("It is not a number!");
                }
            }
        }
        public static string AnyInput(string inputMessage)
        {
            Console.Write(inputMessage);
            return Console.ReadLine();
        }
        public static bool BoolInput(string inputMessage)
        {
            while (true)
            {
                Console.Write(inputMessage);
                string input = Console.ReadLine().ToLower();
                if (input == "y" || input == "yes")
                {
                    return true;
                }
                else if (input == "n" || input == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Wrong answer!");
                }
            }
        }
        public static bool BoolTrans(string text)
        {
            if (text == "true") { return true; }
            else { return false; }
        }
        public static string JustYesNo(string inputMessage)
        {
            while (true)
            {
                Console.Write(inputMessage);
                string input = Console.ReadLine().ToLower();
                if (input == "yes" || input == "no")
                {
                    return input;
                }
            }
        }
    }
}
