using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAX;

namespace TestMaxMathLibrary
{
    public class TestSubtract
    {
        MaxMathLibrary mathlib;

        public TestSubtract()
        {
            mathlib = new MaxMathLibrary();

        }
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(0, 0, 0)]
        [InlineData(-11, 10, -21)]
        public void TestSubtraction(int a, int b, int expected)
        {
            Assert.Equal(expected, mathlib.Subtract(a, b));

        }
    }
}

