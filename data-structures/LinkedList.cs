using System;
using System.Text;

namespace data_structures
{
    public class LinkedList
    {
        private ListNode Head;

        public ListNode Traverse(Func<ListNode, ListNode,bool> expression)
        {
            var current = this.Head;
            ListNode last = null;

            while (current != null)
            {
                if(expression != null && expression(current, last))
                { break; }
                last = current;
                current = current.Next;
            }

            return last;
        }

        public ListNode Append(int value)
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

            return insertNode;
        }

          public void Remove(ListNode itemToRemove)
        {
            //check if head value is the node to remove
            if (this.Head.Value.Equals(itemToRemove.Value))
            {
                this.Head = Head.Next;
            }
            else
            {
                //traverse through the list until you find the node with your value to remove

                this.Traverse((current, previous) =>
                {

                    if (current.Value == itemToRemove.Value)
                    {
                        //Match found, so remove it
                        //set previous node's Next reference to point to the next node instead of the current node 

                        if (previous != null)
                        {
                            previous.Next = current.Next;
                        }
                        return true;
                    }
                    return false;

                });
            }
        }

        public ListNode InsertAt(ListNode node, int value)
        {
            var insertNode = new ListNode(value, node.Next);


            node.Next = insertNode;

            return insertNode;

        }

        public override string ToString()
        {
            var current = this.Head;

            int counter = 0;
            StringBuilder sb = new StringBuilder();

            while (current != null)
            {
                sb.AppendLine(string.Format("Index: {0}, Value: {1}", counter, current.Value));
                current = current.Next;
                counter++;
            }
            return sb.ToString();

        }

    }
}


