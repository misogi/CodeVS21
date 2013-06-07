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
    }
}
