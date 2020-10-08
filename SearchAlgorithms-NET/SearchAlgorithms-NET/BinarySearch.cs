using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms_NET
{
    public static class BinarySearch<T> where T : IComparable
    {
        public static int Search(T[] array, T searchElement)
        {
            int left = 0;
            int right = array.Length - 1;
            int center;

            while (right - left >= 0)
            {
                center = GetCenter(left, right);
                if (array[center].CompareTo(searchElement) == 0)
                {
                    return center;
                }
                else if (array[center].CompareTo(searchElement) > 0)
                {
                    right = center - 1;
                }
                else
                {
                    left = center + 1;
                }
            }
            return -1;
        }

        private static int GetCenter(int left, int right)
        {
            return left + (right - left) / 2;
        }
    }
}
