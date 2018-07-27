using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node<T>
    {
        private T data;
        private NodeList<T> neighbours=null;
        
        public Node() { }
        public Node(T data) { this.data = data;this.neighbours = null; }
        public Node(T data, NodeList<T> neighbours) { this.data = data;this.neighbours = neighbours; }

        public T Value { get { return data; } set { data = value; } }
        public NodeList<T> Neighbours { get { return neighbours; } set { neighbours = value; } }
    }
}
