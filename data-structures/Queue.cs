using System;

namespace data_structures
{
    public class Queue
    {
        private LinkedList list;

        public int count { get; private set; }

        public Queue()
        {
            list = new LinkedList();
            this.count = 0;
        }

        public void Enqueue(int value)
        {
            list.Append(value);
            count++;
        }

        public int? Peek()
        {
            if (list.Head != null)
            {
                return list.Head.Value;
            }
            else
            {
                return null;
            }
       
        }

        public int Dequeue()
        {
            var headValue = this.Peek();

            if (headValue.HasValue)
            {
                count--;
                list.Remove(list.Head);
            }
            return headValue.Value;
        }
    }
}
