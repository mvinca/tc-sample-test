using System;
using Xunit;

namespace DualUnitTest
{
    class XUnitTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(2+2,4);
        }
    }
}