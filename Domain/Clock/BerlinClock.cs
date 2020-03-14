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
    /// Represents a Berlin Clock, wich presents time base on rows of coloured lamps
    /// </summary>
    public class BerlinClock
    {
        /// <summary>
        /// Represents a collection of rows in Berlin clock.
        /// </summary>
        private List<IRow> Rows;

        private int timeInSeconds;

        /// <summary>
        /// Initializes a instance of a BerlinClock to represent 24h Hours at second-precision time.
        /// </summary>

        #region Constructor
        public BerlinClock()
        {
            Rows = new List<IRow>();
            Rows.Add(RowsFactory.GetRow(TimeInterval.Second));
            Rows.Add(RowsFactory.GetRow(TimeInterval.FiveHours));
            Rows.Add(RowsFactory.GetRow(TimeInterval.OneHour));
            Rows.Add(RowsFactory.GetRow(TimeInterval.FiveMinutes));
            Rows.Add(RowsFactory.GetRow(TimeInterval.OneMinute));
        }
        #endregion
        #region public methods
        public void SetTime(string time)
        {
            try
            {
                timeInSeconds = timeToSeconds(DateTime.Parse(time));
            }
            catch
            {
                timeInSeconds = 86402;
            }
            UpdateLayout(timeInSeconds);
        }

        public string getLayout()
        {
            StringBuilder layout = new StringBuilder();

            Rows.ForEach(
                row =>
                {
                    if (row.TimeInterval != TimeInterval.Second)
                        layout.AppendLine();
                    row.Lamps.ForEach(
                        lamp => layout.Append(lamp.LampColour));
                });
            return layout.ToString();
        }

        #endregion

        #region private methods
        private int timeToSeconds(DateTime time)
        {
            int timeInSeconds = 0;
            timeInSeconds += time.Hour * 3600;
            timeInSeconds += time.Minute * 60;
            timeInSeconds += time.Second;
            return timeInSeconds;
        }
        private void UpdateLayout(int timeInSeconds)
        {
            int LampsToTurnOn;
            int MaximumRowValue;
            foreach (var row in Rows)
            {
                MaximumRowValue = ((int)row.TimeInterval * row.Lamps.Count);
                if (row.TimeInterval == TimeInterval.Second)
                {
                    LampsToTurnOn = Math.Abs((timeInSeconds % 2) - 1);
                    timeInSeconds--;
                }
                else
                {
                    LampsToTurnOn = timeInSeconds / (int)row.TimeInterval;
                    timeInSeconds = timeInSeconds % (int)row.TimeInterval;
                }
                foreach (var lamp in row.Lamps)
                {
                    if (LampsToTurnOn == 0)
                        break;
                    lamp.isSet = true;
                    LampsToTurnOn--;
                }
            }
        }
        #endregion
    }


}
