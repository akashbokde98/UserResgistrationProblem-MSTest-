using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string Password_1Pattern = @"^[A-Za-z]{8,}$";
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problem!");
        }
        public bool CheckPassword_1(string input)
        {
            Regex rg = new Regex(Password_1Pattern);
            return rg.IsMatch(input);
        }
    }
}
