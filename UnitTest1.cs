using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MainBasic;
using System.Collections.Generic;
using System.Text;

namespace MainBasic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            CongThuc bm = new CongThuc();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {
            CongThuc bm = new CongThuc();
            double res = bm.Substract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            CongThuc bm = new CongThuc();
            double res = bm.divide(10, 5);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            CongThuc bm = new CongThuc();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }
}
