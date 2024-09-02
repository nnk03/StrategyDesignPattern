/******************************************************************************
* Filename    = ISortingStrategy.cs
*
* Author      = Neeraj Krishna N
*
* Product     = StrategyDesignPattern
* 
* Project     = SortingStrategy
*
* Description = Interface for Sorting Strategy
*****************************************************************************/

namespace SortingStrategy
{
    /// <summary>
    /// Defines an interface for sorting strategy for sorting an array of integers.
    /// </summary>
    public interface ISortingStrategy
    {
        /// <summary>
        /// Sorts the given array using a specific sorting strategy.
        /// </summary>
        /// <param name="array">The array of integers to be sorted.</param>
        /// <returns>A string indicating the type of sorting strategy used.</returns>
        public string Sort( int[] array );
    }
}
