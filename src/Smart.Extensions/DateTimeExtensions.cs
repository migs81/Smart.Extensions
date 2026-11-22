namespace Smart.Extensions
{
    /// <summary>
    /// Contains extension methods for DateTimes
    /// </summary>
    public static class DateTimeExtensions
    {
        #region Is
        
        /// <summary>
        /// Determines whether the specified date falls on a weekend (Saturday or Sunday).
        /// </summary>
        /// <param name="value">The date to check.</param>
        /// <returns><see langword="true"/> if the date falls on a Saturday or Sunday; otherwise, <see langword="false"/>.</returns>
        public static bool IsWeekend(this DateTime value) => value.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;

        /// <summary>
        /// Determines whether the specified date falls on a weekday (Monday through Friday).
        /// </summary>
        /// <param name="value">The date to check.</param>
        /// <returns><see langword="true"/> if the date falls on a weekday; otherwise, <see langword="false"/>.</returns>
        public static bool IsWeekday(this DateTime value) => value.DayOfWeek is not (DayOfWeek.Saturday or DayOfWeek.Sunday);

        /// <summary>
        /// Determines whether the specified date falls within the given date range, optionally including the time component.
        /// </summary>
        /// <param name="source">The date to check.</param>
        /// <param name="startDate">The start of the date range.</param>
        /// <param name="endDate">The end of the date range.</param>
        /// <param name="compareTime"><see langword="true"/> to compare both date and time; <see langword="false"/> to compare only the date component.</param>
        /// <returns><see langword="true"/> if the specified date falls within the range; otherwise, <see langword="false"/>.</returns>
        public static bool IsBetween(this DateTime source, DateTime startDate, DateTime endDate, bool compareTime = false) => compareTime
            ? source >= startDate && source <= endDate // compares date and time
            : source.Date >= startDate.Date && source.Date <= endDate.Date; // compares only the date
        
        /// <summary>
        /// Determines whether the specified date is the first day of its month.
        /// </summary>
        /// <param name="value">The date to check.</param>
        /// <returns><see langword="true"/> if the date is the first day of the month; otherwise, <see langword="false"/>.</returns>
        public static bool IsStartOfMonth(this DateTime value) => value.Day == 1;

        /// <summary>
        /// Determines whether the specified date is the last day of its month.
        /// </summary>
        /// <param name="value">The date to check.</param>
        /// <returns><see langword="true"/> if the date is the last day of the month; otherwise, <see langword="false"/>.</returns>
        public static bool IsEndOfMonth(this DateTime value) => value.Day == DateTime.DaysInMonth(value.Year, value.Month);
        
        #endregion
    }
}
