using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static double sumOfBets;
        static double[] odds = new double[30];
        static double[] bets = new double[30];
        static string bankAccount;
        static double moneyForBankAccount;
        static double userWinBet;

        static void Main(string[] args)
        {

            Random rand = new Random();

            for (int i = 0; i <= 29; i++)
            {
                double odd = 1.1 + rand.NextDouble() * (10.1 - 1.1);
                odds[i] = Math.Round(odd, 2);

            }


            Console.WriteLine(
                $"Before you make your bet please create your BankAccount. Select currency of your bank account UAH/EUR/USD");
            bankAccount = Console.ReadLine();
            Console.WriteLine($"Add some money to your bank account");
            moneyForBankAccount = double.Parse(Console.ReadLine());
            User newUser = new User();
            newUser.AddBankAccount(bankAccount);
            newUser.Deposit(bankAccount, moneyForBankAccount);
            Console.WriteLine($"Your balance is {newUser.GetBalance(bankAccount)}");

            link:

            for (int i = 0; i < bets.Length; i++)
            {

                Console.WriteLine($"Make your bet for game {i + 1} with odd {odds[i]}");
                int userBet = int.Parse(Console.ReadLine());
                bets[i] = userBet * odds[i];

                if (userBet == 0)
                {
                    break;
                }

            }

            var max = MathHelper.FindMaxValue(bets);
            var min = MathHelper.FindMinValue(bets);
            sumOfBets = MathHelper.FindSumOfBets(bets);
            MathHelper.PrintPossibleWin(bets);
            userWinBet = MathHelper.FindWinBet(bets);


            Console.WriteLine($"Your bets sum is {sumOfBets} your minWin is {min} your maxWin is {max}");
            Console.WriteLine($"Your winBet is {userWinBet}");

            newUser.Deposit(bankAccount, userWinBet);
            Console.WriteLine($"Your balance is {newUser.GetBalance(bankAccount)}");

            Console.WriteLine("Do you want to withdraw your win from your account (y/n)");
            string withdrawOrNot = Console.ReadLine();

            if (withdrawOrNot == "y")
            {
                Console.WriteLine("Please set amount which you want to withdraw");
                int amountOfWithdraw = int.Parse(Console.ReadLine());
                newUser.Withdraw(bankAccount, amountOfWithdraw);
                Console.WriteLine($"Your balance is {newUser.GetBalance(bankAccount)}");

            }
            else
            {
                Console.WriteLine("Let's play more");
                goto link;
            }

            Console.ReadKey();
        }
    }
}
