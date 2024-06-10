using HW_PrototypePattern.Classes;
using HW_PrototypePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_PrototypePattern.OutputClasses
{ 
    public class SchoolEmployeeOutputConsole : IMyOutput<SchoolEmployee>
    {
        public void MyOutput(SchoolEmployee item)
        {
            Console.WriteLine("The info about " + item.ToString() + " object");
            Console.WriteLine("Name - " + item.Name);
            Console.WriteLine("Age - " + item.Age.ToString());
            Console.WriteLine("School - " + item.School);
        }
    }
}
