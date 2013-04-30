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
        #region Test Fields
        CollatzConjecture Conjecture;
        List<long> ConjectureListSeed6 = new List<long> 
            { 6, 3, 10, 5, 16, 8, 4, 2, 1 };
        List<long> ConjectureListSeed4 = new List<long> { 4, 2, 1 };
        #endregion

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
            Assert.IsTrue(ConjectureListSeed4.SequenceEqual(Conjecture.Sequence));
        }

        [TestMethod]
        public void CalculatedResults()
        {
            Conjecture = new CollatzConjecture(6);
            Assert.IsTrue(ConjectureListSeed6.SequenceEqual(Conjecture.Sequence));
        }

        [TestMethod]
        public void TestReusability()
        {
            Conjecture = new CollatzConjecture(6);
            Conjecture.EnterNewSeedNumber(4);
            Assert.IsTrue(ConjectureListSeed4.SequenceEqual(Conjecture.Sequence));
        }
    }
}
