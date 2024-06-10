using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_PrototypePattern.Interfaces;

namespace HW_PrototypePattern.Classes
{
    public class SchoolEmployee: Person, IMyCloneable<SchoolEmployee>, ICloneable
    {
        public string School { get; set; }

        public SchoolEmployee MyClone()
        {
            return new SchoolEmployee { Name = this.Name, Age = this.Age, School = this.School };
        }
        public object Clone()
        {
            return this.MyClone();
        }
        public override string ToString()
        {
            return "SchoolEmployee";
        }
    }
}
