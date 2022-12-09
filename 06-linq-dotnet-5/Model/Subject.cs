using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_linq.Model
{
    public class Subject
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Subject()
        {
            id = -1;
            name=string.Empty;
        }

        public Subject(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
