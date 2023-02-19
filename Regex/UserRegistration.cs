using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Regexproblem
{
    internal class UserRegistration
    {
        public string FirstName = "^[A-Z]{1}[a-z]{2,}$";
        public string LastName = "^[A-Z]{1}[a-z]{2,}$";
        public string Email= "^[abc]+([.,-][A-Za-z0-9]+)*[@][bl]+[.][co]+([.][a-zA-Z]+)?$";
        public string MobileNumber = "^91[ ]*[6-9]{1}[0-9]{9}$";
        public string Password = "^[A-Z][a-zA-Z0-9]{7}$";
        //^[a-zA-Z0-9]+([.,-][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$
        //abc.xyz@bl.co.in abc,bl,co mandatory

        public void ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, FirstName))
            {
                Console.WriteLine("{0} is Valid " ,firstName);
            }
            else
            {
                Console.WriteLine("{0} is Invalid " ,firstName);
            }
        }
        public void ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, LastName))
            {
                Console.WriteLine("{0} is Valid ", lastName);
            }
            else
            {
                Console.WriteLine("{0} is Invalid ", lastName);
            }
        }
        public void ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, Email))
            {
                Console.WriteLine("{0} is Valid ", email);
            }
            else
            {
                Console.WriteLine("{0} is Invalid ", email);
            }
        }
        public void ValidateMobileNumber(string mobilenumber)
        {
            if (Regex.IsMatch(mobilenumber, MobileNumber))
            {
                Console.WriteLine("{0} is Valid ", mobilenumber);
            }
            else
            {
                Console.WriteLine("{0} is Invalid ", mobilenumber);
            }
        }
        public void ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, Password))
            {
                Console.WriteLine("{0} is Valid ", password);
            }
            else
            {
                Console.WriteLine("{0} is Invalid ", password);
            }
        }
    }
}
