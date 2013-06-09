using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeVS21Tests
{
    using CodeVS21;
    [TestClass]
    public class GameInfoTest
    {
        [TestMethod]
        public void NewGameInfo()
        {
            var g = new GameInfo("3 4 5 6 7");
            Assert.IsNotNull(g);
            Assert.AreEqual(g.Width,         3);
            Assert.AreEqual(g.Height,        4);
            Assert.AreEqual(g.LengthOfPack,  5);
            Assert.AreEqual(g.Sum,           6);
            Assert.AreEqual(g.NumberOfPacks, 7);
        }

        [TestMethod]
        public void ReadPacksTest()
        {
        }
    }
}
