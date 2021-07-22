using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class DemoHelpers
    {
        //Generating an array filled with random numbers.
        public static int[] GenerateArray(int length)
        {
            //initiating new array to be filled with random numbers.
            int[] randNums = new int[length];
            Random rnd = new Random();

            //inserting random values into each index position. 
            for (int i = 0; i < randNums.Length; i++)
            {
                randNums[i] = rnd.Next(1, 100);
            }

            //returning new filled array.
            return randNums;
        }

        //Function to print an arrays values and their positions.
        public static void PrintArray(int[] array)
        {
            for (int idx = 0; idx < array.Length; idx += 1)
            {
                Console.WriteLine(idx + ": " + array[idx]);
            }
            return;
        }

        //Function to print results from overload iterative method
        public static void PrintResults(int result, int value)
        {
            if (result == -1)
            {
                Console.WriteLine("The number " + value + " is not present.");
            }

            else
            {
                Console.WriteLine("The number " + value + " is at index: " + result);
            }

        }

        public static void PrintResults(int result, int value, int minN, int maxN)
        {
            if (result == -1)
            {
                Console.WriteLine("The number " + value + " is not present between index " + minN + " and index " + maxN);
            }

            else
            {
                Console.WriteLine("The number " + value + " is at index: " + result);
            }
        }
    }
}
