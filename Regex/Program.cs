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
            Console.WriteLine("Enter the option below:");
            Console.WriteLine("1:validate first name\n2:validate last name\n3:validate email\n4:validate mobile number");
            int option = Convert.ToInt32(Console.ReadLine());
            UserRegistration userRegistration = new UserRegistration();
            switch (option) {
                case 1:
                    Console.Write("Enter the first name :");
                    string firstname = Console.ReadLine();
                    userRegistration.ValidateFirstName(firstname);
                    break;
                case 2:
                    Console.Write("Enter the last name :");
                    string lastname = Console.ReadLine();
                    userRegistration.ValidateLastName(lastname);
                    break;
                case 3:
                    Console.Write("Enter the email :");
                    string email = Console.ReadLine();
                    userRegistration.ValidateEmail(email);
                    break;
                case 4:
                    Console.Write("Enter the mobile number :");
                    string mobilenumber = Console.ReadLine();
                    userRegistration.ValidateMobileNumber(mobilenumber);
                    break;

            }
            Console.ReadLine();
        }
    }
}
