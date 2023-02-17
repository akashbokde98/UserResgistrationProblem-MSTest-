using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string PhoneNumberPattern = @"^91[ ][0-9]+$";
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problem!");
        }
        public bool CheckPhoneNumber(string input)
        {
            Regex rg = new Regex(PhoneNumberPattern);
            return rg.IsMatch(input);
        }
    }
}
