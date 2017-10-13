using data_structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.ReadKey();
        }
    }
}
