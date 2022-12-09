using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_linq.Model
{
    public class Parent
    {
        private int id;
        private string name;
        bool isWoman;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool IsWoman { get => isWoman; set => isWoman = value; }

        public Parent(int id, string name, bool isWoman)
        {
            this.id = id;
            this.name = name;
            this.isWoman = isWoman;
        }

        public Parent()
        {
            id = -1;
            name = string.Empty;
            isWoman = false;
        }
    }
}
