namespace Migs.Extensions
{
    /// <summary>
    /// Contains extension methods for DateTimes
    /// </summary>
    public static class DateTimeExt
    {
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
    }
}
