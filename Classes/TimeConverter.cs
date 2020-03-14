using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            var bc = new Clock.BerlinClock.BerlinClock();
            bc.SetTime(aTime);
            return bc.getLayout();
        }
    }
}

