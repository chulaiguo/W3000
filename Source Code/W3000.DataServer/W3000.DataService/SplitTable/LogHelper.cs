using System.Collections.Generic;
using W3000.Data;

namespace W3000.DataService.SplitTable
{
    internal static class LogHelper
    {
        public static SortedList<string, LogRange> GetLogTables(LogRowsCountDataCollection list, int pageIndex, int pageSize)
        {
            SortedList<int, LogRowsCountData> logIndex = new SortedList<int, LogRowsCountData>();
            foreach (LogRowsCountData item in list)
            {
                if (logIndex.ContainsKey(item.SequenceID))
                    continue;

                logIndex.Add(item.SequenceID, item);
            }

            int begin = 0;
            int end = 0;
            SortedList<string, LogRange> rangeIndex = new SortedList<string, LogRange>();
            foreach (KeyValuePair<int, LogRowsCountData> pair in logIndex)
            {
                begin = end + 1;
                end = begin + pair.Value.RowsCount - 1;

                rangeIndex.Add(pair.Value.DBTableName, new LogRange(pair.Value.DBTableName, begin, end));
            }


            int pageBegin = pageIndex * pageSize + 1;
            int pageEnd = (pageIndex + 1) * pageSize;
            SortedList<string, LogRange> retIndex = new SortedList<string, LogRange>();
            for (int i = pageBegin; i <= pageEnd; i++)
            {
                LogRange range = GetLogTable(rangeIndex, i);
                if (range == null)
                    continue;

                if (!retIndex.ContainsKey(range.DBTableName))
                {
                    LogRange data = new LogRange(range.DBTableName);
                    data.Begin = i - range.Begin + 1;
                    data.End = data.Begin;
                    retIndex.Add(range.DBTableName, data);
                }
                else
                {
                    retIndex[range.DBTableName].End++;
                }
            }

            return retIndex;
        }

        private static LogRange GetLogTable(SortedList<string, LogRange> rangeIndex, int index)
        {
            foreach (KeyValuePair<string, LogRange> pair in rangeIndex)
            {
                if (index >= pair.Value.Begin && index <= pair.Value.End)
                {
                    return pair.Value;
                }
            }

            return null;
        }
    }

    internal class LogRange
    {
        private readonly string _dbTableName = string.Empty;
        private int _begin = 0;
        private int _end = 0;

        public LogRange(string dbTableName)
        {
            this._dbTableName = dbTableName;
        }

        public LogRange(string dbTableName, int begin, int end)
        {
            this._dbTableName = dbTableName;
            this.Begin = begin;
            this.End = end;
        }

        public string DBTableName
        {
            get { return _dbTableName; }
        }

        public int Begin
        {
            get { return _begin; }
            set { _begin = value; }
        }

        public int End
        {
            get { return _end; }
            set { _end = value; }
        }
    }
}
