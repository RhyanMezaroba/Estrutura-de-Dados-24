using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArvoresBasicas
{
    public class Node<T>
    {
        public T? Data { get; set; } //Pode ser armazenado em nulo onde vai mostar pro compilador o número 0
        public Node<T>? Parent { get; set; }
        public List<Node<T>>? Children { get; set;} = [];
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