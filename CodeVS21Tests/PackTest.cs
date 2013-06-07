using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeVS21Tests
{
    using CodeVS21;
    [TestClass]
    public class PackTest
    {
        [TestMethod]
        public void NewPackTest()
        {
            var vals = new string[] { "0 0 0 0", "0 0 2 0", "0 1 3 0", "0 1 2 0" };
            var p = new Pack(4, vals);
            Assert.IsNotNull(p);
        }

        [TestMethod]
        public void DropLineTest()
        {
            var vals = new string[] { "0 2 0 0", "0 0 2 0", "0 1 3 0", "0 4 2 0" };
            var p = new Pack(4, vals);
            var line = p.DropLine(0);
            Assert.AreEqual(0, line.Count);
            line = p.DropLine(1);
            Assert.AreEqual(4, line[0]);
            Assert.AreEqual(1, line[1]);
            Assert.AreEqual(2, line[2]);
        }
    }
}
