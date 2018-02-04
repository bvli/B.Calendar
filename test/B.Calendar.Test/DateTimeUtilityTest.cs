namespace B.Calendar.Test
{
    using System;
    using Xunit;

    public class DateTimeUtilityTest
    {
        [Fact]
        public void EasterTest() {
            var easter2008 = new DateTime(2008, 3, 23);
            var easter1961 = new DateTime(1961, 4, 2);
            var easter2007 = new DateTime(2007, 4, 8);

            Assert.Equal(easter2008, DateTimeUtility.CalculateEasterSunday(2008));
            Assert.Equal(easter1961, DateTimeUtility.CalculateEasterSunday(1961));
            Assert.Equal(easter2007, DateTimeUtility.CalculateEasterSunday(2007));
        }

        [Fact]
        public void CarnivalTest()
        {
            var carnival2008 = new DateTime(2008, 2, 3);
            Assert.Equal(carnival2008, DateTimeUtility.GetCarnival(2008));
        }

        [Fact]
        public void MaundyThursdayTest()
        {
            var maundyThursday2008 = new DateTime(2008, 3, 20);
            Assert.Equal(DayOfWeek.Thursday, maundyThursday2008.DayOfWeek);
            Assert.Equal(maundyThursday2008, DateTimeUtility.GetMaundyThursday(2008));
        }

        [Fact]
        public void GoodFridayTest()
        {
            var goodFriday2008 = new DateTime(2008, 3, 21);
            Assert.Equal(DayOfWeek.Friday, goodFriday2008.DayOfWeek);
            Assert.Equal(goodFriday2008, DateTimeUtility.GetGoodFriday(2008));
        }

        [Fact]
        public void PalmSundayTest()
        {
            var palmSunday2008 = new DateTime(2008, 3, 16);
            Assert.Equal(DayOfWeek.Sunday, palmSunday2008.DayOfWeek);
            Assert.Equal(palmSunday2008, DateTimeUtility.GetPalmSunday(2008));
        }

        [Fact]
        public void EasterMondayTest()
        {
            var easterMonday2008 = new DateTime(2008, 3, 24);
            Assert.Equal(DayOfWeek.Monday, easterMonday2008.DayOfWeek);
            Assert.Equal(easterMonday2008, DateTimeUtility.GetEasterMonday(2008));
        }

        [Fact]
        public void GreatPrayerDayTest()
        {
            var greatPrayer2008 = new DateTime(2008, 4, 18);
            Assert.Equal(DayOfWeek.Friday, greatPrayer2008.DayOfWeek);
            Assert.Equal(greatPrayer2008, DateTimeUtility.GetGreatPrayerDay(2008));
        }

        [Fact]
        public void AscensionDayTest()
        {
            var ascension2008 = new DateTime(2008, 5, 1);
            Assert.Equal(DayOfWeek.Thursday, ascension2008.DayOfWeek);
            Assert.Equal(ascension2008, DateTimeUtility.GetAscensionDay(2008));
        }

        [Fact]
        public void WhitSundayTest()
        {
            var whitSunday2008 = new DateTime(2008, 5, 11);
            Assert.Equal(DayOfWeek.Sunday, whitSunday2008.DayOfWeek);
            Assert.Equal(whitSunday2008, DateTimeUtility.GetWhitSunday(2008));
        }

        [Fact]
        public void WhitMondayTest()
        {
            var whitMonday2008 = new DateTime(2008, 5, 12);
            Assert.Equal(DayOfWeek.Monday, whitMonday2008.DayOfWeek);
            Assert.Equal(whitMonday2008, DateTimeUtility.GetWhitMonday(2008));
        }

        [Fact]
        public void AshWednesdayTest()
        {
            var ashWednesday2008 = new DateTime(2008, 2, 6);
            var ashWednesday2007 = new DateTime(2007, 2, 21);
            Assert.Equal(DayOfWeek.Wednesday, ashWednesday2008.DayOfWeek);
            Assert.Equal(DayOfWeek.Wednesday, ashWednesday2007.DayOfWeek);

            Assert.Equal(ashWednesday2008, DateTimeUtility.GetAshWednesday(2008));
            Assert.Equal(ashWednesday2007, DateTimeUtility.GetAshWednesday(2007));
        }
    }
}
