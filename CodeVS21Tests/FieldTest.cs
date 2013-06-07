using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeVS21Tests
{
    using CodeVS21;
    [TestClass]
    public class FieldTest
    {
        [TestMethod]
        public void NewField()
        {
            var f = new Field(3, 2);
            Assert.IsNotNull(f);
        }
    }
}
