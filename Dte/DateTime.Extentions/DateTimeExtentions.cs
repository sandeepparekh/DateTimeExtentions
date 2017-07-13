using System;
using System.Collections.Generic;

namespace Dte
{
    public static class DateTimeExtentions
    {
        public static long ToUnixTimeStamp(this DateTime dateTime)
        {
            return (long)(dateTime - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
        }

        public static List<DateTime> GetDaysOfWeek(this DateTime fromdate, DateTime endDate, DayOfWeek dayPOfWeek)
        {
            if (fromdate >= endDate) return new List<DateTime>();
            var result = new List<DateTime>();
            while (fromdate != endDate)
            {
                if (fromdate.DayOfWeek == dayPOfWeek)
                    result.Add(fromdate);
                fromdate = fromdate.AddDays(1);
            }
            return result;
        }

        public static DateTime AddUnixTimeStamp(this DateTime dateTime, long unixTimeStamp)
        {
            return dateTime.AddSeconds(unixTimeStamp);
        }

        public static bool IsLeapYear(this DateTime datetime)
        {
            if (datetime.Year % 4 != 0)
                return false;
            if (datetime.Year % 100 != 0)
                return true;
            if (datetime.Year % 400 != 0)
                return false;
            return true;
        }
    }
}
