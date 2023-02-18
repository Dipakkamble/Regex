using Regexproblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistration userRegistration=new UserRegistration();
            Console.Write("Enter the first name :");
            string firstname=Console.ReadLine();
            userRegistration.ValidateFirstName(firstname);
            Console.ReadLine();
           
        }
    }
}
