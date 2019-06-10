using System;
using Xunit;
using MyCoreApp;
using System.Linq;

namespace XUnitTestProject
{
    public class NumberGeneratorTest
    {
        [Fact]
        public void Test() {
            var n = new NumberGenerator(1000);
            var numbers = n.ProduceNumbers().ToList();
            Assert.Equal(10, numbers.Count);
        }
    }
}
