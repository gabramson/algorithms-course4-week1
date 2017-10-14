using APSPMakerLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASPSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAPSPMaker()
        {
            var apspMaker = new APSPMaker();
            apspMaker.AddEdge(2, 1, 4);
            apspMaker.AddEdge(1, 3, -2);
            apspMaker.AddEdge(2, 3, 3);
            apspMaker.AddEdge(3, 4, 2);
            apspMaker.AddEdge(4, 2, -1);
            apspMaker.Execute();
            Assert.IsFalse(apspMaker.HasNegativeCycle);
            Assert.AreEqual(-2, apspMaker.MinPathLength);

        }
    }
}
