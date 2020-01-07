using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly int a = 12;
        private readonly double b = 1.5;
        
        [TestMethod()]
        public void SquareTest()
        {
            Assert.AreEqual(144, Square.Squared(a));
        }

        [TestMethod()]
        public void SquareDoubleTest()
        {
            Assert.AreEqual(2.25, Square.Squared(b));
        }

    }
}