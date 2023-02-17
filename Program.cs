using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string LastNamePattern = @"^[A-Z][a-z]{3,}$";
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problem!");
        }
        public bool CheckLastName(string input)
        {
            Regex rg = new Regex(LastNamePattern);
            return rg.IsMatch(input);
        }
    }
}
