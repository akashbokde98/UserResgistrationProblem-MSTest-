using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string Password_4Pattern = @"^((?=.*\d)(?=.*\W)(?=.*[A-Z])(?=.*[a-z]).{8,})$";
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problem!");
        }
        public bool CheckPassword_4(string input)
        {
            Regex rg = new Regex(Password_4Pattern);
            return rg.IsMatch(input);
        }
    }
}
