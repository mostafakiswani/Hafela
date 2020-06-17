using System;
using System.Collections.Generic;
using System.Text;
using DatabaseContext;
using Services;

namespace Services.Region
{
    public class RegionServices
    {
        static TimeZoneInfo timezone = TimeZoneInfo.FindSystemTimeZoneById(Settings.Configurations.RegionKey);

        public static DateTime CurrentDateTime()
        {
            return TimeZoneInfo.ConvertTime(DateTime.Now, timezone);
        }

        public static DateTime CurrentDate()
        {
            return TimeZoneInfo.ConvertTime(DateTime.Now, timezone).Date;
        }
    }
}
