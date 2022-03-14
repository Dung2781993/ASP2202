using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new BikeStoresEntities();
            var products = from p in db.products select p; 
            foreach(var item in products)
            {
                Console.WriteLine("ID {0}", item.product_id);
                Console.WriteLine("Product Name {0}", item.product_name);
            }

            Console.ReadLine();
        }
    }
}
