using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_linq.Model
{
    public class TeachTeacherSchoolClass
    {
        private int subjectId;
        private int teacherId;

        public int SubjectId { get => subjectId; set => subjectId = value; }
        public int TeacherId { get => teacherId; set => teacherId = value; }

        public TeachTeacherSchoolClass(int subjectId, int teacherId)
        {
            this.subjectId = subjectId;
            this.teacherId = teacherId;
        }

        public TeachTeacherSchoolClass()
        {
            subjectId = -1;
            teacherId = -1;
        }
    }
}
