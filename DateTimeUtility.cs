using System;
using System.Diagnostics.CodeAnalysis;

using B.Common.Properties;

namespace B.Common
{
    /// <summary>
    /// Contains <see cref="DateTime"/> utility methods.
    /// </summary>
    public static class DateTimeUtility
    {
        /// <summary>
        /// Gets the week number of the specified date.
        /// </summary>
        /// <param path="year">The year.</param>
        /// <param path="month">The month.</param>
        /// <param path="day">The day.</param>
        /// <returns></returns>
        [SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow")]
        public static int WeekNumber(int year, int month, int day)
        {
            if (year > DateTime.MaxValue.Year)
            {
                throw new ArgumentException(Resources.DateTimeUtil_InvalidYear , "year");
            }
            if (month > DateTime.MaxValue.Month)
            {
                throw new ArgumentException(Resources.DateTimeUtil_InvalidMonth, "month");
            }
            if (day > DateTime.MaxValue.Day)
            {
                throw new ArgumentException(Resources.DateTimeUtil_InvalidDay, "day");
            }
            int a = (14 - month) / 12;
            int y = year + 4800 - a;
            int m = month + 12 * a - 3;
            int JD = day + (153 * m + 2) / 5 + 365 * y + y / 4 - y / 100 + y / 400 - 32045;
            int d4 = (((JD + 31741 - JD % 7) % 146097) % 36524) % 1461;
            int L = d4 / 1460;
            int d1 = ((d4 - L) % 365) + L;
            return d1 / 7 + 1;
        }

        /// <summary>
        /// Gets the week number of the specified date.
        /// </summary>
        /// <param path="date">The date.</param>
        /// <returns></returns>
        public static int WeekNumber(DateTime date)
        {
            DateTime dt = date.Date;
            return WeekNumber(dt.Year, dt.Month, dt.Day);
        }
    }
}
