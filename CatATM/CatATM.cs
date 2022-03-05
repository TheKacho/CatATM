using System;
using System.Text;

namespace CatATM
{
    internal class CatATM
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Cat ATM";
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("\nHello human! First, please enter your Cat account info.\n");
            Console.WriteLine("\nPress Enter to proceed...\n");

            Console.WriteLine("Please enter your ID, human.");
            Console.WriteLine("Note: This cat will only read ID numbers up to 9 digits. \nAnything over that will upset the cat!\n");
            string pin = RequestPIN();
            

            Console.ReadKey();
        }

        private static string RequestPIN() // when the user enters in the number, it should appear with **** rather than
                                           // displaying the full numbers
        {
            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);

                if (!char.IsControl(keyInfo.KeyChar))
                {
                    sb.Append(keyInfo.KeyChar);
                    Console.Write("*");
                }
            } while (keyInfo.Key != ConsoleKey.Enter);
            {
                return sb.ToString();
            }
        }
    }
}
