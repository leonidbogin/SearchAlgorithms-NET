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
            PrintArray(array);

            int element = 8;
            Console.Write($"Linear Search: {element};\t");
            PrintResult(array, LinearSearch<int>.Search(array, element));

            element = 13;
            Console.Write($"Linear Search: {element};\t");
            PrintResult(array, LinearSearch<int>.Search(array, element));

            Console.Write("\nSort: ");
            Array.Sort(array);
            PrintArray(array);

            element = 8;
            Console.Write($"Binary Search: {element};\t");
            PrintResult(array, BinarySearch<int>.Search(array, element));

            element = 13;
            Console.Write($"Binary Search: {element};\t");
            PrintResult(array, BinarySearch<int>.Search(array, element));

            Console.ReadLine();
        }

        public static void PrintArray<T>(T[] array)
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

        public static void PrintResult<T>(T[] array, int index)
        {
            if (index > -1)
            {
                Console.WriteLine($"Item found: {array[index]}[{index}]");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }
    }
}
