using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_PrototypePattern.Interfaces;

namespace HW_PrototypePattern.Classes
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return "Person";
        }
    }
}
