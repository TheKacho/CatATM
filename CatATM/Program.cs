using System;

namespace CatATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cat ATM";

            Console.WriteLine("Hello human! First, please enter your 4 digit Cat PIN.");
            
            

            Console.ReadKey();
        }

        private static string RequestPIN()
        {
            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);

                if (!char.IsControl(keyInfo.KeyChar)
                {
                    sb.Append(keyInfo.KeyChar);
                    Console.Write("*")
                }
            } while (true);
        }
    }
}
