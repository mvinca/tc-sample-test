﻿using NUnit.Framework;

namespace DualUnitTest
{
    [TestFixture]
    public class NUnitTests
    {
        [Test]
        public void NUnitTest1()
        {
            Assert.AreEqual(2 + 2, 4);
        }

        [Test]
        public void NUnitTest2()
        {
            Assert.AreEqual(2 * 2, 4);
        }
    }
}
