using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArvoreNominal
{
    public class Person<T>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public Person() { }
        public Person(int id, string name, string role)
        {
            Id = id;
            Name = name;
            Role = role;
        }
        public int GetHeight()
        {
            int height = 1;
            Node<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }

            return height;
        }
    }
}
