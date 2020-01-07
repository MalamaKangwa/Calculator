using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 100;
        private readonly int b = 20;
        private readonly double c = 10.5;
        private readonly double d = 2.5;
        private readonly double[] arrayA = { 20.0, 2.5, 3.5, 4 };
        private readonly int[] arrayB = { 16, 2, 2 };


        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(5, Division.Divide(a, b));
        }

        [TestMethod()]
        public void DivideDoubleTest()
        {
            Assert.AreEqual(4.2, Division.Divide(c, d));
        }

        [TestMethod()]
        public void DivideDoubleArrayTest()
        {
            Assert.AreEqual(0.5714285714285715, Division.Divide(arrayA));
        }

        [TestMethod()]
        public void DivideIntArrayTest()
        {
            Assert.AreEqual(4, Division.Divide(arrayB));
        }
    }
}

