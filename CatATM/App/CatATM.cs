using CatATM.Domain.Entity;
using CatATM.Domain.Interface;
using CatATM.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CatATM
{
    public class CatATM : IUserLogin
    {
        private List<UserAccount> userAccountList;
        private UserAccount selectedAcct;

        public void CheckUserAcctNumAndPin()
        {
            bool isCorrectLog = false;
            while (isCorrectLog == false)
            {
                UserAccount inputAccount = AppScreen.UserLoginForm();
                AppScreen.LogProcess();
                foreach(UserAccount account in userAccountList)
                {
                    selectedAcct = account;
                    if (inputAccount.AccountNumber.Equals(selectedAcct.AccountNumber))
                    {
                        selectedAcct.TotalLog++;

                        if (inputAccount.AccountPin.Equals(selectedAcct.AccountPin))
                        {
                            selectedAcct = account;

                            if(selectedAcct.IsLocked || selectedAcct.TotalLog > 3)
                            {
                                //Tells the user that their account is already locked or locked after 3 unsuccessful attempts
                                AppScreen.AcctLockout();
                            }
                            else //else if logged in correctly, the total log count resets to 0
                            {
                                selectedAcct.TotalLog = 0;
                                isCorrectLog = true;
                                break;
                            }
                        }
                    }
                    if (isCorrectLog == false) // tells user that it has 3 tries to log in successfully or they get locked out
                    {
                        Utilities.PrintMsg("\n The cat hisses at you!! It says invalid account number or PIN.", false);
                        selectedAcct.IsLocked = selectedAcct.TotalLog == 3;
                        if (selectedAcct.IsLocked)
                        {
                            AppScreen.AcctLockout();
                        }
                    }
                    Console.Clear();
                }
            }
            
        }

       public void WelcomeBack()
        {
            Console.WriteLine($"Welcome back, {selectedAcct.Name}. ");
        }

        public void InitializeData()
        {
            userAccountList = new List<UserAccount>
            {
                new UserAccount{Id=1, Name = "Demo Account1", AccountNumber = 123456, AccountPin = 1234, AcctBalance = 10000.00m, IsLocked = false},
                new UserAccount {Id = 2, Name = "Demo Account2", AccountNumber = 246810, AccountPin = 1357, AcctBalance = 30000.00m, IsLocked = false },
                new UserAccount {Id = 3, Name = "Demo Account3", AccountNumber = 135790, AccountPin = 2468, AcctBalance = 25000.00m, IsLocked = true }
            };
          
        }

        // TODO: Add in options after login (feed the cat, pet the cat, play with cat with some toys and log out)

        public void CatChoices()
        {

        }
    }
}
