using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArvoreNominal
{
    public class Tree<T>
    {
        public Person<T>? Root { get; set; }

        public void PrintTree(Person<T> Person)
        {
            Console.WriteLine($"ID: {Person.Id}");
            Console.WriteLine($"Person: {Person.Name}");
            Console.WriteLine($"Role: {Person.Role} \n");

            if(Person.Children!.Count() > 0)
                foreach(var i in Person.Children!)
                    PrintTree(i);
        }
    }
}