using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAX;

namespace TestMaxMathLibrary
{
    public class TestModulo
    {
        MaxMathLibrary mathlib;
        
        public TestModulo()
        {
            mathlib = new MaxMathLibrary();

        }
        [Theory]
        [InlineData(10, 2, 0)]
        [InlineData(5, 2, 1)]
        public void TestModulos(int a, int b, int expected)
        {
            Assert.Equal(expected, mathlib.Modulo(a, b));
        }
    }
}
