using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTreeNode<T> : Node<T>
    {
        public BinaryTreeNode(): base() { }
        public BinaryTreeNode(T data): base(data, null) { }
        public BinaryTreeNode(T data,BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            base.Value = data;
            NodeList<T> childs = new NodeList<T>(2);
            childs[0] = left;
            childs[1] = right;
            base.Neighbours = childs;
        }

        public BinaryTreeNode<T> Left
        {
            get
            {
                if (base.Neighbours == null)
                    return null;
                else
                    return (BinaryTreeNode<T>)base.Neighbours[0];
            }

            set
            {
                if (base.Neighbours == null)
                    base.Neighbours = new NodeList<T>(2);

                base.Neighbours[0] = value;
            }
        }

        public BinaryTreeNode<T> Right
        {
            get
            {
                if (base.Neighbours == null)
                    return null;
                else
                    return (BinaryTreeNode<T>)base.Neighbours[1];
            }

            set
            {
                if (base.Neighbours == null)
                    base.Neighbours = new NodeList<T>(2);

                base.Neighbours[1] = value;
            }
        }



    }
}
