using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatATM.UI
{
    public static class Utilities
    {
        public static string GetSecretInfo(string prompt)
        {
            bool isPrompt = true;

            string asterisks = "";

            StringBuilder input = new StringBuilder();

            while (true)
            {
                if (isPrompt)
                    Console.WriteLine(prompt);
                ConsoleKeyInfo inputKey = Console.ReadKey(true);

                if (inputKey.Key == ConsoleKey.Enter)
                {
                    if(input.Length == 6)
                    {
                        break;
                    }
                    else
                    {
                        PrintMsg("\nThe cat hisses angrily! \nIt is asking for your 6 digits!", false);
                        isPrompt = true;
                        input.Clear();
                    }
                }
                if(inputKey.Key == ConsoleKey.Backspace && input.Length > 0)
                {   //anytime the user uses backspace during the password, it does remove the entry per character
                    input.Remove(input.Length - 1, 1);
                }
                else if (inputKey.Key != ConsoleKey.Backspace)
                {
                    input.Append(inputKey.KeyChar);
                    Console.Write(asterisks + "*");
                }
            }
            return input.ToString();
        }
        public static void PrintMsg(string msg, bool success = true)
        {
            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;               
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
            PressEnter();
        }


        public static string UserInput(string prompt) 
        { 
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();
        }
        public static void PressEnter()
        {
            Console.WriteLine("\nPress Enter to proceed.\n");
            Console.ReadLine();
        }
    }
}
