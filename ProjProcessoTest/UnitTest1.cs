using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjProcesso.Controllers;

namespace ProjProcessoTest
{
    [TestClass]
    public class UnitTest1
    {
        public IndexController Index = new IndexController();


        [TestMethod]
        public void TestMethodGet()
        {
            Assert.AreEqual(Index.Get(100, 5), "105,10");
        }

        [TestMethod]
        public void TestMethodShowMe()
        {
            Assert.AreEqual(Index.ShowMe(), "https://github.com/rogeriosoaresec");
        }
    }
}
