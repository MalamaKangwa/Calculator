using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class MultiplyTests
    {
        private readonly int a = 10;
        private readonly int b = 20;
        private readonly double c = 1.5;
        private readonly double d = 2.5;
        private readonly double[] arrayA = { 2.0, 2.5, 3.5, 4 };
        private readonly int[] arrayB = { 1, 2, 3, 4 };


        [TestMethod()]
        public void ProductTest()
        {
            Assert.AreEqual(200, Multiply.Product(a, b));
        }

        [TestMethod()]
        public void ProductDoubleTest()
        {
            Assert.AreEqual(3.75, Multiply.Product(c, d));
        }

        [TestMethod()]
        public void ProductDoubleArrayTest()
        {
            Assert.AreEqual(70, Multiply.Product(arrayA));
        }

        [TestMethod()]
        public void ProductIntArrayTest()
        {
            Assert.AreEqual(24, Multiply.Product(arrayB));
        }
    }
}