using Clock.BerlinClock.Enumerations;
using System.Collections.Generic;

namespace Clock.BerlinClock.Interfaces
{
    /// <summary>
    /// Represents a row on Berlin Clock
    /// </summary>
    internal interface IRow
    {
        /// <summary>
        /// A collection of lamps in this row
        /// </summary>
        List<ILamp> Lamps { get; set; }
        /// <summary>
        /// The time interval which a lamp represents
        /// </summary>
        TimeInterval TimeInterval { get; }
    }
}