using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class User
    {
        public string name;
        public string lastName;
        private string password;
        public BankAccount bankAccount;



        public User()
        { 
        bankAccount = new BankAccount();
        }

        public string FullName
        {
            get { return name + " " + lastName; }
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public void SetPassword(string newPassword)
        {
            password = newPassword;
        }

        public bool IsCorrectPassword(string passwordForComparation)
        {
            bool result = password == passwordForComparation;

            return result;
        }
    }
}
