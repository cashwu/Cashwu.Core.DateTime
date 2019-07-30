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
    }
}