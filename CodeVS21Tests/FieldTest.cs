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
            Assert.AreEqual(f.ValueOfCell(0, 0), 0);
            Assert.AreEqual(f.ValueOfCell(0, 1), 0);
            Assert.AreEqual(f.ValueOfCell(1, 0), 0);
        }
    }
}
