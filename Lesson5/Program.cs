using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace Lesson5
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        /*User ukrainian = new User();
    //        ukrainian.name = "Serhii";
    //        ukrainian.lastName = "Test";
    //        ukrainian.age = 18;

    //        User american = new User();
    //        american.name = "John";
    //        american.lastName = "TestAmer";
    //        american.age = 7;
    //        american.SetPassword("yourNewPass");

    //        Console.WriteLine(ukrainian.name + " " + ukrainian.lastName + " " + ukrainian.age);
    //        Console.WriteLine(american.name + " " + american.lastName + " " + american.age);

    //        american.lastName = "Pupkin";

    //        Console.WriteLine(american.name + " " + american.lastName + " " + american.age);*/
    //        User user = new User();
    //        User user2 = new User("Petya");
    //        //user.name = "AAA";
    //        user.lastName = "BBB";
    //        Console.WriteLine(user.FullName);
    //        Console.WriteLine(user2.FullName);
    //        Console.ReadLine();
    //    }
    //}


    class Program
    {

        static double sum = 0;
        static double[] odds = new double[30];
        static double[] bets = new double[30];
       

        static void Main(string[] args)
        {

            Console.WriteLine("You need to create new User. Please fill your userName");
            string userName = Console.ReadLine();
            User newUser = new User(userName);
            Console.WriteLine("Please enter your gender");
            newUser.gender = Console.ReadLine();
            Console.WriteLine("Please add your age");
            newUser.age = int.Parse(Console.ReadLine());
            link:
            Console.WriteLine("Please add your password");
            newUser.SetPassword(Console.ReadLine());
            Console.WriteLine("Please confirm your new password");

            if (newUser.IsCorrectPassword(Console.ReadLine()) != true)
            {
                Console.WriteLine("Your password has not been confirmed");
                goto link;
            }
            else
            {
                Console.WriteLine("Your password has been confirmed");
            }

            
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


    class User
    {
        public string name;
        public string gender;
        private string password { get; set; }
        public int age;
    
      

        public User(string newName)
        {
            name = newName;
        }
     
        public void SetPassword(string newPassword)
        {
            password = newPassword;
        }

        public bool IsCorrectPassword(string passwordForComparation)
        {
             bool CheckPass = password == passwordForComparation;

              return CheckPass;

        }
    }
}
