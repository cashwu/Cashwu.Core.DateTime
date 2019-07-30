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

        /// <summary>
        /// Returns the length of the month, taking account of the year.
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        public static int LengthOfMonth(this DateTime current)
        {
            return DateTime.DaysInMonth(current.Year, current.Month);
        }

        /// <summary>
        /// Combines this DateTime with a day-of-month to create a DateTime.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="dayOfMonth"></param>
        /// <returns></returns>
        public static DateTime AtDay(this DateTime current, int dayOfMonth)
        {
            return new DateTime(current.Year, current.Month, dayOfMonth, current.Hour, current.Minute, current.Second, current.Millisecond);
        }

        /// <summary>
        /// Returns a copy of this DateTime with the month-of-year altered.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static DateTime WithMonth(this DateTime current, int month)
        {
            return new DateTime(current.Year, month, current.Day, current.Hour, current.Minute, current.Second, current.Millisecond);
        }
    }
}