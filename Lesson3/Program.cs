using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] odds = new double[30];
            double[] bets = new double[30];
            double sum = 0;
            
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
                sum += bets[i];
                
               if (userBet == 0)
                {
                    break;
                }

            }
            
            double max = bets[0];
            double min = bets[0];

            for (int a = 1; a < bets.Length; a++)
            {
                if (bets[a] > max)
                    max = bets[a];
                if (bets[a] == 0)
                    break;
            }

           
            for (int a = 1; a < bets.Length; a++)
            {
                if (bets[a] == 0)
                    break;
                if (bets[a] < min)
                    min = bets[a];
            }

            Console.WriteLine($"Your bets sum is {sum} your minWin is {min} your maxWin is {max}");
            Console.ReadKey();
        }
    }
}
