using Clock.BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.BerlinClock.Components
{
    internal class Lamp : ILamp
    {
        private string lampColour;
        public string LampColour
        {
            get { return this.isSet ? this.lampColour : "O"; }
        }
        public bool isSet { get; set; }
        public Lamp(string lampColour)
        {
            this.lampColour = lampColour;
            this.isSet = false;
        }
    }
}
