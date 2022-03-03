using Abstraction.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models
{
    class Motor : IMotor
    {
        public void Delete()
        {
            Console.WriteLine("Delete");
        }

        public void Display()
        {
            Console.WriteLine("Display Motor");
        }

        public void Insert()
        {
            Console.WriteLine("Insert Motor");
        }
    }
}
