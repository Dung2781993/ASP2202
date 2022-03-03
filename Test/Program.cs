using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var result = new List<int>();
            //int input = 6;
            //for(var i = 0; i < input; i++)
            //{
            //    result.Add(getFibonaci(i));
            //}
            //Console.WriteLine(result);

            var arr = new int[] { 1, 1, 2, 3, 4};
            var result = checkDuplicated(arr);



            Console.WriteLine();
        }

        public static int getFibonaci(int n)
        {
            if (n == 0) return 0; //it will return the first number of the series
            if (n == 1) return 1; // it will return the second number of the series
            return getFibonaci(n - 1) + getFibonaci(n - 2);
        }

        public static bool checkDuplicated(int [] arr)
        {
            var hashTable = new Hashtable();

            foreach(var item in arr)
            {
                if (hashTable.ContainsKey(item))
                {
                    return true;
                } else
                {
                    hashTable.Add(item, 1);
                }
            }

            return false;
        }
    }
}
