using MyCoreApp;
using System;
using Xunit;

namespace XUnitTestProjectTests
{
    public class NumberGeneratorTest
    {
        [Fact]
        public void Test()
        {
            var n = new NumberGenerator(1000);
            var numbers = n.ProduceNumbers().ToList();
            Assert.Equal(10, numbers.Count);
        }
    }
}
