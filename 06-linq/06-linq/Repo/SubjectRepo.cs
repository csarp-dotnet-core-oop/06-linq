using _06_linq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_linq.Repo
{
    public class SubjectRepo
    {
        private List<Subject> subjects;

        public List<Subject> Subjects { get => subjects; set => subjects = value; }

        public SubjectRepo()
        {
            subjects.Add(new Subject(1, "Matematika"));
            subjects.Add(new Subject(2, "Magyar nyelv"));
            subjects.Add(new Subject(2, "Irodalom"));
            subjects.Add(new Subject(2, "Angol nyelv"));
            subjects.Add(new Subject(2, "Német nyelv"));
            subjects.Add(new Subject(2, "Történelem"));
            subjects.Add(new Subject(2, "Rajz"));
            subjects.Add(new Subject(2, "Testnevelés"));
        }
    }
}
