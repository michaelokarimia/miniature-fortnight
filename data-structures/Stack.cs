using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures
{
    public class Stack
    {
        private readonly LinkedList list;

        private int count;

        public Stack()
        {
            list = new LinkedList();
            count = 0;
        }

        public void Push(int value)
        {
            list.Append(value);
            count++;
        }

        public int Peek()
        {
            return list.Traverse(null).Value;
        }

        public int Pop()
        {
            var last = list.Traverse(null);

            var lastValue = last.Value;

            list.Remove(last);

            count--;

            return lastValue;
        }
    }
}
