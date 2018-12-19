using System;
using betRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace betRaceUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 obj = new Form1();
            int total  = obj.Cash1 + obj.Cash2 + obj.Cash3;
            
            Assert.AreEqual(obj.maxBetPrice , total);
        }
    }
}
