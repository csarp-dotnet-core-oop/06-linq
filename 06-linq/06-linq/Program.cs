using _06_linq.Service;
using System.Text;

namespace _06_linq
{
    class Program
    {
        static void Main(string[] args)
        {

            TeachTeacherSubjectService teachTeacherSubjectService = new TeachTeacherSubjectService();
            //teachTeacherSubjectService.TeacherSubjectPair();
            //teachTeacherSubjectService.TeacherSubjectPairLinq();
            //teachTeacherSubjectService.TeacherTeachSubjects();
            teachTeacherSubjectService.NumberOfTeacherPerSubject();
            Console.ReadKey();
        }
    }
}
