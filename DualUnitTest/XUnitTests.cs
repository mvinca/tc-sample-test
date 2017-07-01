using System;
using Xunit;

namespace DualUnitTest
{
    internal class XUnitTests
    {
        [Fact]
        public void XUnitTest1()
        {
            Assert.Equal(2+2,4);
        }
    }
}