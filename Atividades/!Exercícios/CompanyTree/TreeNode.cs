using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyTree
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>();

        public TreeNode(T data)
        {
            Data = data;
        }

        // Adiciona um subordinado (nó filho)
        public void AddChild(TreeNode<T> child)
        {
            Children.Add(child);
        }
    }
}