using CatATM.Domain.Entity;
using CatATM.Domain.Interface;
using CatATM.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatATM
{
    public class CatATM : IUserLogin
    {
        private List<UserAccount> userAccountList;
        private UserAccount selectedAcct;

        public void CheckUserAcctNumAndPin()
        {
            bool isCorrectLog = false;

            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.AccountNumber = CatValidate.Convert<long>("account number");
            tempUserAccount.AccountPin = 
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
        
        
    }
}
