using System;
using NUnit.Framework;

namespace B.Common.Test {

    /// <summary />
    [TestFixture]
    public class DateTimeUtilityTest {

        /// <summary />
        [Test]
        public void EasterTest() {
            DateTime easter2008 = new DateTime(2008, 3, 23);
            DateTime easter1961 = new DateTime(1961, 4, 2);
            DateTime easter2007 = new DateTime(2007, 4, 8);

            Assert.AreEqual(easter2008, DateTimeUtility.CalculateEasterSunday(2008));
            Assert.AreEqual(easter1961, DateTimeUtility.CalculateEasterSunday(1961));
            Assert.AreEqual(easter2007, DateTimeUtility.CalculateEasterSunday(2007));
        }

        /// <summary />
        [Test]
        public void MaundyThursdayTest() {
            DateTime maundyThursday2008 = new DateTime(2008, 3, 20);
            Assert.AreEqual(DayOfWeek.Thursday, maundyThursday2008.DayOfWeek);
            Assert.AreEqual(maundyThursday2008, DateTimeUtility.GetMaundyThursday(2008));
        }

        /// <summary />
        [Test]
        public void GoodFridayTest() {
            DateTime goodFriday2008 = new DateTime(2008, 3, 21);
            Assert.AreEqual(DayOfWeek.Friday, goodFriday2008.DayOfWeek);
            Assert.AreEqual(goodFriday2008, DateTimeUtility.GetGoodFriday(2008));
        }

        /// <summary />
        [Test]
        public void PalmSundayTest() {
            DateTime palmSunday2008 = new DateTime(2008, 3, 16);
            Assert.AreEqual(DayOfWeek.Sunday, palmSunday2008.DayOfWeek);
            Assert.AreEqual(palmSunday2008, DateTimeUtility.GetPalmSunday(2008));
        }
        
        /// <summary />
        [Test]
        public void EasterMondayTest() {
            DateTime easterMonday2008 = new DateTime(2008, 3, 24);
            Assert.AreEqual(DayOfWeek.Monday, easterMonday2008.DayOfWeek);
            Assert.AreEqual(easterMonday2008, DateTimeUtility.GetEasterMonday(2008));
        }

        /// <summary />
        [Test]
        public void GreatPrayerDayTest() {
            DateTime greatPrayer2008 = new DateTime(2008, 4, 18);
            Assert.AreEqual(DayOfWeek.Friday, greatPrayer2008.DayOfWeek);
            Assert.AreEqual(greatPrayer2008, DateTimeUtility.GetGreatPrayerDay(2008));
        }

        /// <summary />
        [Test]
        public void AscensionDayTest() {
            DateTime ascension2008 = new DateTime(2008, 5, 1);
            Assert.AreEqual(DayOfWeek.Thursday, ascension2008.DayOfWeek);
            Assert.AreEqual(ascension2008, DateTimeUtility.GetAscensionDay(2008));
        }

        /// <summary />
        [Test]
        public void WhitSundayTest() {
            DateTime whitSunday2008 = new DateTime(2008, 5, 11);
            Assert.AreEqual(DayOfWeek.Sunday, whitSunday2008.DayOfWeek);
            Assert.AreEqual(whitSunday2008, DateTimeUtility.GetWhitSunday(2008));
        }

        /// <summary />
        [Test]
        public void WhitMondayTest() {
            DateTime whitMonday2008 = new DateTime(2008, 5, 12);
            Assert.AreEqual(DayOfWeek.Monday, whitMonday2008.DayOfWeek);
            Assert.AreEqual(whitMonday2008, DateTimeUtility.GetWhitMonday(2008));
        }

                /// <summary />
        [Test]
        public void AshWednesdayTest() {
            DateTime ashWednesday2008 = new DateTime(2008, 2, 6);
            DateTime ashWednesday2007 = new DateTime(2007, 2, 21);
            Assert.AreEqual(DayOfWeek.Wednesday, ashWednesday2008.DayOfWeek);
            Assert.AreEqual(DayOfWeek.Wednesday, ashWednesday2007.DayOfWeek);

            Assert.AreEqual(ashWednesday2008, DateTimeUtility.GetAshWednesday(2008));
            Assert.AreEqual(ashWednesday2007, DateTimeUtility.GetAshWednesday(2007));
        }

    }
}
