using CodeWars;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            var actual = Program.ComputeDepth(42);
            var expected = 9;
            //act
            Assert.Equal(expected, actual);
        }
    }
}
