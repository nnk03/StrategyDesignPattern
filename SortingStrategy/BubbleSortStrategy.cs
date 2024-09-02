using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStrategy
{
    public class BubbleSortStrategy : ISortingStrategy
    {
        public string Sort(int[] array)
        {
            int length = array.Length;

            for(int i = 0; i < length - 1; ++i)
            {
                for(int j = 0; j < length - i - 1; ++j)
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
