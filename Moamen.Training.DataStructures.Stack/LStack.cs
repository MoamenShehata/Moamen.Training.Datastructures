using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.DataStructures.Stack
{
    public class LStack<T> : IEnumerable<T>
    {
        private LinkedList<T> _stack = new LinkedList<T>();

        public void Push(T item)
        {
            _stack.AddFirst(item);
        }

        public T Pop()
        {
            if (_stack.Count == 0)
                throw new Exception("The stack is empty");

            var value = _stack.First.Value;
            _stack.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            if (_stack.Count == 0)
                throw new Exception("The stack is empty");

            return _stack.First.Value;
        }

        public IEnumerator<T> GetEnumerator() => _stack.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
