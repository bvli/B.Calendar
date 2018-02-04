namespace B.Calendar
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Contains <see cref="DateTime"/> utility methods.
    /// </summary>
    public static class DateTimeUtility
    {
        /// <summary>
        /// Gets the carnival sunday
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        public static DateTime GetCarnival(int year)
        {
            if (0 > year || year > DateTime.MaxValue.Year)
            {
                throw new ArgumentOutOfRangeException(nameof(year));
            }

            DateTime result = CalculateEasterSunday(year).AddDays(-49);
            Debug.Assert(result.DayOfWeek == DayOfWeek.Sunday);
            return result;
        }


        /// <summary>
        /// Gets the palm sunday of the specified <paramref name="year"/>.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        /// <remarks>Sunday before Easter.</remarks>
        public static DateTime GetPalmSunday(int year)
        {
            if (0 > year || year > DateTime.MaxValue.Year)
            {
                 throw new ArgumentOutOfRangeException(nameof(year));
            }

            return CalculateEasterSunday(year).AddDays(-7);
        }

        /// <summary>
        /// Gets the maundy thursday of the specified <paramref name="year"/>.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        /// <remarks>The Thursday before Easter; commemorates the Last Supper.</remarks>
        public static DateTime GetMaundyThursday(int year)
        {
            if (0 > year || year > DateTime.MaxValue.Year)
            {
                 throw new ArgumentOutOfRangeException(nameof(year));
            }

            return CalculateEasterSunday(year).AddDays(-3);
        }
        /// <summary>
        /// Gets the good friday of the specified <paramref name="year"/>.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        /// <remarks>Friday before Easter.</remarks>
        public static DateTime GetGoodFriday(int year)
        {
            if (0 > year || year > DateTime.MaxValue.Year)
            {
                 throw new ArgumentOutOfRangeException(nameof(year));
            }

            return GetMaundyThursday(year).AddDays(1);
        }

        /// <summary>
        /// Gets the easter monday of the specified <paramref name="year"/>.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static DateTime GetEasterMonday(int year)
        {
            if (0 > year || year > DateTime.MaxValue.Year)
            {
                 throw new ArgumentOutOfRangeException(nameof(year));
            }

            return CalculateEasterSunday(year).AddDays(1);
        }

        /// <summary>
        /// Gets the great prayer day of the specified <paramref name="year"/>.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        /// <remarks>This is a specific danish holyday.</remarks>
        public static DateTime GetGreatPrayerDay(int year)
        {
            if (0 > year || year > DateTime.MaxValue.Year)
            {
                 throw new ArgumentOutOfRangeException(nameof(year));
            }

            // fourth friday after easter.
            return CalculateEasterSunday(year).AddDays(5 + 3 * 7);
        }

        /// <summary>
        /// Gets the ascension day of the specified <paramref name="year"/>.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        /// <remarks>Celebration of the Ascension of Christ into heaven; observed on the 40th day after Easter</remarks>
        public static DateTime GetAscensionDay(int year)
        {
            if (0 > year || year > DateTime.MaxValue.Year)
            {
                 throw new ArgumentOutOfRangeException(nameof(year));
            }

            // sixth thursday after easter.
            return CalculateEasterSunday(year).AddDays(39);
        }

        /// <summary>
        /// Gets the whit sunday of the specified <paramref name="year"/>.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        /// <remarks>Seventh Sunday after Easter; commemorates the emanation of the Holy Spirit to the Apostles; a quarter day in Scotland.</remarks>
        public static DateTime GetWhitSunday(int year)
        {
            if (0 > year || year > DateTime.MaxValue.Year)
            {
                 throw new ArgumentOutOfRangeException(nameof(year));
            }

            return CalculateEasterSunday(year).AddDays(7 * 7);
        }

        /// <summary>
        /// Gets the whit monday of the specified <paramref name="year"/>.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        /// <remarks>The day after Whitsunday; a legal holiday in England and Wales and Ireland.</remarks>
        public static DateTime GetWhitMonday(int year)
        {
            if (0 > year || year > DateTime.MaxValue.Year)
            {
                 throw new ArgumentOutOfRangeException(nameof(year));
            }

            return GetWhitSunday(year).AddDays(1);
        }


        /// <summary>
        /// Gets ash wednesday.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        public static DateTime GetAshWednesday(int year)
        {
            if (0 > year || year > DateTime.MaxValue.Year)
            {
                 throw new ArgumentOutOfRangeException(nameof(year));
            }

            return CalculateEasterSunday(year).AddDays(-46);
        }

        /// <summary>
        /// Calculates easter sunday for the specified <paramref name="year"/>.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>The <see cref="DateTime">date</see> of easter sunday.</returns>
        /// <remarks>This method uses the algorithm specified in the wikipedia article: <a href="http://en.wikipedia.org/wiki/Computus">Computus</a>.</remarks>
        public static DateTime CalculateEasterSunday(int year)
        {
            if (0 > year || year > DateTime.MaxValue.Year)
            {
                 throw new ArgumentOutOfRangeException(nameof(year));
            }

            int a = year % 19;
            int b = year / 100;
            int c = year % 100;
            int d = b / 4;
            int e = b % 4;
            int f = (b + 8) / 25;
            int g = (b - f + 1) / 3;
            int h = (19 * a + b - d - g + 15) % 30;
            int i = c / 4;
            int k = c % 4;
            int l = (32 + 2 * e + 2 * i - h - k) % 7;
            int m = (a + 11 * h + 22 * l) / 451;
            int month = (h + l - 7 * m + 114) / 31;
            int day = ((h + l - 7 * m + 114) % 31) + 1;

            return new DateTime(year, month, day).Date;
        }
    }
}
