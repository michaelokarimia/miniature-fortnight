using data_structures;
using System;

namespace ConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList();

            var ten = linkedList.Append(10);
            linkedList.Append(11);
            var twelve = linkedList.Append(12);
            linkedList.Append(13);
            linkedList.Append(14);


            Console.WriteLine(linkedList.ToString());

            linkedList.InsertAt(twelve, 100);
            Console.WriteLine(linkedList.ToString());

            linkedList.InsertAt(ten, -1);
            Console.WriteLine(linkedList.ToString());

            linkedList.Remove(ten);
            Console.WriteLine(linkedList.ToString());

            linkedList.Remove(twelve);
            Console.WriteLine(linkedList.ToString());

            Console.ReadKey();
        }


        public static void PrintNodes(ListNode current)
        {
            while (current != null)
            {
                Console.WriteLine("Value: {0}", current.Value);
                current = current.Next;
            }
        }
    }
}
