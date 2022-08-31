using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using MAX;

namespace TestMaxMathLibrary
{
    public class TestMultiply
    {
        MaxMathLibrary mathlib;

        public TestMultiply()
        {
            mathlib = new MaxMathLibrary();
        }
        [Theory]
        [InlineData (1, 2, 2)]
        [InlineData (3, 4, 12)]
        [InlineData (-5, 2, -10)]
        [InlineData (0, 100, 0)]
        public void TestMultiplion(int a, int b, int expected)
        {
            Assert.Equal(expected, mathlib.Multiply(a, b));
        }
    }
}
