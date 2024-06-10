using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_PrototypePattern.Interfaces;

namespace HW_PrototypePattern.Classes
{
    public class Person: IMyCloneable<Person>, ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person MyClone()
        {
            return new Person { Name = this.Name, Age = this.Age };
        }
        public object Clone()
        {
            return this.MyClone();
        }
        public override string ToString()
        {
            return "Person";
        }
    }
}
