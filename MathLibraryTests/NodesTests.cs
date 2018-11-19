using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibrary.Tests
{
    [TestClass()]
    public class NodesTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Nodes s = new Nodes();
            s.Add(156416);
            s.Add(235849857);
            string t = s.GetValue();
            Assert.AreEqual((156416 + 235849857).ToString(), t);
        }

        [TestMethod()]
        public void MultiplyTest1()
        {
            Nodes s = new Nodes();
            s.Add(9999);
            Nodes r = s.Multiply(9999);
            string t = r.GetValue();
            Assert.AreEqual("99980001", t);
        }

        [TestMethod()]
        public void MultiplyTest2()
        {
            Nodes s = new Nodes();
            s.Add(24);
            Nodes r = s.Multiply(5);
            string t = r.GetValue();
            Assert.AreEqual("120", t);
        }

        [TestMethod()]
        public void GetValue0Test()
        {
            Nodes s = new Nodes();
            s.Add(0);
            string t = s.GetValue();
            Assert.AreEqual("0", t);
        }

        [TestMethod()]
        public void GetValue1Test()
        {
            Nodes s = new Nodes();
            s.Add(1);
            string t = s.GetValue();
            Assert.AreEqual("1", t);
        }
        [TestMethod()]
        public void GetValue10Test()
        {
            Nodes s = new Nodes();
            s.Add(10);
            string t = s.GetValue();
            Assert.AreEqual("10", t);
        }
        [TestMethod()]
        public void FactorialTest()
        {
            Nodes s = new Nodes();
            s = s.Factorial(14);
            string t = s.GetValue();
            Assert.AreEqual("87178291200", t);
        }
    }
}