using System;
using System.Text;

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

        public void Append(int value)
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

        public void Remove(ListNode node)
        {
            //check if head value is the node to remove
            if (this.Head.Value.Equals(node.Value))
            {
                this.Head = Head.Next;
            }
            else
            {
                //traverse through the list until you find the node with your value to remove

                this.Traverse((n, last) =>
                {

                    if (n.Value == node.Value)
                    {
                        last.Next = n.Next;
                        return true;
                    }
                    return false;

                });
            }
            Size--;
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
                sb.AppendLine(string.Format("Index:{0} value: {1}", counter, current.Value));
                current = current.Next;
                counter++;
            }
            return sb.ToString();

        }

    }
}


