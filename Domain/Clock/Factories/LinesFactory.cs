using Clock.BerlinClock.Components;
using Clock.BerlinClock.Enumerations;
using Clock.BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.BerlinClock
{
    /// <summary>
    /// Represents a row of lamps in berlin clock
    /// </summary>
    public static class RowsFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowtype">Type of row</param>
        /// <returns>A row representation of berlin CLock with equivalent Lamp instances.</returns>
        internal static IRow GetRow(TimeInterval rowtype)
        {
            switch (rowtype)
            {
                case TimeInterval.Second:
                    {
                        return new Row(CreateSecondsRow(), TimeInterval.Second);
                    }
                case TimeInterval.FiveHours:
                    {
                        return new Row(CreateFiveHourRow(),TimeInterval.FiveHours);
                    }
                case TimeInterval.OneHour:
                    {
                        return new Row(CreateOneHourRow(), TimeInterval.OneHour);
                    }
                case TimeInterval.FiveMinutes:
                    {
                        return new Row(CreateFiveMinuteRow(), TimeInterval.FiveMinutes);
                    }
                case TimeInterval.OneMinute:
                    {
                        return new Row(CreateOneMinuteRow(), TimeInterval.OneMinute);
                    }
                default: return null;
            }
        }

        #region private methods
        private static List<ILamp> CreateSecondsRow()
        {
            var row = new List<ILamp>();

            row.Add(LampFactory.GetLamp( "Y"));
            return row;
        }
        private static List<ILamp> CreateFiveHourRow()
        {
            var row = new List<ILamp>();
            row.Add(LampFactory.GetLamp( "R"));
            row.Add(LampFactory.GetLamp( "R"));
            row.Add(LampFactory.GetLamp( "R"));
            row.Add(LampFactory.GetLamp( "R"));
            return row;
        }
        private static List<ILamp> CreateOneHourRow()
        {
            var row = new List<ILamp>();
            row.Add(LampFactory.GetLamp( "R"));
            row.Add(LampFactory.GetLamp( "R"));
            row.Add(LampFactory.GetLamp( "R"));
            row.Add(LampFactory.GetLamp( "R"));
            return row;
        }
        private static List<ILamp> CreateFiveMinuteRow()
        {
            var row = new List<ILamp>();
            row.Add(LampFactory.GetLamp( "Y"));
            row.Add(LampFactory.GetLamp( "Y"));
            row.Add(LampFactory.GetLamp( "R"));
            row.Add(LampFactory.GetLamp( "Y"));
            row.Add(LampFactory.GetLamp( "Y"));
            row.Add(LampFactory.GetLamp( "R"));
            row.Add(LampFactory.GetLamp( "Y"));
            row.Add(LampFactory.GetLamp( "Y"));
            row.Add(LampFactory.GetLamp( "R"));
            row.Add(LampFactory.GetLamp( "Y"));
            row.Add(LampFactory.GetLamp( "Y"));
            return row;
        }
        private static List<ILamp> CreateOneMinuteRow()
        {
            var row = new List<ILamp>();
            row.Add(LampFactory.GetLamp( "Y"));
            row.Add(LampFactory.GetLamp( "Y"));
            row.Add(LampFactory.GetLamp( "Y"));
            row.Add(LampFactory.GetLamp( "Y"));
            return row;
        }

        /// <summary>
        /// Converts a time component to it´s representation in seconds for easier calculation
        /// </summary>
        /// <param name="time">Time to be converted</param>
        /// <returns>time interval converted in seconds</returns>

        #endregion
    }
}
