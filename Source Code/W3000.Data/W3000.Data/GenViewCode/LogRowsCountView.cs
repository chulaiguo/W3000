using System;

namespace W3000.Data
{
	[Serializable]
	public partial class LogRowsCountView
	{

		public LogRowsCountView()
		{
		}

		public LogRowsCountView(LogRowsCountData data)
		{
		}


		public LogRowsCountData ToLogRowsCountData()
		{
			LogRowsCountData entity = new LogRowsCountData();

			return entity;
		}
	}
}
