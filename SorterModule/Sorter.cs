/******************************************************************************
* Filename    = Sorter.cs
*
* Author      = Neeraj Krishna N
*
* Product     = StrategyDesignPattern
* 
* Project     = SorterModule
*
* Description = Sorter Class which has an instance of strategy to be used
*****************************************************************************/

using SortingStrategy;

namespace SorterModule
{
    /// <summary>
    /// The Sorter class is responsible for sorting an array using a specified sorting strategy.
    /// </summary>
    public class Sorter
    {
        /// <summary>
        /// Holds the reference to the sorting strategy to be used.
        /// </summary>
        private ISortingStrategy? _sortingStrategy;

        /// <summary>
        /// Sets the sorting strategy to be used by the Sorter.
        /// </summary>
        /// <param name="sortingStrategy">The sorting strategy to be applied.</param>
        public void SetSortingStrategy( ISortingStrategy sortingStrategy )
        {
            _sortingStrategy = sortingStrategy;
        }

        /// <summary>
        /// Sorts the given array using the specified sorting strategy.
        /// </summary>
        /// <param name="array">The array of integers to be sorted.</param>
        /// <returns>
        /// A string representing the sorting strategy used or if no sorting strategy was specified then it returns "unspecified strategy"
        /// </returns>
        public string Sort( int[] array )
        {
            if (_sortingStrategy == null)
            {
                return "Unspecified Strategy";
            }

            return _sortingStrategy.Sort( array );
        }
    }
}
