using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string EmailAddressPattern = @"^[a-z{3,}]+[@+-.0-9a-z{3,}]+$";
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problem!");
        }
        public bool CheckEmailAddress(string input)
        {
            Regex rg = new Regex(EmailAddressPattern);
            return rg.IsMatch(input);
        }
    }
}
