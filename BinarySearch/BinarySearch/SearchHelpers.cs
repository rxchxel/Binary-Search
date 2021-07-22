using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class SearchHelpers
    {
        //Iterative binary search function.
        public static int BinarySearch(int[] array, int number)
        {
            return BinarySearch(array, number, 0, array.Length - 1);
        }

        //Interative overloaded binary search function.
        public static int BinarySearch(int[] array, int number, int minN, int maxN)
        {
            int midN = (maxN - minN) / 2;
            while (minN <= maxN)
            {
                if (array[midN] > number)
                {
                    maxN = midN - 1;
                    midN = minN + (maxN - minN) / 2;
                }
                else if (array[midN] < number)
                {
                    minN = midN + 1;
                    midN = minN + (maxN - minN) / 2;
                }
                else if (array[midN] == number)
                {
                    return midN;
                }
            }
            return -1;
        }

        //Recursive binary search function.
        public static int RecursiveSearch(int[] array, int number)
        {
            return RecursiveSearch(array, number, 0, array.Length - 1);
        }

        //overloaded Recursive Search
        public static int RecursiveSearch(int[] array, int number, int minN,  int maxN)
        {
            int midN = minN + (maxN - minN) / 2;

            if (maxN < minN)
            {
                return -1;
            }
            else if (array[midN] > number)
            {
                return RecursiveSearch(array, number, minN, midN - 1);
            }
            else if (array[midN] < number)
            {
               return RecursiveSearch(array, number, midN + 1, maxN);
            }

            return midN;           
        }
    }
}
