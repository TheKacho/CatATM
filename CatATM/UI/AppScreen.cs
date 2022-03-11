using CatATM.Domain.Entity;
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

        internal static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.AccountNumber = CatValidate.Convert<long>("account number");
            tempUserAccount.AccountPin = Convert.ToInt32(Utilities.GetSecretInfo("Please enter your account PIN."));
            return tempUserAccount;
        }

        internal static void LogProcess()
        {
            Console.WriteLine("\nThe cat is checking your account information and PIN...");
            Utilities.PrintLoadingDots();
        }
    }
}
