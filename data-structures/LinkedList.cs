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

        public ListNode Traverse(Func<ListNode,bool> expression)
        {
            var current = this.Head;
            ListNode last = null;

            while (current != null)
            {
                if(expression != null && expression(current))
                { break; }
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
                var lastNode = this.Traverse(null);
                lastNode.Next = insertNode;
            }

            Size++;

        }

        public void Remove(object value)
        {
            //check if head value is the node to remove
            if (this.Head.Value.Equals(value))
            {
                this.Head = Head.Next;
            }
            else
            {
                //traverse through the list until you find the node with your value to remove

                this.Traverse((n) => { return (n.Value == value); });


                //remember the previous node
            }

            Size--;
        }

        public ListNode InsertAt(ListNode node, object value)
        {
            var insertNode = new ListNode(value, node.Next);


            node.Next = insertNode;

            return insertNode;

        }
    }
}


