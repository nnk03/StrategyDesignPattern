using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStrategy
{
    public class SelectionSortStrategy : ISortingStrategy
    {
        private int FindMinValueIndex(int[] array, int left, int right )
        {
            int minValueIndex = left;
            int currentIndex = left;
            while(currentIndex <= right)
            {
                if(array[minValueIndex] < array[currentIndex])
                {
                    minValueIndex = currentIndex;
                }
                ++currentIndex;
            }

            return minValueIndex;
        }
        public string Sort(int[] array )
        {
            int length = array.Length;
            for(int i = 0; i < length; ++i)
            {
                int minValueIndex = FindMinValueIndex( array , i , length - 1 );
                ( array[i], array[minValueIndex] ) = ( array[minValueIndex], array[i] );
            }

            return "SELECTION_SORTED";
        }
    }
}
