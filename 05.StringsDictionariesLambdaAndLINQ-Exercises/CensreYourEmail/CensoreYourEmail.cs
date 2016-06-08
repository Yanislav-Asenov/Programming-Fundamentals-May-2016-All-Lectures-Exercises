using System;

namespace CensreYourEmail
{
    public class CensoreYourEmail
    {
        public static void Main()
        {
            string email = Console.ReadLine();
            string inputText = Console.ReadLine();
            int indexOfDomain = email.IndexOf('@');
            string domain = email.Substring(indexOfDomain + 1);
            string username = email.Substring(0, indexOfDomain);
            string replacement = new string('*', username.Length) + "@" + domain;
            string result = inputText.Replace(email, replacement);
            Console.WriteLine(result);
        }
    }
}
