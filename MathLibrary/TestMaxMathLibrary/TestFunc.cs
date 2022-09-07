using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaxMathLibrary
{
    public class TestFunc
    {
        MAX.MaxMathLibrary mathlib;

        public TestFunc()
        {
            mathlib = new MAX.MaxMathLibrary();
        }
        //x^2 + 2x + 5 = ?
        [Theory]
        [InlineData(0, 5)]
        [InlineData(1, 8)]
        [InlineData(-1, 4)]
        [InlineData(-10, 85)]
        //[InlineData(-11, 0)]
        //[InlineData(10, 0)]
        [InlineData(9, 104)]
        public void TestFunction(int x, int expected)
        {
            Assert.Equal(expected, mathlib.Func(x));
            Assert.InRange<int>(x, -10, 9);
        }
    }
}
