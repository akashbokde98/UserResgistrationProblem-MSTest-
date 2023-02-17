using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string Password_3Pattern = @"^((?=.*\d)(?=.*[A-Z])(?=.*[a-z]).{8,})$";
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problem!");
        }
        public bool CheckPassword_3(string input)
        {
            Regex rg = new Regex(Password_3Pattern);
            return rg.IsMatch(input);
        }
    }
}
