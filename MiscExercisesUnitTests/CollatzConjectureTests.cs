using System;
using MiscExercises;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiscExercisesUnitTests
{
    [TestClass]
    public class CollatzConjectureTests
    {
        CollatzConjecture Conjecture;

        [TestMethod]
        public void DefaultConstructorCreatesThreeElementList()
        {
            Conjecture = new CollatzConjecture();

            Assert.AreEqual(1, Conjecture.Sequence.Count);
        }

        [TestMethod]
        public void DefaultConstructorValues()
        {
            Conjecture = new CollatzConjecture();
            List<long> CompareList = new List<long> { 4, 2, 1 };

            Assert.AreEqual(true, CompareList.Equals(Conjecture));
        }

        [TestMethod]
        public void CalculatedResults()
        {
            Conjecture = new CollatzConjecture(6);
            List<long> CompareList = new List<long> { 6, 3, 10, 5, 16, 8, 4, 2, 1 };

            Assert.AreEqual(true, CompareList.Equals(Conjecture));
        }
    }
}
