using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string Password_2Pattern = @"^((?=.*)(?=.*[A-Z])(?=.*).{8,})$";
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problem!");
        }
        public bool CheckPassword_2(string input)
        {
            Regex rg = new Regex(Password_2Pattern);
            return rg.IsMatch(input);
        }
    }
}
