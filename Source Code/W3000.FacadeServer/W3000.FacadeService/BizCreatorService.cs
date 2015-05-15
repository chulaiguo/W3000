using W3000.CreatorService;

namespace W3000.FacadeService
{
	public class BizCreatorService : ServiceBase
	{
		public BizCreatorService(Cheke.SecurityToken token)
			: base(token)
		{
		}

		public W3000.Data.UsrAccountData CreateUsrAccount()
		{
			return new BizCreator(base.OriginalToken).CreateUsrAccount();
		}

		public W3000.Data.BDBuildingData CreateBDBuilding( System.Int32 countryID, System.Boolean isFederal)
		{
			return new BizCreator(base.OriginalToken).CreateBDBuilding( countryID, isFederal);
		}

		public W3000.Data.UtilHolidayData CreateUtilHoliday()
		{
			return new BizCreator(base.OriginalToken).CreateUtilHoliday();
		}

	}
}
