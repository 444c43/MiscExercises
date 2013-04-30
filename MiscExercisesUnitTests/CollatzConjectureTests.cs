using System;
using System.Linq;
using MiscExercises;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiscExercisesUnitTests
{
    [TestClass]
    public class CollatzConjectureTests
    {
        CollatzConjecture Conjecture;
        List<long> FirstCompareList = new List<long> 
            { 6, 3, 10, 5, 16, 8, 4, 2, 1 };
        List<long> SecondCompareList = new List<long> { 4, 2, 1 };

        [TestMethod]
        public void DefaultConstructorCreatesThreeElementList()
        {
            Conjecture = new CollatzConjecture();
            Assert.AreEqual(3, Conjecture.Sequence.Count);
        }

        [TestMethod]
        public void DefaultConstructorValues()
        {
            Conjecture = new CollatzConjecture();
            Assert.IsTrue(SecondCompareList.SequenceEqual(Conjecture.Sequence));
        }

        [TestMethod]
        public void CalculatedResults()
        {
            Conjecture = new CollatzConjecture(6);
            Assert.IsTrue(FirstCompareList.SequenceEqual(Conjecture.Sequence));
        }

        [TestMethod]
        public void TestReusability()
        {
            Conjecture = new CollatzConjecture(6);
            Conjecture.EnterNewSeedNumber(4);
            Assert.IsTrue(SecondCompareList.SequenceEqual(Conjecture.Sequence));
        }
    }
}
