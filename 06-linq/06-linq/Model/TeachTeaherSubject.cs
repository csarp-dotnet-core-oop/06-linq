using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_linq.Model
{
    public class TeachTeaherSubject
    {
        private int teacherId;
        private int subjectId;

        public int TeacherId { get => teacherId; set => teacherId = value; }
        public int SubjectId { get => subjectId; set => subjectId = value; }

        public TeachTeaherSubject(int teacherId, int subjectId)
        {
            this.teacherId = teacherId;
            this.subjectId = subjectId;
        }

    }
}
