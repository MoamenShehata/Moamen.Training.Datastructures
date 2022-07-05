using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.DataStructures.BinaryTree
{
    public class BinaryTree<T>
        where T : IComparable<T>
    {
        private BinaryTreeNode<T> root;
        private int count;

        public void Add(T value)
        {
            if (count == 0)
            {
                root = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddTo(root, value);
            }

            count++;
        }

        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
        }

        public BinaryTreeNode<T> Find(T value)
        {
            return Find(root, value);
        }

        private BinaryTreeNode<T> Find(BinaryTreeNode<T> node, T value)
        {
            if (node == null)
                return null;

            if (value.CompareTo(node.Value) == 0)
                return node;

            if (value.CompareTo(node.Value) < 0)
                return Find(node.Left, value);

            return Find(node.Right, value);
        }

        private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            var current = root;
            parent = null;

            while (current != null)
            {
                if (value.CompareTo(current.Value) < 0)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (value.CompareTo(current.Value) > 0)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    break;
                }
            }
            return current;
        }
    }
}
