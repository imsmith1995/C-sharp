using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MAX
{
    public class MaxMathLibrary
    {
        public const decimal PI = 3.1415927m;

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
        public int Modulo(int a, int b)
        {
            return a - (a / b * b);
        }
    }
}