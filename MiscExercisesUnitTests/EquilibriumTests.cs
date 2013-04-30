using System;
using MiscExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiscExercisesUnitTests
{
    [TestClass]
    public class EquilibriumTests
    {
        [TestMethod]
        public void TestEquilibriumFindsFirst()
        {
            int[] TestArray = new int[] { -7, 1, 5, 2, -4, 3, 0 };
            int Result = Equilibrium.FindFirstEquilibrium(TestArray);

            Assert.AreEqual(Result, 3);
        }
    }
}
