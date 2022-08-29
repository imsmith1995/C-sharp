using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAX
{
    internal class Student
    {   //Properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    
        //Methods
        public string Fullname ()
        {
            return Firstname + " " + Lastname;
        }
    }


}
