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

        // TODO: Add in options after login (feed the cat, pet the cat, play with cat and log out)

        public void CatChoices()
        {
            string function = ""; // fixed the problem, but this portion does not seem to run after login, it just ends

            List<string> petCat = new List<string>();
            petCat.Add("Pet the cat");
            petCat.Add("pet cat");
            petCat.Add("pet");
            petCat.Add("Pet");

            while (true)
            {
                Console.WriteLine("How do you want to interact with the cat?");
                Console.WriteLine("Pet the cat, feed it with treats, play around with toys, or log out?");
                Console.Write("Which would you like to do?");
                
                if (petCat.Contains(function)) //function on this one does not want to work
                {
                    PetCat();
                    break;
                }
                else if(function == "Feed the Cat" || function == "feed cat")
                {
                    FeedCat();
                    break;
                }
                else if(function == "Play with Cat" || function == "play cat")
                {
                    PlayCat();
                    break;
                }
                else if(function == "Log out" || function == "log out" || function == "logout")
                {
                    Console.WriteLine("Thanks fpr using the Cat ATM.");
                    Console.WriteLine("Press enter to log out");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please type in your choice:");
                }
            }
        }



        private void FeedCat()
        {
            int feedCat;
            try
            {
                Console.Write("How much food will you feed the cat?");
                feedCat = Convert.ToInt32(Console.ReadLine());

                if (feedCat >= 10)
                {
                    Console.WriteLine("Cat Error!! Invalid food amount! Your choice must be lower than 10 ounces!");
                }
                else
                {
                    Console.WriteLine("You have fed " + feedCat + "ounces of food!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        // TODO: create full functions for the rest of the options
        private static void PetCat()
        {
            throw new NotImplementedException();
        }
        private static void PlayCat()
        {
            throw new NotImplementedException();
        }
    }
}
