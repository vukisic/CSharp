using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://msdn.microsoft.com/en-us/library/ms379572(v=vs.80).aspx

namespace BinaryTree
{
    public class BinaryTree<T>: IComparer<T>
    {
        private BinaryTreeNode<T> root;
        private Comparer<T> comparer=Comparer<T>.Default; //Default Comparer for type T
        private int count;

        public BinaryTree() { root = null; }
        public BinaryTreeNode<T> Root { get { return root; } set { root = value; } }
        public int Count { get { return count; } set { count = value; } }

        public virtual void Clear() { root = null; }

        public void PreorderTraversal(BinaryTreeNode<T> curr)
        {
            if (curr != null)
            {
                Console.WriteLine(curr.Value);
                PreorderTraversal(curr.Left);
                PreorderTraversal(curr.Right);
            }
        }

        public void InorderTraversal(BinaryTreeNode<T> curr)
        {
            if (curr != null)
            {
                InorderTraversal(curr.Left);
                Console.WriteLine(curr.Value);
                InorderTraversal(curr.Right);
            }
        }

        public void PostorderTraversal(BinaryTreeNode<T> curr)
        {
            if (curr != null)
            {
                PostorderTraversal(curr.Left);
                PostorderTraversal(curr.Right);
                Console.WriteLine(curr.Value);
            }
        }

        public bool Contains(T data)
        {
            BinaryTreeNode<T> curr = root;
            int result;
            while (curr != null)
            {
                result = comparer.Compare(curr.Value, data);
                if (result == 0)
                    return true;
                else if (result > 0)
                    curr = curr.Left;
                else
                    curr = curr.Right;
            }
            return false;
        }

        public int Compare(T x, T y)
        {
            return comparer.Compare(x, y);
        }

        public virtual void Add(T data)
        {
            BinaryTreeNode<T> n = new BinaryTreeNode<T>(data);
            int result;
            BinaryTreeNode<T> curr = root;
            BinaryTreeNode<T> parent = null;

            while (curr != null)
            {
                result = comparer.Compare(curr.Value, data);
                if (result == 0)
                    return; //Attempt to add duplicate
                else if (result > 0)
                {
                    parent = curr;
                    curr = curr.Left;
                }
                else if(result < 0)
                {
                    parent = curr;
                    curr = curr.Right;
                }
            }

            count++;
            if (parent == null)
                root = n;
            else
            {
                result = comparer.Compare(parent.Value, data);
                if (result > 0) //parent.Value > data
                    parent.Left = n;
                else
                    parent.Right = n; //parent.Value < data
            }

        }


        

        public bool Remove(T data)
        {
            if (root == null)
                return false; //Empty tree -> Nothing to remove!

            //Trying to find Node with 'data' value
            BinaryTreeNode<T> curr = root, parent = null;
            int result = comparer.Compare(curr.Value, data);
            while (result != 0)
            {
                if (result > 0)
                {
                    //curr.Value > data go in Left subtree
                    parent = curr;
                    curr = curr.Left;
                }
                else if (result < 0)
                {
                    //curr.Value < data go in right subtree
                    parent = curr;
                    curr = curr.Right;
                }

                if (curr == null)
                    return false; //Didn't find Node with that 'data' value
                else
                    result = comparer.Compare(curr.Value, data); //Compare again
            }

            //We find our Node and it's parent -> We are ready to remove curr Node
            --count;

            //CASE 1: If curr Node has no right child -> curr's left child becomes curr
            if (curr.Right==null)
            {
                if (parent == null)
                    root = curr.Left;
                else
                {
                    result = comparer.Compare(parent.Value, curr.Value);
                    if (result > 0) //parent.Value > curr.Value
                        parent.Left = curr.Left; //Make curr's left child a left child of curr parent
                    else if(result < 0) //parent.Value < curr.Value
                        parent.Right = curr.Left; //Make curr's left child a right child of curr parent
                }

            }
            //CASE 2: If curr's right child has no left child -> curr's right child replaces curr
            else if (curr.Right.Left==null)
            {
                curr.Right.Left = curr.Left;
                if (parent == null)
                    root = curr.Right;
                else
                {
                    result = comparer.Compare(parent.Value, curr.Value);
                    if (result > 0) //parent.Value > curr.Value
                        parent.Left = curr.Right; //Make curr's right child a left child of curr parent
                    else if (result < 0) //parent.Value < curr.Value
                        parent.Right = curr.Right; //Make curr's right child a right child of curr parent
                }
            }
            //Case 3: if curr's right child hase left child -> replace curr with curr's right child's left-with smallest value
            else
            {
                BinaryTreeNode<T> SmallestLeft = curr.Right.Left, SmallestLeftParent = curr.Right;
                while (SmallestLeft.Left != null) //Searching for "most left" Node
                {
                    SmallestLeftParent = SmallestLeft;
                    SmallestLeft = SmallestLeft.Left;
                }

                //Perent's left subtree becomes SmallestLeft right sub tree
                SmallestLeftParent.Left = SmallestLeft.Right;

                //Assign SmallestLeft's right and left child to curr's left and right
                SmallestLeft.Left = curr.Left;
                SmallestLeft.Right = curr.Right;

                if (parent == null)
                    root = SmallestLeft;
                else
                {
                    result = comparer.Compare(parent.Value, curr.Value);
                    if (result > 0) //parent.Value > curr.Value
                        parent.Left = SmallestLeft; //Make SmallestLeft a left child of parent
                    else if (result < 0) //parent.Value < curr.Value
                        parent.Right = SmallestLeft; //Make SmallestLeft a right child of parent
                }
            }
            return true;
        }







    }
}
