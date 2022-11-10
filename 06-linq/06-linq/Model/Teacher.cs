using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_linq.Model
{
    public  class Teacher
    {
        private int id;
        private string name;
        bool isHeadTeacher;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool IsHeadTeacher { get => isHeadTeacher; set => isHeadTeacher = value; }

        public Teacher(int id, string name, bool isHeadTeacher)
        {
            this.Id = id;
            this.Name = name;
            this.IsHeadTeacher = isHeadTeacher;
        }

        public Teacher()
        {
            id = -1;
            name = string.Empty;
            isHeadTeacher = false;
        }


    }
}
