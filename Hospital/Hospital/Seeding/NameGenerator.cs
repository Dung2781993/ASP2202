using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Seeding
{
    public class NameGenerator
    {
        private static string[] firstNames =
        {
            "Hello1",
            "Hello2",
            "Hello3",
            "Hello4",
            "Hello5"
        };

        private static string[] lastNames =
        {
            "World1",
            "World2",
            "World3",
            "World4",
            "World5"
        };

        public static string FirstName()
        {
            return GenerateName(firstNames);
        }

        public static string LastName()
        {
            return GenerateName(lastNames);
        }

        private static string GenerateName(String [] names)
        {
            var random = new Random();

            var index = random.Next(0, names.Length);
            string name = names[index];
            return name;
        }
    }
}