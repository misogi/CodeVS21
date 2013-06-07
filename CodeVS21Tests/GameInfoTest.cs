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
        }
    }
}
