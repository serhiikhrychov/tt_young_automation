using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {

      static double sum = 0;
      static double[] odds = new double[30];
      static double[] bets = new double[30];

        static void Main(string[] args)
        {
        
            Random rand = new Random();

            for (int i = 0; i <= 29; i++)
            {
                double odd = 1.1 + rand.NextDouble() * (10.1 - 1.1);
                odds[i] = Math.Round(odd, 2);

            }

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

            var max = FindMaxValue(bets);
            var min = FindMinValue(bets);
            sum = FindSumOfBets(bets);
            PrintPossibleWin(bets);

            
           Console.WriteLine($"Your bets sum is {sum} your minWin is {min} your maxWin is {max}");
            Console.ReadKey();
        }

        static double FindMinValue(double[] input)
        {
            double minValue = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == 0)
                    break;
                if (input[i] < minValue)
                    minValue = input[i];
            }

            return minValue;
        }

        static double FindMaxValue(double[] input)
        {
            double maxValue = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > maxValue)
                    maxValue = input[i];
                if (input[i] == 0)
                    break;
            }
            return maxValue;
        }

        static void PrintPossibleWin(double[] input)
        {
            Console.WriteLine("Here the list of your possible win:");
            foreach (var t in input)
            {
                if (t != 0)
                    Console.WriteLine(t);
            }
        }

        static double FindSumOfBets(double[] input)
        {
            foreach (var i in input)
                sum += i;

            return sum;
        }
    }
}
