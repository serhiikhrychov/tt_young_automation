using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();
            User user5 = new User();
            User user6 = new User();
            user1.Name = "Name1";
            user2.Name = "Name2";
            user3.Name = "Name3";
            user4.Name = "Name4";
            user5.Name = "Name5";
            user6.Name = "Name6";
            user1.LastName = "SomeLastName";
            user3.LastName = "SomeLastName";

            List<User> users = new List<User>();
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);
            users.Add(user6);

            //foreach (var user in users)
            //{
            //    if (user.LastName != "SomeLastName")
            //        user.LastName = "TT";
            //}

            //users.Where(user => user.LastName == null)
        }

        public static List<User> GetListUsersWithoutLastName(List<User> givenList)
        {
            List<User> result = new List<User>();
            result = givenList.Where(givenUser => givenUser.LastName == null).ToList();

           bool IsPresentOne = givenList.Any(givenUser => givenUser.LastName == null);

           bool IsPresentAll = givenList.All(givenUser => givenUser.LastName == null);
           bool IsPresentWithname = givenList.Where(givenUser => givenUser.LastName == null).Any(y => y.Name == "User1");

           User IsPresentFirst = givenList.First(givenUser => givenUser.LastName == null); // - не найдет - будет эксепшен 
           User isPresentFirstOrDefault = givenList.FirstOrDefault(givenUser => givenUser.LastName == null); // - не найдет - даст ему дефолтное значение и не будет эксепшен 

            return result;
        }
    }

    public class User
    {
        public string Name;
        public string LastName;
    }
}
