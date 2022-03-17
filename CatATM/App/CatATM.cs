using CatATM.Domain.Entity;
using CatATM.Domain.Interface;
using CatATM.UI;
using System;
using System.Collections.Generic;
using System.IO;
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

        

        public void CatChoices()
        {
            string function = "";

            List<string> petCat = new List<string>();
            petCat.Add("Pet the cat");
            petCat.Add("pet cat");
            petCat.Add("pet");
            petCat.Add("Pet");

            while (true)
            {
                Console.WriteLine("\nHow do you want to interact with the cat?\n");
                Console.WriteLine("\nPet the cat, feed it with treats, play around with toys, learn about the program, or log out?\n");
                Console.Write("\n\nWhich would you like to do?\n\n");
                function = Console.ReadLine(); // this requires the user to type in the key words in order to get to the option

                if (petCat.Contains(function)) 
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
                else if(function == "About")
                {
                    AboutCat();
                    break;
                }
                else if(function == "Log out" || function == "log out" || function == "logout")
                {
                    Console.WriteLine("Thanks for using the Cat ATM.");
                    Console.WriteLine("Press enter to log out and exit the program.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\nPlease type in your choice:\n");
                }
            }
        }

        private void AboutCat()
        {
            try
            {                
                using (StreamReader sr = new StreamReader("AboutCat.txt"))
                {
                    string line;
                    // Reads the line from the text file
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        CatChoices();
                    }
                }
            }
            catch (Exception e)
            {
                // Informs the user about what the error is
                Console.WriteLine("\n Cat Error! The file could not be read!");
                Console.WriteLine(e.Message);
                CatChoices();
            }
        }

        private void PetCat()
        {
            int petCat;
            try
            {
                Console.Write("\nHow many pets will you pet the cat?\n");
                petCat = Convert.ToInt32(Console.ReadLine());

                if (petCat <= 5)
                {
                    Console.WriteLine("\nError! You are not petting the cat enough! Please have more than 5 pets!");
                    PetCat();
                }
                else
                {
                    Console.WriteLine("You've petted the cat " + petCat + " times!");
                }
            }
            finally
            {
                Console.WriteLine("\nPress enter to return back to the main menu...\n");
                Utilities.PressEnter();
                CatChoices(); // awaits the user to press enter to return to main menu
            }
        }

        private void FeedCat()
        {
            int feedCat;
            try
            {
                Console.Write("\nHow much food will you feed the cat?\n");
                feedCat = Convert.ToInt32(Console.ReadLine());

                if (feedCat >= 10)
                {
                    Console.WriteLine("\nCat Error!! Too much food!\n \nYour choice must be lower than 10 ounces!\n");
                    FeedCat();
                }
                else
                {
                    Console.WriteLine("You have fed the cat " + feedCat + " ounces of food!");
                    Console.WriteLine("\nThe cat is now fed!\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        private void PlayCat()
        {
            int playCat;
            try
            {
                Console.Write("\nHow many toys will you play with the cat?\n");
                playCat = Convert.ToInt32(Console.ReadLine());

                if (playCat <= 5)
                {
                    Console.WriteLine("\nError! You did not add enough toys to satisfy the cat!");
                    PlayCat();
                }
                else
                {
                    Console.WriteLine("You have gave the cat " + playCat + " toys to play around with!");
                    Console.WriteLine("\nThe cat is now satisfied!\n");
                }
            }
            finally
            {
                Console.WriteLine("\nPress enter to return back to the main menu...\n");
                Utilities.PressEnter();
                CatChoices(); // awaits the user to press enter to return to main menu
            }
        }
    }
}
