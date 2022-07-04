using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.DataStructures.Stack
{
    public class AStack<T> : IEnumerable<T>
    {
        private T[] stack;
        private int count = 0;

        public AStack(int capacity = 10)
        {
            stack = new T[capacity];
        }

        public void Push(T item)
        {
            if (count == stack.Length)
            {
                var newArr = new T[stack.Length * 2];
                stack.CopyTo(newArr, 0);
                stack = newArr;
            }
            stack[count++] = item;
        }

        public T Pop()
        {
            if (count == 0)
                throw new Exception("The stack is empty");
            return stack[--count];
        }

        public T Peek()
        {
            if (count == 0)
                throw new Exception("The stack is empty");
            return stack[count - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
