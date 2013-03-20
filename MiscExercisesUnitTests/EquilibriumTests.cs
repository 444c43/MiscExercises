using System;
using MiscExercises.EquilibriumIndices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiscExercisesUnitTests
{
    [TestClass]
    public class EquilibriumTests
    {
        [TestMethod]
        public void TestResult()
        {
            int[] TestArray = new int[] { -7, 1, 5, 2, -4, 3, 0 };
            int Result = Equilibrium.FindFirst(TestArray);

            Assert.AreEqual(Result, 3);
        }
    }
}
