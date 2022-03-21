using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using System;

namespace UnitTestService
{
    [TestClass]
    public class UnitTestLine
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Line.LineMethod(10, 2), "Ответ -0,2");
            Assert.AreEqual(Line.LineMethod(8, 5), "Ответ -1,6");
        }
    }
}
