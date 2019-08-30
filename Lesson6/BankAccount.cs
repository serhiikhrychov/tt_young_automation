using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class BankAccount
    {
        private double _balance;

        //public BankAccount(double balance)
        //{
        //    _balance = balance;
        //}

        public double GetBalance()
        {
            return _balance;
        }

        public void Deposit(double money)
        {
            if (money != 0)
            {
                _balance += money;
            }
        }

        public void Withdraw(double money)
        {
            if (money < _balance)
                _balance -= money;
            else
            {
                Console.WriteLine("Your balance can't be < 0");
            }

        }
    }
}
