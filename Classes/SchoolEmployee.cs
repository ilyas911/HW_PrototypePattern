using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_PrototypePattern.Interfaces;

namespace HW_PrototypePattern.Classes
{
    public abstract class SchoolEmployee : Person
    {
        public string School { get; set; }

        public override string ToString()
        {
            return "SchoolEmployee";
        }
    }
}
