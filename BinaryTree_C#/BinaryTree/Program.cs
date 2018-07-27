using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryTree<int> iTree = new BinaryTree<int>();

            iTree.Add(30);
            iTree.Add(50);
            iTree.Add(10);
            iTree.Add(60);
            iTree.PreorderTraversal(iTree.Root);
            Console.WriteLine("----------------------------");
            iTree.Remove(30);
            iTree.PreorderTraversal(iTree.Root);
            
            Console.ReadLine();
        }
    }
}
