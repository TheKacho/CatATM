using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatATM.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            Console.Clear();

            Console.Title = "Cat ATM";
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("\nHello human! First, please enter your Cat account info.\n");


            Console.WriteLine("Please enter your ID, human.");
            Console.WriteLine("Note: This cat is very picky about its numbers. \nIf you input incorrectly, it will upset the cat!\n");
            Utilities.PressEnter();
        }

        
    }
}
