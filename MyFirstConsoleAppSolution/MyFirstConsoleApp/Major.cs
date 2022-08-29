using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAX
{
    internal class Major
    {   //Properties
        public string Code { get; set; }
        public string Description { get; set; }
        public int MinSAT { get; set; }

        //Methods
        public void Print()
        {   string message = $"{Code}\t{ Description}\t{MinSAT}";
            System.Console.WriteLine(message);
        }
    }
}
