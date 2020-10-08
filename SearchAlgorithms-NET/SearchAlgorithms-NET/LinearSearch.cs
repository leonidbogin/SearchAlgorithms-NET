using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms_NET
{
    public static class LinearSearch<T>
    {
        public static int Search(T[] array, T searchElement)
        {
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(searchElement)) 
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
