/******************************************************************************
* Filename    = BubbleSortStrategy.cs
*
* Author      = Neeraj Krishna N
*
* Product     = StrategyDesignPattern
* 
* Project     = SortingStrategy
*
* Description = Implements Bubble Sort Strategy
*****************************************************************************/

using System;

namespace SortingStrategy
{
    /// <summary>
    /// Implementation of the bubble sort algorithm for sorting an array.
    /// </summary>
    public class BubbleSortStrategy : ISortingStrategy
    {
        /// <summary>
        /// Sorts the given array using the bubble sort algorithm.
        /// </summary>
        /// <param name="array">The array of integers to be sorted.</param>
        /// <returns>A string indicating that the array has been bubble sorted.</returns>
        public string Sort( int[] array )
        {
            int length = array.Length;

            for (int i = 0; i < length - 1; ++i)
            {
                for (int j = 0; j < length - i - 1; ++j)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    }
                }
            }

            return "BUBBLE_SORTED";
        }
    }
}
