using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models
{
    public class Cow : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Cow Sound ");
        }
    }
}
