using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] randNums = DemoHelpers.GenerateArray(10);
            int numberToFind = randNums[0];
            int numberToFind2 = randNums[1];

            Console.WriteLine("Assignment 1: Implement Binary Search");
            Console.WriteLine("Student number: C0003475 \n");

            //printing unsorted array.
            Console.WriteLine("The Random Generated unsorted array is: ");
            DemoHelpers.PrintArray(randNums);

            //sorting the array into ascending order, calling RecursiveSort from Method class. 
            int[] sortedArray = SortHelpers.RecursiveSort(randNums, randNums.Length, 0);

            //printing the sorted array.
            Console.WriteLine("The sorted array using a recursive selection sort is: ");
            DemoHelpers.PrintArray(sortedArray);

            //calling the search functions.
            Console.WriteLine("\nThe recursive binary search");
            Console.WriteLine("\nThe number being recursively searched for is: " + numberToFind);
            int positionR = SearchHelpers.RecursiveSearch(sortedArray, numberToFind);
            Console.WriteLine("The number " + numberToFind + " is at index: " + positionR + "\n");

            Console.WriteLine("The iterative binary search");
            Console.WriteLine("\nThe number being iteratively searched for is: " + numberToFind2);
            int positionI = SearchHelpers.BinarySearch(sortedArray, numberToFind2);
            Console.WriteLine("The number " + numberToFind2 + " is at index: " + positionI + "\n");
        
            //finding an unknown number within a set range. 
            Console.WriteLine("\nOverloaded iterative binary searches");
            Console.WriteLine("\nFinding a random number in range within index 2 -> index 6");
            int num1 = rnd.Next(100);
            int minN = 2;
            int maxN = 6;
            int rndPosition = SearchHelpers.BinarySearch(sortedArray, num1, minN, maxN);
            DemoHelpers.PrintResults(rndPosition, num1, minN, maxN);

            Console.WriteLine("\nOverloaded recursive binary search:");
            Console.WriteLine("\nFinding a random number in range index 3 -> index 7");
            int num2 = rnd.Next(100);
            int minN2 = 3;
            int maxN2 = 7;
            int rndPosition2 = SearchHelpers.RecursiveSearch(sortedArray, num2, minN2, maxN2);
            DemoHelpers.PrintResults(rndPosition2, num2, minN2, maxN2);

            //Console.WriteLine("testing parameters");
            //outside of range and below; expecting - 1 returned.
            //int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int pos = SearchHelpers.RecursiveSearch(array, 1, 3, 7);
            //DemoHelpers.PrintResults(pos, 1, 3, 7);

            //outside of range and above; expecting - 1 returned.
            //int[] array2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int pos2 = SearchHelpers.RecursiveSearch(array, 9, 3, 7);
            //DemoHelpers.PrintResults(pos, 9, 3, 7);

            Console.ReadKey();
        }
    }
}
