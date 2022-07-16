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
        static void SwapInts(int[] arr, int firstIndexPosition, int secondIndexPosition)
        {
            // Store the first element's index
            int tempArr = arr[firstIndexPosition];

            // Assign the first index to the second index
            arr[firstIndexPosition] = arr[secondIndexPosition];

            // Assigns the second index to the first index temp position
            arr[secondIndexPosition] = tempArr;
        }
    }
}
