using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_PrototypePattern.Interfaces;

namespace HW_PrototypePattern.Classes
{
    public class SubjectTeacher: SchoolEmployee, IMyCloneable<SubjectTeacher>, ICloneable
    {
        public string Subject { get; set; }

        public SubjectTeacher MyClone()
        {
            return new SubjectTeacher { Name = this.Name, Age = this.Age, School = this.School, Subject = this.Subject };
        }
        public object Clone()
        {
            return this.MyClone();
        }
        public override string ToString()
        {
            return "SubjectTeacher";
        }
    }
}
