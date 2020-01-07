using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 100;
        private readonly int b = 20;
        private readonly double c = 30.5;
        private readonly double d = 20.5;
        private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07};
        private readonly int[] arrayB = {26, 7, 8, 5, 2 };


        [TestMethod()]
        public void DifferenceTest()
        {
            Assert.AreEqual(80, Subtraction.Difference(a, b));
        }

        [TestMethod()]
        public void DifferenceDoubleTest()
        {
            Assert.AreEqual(10, Subtraction.Difference(c, d));
        }

        [TestMethod()]
        public void DifferenceDoubleArrayTest()
        {
            Assert.AreEqual(-8.16, Subtraction.Difference(arrayA));
        }

        [TestMethod()]
        public void DifferenceIntArrayTest()
        {
            Assert.AreEqual(4, Subtraction.Difference(arrayB));
        }
    }
}