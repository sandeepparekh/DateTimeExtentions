using System;
using Dte;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.DateTime.Extentions
{
    [TestClass]
    public class DateTimeExtentions
    {
        [TestMethod]
        public void ToUnixTimeStamp()
        {
            var d = new System.DateTime(1970, 1, 1, 0, 0, 0);
            var dd = new System.DateTime(1970, 1, 2, 0, 0, 0);

            Assert.AreEqual(0, d.ToUnixTimeStamp());
            Assert.AreEqual(86400, dd.ToUnixTimeStamp());
        }

        [TestMethod]
        public void GetDaysOfWeek()
        {
            var fromDate = new System.DateTime(2017, 01, 2);
            var toDate = new System.DateTime(2017, 01, 8);
            var mondays = fromDate.GetDaysOfWeek(toDate, DayOfWeek.Monday);

            Assert.AreEqual(1, mondays.Count);
        }

        [TestMethod]
        public void AddUnixTimeStamp()
        {
            var d = new System.DateTime(2017, 01, 2);

            Assert.AreEqual(3, d.AddUnixTimeStamp(86400).Day);
        }

        [TestMethod]
        public void IsLeapYear()
        {
            var d = new System.DateTime(1904,01,01);
            Assert.AreEqual(true,d.IsLeapYear());

            d = new System.DateTime(1948, 01, 01);
            Assert.AreEqual(true, d.IsLeapYear());

            d = new System.DateTime(1996, 01, 01);
            Assert.AreEqual(true, d.IsLeapYear());

            d = new System.DateTime(2004, 01, 01);
            Assert.AreEqual(true, d.IsLeapYear());

            d = new System.DateTime(2002, 01, 01);
            Assert.AreEqual(false, d.IsLeapYear());

            d = new System.DateTime(2018, 01, 01);
            Assert.AreEqual(false, d.IsLeapYear());
        }
    }
}
