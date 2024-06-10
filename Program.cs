using HW_PrototypePattern.Classes;
using HW_PrototypePattern.Interfaces;
using HW_PrototypePattern.OutputClasses;

internal class Program
{
    private static void Main()
    {
        var person1 = new Person { Name = "Katya", Age = 30 };
        var person2 = person1.MyClone();
        var person3 = (Person)person1.Clone();

        var schoolEmployee1 = new SchoolEmployee { Name = "Maria", Age = 28, School = "School 171" };
        var schoolEmployee2 = schoolEmployee1.MyClone();
        var schoolEmployee3 = (SchoolEmployee)schoolEmployee1.Clone();

        var subjectTeacher1 = new SubjectTeacher { Name = "Natalya", Age = 40, School = "School 171", Subject = "Math" };
        var subjectTeacher2 = subjectTeacher1.MyClone();
        var subjectTeacher3 = (SubjectTeacher)subjectTeacher1.Clone();

        var classroomTeacher1 = new ClassroomTeacher { Name = "Daria", Age = 40, School = "School 171", Classroom = "5A" };
        var classroomTeacher2 = classroomTeacher1.MyClone();
        var classroomTeacher3 = (ClassroomTeacher)classroomTeacher1.Clone();

        IMyOutput<Person> personOutput = new PersonOutputConsole();
        IMyOutput<SchoolEmployee> schoolEmployeeOutput = new SchoolEmployeeOutputConsole();
        IMyOutput<SubjectTeacher> subjectTeacherOutput = new SubjectTeacherOutputConsole();
        IMyOutput<ClassroomTeacher> classroomTeacherOutput = new ClassroomTeacherOutputConsole();

        personOutput.MyOutput(person1);
        personOutput.MyOutput(person2);
        personOutput.MyOutput(person3);
        schoolEmployeeOutput.MyOutput(schoolEmployee1);
        schoolEmployeeOutput.MyOutput(schoolEmployee2);
        schoolEmployeeOutput.MyOutput(schoolEmployee3);
        subjectTeacherOutput.MyOutput(subjectTeacher1);
        subjectTeacherOutput.MyOutput(subjectTeacher2);
        subjectTeacherOutput.MyOutput(subjectTeacher3);
        classroomTeacherOutput.MyOutput(classroomTeacher1);
        classroomTeacherOutput.MyOutput(classroomTeacher2);
        classroomTeacherOutput.MyOutput(classroomTeacher3);
    }
}