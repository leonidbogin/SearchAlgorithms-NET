using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms_NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Array: ");
            int[] array = new int[] { 5, 10, 1, 7, 4, 9, 8, 6, 2, 3, 5 };
            Print(array);

            Console.ReadLine();
        }

        public static void Print<T>(T[] array)
        {
            if (array.Length > 0)
            {
                Console.Write(array[0]);
                for (int i = 1; i < array.Length; i++)
                {
                    Console.Write(" " + array[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
