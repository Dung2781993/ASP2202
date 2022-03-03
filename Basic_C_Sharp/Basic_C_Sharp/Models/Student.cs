﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_Sharp.Models
{
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
            Name = name;
        }

        public void Study()
        {
            Console.WriteLine("Study");
        }
    }
}
