namespace Smart.Extensions
{
    /// <summary>
    /// Contains extension methods for DateTimes
    /// </summary>
    public static class DateTimeExtensions
    {
        #region Is
        
        public static bool IsWeekend(this DateTime value) => value.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;

        public static bool IsWeekday(this DateTime value) => value.DayOfWeek is not (DayOfWeek.Saturday or DayOfWeek.Sunday);

        /// <summary>
        /// Returns true if the given DateTime is between the specified start and end DateTime.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="compareTime">Determines whether the time is taken into account</param>
        /// <returns></returns>
        public static bool IsBetween(this DateTime source, DateTime startDate, DateTime endDate, bool compareTime = false) => compareTime
            ? source >= startDate && source <= endDate // compares date and time
            : source.Date >= startDate.Date && source.Date <= endDate.Date; // compares only the date
        
        #endregion
    }
}
