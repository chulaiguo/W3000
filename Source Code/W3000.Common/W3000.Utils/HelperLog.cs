using System;
using System.Collections.Generic;

namespace W3000.Utils
{
    public static class HelperLog
    {
        public static string GetSplitByMonthTable(string tableName, int year, int month)
        {
            string suffix = GetSplitByMonthSuffix(year, month);
            return string.Format("{0}_{1}", tableName, suffix);
        }

        public static string GetSplitByMonthTable(string tableName, string suffix)
        {
            return string.Format("{0}_{1}", tableName, suffix);
        }

        public static string GetSplitByMonthSuffix(int year, int month)
        {
            return string.Format("{0}_{1:d2}", year, month);
        }

        public static string GetSplitByYearTable(string tableName, int year)
        {
            return string.Format("{0}_{1}", tableName, year);
        }

        public static SortedList<DateTime, DateTime> SplitByMonth(DateTime begin, DateTime end)
        {
            SortedList<DateTime, DateTime> list = new SortedList<DateTime, DateTime>();

            DateTime tempBegin = begin;
            int days = DateTime.DaysInMonth(tempBegin.Year, tempBegin.Month);
            DateTime tempEnd = new DateTime(tempBegin.Year, tempBegin.Month, days, 23, 59, 59, 999);

            while (tempEnd < end)
            {
                list.Add(tempBegin, tempEnd);

                tempBegin = tempEnd.AddMilliseconds(1);
                days = DateTime.DaysInMonth(tempBegin.Year, tempBegin.Month);
                tempEnd = new DateTime(tempBegin.Year, tempBegin.Month, days, 23, 59, 59, 999);
            }

            list.Add(tempBegin, end);
            return list;
        }

        public static SortedList<DateTime, DateTime> SplitByYear(DateTime begin, DateTime end)
        {
            SortedList<DateTime, DateTime> list = new SortedList<DateTime, DateTime>();

            DateTime tempBegin = begin;
            int days = DateTime.DaysInMonth(tempBegin.Year, 12);
            DateTime tempEnd = new DateTime(tempBegin.Year, 12, days, 23, 59, 59, 999);

            while (tempEnd < end)
            {
                list.Add(tempBegin, tempEnd);

                tempBegin = tempEnd.AddMilliseconds(1);
                days = DateTime.DaysInMonth(tempBegin.Year, 12);
                tempEnd = new DateTime(tempBegin.Year, 12, days, 23, 59, 59, 999);
            }

            list.Add(tempBegin, end);
            return list;
        }
    }
}
