using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArvoresBasicas
{
    public class Tree<T>
    {
        public Person<T>? Root { get; set; }

        public void PrintTree(Person<T> Person)
        {
            Console.WriteLine($"Level: {Person.GetHeight()}");
            Console.WriteLine($"Pessoa: {Person.Data} \n");

            if(Person.Children!.Count() > 0)
                foreach(var i in Person.Children!)
                    PrintTree(i);
        }
    }
}