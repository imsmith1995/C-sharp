using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTutorial
{
    internal class Parrot : ISpeakable
    {
        public string Color { get; set; }
        public string AnimalType { get; set; } = "Parrot";
        public void Speak()
        {
            Console.WriteLine("Squawk!");
        }
    }
}
