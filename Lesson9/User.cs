using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class User
    {
        

        Dictionary<string, BankAccount> bankAccounts = new Dictionary<string, BankAccount>();


   

        public void Deposit(string currency, double money)
        {
            bankAccounts[currency].Deposit(money);
           
        }

        public void Withdraw(string currency, double money)
        {
            bankAccounts[currency].Withdraw(money);
        }
      
        public double GetBalance(string currency)
        {
          return bankAccounts[currency].GetBalance();
        }

        public void AddBankAccount(string currency)
        {
            BankAccount account = new BankAccount();
            bankAccounts.Add(currency, account);
        }

        public void CloseBankAccount(string currency)
        {
            bankAccounts.Remove(currency);
        }



    }
}
