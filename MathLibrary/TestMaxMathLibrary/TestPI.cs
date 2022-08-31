using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAX;

namespace TestMaxMathLibrary
{
    public class TestPI
    {

        [Fact]
        public void TestPIValue()
        {
            Assert.Equal(3.1415927m, MaxMathLibrary.PI, 7);
        }
    }
}
