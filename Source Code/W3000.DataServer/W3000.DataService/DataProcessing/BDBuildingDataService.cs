using System;
using W3000.Data;

namespace W3000.DataService
{
	public partial class BDBuildingDataService
	{
        protected override void BeforeInsert(Cheke.BusinessEntity.BusinessBase entity)
        {
            this.ProcessAddress(entity);
        }

        protected override void BeforeUpdate(Cheke.BusinessEntity.BusinessBase entity)
        {
            this.ProcessAddress(entity);
        }

        private void ProcessAddress(Cheke.BusinessEntity.BusinessBase entity)
        {
            BDBuildingData building = entity as BDBuildingData;
            if (building == null)
                return;

            int index = building.Address1.IndexOf(' ');
            if(index > 0)
            {
                building.StreetNumb = building.Address1.Substring(0, index).Trim();
                building.StreetName = building.Address1.Substring(index + 1).Trim();
            }
            else
            {
                building.StreetNumb = string.Empty;
                building.StreetName = building.Address1.Trim();
            }
        }
	}
}
