using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHelpersLibrary
{
    public static class ArrayHelpers
    {
        // SwapInts takes in an array and two positions. The method will swap the values for the two.
        public static void SwapInts(int[] arr, int firstIndexPosition, int secondIndexPosition)
        {
            // Store the first element's index
            int tempArr = arr[firstIndexPosition];

            // Assign the first index to the second index
            arr[firstIndexPosition] = arr[secondIndexPosition];

            // Assigns the second index to the first index temp position
            arr[secondIndexPosition] = tempArr;
        }

        // Check if two arrays are equal. If they have the same number of elements and values of those elements.
        // Generic type <T> can pass any two arrays of the same type.
        public static bool CheckArrayEquality<T>(T[] firstArr, T[] secondArr)
        {
            return Enumerable.SequenceEqual(firstArr, secondArr);
        }

    }
}
