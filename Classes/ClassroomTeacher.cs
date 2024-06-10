using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_PrototypePattern.Interfaces;

namespace HW_PrototypePattern.Classes
{
    public class ClassroomTeacher: SchoolEmployee, IMyCloneable<ClassroomTeacher>, ICloneable
    {
        public string Classroom {  get; set; }

        public ClassroomTeacher MyClone()
        {
            return new ClassroomTeacher { Name = this.Name, Age = this.Age, School = this.School, Classroom = this.Classroom };
        }
        public object Clone()
        {
            return this.MyClone();
        }
        public override string ToString()
        {
            return "ClassroomTeacher";
        }
    }
}
