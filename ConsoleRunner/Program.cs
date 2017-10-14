using data_structures;
using System;

namespace ConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();

            list.Append(1);
            list.Append(2);
            list.Append(3);


            Console.WriteLine(list.ToString());
            list.Remove(2);
            Console.WriteLine(list.ToString());

            Console.ReadKey();
        }
    }
}
