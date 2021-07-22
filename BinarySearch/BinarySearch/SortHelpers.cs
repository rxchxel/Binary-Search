using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class SortHelpers
    {
        //Recursive Selection Sort.
        public static int[] RecursiveSort(int[] array, int size, int index)
        {
            //returns when the index position is the same as the size of the array.
            if (index == size)
                return array;

            //calling on minIndex function to find the smallest number. 
            int number = MinIndex(array, index, size - 1);

            if (number != index)
            {
                //swapping the values
                int tempNum = array[number];
                array[number] = array[index];
                array[index] = tempNum;
            }

            //recalling the function. 
            RecursiveSort(array, size, index + 1);
            return array;
        }
        
        //Finding the minimum value within a given array.
        public static int MinIndex(int[] array, int index, int length)
        {
            if (index == length)
            {
                return index;
            }

            //Finding the index of the minimum value in the array.
            int number = MinIndex(array, index + 1, length);
            //Returning minimum value of the current and remaining values, using ternary operator.
            return array[index] < array[number] ? index : number;
        }
    }
}
