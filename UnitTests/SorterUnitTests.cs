/******************************************************************************
* Filename    = SorterUnitTests.cs
*
* Author      = Neeraj Krishna N
*
* Product     = StrategyDesignPattern
* 
* Project     = UnitTests
*
* Description = Unit Tests for strategy design pattern
*****************************************************************************/

using SorterModule;
using SortingStrategy;

namespace UnitTests
{
    [TestClass]
    public class SorterUnitTests
    {
        [TestMethod]
        public void TestBubbleSortStrategy()
        {
            // Create a Sorter instance and set strategy to Bubble Sort
            var sorter = new Sorter();
            var strategy = new BubbleSortStrategy();
            sorter.SetSortingStrategy( strategy );

            int[] array = [9 , 7 , 5 , 3 , 1];

            // Sort the array
            string strategyUsed = sorter.Sort( array );

            // Assert the array is sorted and strategy used is correct
            CollectionAssert.AreEqual( new int[] { 1 , 3 , 5 , 7 , 9 } , array );
            Assert.AreEqual( strategyUsed , "BUBBLE_SORTED" );
        }

        [TestMethod]
        public void TestSelectionSortStrategy()
        {
            // Create a Sorter instance and set strategy to Selection Sort
            var sorter = new Sorter();
            var strategy = new SelectionSortStrategy();
            sorter.SetSortingStrategy( strategy );

            int[] array = [5 , 3 , 4 , 2 , 1];

            // Sort the array
            string strategyUsed = sorter.Sort( array );

            // Assert the array is sorted and strategy used is correct
            CollectionAssert.AreEqual( new int[] { 1 , 2 , 3 , 4 , 5 } , array );
            Assert.AreEqual( strategyUsed , "SELECTION_SORTED" );
        }

        [TestMethod]
        public void TestNoStrategy()
        {
            // Create a Sorter instance and set strategy to Selection Sort
            var sorter = new Sorter();

            int[] array = [5 , 3 , 4 , 2 , 1];

            // Sort the array
            string strategyUsed = sorter.Sort( array );

            // Assert the array is not sorted and it's the original array itself
            CollectionAssert.AreNotEqual( new int[] { 1 , 2 , 3 , 4 , 5 } , array );
            CollectionAssert.AreEqual( new int[] { 5 , 3 , 4 , 2 , 1 } , array );
            Assert.AreEqual( strategyUsed , "Unspecified Strategy" );
        }
    }
}
