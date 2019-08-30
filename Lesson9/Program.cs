using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int count = list.Count;
            list.Add("Serg");
            list.Insert(1, "Test");
            list.Add("3");
            Console.WriteLine(list.Count);

            





            Dictionary<int, string> testCaseResults = new Dictionary<int, string>();
            testCaseResults.Add(1, "Passed");
            testCaseResults.Add(2, "Passed");
            testCaseResults.Add(2, "Failed");
            testCaseResults.Remove(2);
            testCaseResults.Add(4, "Blocked");
            if (!testCaseResults.TryGetValue( 1, "Blocked"))


            Console.WriteLine(testCaseResults.ContainsKey(1));
            Console.ReadKey();
        }
    }
}
