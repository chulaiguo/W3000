using System;
using W3000.Data;

namespace W3000.DataService
{
	public partial class UtilHolidayDataService
	{
        protected override void BeforeInsert(Cheke.BusinessEntity.BusinessBase entity)
        {
            this.AdjustData(entity as UtilHolidayData);
        }

        protected override void BeforeUpdate(Cheke.BusinessEntity.BusinessBase entity)
        {
            this.AdjustData(entity as UtilHolidayData);
        }

        private void AdjustData(UtilHolidayData holiday)
        {
            DateTime date = new DateTime(holiday.Date.Year, holiday.Date.Month, holiday.Date.Day, 12, 0, 0, 0);
            holiday.Date = date;
        }
    }
}
