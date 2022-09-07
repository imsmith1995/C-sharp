using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Sqr : Rect
    {
        public override string Print()
        {
            return $"Side[{Side1}]";
        }
        public Sqr(int side) : base(side, side) 
        {
           
        }
    }
}
