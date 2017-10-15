using System;

namespace data_structures
{
    public class QueueWithInternalStacks
    {
        private Stack frontStack;
        private Stack rearStack;

        public QueueWithInternalStacks()
        {
            frontStack = new Stack();
            rearStack = new Stack();
        }


        public int? Peek()
        {
            return frontStack.Peek();
        }

        public void Enqueue(int v)
        {
            if (rearStack.Peek() != null)
            {
                frontStack.Push(rearStack.Pop());
            }
            rearStack.Push(v);
        }

        public int? Dequeue()
        {
            int? current = null;

            if (frontStack.Peek() != null)
            {
                current = frontStack.Pop();
            }

            


            return current;
        }
    }
}
