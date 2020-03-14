using Clock.BerlinClock.Enumerations;
using Clock.BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.BerlinClock.Components
{
    internal class Row : IRow
    {
        public List<ILamp> Lamps { get; set; }
        public TimeInterval TimeInterval { get; }
       
        public Row(List<ILamp> lamps, TimeInterval timeInterval)
        {
            Lamps = lamps;
            TimeInterval = timeInterval;
        }
    }
}
