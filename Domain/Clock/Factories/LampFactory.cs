using Clock.BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.BerlinClock
{
    /// <summary>
    /// Returns instances of lamps for berlim clock, that represents time intervals
    /// </summary>
    internal static class LampFactory
    {
        /// <summary>
        /// Returns a instance of lamp
        /// </summary>
        /// <param name="lampColour">The colour of lamp</param>
        /// <returns></returns>
        public static ILamp GetLamp(string lampColour)
        {
            return new Components.Lamp(lampColour);
        }
    }
}
