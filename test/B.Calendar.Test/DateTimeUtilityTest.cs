namespace B.Calendar.Test
{
    using System;
    using Xunit;

    public class DateTimeUtilityTest
    {
        [Fact]
        public void EasterTest() {
            DateTime easter2008 = new DateTime(2008, 3, 23);
            DateTime easter1961 = new DateTime(1961, 4, 2);
            DateTime easter2007 = new DateTime(2007, 4, 8);

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
            DateTime maundyThursday2008 = new DateTime(2008, 3, 20);
            Assert.Equal(DayOfWeek.Thursday, maundyThursday2008.DayOfWeek);
            Assert.Equal(maundyThursday2008, DateTimeUtility.GetMaundyThursday(2008));
        }

        [Fact]
        public void GoodFridayTest()
        {
            DateTime goodFriday2008 = new DateTime(2008, 3, 21);
            Assert.Equal(DayOfWeek.Friday, goodFriday2008.DayOfWeek);
            Assert.Equal(goodFriday2008, DateTimeUtility.GetGoodFriday(2008));
        }

        [Fact]
        public void PalmSundayTest()
        {
            DateTime palmSunday2008 = new DateTime(2008, 3, 16);
            Assert.Equal(DayOfWeek.Sunday, palmSunday2008.DayOfWeek);
            Assert.Equal(palmSunday2008, DateTimeUtility.GetPalmSunday(2008));
        }

        [Fact]
        public void EasterMondayTest()
        {
            DateTime easterMonday2008 = new DateTime(2008, 3, 24);
            Assert.Equal(DayOfWeek.Monday, easterMonday2008.DayOfWeek);
            Assert.Equal(easterMonday2008, DateTimeUtility.GetEasterMonday(2008));
        }

        [Fact]
        public void GreatPrayerDayTest()
        {
            DateTime greatPrayer2008 = new DateTime(2008, 4, 18);
            Assert.Equal(DayOfWeek.Friday, greatPrayer2008.DayOfWeek);
            Assert.Equal(greatPrayer2008, DateTimeUtility.GetGreatPrayerDay(2008));
        }

        [Fact]
        public void AscensionDayTest()
        {
            DateTime ascension2008 = new DateTime(2008, 5, 1);
            Assert.Equal(DayOfWeek.Thursday, ascension2008.DayOfWeek);
            Assert.Equal(ascension2008, DateTimeUtility.GetAscensionDay(2008));
        }

        [Fact]
        public void WhitSundayTest()
        {
            DateTime whitSunday2008 = new DateTime(2008, 5, 11);
            Assert.Equal(DayOfWeek.Sunday, whitSunday2008.DayOfWeek);
            Assert.Equal(whitSunday2008, DateTimeUtility.GetWhitSunday(2008));
        }

        [Fact]
        public void WhitMondayTest()
        {
            DateTime whitMonday2008 = new DateTime(2008, 5, 12);
            Assert.Equal(DayOfWeek.Monday, whitMonday2008.DayOfWeek);
            Assert.Equal(whitMonday2008, DateTimeUtility.GetWhitMonday(2008));
        }

        [Fact]
        public void AshWednesdayTest()
        {
            DateTime ashWednesday2008 = new DateTime(2008, 2, 6);
            DateTime ashWednesday2007 = new DateTime(2007, 2, 21);
            Assert.Equal(DayOfWeek.Wednesday, ashWednesday2008.DayOfWeek);
            Assert.Equal(DayOfWeek.Wednesday, ashWednesday2007.DayOfWeek);

            Assert.Equal(ashWednesday2008, DateTimeUtility.GetAshWednesday(2008));
            Assert.Equal(ashWednesday2007, DateTimeUtility.GetAshWednesday(2007));
        }
    }
}
