using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CatATM.UI
{
    public static class Utilities
    {
        public static string GetSecretInfo(string prompt)
        {   //this prompts the user to enter their pin number, displaying in asterisks rather than numbers for security purposes
            bool isPrompt = true;

            string asterisks = "";

            StringBuilder input = new StringBuilder();

            while (true)
            {
                if (isPrompt)
                    Console.WriteLine(prompt);
                isPrompt = false;

                ConsoleKeyInfo inputKey = Console.ReadKey(true);

                if (inputKey.Key == ConsoleKey.Enter)
                {
                    if(input.Length == 4)
                    {
                        break;
                    }
                    else
                    {
                        PrintMsg("\nThe cat hisses angrily! \nPlease enter in your correct PIN.", false);
                        isPrompt = true;
                        input.Clear();
                        continue;
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

        public static void PrintLoadingDots(int timer = 10)
        {
            
            for (int i = 0; i < timer; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Console.Clear();
        }
        public static void PressEnter()
        {
            Console.WriteLine("\nPress Enter to proceed.\n");
            Console.ReadLine();
        }
    }
}
