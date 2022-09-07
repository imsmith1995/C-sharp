using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PracticingCollections
{
    public class StateProperties
    {
        public string? AirQuality { get; set; }
        public int Population { get; set; }
        public int Economy { get; set; }
        public string? PersonalBias { get; set; }

        public virtual string CurrentStatus()
        {
            return $"The Air Quality is {AirQuality}. The Population is {Population}. The Economy is {Economy}. My personal bias is {PersonalBias}.";
        }

    }


}
