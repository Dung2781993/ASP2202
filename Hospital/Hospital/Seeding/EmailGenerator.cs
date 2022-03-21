using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Seeding
{
    public class EmailGenerator
    {
        private static Random random = new Random();

        private static String[] domains =
        {
            "gmail.com",
            "outlook.com",
            "hotmail.com",
            "yahoo.com"
        };

        public static string GenerateEmail(string name)
        {
            string domain = domains[random.Next(domains.Length)];
            int number = random.Next(1, 200);

            return $"{name.ToLower()}{number}@{domain}";
        }
    }
}