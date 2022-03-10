using CatATM.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatATM.App
{
    public class Entry
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            long accountNumber = CatValidate.Convert<long>("account number");
            Console.WriteLine($"Your account number is {accountNumber}");


            Utilities.PressEnter();



        }
    }
}
