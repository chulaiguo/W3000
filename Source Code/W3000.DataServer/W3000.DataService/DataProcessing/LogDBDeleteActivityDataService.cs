using System;
using W3000.Data;

namespace W3000.DataService
{
	public partial class LogDBDeleteActivityDataService
	{
        public override Cheke.BusinessEntity.Result Save(LogDBDeleteActivityData entity)
        {
            throw new NotSupportedException("The operation is NOT supported by W3000.");
        }

        public override Cheke.BusinessEntity.Result Save(LogDBDeleteActivityDataCollection list)
        {
            throw new NotSupportedException("The operation is NOT supported by W3000.");
        }
	}
}
