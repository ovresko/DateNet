using System;
using System.Collections.Generic;
using System.Text;

namespace DateNet.DateNetSource
{
    interface IDateNet
    {
        int DaysPassedFrom(DateTime date);
        int DaysPassedFrom(DateTime fromDate, DateTime toDate);
        int WeekPassedFrom(DateTime date);
        int WeekPassedFrom(DateTime StartDate, DateTime EndDate);

        DateTime DateAfterDays(int days);
        DateTime DateBeforeDays(int days);
        DateTime DateAfterTime(TimeSpan timeSpan);
        DateTime DateAfterWeeks(int weeks);
        IEnumerable<DateTime> DatesBetween(DateTime StartDate, DateTime EndDate);

        int DaysBefore(DateTime date);
        int DaysBefore(DateTime RefDate, DateTime date);

        int WeeksBefore(DateTime date);
        int WeeksBefore(DateTime RefDate, DateTime date);

        IEnumerable<DateTime> DistinctDates(IEnumerable<object> listObjects);


    }
}
