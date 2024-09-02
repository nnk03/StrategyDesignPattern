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
