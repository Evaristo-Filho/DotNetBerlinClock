using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.BerlinClock.Enumerations
{
    /// <summary>
    /// A time interval for a lamp, with it´s representation in seconds
    /// </summary>
    public enum TimeInterval
    {
        Second = 1,
        FiveHours = 18000,
        OneHour = 3600,
        FiveMinutes = 300,
        OneMinute = 60
    }
}
