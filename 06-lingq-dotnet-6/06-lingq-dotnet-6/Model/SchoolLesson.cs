using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_linq.Model
{
    public class SchoolLesson
    {
        int schoolLessonId;
        int studentId;
        int teacherId;
        int subjectId;

        public int SchoolLessonId { get => schoolLessonId; set => schoolLessonId = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public int TeacherId { get => teacherId; set => teacherId = value; }
        public int SubjectId { get => subjectId; set => subjectId = value; }

        public SchoolLesson(int schoolLessonId, int studentId, int teacherId, int subjectId)
        {
            this.schoolLessonId = schoolLessonId;
            this.studentId = studentId;
            this.teacherId = teacherId;
            this.subjectId = subjectId;
        }

        public SchoolLesson()
        {
            schoolLessonId = -1;
            studentId = -1;
            teacherId = -1;
            subjectId = -1;
        }

    }
}
