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
            int timeInSeconds = 0;
            try
            {
                timeInSeconds = timeToSeconds(DateTime.Parse(aTime));
            }
            catch
            {
                timeInSeconds = 86402; // represents a day plus 2 seconds, since 24:00:00, since the hour 24:00 in invalid.
            }

            var result = generateLayout(timeInSeconds);
            var kk = result.ToString();
            return result.ToString();
        }



        /// <summary>
        /// Converts a time component to it´s representation in seconds for easy calculation
        /// </summary>
        /// <param name="time">Time to be converted</param>
        /// <returns>time interval converted in seconds</returns>
        private int timeToSeconds(DateTime time)
        {
            int timeInSeconds = 0;
            timeInSeconds += time.Hour * 3600;
            timeInSeconds += time.Minute * 60;
            timeInSeconds += time.Second;
            return timeInSeconds;
        }

        /// <summary>
        /// Generates Berlin clock representantion
        /// </summary>
        /// <param name="time">time in seconds</param>
        private StringBuilder generateLayout(int time)
        {

            var fiveHours = 18000;
            var oneHour = 3600;
            var fiveMinutes = 300;
            var oneMinute = 60;

            var result = new StringBuilder();

            EvaluateRow(ref time, 1, 1, result);
            EvaluateRow(ref time, fiveHours, 4, result);
            EvaluateRow(ref time, oneHour, 4, result);
            EvaluateRow(ref time, fiveMinutes, 11, result);
            EvaluateRow(ref time, oneMinute, 4, result, false);

            return result;
        }

        /// <summary>
        /// Evaluates row for Berlin clock, much like a minimum commom multiple algorithm.
        /// </summary>
        /// <param name="time">remaining time to be evaluated</param>
        /// <param name="interval">Time interval wich is represented by rows</param>
        /// <param name="cols">number of "cels" in each row</param>
        /// <param name="result">The result of evaluation after the step</param>
        /// <param name="newLine">Generates or not a new line after evaluation</param>
        private void EvaluateRow(ref int time, int interval, int cols, StringBuilder result, bool newLine = true)
        {
            if (interval == 1 && time % 2 == 0)
            {
                result.Append("Y");
                time--;
            }
            else
            {
                if (interval == 1)
                {
                    time--;
                    result.Append("O");
                }
                else
                {
                    var lamps = time / interval;
                    time = time % interval;

                    for (int i = 1; i <= cols; i++)
                    {
                        if (i <= lamps)
                        {
                            if ((i % 3 != 0 && cols == 11) || time < 60 && time != 1)
                                result.Append("Y");
                            else
                                result.Append("R");
                        }
                        else
                            result.Append("O");
                    }
                }
            }
            if (newLine)
                result.AppendLine();
        }
    }
}

