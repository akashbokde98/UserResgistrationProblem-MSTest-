using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string EmailAddressSamples = @"^[a-z]{3,}[.]?[-+]*[0-9]*[@]{1,1}[a-z0-9]{1,5}[.]{1,1}[a-z]{3,3}[,]?[.]?[a-z]*$";
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problem!");
        }
        public bool CheckEmailSamples(string input)
        {
            Regex rg = new Regex(EmailAddressSamples);
            return rg.IsMatch(input);
        }
    }
}
