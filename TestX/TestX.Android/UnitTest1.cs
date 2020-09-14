using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestX
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Simple Tests 2")]
        public void TestMethod2B()
        {
            Assert.IsTrue(true);
        }
    }
}
