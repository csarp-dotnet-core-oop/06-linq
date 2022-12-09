using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_linq.Model
{
    public class Student
    {
        private int id;
        private string name;
        private int schoolClassId;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int SchoolClassId { get => schoolClassId; set => schoolClassId = value; }

        public Student(int id, string name, int schoolClassId)
        {
            this.id = id;
            this.name = name;
            this.schoolClassId = schoolClassId;
        }

        public Student()
        {
            id = -1;
            name = string.Empty;
            schoolClassId = -1;
        }


    }
}
