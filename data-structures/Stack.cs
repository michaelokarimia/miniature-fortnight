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

        public int? Peek()
        {
            var matchingNode = list.Traverse((n, m) => n.Next == null);
            if (matchingNode != null)
                return matchingNode.Value;
            else
                return null;
        }

        public int Pop()
        {
            var last = list.Traverse((n,m) => n.Next == null);

            var lastValue = last.Value;

            list.Remove(last);

            count--;

            return lastValue;
        }
    }
}
