using System;
using Xunit;

namespace DualUnitTest
{
    public class XUnitTests
    {
        [Fact]
        public void XUnitTest1()
        {
            Assert.Equal(2+2,4);
        }
    }
}