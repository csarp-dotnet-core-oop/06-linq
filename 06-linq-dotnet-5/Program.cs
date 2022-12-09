using _06_linq.Service;
using System;

namespace _06_linq_dotnet_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeacherService teacherService = new TeacherService();
            teacherService.HeadTeachersName();


            //TeachTeacherSubjectService teachTeacherSubjectService = new TeachTeacherSubjectService();
            //teachTeacherSubjectService.TeacherSubjectPair();
            //teachTeacherSubjectService.TeacherSubjectPairLinq();
            //teachTeacherSubjectService.TeacherTeachSubjects();
            //teachTeacherSubjectService.NumberOfTeacherPerSubject();
            Console.ReadKey();
        }
    }
}
