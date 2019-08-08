using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
           
            Console.WriteLine("What is your gender? (M/F)");
            string gender = Console.ReadLine();
            gender.ToLower();


            Console.WriteLine("Are you married? (Y/N)");
            string marriageStatus = Console.ReadLine();
            marriageStatus.ToLower();



            if (gender == "f" && marriageStatus == "y")
            {
                Console.WriteLine($"Nice to meet you Mrs {name}");
            }
            else if (gender == "f" && marriageStatus == "n")
            {
                Console.WriteLine($"Nice to meet you Ms {name}");
            }
            else
            {
                Console.WriteLine($"Nice to meet you Mr {name}");
            }

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            switch (age)
            {
                case int userAge when userAge < 0:
                   Console.WriteLine("Age cannot be a negative value");
                   break;

                case int userAge when userAge < 18:
                    Console.WriteLine($"Bad. {age} is not allowed on this site!");
                    break;

                case int userAge when userAge >= 18:
                    Console.WriteLine($"Ok. {age} is allowed on this site!");
                    break;

            }
            Console.ReadKey();
        }
    }
}
