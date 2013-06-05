using System;
using FruitBasket;
using System.Linq;
using SortingAlgorithms;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiscExercisesUnitTests
{
    [TestClass]
    public class BubbleSortTests
    {
        List<int> ListToSort = new List<int> { 6, 5, 4, 3, 2, 1 };
        List<int> CompareList = new List<int> { 1, 2, 3, 4, 5, 6 };
        BubbleSort Sort;

        [TestMethod]
        public void TestSortResult()
        {
            Sort = new BubbleSort(ListToSort);

            Assert.IsTrue(CompareList.SequenceEqual(Sort.SortedList));
        }
    }
}
