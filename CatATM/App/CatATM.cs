using CatATM.UI;
using System;
using System.Text;

namespace CatATM
{
    internal class CatATM
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();

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
