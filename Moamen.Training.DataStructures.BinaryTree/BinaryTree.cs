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

        public IEnumerable<T> PreOrder()
        {
            return PreOrderTraverse(root);
        }

        private IEnumerable<T> PreOrderTraverse(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                //process
                yield return node.Value;

                //visit left
                foreach (var item in PreOrderTraverse(node.Left))
                    yield return item;

                //visit right
                foreach (var item in PreOrderTraverse(node.Right))
                    yield return item;
            }
        }

        public IEnumerable<T> InOrder()
        {
            return InOrderTraverse(root);
        }

        private IEnumerable<T> InOrderTraverse(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                //visit left
                foreach (var item in InOrderTraverse(node.Left))
                    yield return item;
                //process
                yield return node.Value;

                //visit right
                foreach (var item in InOrderTraverse(node.Right))
                    yield return item;
            }
        }

        public IEnumerable<T> PostOrder()
        {
            return PostOrderTraverse(root);
        }

        private IEnumerable<T> PostOrderTraverse(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                //visit left
                foreach (var item in PostOrderTraverse(node.Left))
                    yield return item;

                //visit right
                foreach (var item in PostOrderTraverse(node.Right))
                    yield return item;

                //process
                yield return node.Value;
            }
        }
    }
}
