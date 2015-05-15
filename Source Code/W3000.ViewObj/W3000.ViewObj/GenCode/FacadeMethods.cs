using System;
using Cheke;
using W3000.Data;
using W3000.FacadeServiceWrapper;

namespace W3000.ViewObj
{
	public static class BizCreator
	{
		public static UsrAccount CreateUsrAccount()
		{
			return CreateUsrAccount( Identity.Token);
		}

		public static UsrAccount CreateUsrAccount(SecurityToken token)
		{

			W3000.Data.UsrAccountData _result_ = BizCreatorWrapper.CreateUsrAccount( token);
			if(_result_ == null)
				return null;

			return new UsrAccount(_result_);
		}

		public static BDBuilding CreateBDBuilding(System.Int32 countryID,System.Boolean isFederal)
		{
			return CreateBDBuilding(countryID,isFederal, Identity.Token);
		}

		public static BDBuilding CreateBDBuilding(System.Int32 countryID,System.Boolean isFederal, SecurityToken token)
		{

			W3000.Data.BDBuildingData _result_ = BizCreatorWrapper.CreateBDBuilding(countryID,isFederal, token);
			if(_result_ == null)
				return null;

			return new BDBuilding(_result_);
		}

		public static UtilHoliday CreateUtilHoliday()
		{
			return CreateUtilHoliday( Identity.Token);
		}

		public static UtilHoliday CreateUtilHoliday(SecurityToken token)
		{

			W3000.Data.UtilHolidayData _result_ = BizCreatorWrapper.CreateUtilHoliday( token);
			if(_result_ == null)
				return null;

			return new UtilHoliday(_result_);
		}

	}

	public static class BizEmail
	{
		public static System.String SendEmail(Cheke.EmailData.EmailMessageData data)
		{
			return SendEmail(data, Identity.Token);
		}

		public static System.String SendEmail(Cheke.EmailData.EmailMessageData data, SecurityToken token)
		{

			System.String _result_ = BizEmailWrapper.SendEmail(data, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public static class BizExcel
	{
		public static System.Data.DataTable GetSchemaTable(System.Byte[] data)
		{
			return GetSchemaTable(data, Identity.Token);
		}

		public static System.Data.DataTable GetSchemaTable(System.Byte[] data, SecurityToken token)
		{

			System.Data.DataTable _result_ = BizExcelWrapper.GetSchemaTable(data, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static System.String[] GetExcelSheetsList(System.Byte[] data)
		{
			return GetExcelSheetsList(data, Identity.Token);
		}

		public static System.String[] GetExcelSheetsList(System.Byte[] data, SecurityToken token)
		{

			System.String[] _result_ = BizExcelWrapper.GetExcelSheetsList(data, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static System.Data.DataTable LoadIntoDataTable(System.Byte[] data,System.String sheet,System.Boolean header)
		{
			return LoadIntoDataTable(data,sheet,header, Identity.Token);
		}

		public static System.Data.DataTable LoadIntoDataTable(System.Byte[] data,System.String sheet,System.Boolean header, SecurityToken token)
		{

			System.Data.DataTable _result_ = BizExcelWrapper.LoadIntoDataTable(data,sheet,header, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static System.Data.DataSet LoadIntoDataSet(System.Byte[] data,System.Boolean header)
		{
			return LoadIntoDataSet(data,header, Identity.Token);
		}

		public static System.Data.DataSet LoadIntoDataSet(System.Byte[] data,System.Boolean header, SecurityToken token)
		{

			System.Data.DataSet _result_ = BizExcelWrapper.LoadIntoDataSet(data,header, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public static class BizLogin
	{
		public static Cheke.BusinessEntity.Result Login()
		{
			return Login( Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Login(SecurityToken token)
		{

			Cheke.BusinessEntity.Result _result_ = BizLoginWrapper.Login( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result LoginByWeb(System.String userId,System.String md5Password)
		{
			return LoginByWeb(userId,md5Password, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result LoginByWeb(System.String userId,System.String md5Password, SecurityToken token)
		{

			Cheke.BusinessEntity.Result _result_ = BizLoginWrapper.LoginByWeb(userId,md5Password, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result RecoverPassword(System.String userId)
		{
			return RecoverPassword(userId, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result RecoverPassword(System.String userId, SecurityToken token)
		{

			Cheke.BusinessEntity.Result _result_ = BizLoginWrapper.RecoverPassword(userId, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result ChangePassword(System.String newPassword)
		{
			return ChangePassword(newPassword, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result ChangePassword(System.String newPassword, SecurityToken token)
		{

			Cheke.BusinessEntity.Result _result_ = BizLoginWrapper.ChangePassword(newPassword, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static W3000.BizData.BizDBPermissionCollection GetDBPermission(System.String userID)
		{
			return GetDBPermission(userID, Identity.Token);
		}

		public static W3000.BizData.BizDBPermissionCollection GetDBPermission(System.String userID, SecurityToken token)
		{

			W3000.BizData.BizDBPermissionCollection _result_ = BizLoginWrapper.GetDBPermission(userID, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static W3000.BizData.BizBRPermissionCollection GetBRPermission(System.String userID)
		{
			return GetBRPermission(userID, Identity.Token);
		}

		public static W3000.BizData.BizBRPermissionCollection GetBRPermission(System.String userID, SecurityToken token)
		{

			W3000.BizData.BizBRPermissionCollection _result_ = BizLoginWrapper.GetBRPermission(userID, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

}
