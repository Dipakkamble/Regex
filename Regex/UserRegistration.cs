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
        public string FirstName = ("^[A-Z]{1}[a-z]{2,}$");
        public string LastName = ("^[A-Z]{1}[a-z]{2,}$");
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
    }
}
