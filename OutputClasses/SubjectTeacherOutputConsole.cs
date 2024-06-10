﻿using HW_PrototypePattern.Classes;
using HW_PrototypePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_PrototypePattern.OutputClasses
{
    public class SubjectTeacherOutputConsole : IMyOutput<SubjectTeacher>
    {
        public void MyOutput(SubjectTeacher item)
        {
            Console.WriteLine("The info about " + item.ToString() + " object");
            Console.WriteLine("Name - " + item.Name);
            Console.WriteLine("Age - " + item.Age.ToString());
            Console.WriteLine("School - " + item.School);
            Console.WriteLine("Subject - " + item.Subject);
        }
    }
}
