using HW_PrototypePattern.Classes;
using HW_PrototypePattern.Interfaces;
using HW_PrototypePattern.OutputClasses;

internal class Program
{
    private static void Main()
    {
        var subjectTeacher1 = new SubjectTeacher { Name = "Natalya", Age = 40, School = "School 171", Subject = "Math" };
        var subjectTeacher2 = subjectTeacher1.MyClone();
        var subjectTeacher3 = (SubjectTeacher)subjectTeacher1.Clone();

        var classroomTeacher1 = new ClassroomTeacher { Name = "Daria", Age = 40, School = "School 171", Classroom = "5A" };
        var classroomTeacher2 = classroomTeacher1.MyClone();
        var classroomTeacher3 = (ClassroomTeacher)classroomTeacher1.Clone();

        IMyOutput<SubjectTeacher> subjectTeacherOutput = new SubjectTeacherOutputConsole();
        IMyOutput<ClassroomTeacher> classroomTeacherOutput = new ClassroomTeacherOutputConsole();

        subjectTeacherOutput.MyOutput(subjectTeacher1);
        subjectTeacherOutput.MyOutput(subjectTeacher2);
        subjectTeacherOutput.MyOutput(subjectTeacher3);
        classroomTeacherOutput.MyOutput(classroomTeacher1);
        classroomTeacherOutput.MyOutput(classroomTeacher2);
        classroomTeacherOutput.MyOutput(classroomTeacher3);
    }
}