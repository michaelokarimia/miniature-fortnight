namespace data_structures
{
    public class ListNode
    {
        public ListNode(object value)
        {
            this.Value = value;
            this.Next = null;
        }

        public object Value { get; }
        public ListNode Next { get; set; }
    }
}


