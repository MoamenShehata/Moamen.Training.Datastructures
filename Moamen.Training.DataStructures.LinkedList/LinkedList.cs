using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.DataStructures.LinkedList
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> Head { get; set; }
        public LinkedListNode<T> Tail { get; set; }
        public int Count { get; private set; }

        public void AddFirst(LinkedListNode<T> node)
        {
            var temp = Head;

            Head = node;
            Head.Next = temp;
            if (Count == 0)
                Tail = Head;

            Count++;
        }

        public void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }

            Count++;
        }
    }
}
