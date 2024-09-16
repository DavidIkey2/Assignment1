using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeEnrolment1
{
    public class Utility
    {
        /// <summary>
        /// Linear Search Array T
        /// </summary>
        /// <typeparam name="T">T variable type</typeparam>
        /// <param name="array">the array to search</param>
        /// <param name="target">what you are searching for</param>
        /// <returns>index if found or -1 if not found</returns>
        public static int LinearSearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int i = 0;
            bool found = false;
            while (!found && i < array.Length) // while not found and not end of array
            {
                if (target.CompareTo(array[i]) == 0)
                    found = true;
                else
                    i++; // if no match move to next element in array
            }
            if (i < array.Length)
                return i; //return index of array element found
            else
                return -1; //return -1 if not found
        }
        /// <summary>
        /// Binary Search Array T
        /// </summary>
        /// <typeparam name="T">T variable type</typeparam>
        /// <param name="array">the array to search</param>
        /// <param name="target">what you are searching for</param>
        /// <returns>index if found of -1 if not found</returns>
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int min = 0;
            int max = array.Length - 1;
            int mid;
            do
            {
                mid = (min + max) / 2;
                if (target.CompareTo(array[mid]) == 0) //if the item is found return index mid
                    return mid;
                if (target.CompareTo(array[mid]) > 0) //check if the item wanted is in the top half of the search
                    min = mid + 1; //the item must be in the upper half, set the min for the search to start at mid +1
                else
                    max = mid - 1; //otherwise the item must be in the lower half, set max to the mid-s
            }
            while (min <= max);
            return -1; // -1 is return when not found
        }
        /// <summary>
        /// Bubble Sort in Ascending Order
        /// </summary>
        /// <typeparam name="T">T variable type</typeparam>
        /// <param name="myArray">the array you are sorting</param>
        public static void BubbleSortAsc<T>(T[] myArray) where T : IComparable<T>
        {                        
            // outer loop
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                //inner loop
                for (int j = 0; j < myArray.Length - 1; j++)
                {
                    //compare element
                    if (myArray[j].CompareTo(myArray[j+ 1]) > 0)
                    {   //swap the numbers
                        T temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j +1] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// Bubble Sort in Descending Order
        /// </summary>
        /// <typeparam name="T">T variable type</typeparam>
        /// <param name="myArray">the array you are sorting</param>
        public static void BubbleSortDes<T>(T[] myArray) where T : IComparable<T>
        {
            // outer loop
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                //inner loop
                for (int j = 0; j < myArray.Length - 1; j++)
                {
                    //compare element
                    if (myArray[j].CompareTo(myArray[j + 1]) < 0)
                    {   //swap the numbers
                        T temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;
                    }
                }
            }
        }
    }
}
