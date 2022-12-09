using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _06_linq.Repo;

namespace _06_linq.Service
{
    class TeacherService
    {
        public TeacherRepo teacherRepo = new TeacherRepo();

        public TeacherService()
        {            
        }

        public void HeadTeachersName()
        {
            List<string> headTeacher = (from teacher in teacherRepo.Teachers
                                        where teacher.IsHeadTeacher
                                        select teacher.Name).ToList();
            Console.WriteLine("Osztályfőnökök:");
            foreach(string name in headTeacher)
            {
                Console.WriteLine($"{name}");
            }

        }


    }
}
