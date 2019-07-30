using System;

namespace JavaLikeDateTime
{
    public static class JavaLikeDateTimeExtensions
    {
        /// <summary>
        /// Checks if this current DateTime is after the specified (other) DateTime.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static bool IsAfter(this DateTime current, DateTime other)
        {
            return current > other;
        }

        /// <summary>
        /// Checks if this current DateTime is before the specified (other) DateTime.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static bool IsBefore(this DateTime current, DateTime other)
        {
            return current < other;
        }

        /// <summary>
        /// Returns a DateTime at the end of the month.
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        public static DateTime AtEndOfMonth(this DateTime current)
        {
            var daysInMonth = DateTime.DaysInMonth(current.Year, current.Month);
            return new DateTime(current.Year, current.Month, daysInMonth, current.Hour, current.Minute, current.Second, current.Millisecond);
        }
    }
}