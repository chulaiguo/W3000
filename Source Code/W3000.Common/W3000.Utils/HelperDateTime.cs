namespace W3000.Utils
{
    public static class HelperDateTime
    {
        public static decimal CalculateHourSpan(string beginTime, string endTime)
        {
            int begin = TimeToMinute(beginTime);
            if (begin == -1)
                return 0;

            int end = TimeToMinute(endTime);
            if (end == -1)
                return 0;

            return CalculateHourSpan(begin, end);
        }

        public static decimal CalculateHourSpan(int begin, int end)
        {
            return begin > end ? ((24 * 60 - begin) + end) / 60M : (end - begin) / 60M;
        }

        public static int TimeToMinute(string time)
        {
            if (time.Length != 4)
                return -1;

            int hour;
            if (!int.TryParse(time.Substring(0, 2), out hour))
                return -1;

            if (hour < 0 || hour > 24)
                return -1;

            int minute;
            if (!int.TryParse(time.Substring(2), out minute))
                return -1;

            if (minute < 0 || minute > 59)
                return -1;

            if (hour == 24 && minute != 0)
                return -1;

            return hour*60 + minute;
        }

        public static bool IsInTimeRange(int hour, int minute, string beginTime, string endTime)
        {
            int benginNumber;
            if (!int.TryParse(beginTime, out benginNumber))
                return false;

            int endNumber;
            if (!int.TryParse(endTime, out endNumber))
                return false;

            int number = hour*100 + minute;
            return number >= benginNumber && number <= endNumber;
        }

        public static bool GetHourMinute(string time, ref int hour, ref int minute)
        {
            if (time.Length != 4)
                return false;

            if (!int.TryParse(time.Substring(0, 2), out hour))
                return false;

            if (hour < 0 || hour >= 24)
                return false;

            if (!int.TryParse(time.Substring(2), out minute))
                return false;

            if (minute < 0 || minute > 59)
                return false;

            return true;
        }
    }
}