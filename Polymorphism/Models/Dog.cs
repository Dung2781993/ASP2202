using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Dog : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Dog Speak ......");
        }
    }
}
