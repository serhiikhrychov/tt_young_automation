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
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            numbers[0] = 0;
            numbers[1] = 1;
            numbers[2] = 2;
            numbers[3] = 3;
            numbers[4] = 4;

            int[] numbers2 = new int[5];

            numbers[0] = 0;
            numbers[1] = 1;
            numbers[2] = 2;
            numbers[3] = 3;
            numbers[4] = 4;


            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }

            int max2 = numbers2[0];
            for (int i = 1; i < numbers2.Length; i++)
            {
                if (numbers2[i] > max)
                    max = numbers2[i];
            }
           

        }

        static int Max(int[] input)
        {
            int max = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > max)
                    max = input[i];
            }
            return max;
        }
    }
}
