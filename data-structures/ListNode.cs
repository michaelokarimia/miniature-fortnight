namespace data_structures
{
    public class ListNode
    {
        public ListNode(int value)
        {
            this.Value = value;
            this.Next = null;
        }

        public ListNode(int value, ListNode next) 
        {
            this.Value = value;
            Next = next;
        }

        public int Value { get; }
        public ListNode Next { get; set; }
    }
}


