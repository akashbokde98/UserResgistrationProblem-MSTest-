using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string FirstNamePattern = @"^[A-Z][a-z]{3,}$";
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problem!");
        }
        public bool CheckFirstName(string input)
        {
            Regex rg = new Regex(FirstNamePattern);
            return rg.IsMatch(input);
        }
    }
}
