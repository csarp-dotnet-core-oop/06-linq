using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_linq.Model
{
    public class LearnSchoolClassSubject
    {
        private int schoolClassId;
        private int subjectId;

        public int SchoolClassId { get => schoolClassId; set => schoolClassId = value; }
        public int SubjectId { get => subjectId; set => subjectId = value; }

        public LearnSchoolClassSubject(int schoolClassId, int subjectId)
        {
            this.SchoolClassId = schoolClassId;
            this.SubjectId = subjectId;
        }

        public LearnSchoolClassSubject()
        {
            schoolClassId = -1;
            subjectId = -1;
        }

    }
}
