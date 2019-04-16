using System;

namespace Angle
{
    /// <summary>
    /// Provides method to measure angle between clock arrows 
    /// </summary>
    public class Measurer
    {
        private readonly int minutesInCicle = 60;
        private readonly int angleTotal = 360;
        private readonly int hoursInCicle = 12;

        /// <summary>
        /// Measure angle between clock arrows.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when minutes or hours have invalid value</exception>
        /// <param name="hour">Amount of hours to measure.</param>
        /// <param name="minutes">Amount of minutes to measure.</param>
        /// <returns>Angle between arrows in degrees.</returns>
        public int MeasureAngle(int hour, int minutes)
        {
            CheckInputData(hour, minutes);

            double angleHour = (double)angleTotal / (hoursInCicle * minutesInCicle) * (hour * minutesInCicle + minutes);
            int angleMinute = (angleTotal / minutesInCicle) * minutes;

            int result = Math.Abs((int)angleHour - angleMinute);

            return result > 180 ? 360 - result : result;
        }

        private void CheckInputData(int hour, int minutes)
        {
            if (hour > hoursInCicle * 2 || hour < 0)
            {
                throw new ArgumentException($"Amount of {nameof(hour)} has incorrect value.");
            }

            if (minutes > minutesInCicle || minutes < 0)
            {
                throw new ArgumentException($"Amount of {nameof(minutes)} has incorrect value.");
            }
        }
    }
}
