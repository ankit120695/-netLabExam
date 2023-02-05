using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 50);
            }

            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              select number;

            Console.WriteLine("Numbers divisible by 2:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine(evenNumber);
            }

            Console.ReadKey();
        }
    }
}
