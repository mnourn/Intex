using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MathLibrary.Tests
{
    [TestClass()]
    public class NodesTests
    {        
        [TestMethod()]
        public void FactorialTest()
        {
            Factorial s = new Factorial();
            List<byte> result = s.GetFactorial(14);
            result.Reverse();
            string t = string.Join("", result);
            Assert.AreEqual("87178291200", t);
        }
    }
}