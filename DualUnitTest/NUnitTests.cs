using NUnit.Framework;

namespace DualUnitTest
{
    [TestFixture]
    class NUnitTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(2 + 2, 4);
        }
    }
}
