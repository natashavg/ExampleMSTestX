using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestX
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Simple Tests 1")]
        public void TestMethod1A()
        {
            Assert.IsTrue(true);
        }
    }
}
