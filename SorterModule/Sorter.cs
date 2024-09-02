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
    public class Sorter
    {
        public ISortingStrategy? _sortingStrategy;

        public void SetSortingStrategy(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        public string Sort(int[] array )
        {
            if(_sortingStrategy == null)
            {
                return "Unspecified Strategy";
            }

            return _sortingStrategy.Sort(array);
        }
    }
}
