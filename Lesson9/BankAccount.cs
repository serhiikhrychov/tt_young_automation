using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class BankAccount
    {
        private double _balance;

  
        public double GetBalance()
        {
            return _balance;
        }

        public void Deposit(double money)
        {
            if (money <= 0)
            {
                Console.WriteLine("Sorry money amount should be > 0");
            }
            else
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
