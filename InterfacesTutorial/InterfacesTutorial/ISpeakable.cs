using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTutorial
{

    internal interface ISpeakable
    {
        public string AnimalType { get; set; }
        public void Speak();
        public void Scream()
        {
            Console.WriteLine($"{AnimalType} screams ");
            Speak();
        }
    }
}
