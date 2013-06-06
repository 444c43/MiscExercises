using System;
using FruitBasket;
using System.Linq;
using SortingAlgorithms;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiscExercisesUnitTests
{
    [TestClass]
    public class InsertionSortTests
    {
        List<int> ListToSort = new List<int> {
            12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        List<int> CompareList = new List<int> {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};

        InsertionSort Insertion;

        [TestMethod]
        public void TestSortResult()
        {
            Insertion = new InsertionSort(ListToSort);
            Insertion.SortList();

            Assert.IsTrue(CompareList.SequenceEqual(Insertion.SortedList));
        }
    }
}
