namespace Clock.BerlinClock.Interfaces
{
    /// <summary>
    /// Repesents a time unit on a berlin clock
    /// </summary>
    internal interface ILamp
    {
        /// <summary>
        /// colour of the lamp
        /// </summary>
        string LampColour { get; }
        
        /// <summary>
        /// Represents current status of lamp On/Off
        /// </summary>
        bool isSet { get; set; }
    }
}