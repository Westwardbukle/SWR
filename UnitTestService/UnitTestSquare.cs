using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Services;

namespace UnitTestService
{
    [TestClass]
    class UnitTestSquare
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Square.SquareMethod(5,8,1), "Корень х1 =-1.4633249580710799, х2=-0.13667504192892005");
            Assert.AreEqual(Square.SquareMethod(5, 4, 1), "Корень х1 =-4");
            Assert.AreEqual(Square.SquareMethod(0, 4, 1), "Корней нет");
        }
    }
}
