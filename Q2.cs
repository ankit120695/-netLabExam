using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;

            IncrementAndDecrement(ref n1, ref n2);

            Console.WriteLine("n1: " + n1);
            Console.WriteLine("n2: " + n2);

            Console.ReadKey();
        }

        static void IncrementAndDecrement(ref int n1, ref int n2)
        {
            n1++;
            n2--;
        }
    }
}
