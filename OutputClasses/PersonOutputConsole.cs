using HW_PrototypePattern.Classes;
using HW_PrototypePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_PrototypePattern.OutputClasses
{
    public class PersonOutputConsole : IMyOutput<Person>
    {
        public void MyOutput(Person item)
        {
            Console.WriteLine("The info about " + item.ToString() + " object");
            Console.WriteLine("Name - " + item.Name);
            Console.WriteLine("Age - " + item.Age.ToString());
        }
    }
}
