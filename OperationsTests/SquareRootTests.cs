using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SquareRootTests
    {
        private readonly int a = 144;
        private readonly double b = 2.25;

        [TestMethod()]
        public void SquareRootTest()
        {
            Assert.AreEqual(12, SquareRoot.Root(a));
        }

        [TestMethod()]
        public void SquareRootDoubleTest()
        {
            Assert.AreEqual(1.5, SquareRoot.Root(b));
        }
    }
}