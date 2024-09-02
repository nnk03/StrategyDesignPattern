/******************************************************************************
* Filename    = SelectionSortStrategy.cs
*
* Author      = Neeraj Krishna N
*
* Product     = StrategyDesignPattern
* 
* Project     = SortingStrategy
*
* Description = Implements Selection Sort Strategy
*****************************************************************************/

using System;

namespace SortingStrategy
{
    /// <summary>
    /// Implementation of the selection sort algorithm for sorting an array.
    /// </summary>
    public class SelectionSortStrategy : ISortingStrategy
    {
        /// <summary>
        /// Finds the index of the minimum value in the specified range of the array.
        /// </summary>
        /// <param name="array">The array to search within.</param>
        /// <param name="left">The starting index of the range.</param>
        /// <param name="right">The ending index of the range (inclusive).</param>
        /// <returns>The index of the minimum value within the specified range.</returns>
        private int FindMinValueIndex( int[] array , int left , int right )
        {
            int minValueIndex = left;
            int currentIndex = left;
            while (currentIndex <= right)
            {
                if (array[currentIndex] < array[minValueIndex])
                {
                    minValueIndex = currentIndex;
                }
                ++currentIndex;
            }

            return minValueIndex;
        }

        /// <summary>
        /// Sorts the given array using the selection sort algorithm.
        /// </summary>
        /// <param name="array">The array of integers to be sorted.</param>
        /// <returns>A string indicating that the array has been selection sorted.</returns>
        public string Sort( int[] array )
        {
            int length = array.Length;
            for (int i = 0; i < length; ++i)
            {
                int minValueIndex = FindMinValueIndex( array , i , length - 1 );
                (array[i], array[minValueIndex]) = (array[minValueIndex], array[i]);
            }

            return "SELECTION_SORTED";
        }
    }
}
