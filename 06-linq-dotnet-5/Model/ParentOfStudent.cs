using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_linq.Model
{
    public class ParentOfStudent
    {
        private int parentId;
        private int studentId;

        public int ParentId { get => parentId; set => parentId = value; }
        public int StudentId { get => studentId; set => studentId = value; }

        public ParentOfStudent(int parentId, int studentId)
        {
            this.parentId = parentId;
            this.studentId = studentId;
        }

        public ParentOfStudent()
        {
            parentId = -1;
            studentId = -1;
        }
        
    }
}
