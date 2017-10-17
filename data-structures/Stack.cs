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
            count++;
            //empty list, add a new node
            if (list.Head == null)
            {
                list.Head = new ListNode(value);
            }
            else
            {
                //replace head with the new node and point its next value to the new node
                var currentHead = list.Head;
                list.Head = new ListNode(value);
                list.Head.Next = currentHead;
            }
            
        }

        public int? Peek()
        {
            return list.Head?.Value;
        }

        public int? Pop()
        {
            var headValue = list.Head?.Value;

            list.Head = list.Head?.Next;

            return headValue;
        }
    }
}
