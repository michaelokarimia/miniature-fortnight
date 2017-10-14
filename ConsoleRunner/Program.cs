using data_structures;
using System;

namespace ConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new ListNode(1);

            start.AddNext(2).AddNext(3).AddNext(4).AddNext(5);

            PrintNodes(start);
            
            
           
                        



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
