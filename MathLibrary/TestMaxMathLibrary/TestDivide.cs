using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAX;

namespace TestMaxMathLibrary
{
    public class TestDivide
    {
        MaxMathLibrary mathlib;

        public TestDivide()
        {
            mathlib = new MaxMathLibrary();
        }
        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(20, 4, 5)]
        [InlineData(-1, 2, -0.5)]
        [InlineData(10, 2, 5)]
        public void TestDivision(int a, int b, int expected)
        {
            Assert.Equal(expected, mathlib.Divide(a, b));
        }
    }
}
