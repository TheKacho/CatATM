using CatATM.Domain.Entity;
using CatATM.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatATM
{
    internal class CatATM
    {
        private List<UserAccount> userAccountList;
        private UserAccount selectedAcct;

        public void InitializeData()
        {
            userAccountList = new List<UserAccount>
            {
                new UserAccount{}
            }
        }
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            long accountNumber = CatValidate.Convert<long>("account number");
            Console.WriteLine($"Your account number is {accountNumber}");
            
            
            Utilities.PressEnter();


            
        }
    }
}
