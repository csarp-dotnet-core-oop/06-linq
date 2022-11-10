using _06_linq.Model.DTO;
using _06_linq.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_linq.Service
{
    // https://dotnettutorials.net/lesson/introduction-to-linq/
    public class TeachTeacherSubjectService
    {
        RepositoryWrapper repositoryWrapper;

        public TeachTeacherSubjectService()
        {
            repositoryWrapper = new RepositoryWrapper();
        }

        // 1. feladat
        // Tanár tantárgy párok
        public void TeacherSubjectPair()
        {
            List<TeacherSubjectPair> result = (from teacher in repositoryWrapper.TeacherRepo.Teachers
                                               from subject in repositoryWrapper.SubjectRepo.Subjects
                                               orderby teacher.Name
                                               select new TeacherSubjectPair
                                               {
                                                   Teacher = teacher.Name,
                                                   Subject = subject.Name                                                   
                                               }).ToList();

            Console.WriteLine("Tanár - tantárgy párok:");
            foreach (TeacherSubjectPair pair in result)
                Console.WriteLine($"{pair.Teacher} => {pair.Subject}");
        }

        public void TeacherSubjectPairLinq()
        {
            var result = repositoryWrapper.TeacherRepo.Teachers.SelectMany(
                    teacher => repositoryWrapper.SubjectRepo.Subjects, (teacher, subject) => new TeacherSubjectPair
                    {
                        Teacher = teacher.Name,
                        Subject = subject.Name
                    }).OrderBy(pair => pair.Teacher).ToList();
                                     

            Console.WriteLine("Tanár - tantárgy párok:");
            foreach (TeacherSubjectPair pair in result)
                Console.WriteLine($"{pair.Teacher} => {pair.Subject}");
        }

    }
}
