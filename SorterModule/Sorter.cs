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

        public void Sort(int[] array )
        {
            if(_sortingStrategy == null)
            {
                Console.WriteLine( "Strategy Not Specified" );
                return;
            }

            _sortingStrategy.Sort(array);
        }
    }
}
