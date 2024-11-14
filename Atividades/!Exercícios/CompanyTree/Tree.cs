using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyTree
{
    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }
        public Tree(T rootData)
        {
            Root = new TreeNode<T>(rootData);
        }
        // Método para exibir o organograma
        public void Display(TreeNode<T> node, int indent = 0)
        {
            if (node == null) return;

            Console.WriteLine(new string(' ', indent) + node.Data);

            foreach (var child in node.Children)
            {
                Display(child, indent + 4);
            }
        }
    }
}