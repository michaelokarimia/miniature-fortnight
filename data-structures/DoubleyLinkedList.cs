using System;
using System.Text;

namespace data_structures
{

    public class Node
    {
        public Node(int val, Node next, Node previous)
        {
            this.Value = val;
            this.Next = next;
            this.Previous = previous;
        }

        

        public int Value { get; }
        public Node Previous { get; set; }
        public Node Next { get; set; }
    }

    public class DoubleyLinkedList
    {
        private Node Head;

        public Node Traverse(Func<Node,bool> expression)
        {
            var current = this.Head;
            Node last = null;

            while (current != null)
            {
                var result = expression(current);
                last = current;
                current = current.Next;
                if(result)
                    { break; }
            
            }

            return last;
        }

        public Node Append(int value)
        {
            var insertNode = new Node(value, null, null);      
            
            //if list is empty insert new node at head
            if(this.Head == null)
            {
                this.Head = insertNode;
            }
            else
            {
                //traverse list to get to the end, and insert new node there
                var lastNode = this.Traverse((n) => n.Next == null);
                insertNode.Previous = lastNode;
                lastNode.Next = insertNode;
            }

            return insertNode;
        }

          public void Remove(Node deleteNode)
        {
            //check if head value is the node to remove
            if (this.Head.Value.Equals(deleteNode.Value))
            {
                this.Head = Head.Next;
            }
            else
            {
                //set previous node's Next reference to point to the next node instead of the current node 

                ///1 -><- 2 -><- 3 -><- 4 ->


                var previous = deleteNode.Previous;
                var next = deleteNode.Next;

                if (next != null)
                {
                    next.Previous = previous;
                }

                previous.Next = next;
            }
        }

        public Node InsertAt(Node node, int value)
        {
            // 1 -><- 2 -><- 8 -><-3
            var newNode = new Node(value, node.Next, node.Previous);

            node.Next.Previous = newNode;

            node.Next = newNode;

            return newNode;

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


