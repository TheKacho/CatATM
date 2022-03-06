using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatATM.UI
{
    public static class Utilities
    {
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
