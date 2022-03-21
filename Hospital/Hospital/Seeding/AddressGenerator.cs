using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Seeding
{
    public class AddressGenerator
    {
        private static Random rnd = new Random();

        private static string[] townNames =
        {
            "Test1",
            "Test2 ",
            "Test3"
        };
        //private static string[] townNames = File.ReadAllLines("<INSERT DIR HERE>");
        private static string[] streetNames =
        {
            "Stree1",
            "Stree2",
            "Stree3"
        };
        //private static string[] streetNames = File.ReadAllLines("<INSERT DIR HERE>");

        internal static string NewAddress()
        {
            string townName = townNames[rnd.Next(townNames.Length)];
            string streetName = streetNames[rnd.Next(streetNames.Length)];
            int number = rnd.Next(1, 100);

            return $"{townName}, {streetName} {number}";
        }
    }
}