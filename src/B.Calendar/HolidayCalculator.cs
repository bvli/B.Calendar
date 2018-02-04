namespace B.Calendar
{
    using System;

    /// <summary>
    /// Calculates Christian holidays based on the Gregorian calendar.
    /// </summary>
    public class HolidayCalculator
    {
        /// <summary>
        /// Gets the carnival sunday
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        public DateTime GetCarnival(int year)
        {
            if (0 > year || year > DateTime.MaxValue.Year)
            {
                throw new ArgumentOutOfRangeException(nameof(year));
            }

            return CalculateEasterSunday(year).AddDays(-49);
        }

        /// <summary>
        /// Gets the palm sunday of the specified <paramref name="year"/>.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        /// <remarks>Sunday before Easter.</remarks>
        public DateTime GetPalmSunday(int year)
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
        public DateTime GetMaundyThursday(int year)
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
        public DateTime GetGoodFriday(int year)
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
        public DateTime GetEasterMonday(int year)
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
        public DateTime GetGreatPrayerDay(int year)
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
        public DateTime GetAscensionDay(int year)
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
        public DateTime GetWhitSunday(int year)
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
        public DateTime GetWhitMonday(int year)
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
        public DateTime GetAshWednesday(int year)
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
        public DateTime CalculateEasterSunday(int year)
        {
            if (0 > year || year > DateTime.MaxValue.Year)
            {
                throw new ArgumentOutOfRangeException(nameof(year));
            }

            var a = year % 19;
            var b = year / 100;
            var c = year % 100;
            var d = b / 4;
            var e = b % 4;
            var f = (b + 8) / 25;
            var g = (b - f + 1) / 3;
            var h = (19 * a + b - d - g + 15) % 30;
            var i = c / 4;
            var k = c % 4;
            var l = (32 + 2 * e + 2 * i - h - k) % 7;
            var m = (a + 11 * h + 22 * l) / 451;
            var month = (h + l - 7 * m + 114) / 31;
            var day = ((h + l - 7 * m + 114) % 31) + 1;

            return new DateTime(year, month, day).Date;
        }
    }
}
