using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTutorial
{
    internal class Frog : ISpeakable
    {
        public string Size { get; set; }
        public string AnimalType { get; set; } = "Frog";

        public void Speak()
        {
            Console.WriteLine("Ribbit");
        }
        public void Scream()
        {
            Console.WriteLine($"{AnimalType} screams 'Ribbit!!'");
        }
    }
}
