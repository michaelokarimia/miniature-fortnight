using System;

namespace data_structures
{
    public class LinkedList
    {
        private ListNode Head;
        public int Size;

        public LinkedList()
        {
            Size = 0;
        }

        public ListNode Traverse()
        {
            var current = this.Head;
            ListNode last = null;

            while (current != null)
            {
                last = current;
                current = current.Next;
            }

            return last;
        }

        public void Append(object value)
        {
            var insertNode = new ListNode(value);      
            
            //if list is empty insert new node at head
            if(this.Head == null)
            {
                this.Head = insertNode;
            }
            else
            {
                //traverse list to get to the end, and insert new node there
                var lastNode = this.Traverse();
                lastNode.Next = insertNode;
            }

            Size++;

        }
    }
}


