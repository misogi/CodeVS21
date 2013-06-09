using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeVS21Tests
{
    using CodeVS21;
    [TestClass]
    public class FieldTest
    {
        [TestMethod]
        public void NewFieldTest()
        {
            var f = new Field(3, 2);
            Assert.IsNotNull(f);
        }

        [TestMethod]
        public void ValueOfCellTest()
        {
            var f = new Field(3, 2);
            Assert.AreEqual(0, f.ValueOfCell(0, 0));
            Assert.AreEqual(0, f.ValueOfCell(0, 1));
            Assert.AreEqual(0, f.ValueOfCell(1, 0));
        }

        [TestMethod]
        public void FallTest()
        {
            var f = new Field(8, 8);
            var vals = new string[4]
                           {
                               "1 2 3 4",
                               "2 0 3 0",
                               "3 0 0 1",
                               "0 0 0 1"
                           };
            var p = new Pack(4, vals);
            f.Fall(p, 0, 0);
            Assert.AreEqual(3, f.ValueOfCell(0, 0));
            Assert.AreEqual(2, f.ValueOfCell(0, 1));
            Assert.AreEqual(2, f.ValueOfCell(1, 0));
        }
    }
}
