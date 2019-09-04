using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class MathHelper
    {
        public static double sum;
        public static double FindMinValue(double[] input)
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

        public static double FindMaxValue(double[] input)
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

        public static void PrintPossibleWin(double[] input)
        {
            Console.WriteLine("Here the list of your possible win:");
            foreach (var t in input)
            {
                if (t != 0)
                    Console.WriteLine(t);
            }
        }


        public static double FindWinBet(double[] input)
        {
            double winBet;


            do
            {
                Random rand = new Random();
                var index = rand.Next(input.Length);
                winBet = input[index];
            } while (winBet == 0);

            return winBet;
        }

        public static double FindSumOfBets(double[] input)
        {
            foreach (var i in input)
                sum += i;

            return sum;
        }
    }
}
