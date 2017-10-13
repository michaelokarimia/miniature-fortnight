namespace data_structures
{
    public class ListNode
    {
        public ListNode(object value)
        {
            this.Value = value;
            this.Next = null;
        }

        public ListNode(object value, ListNode next) 
        {
            this.Value = value;
            Next = next;
        }

        public object Value { get; }
        public ListNode Next { get; set; }
    }
}


