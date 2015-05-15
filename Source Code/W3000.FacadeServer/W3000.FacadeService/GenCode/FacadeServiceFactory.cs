using System;
using Cheke;
using W3000.Data;
using W3000.BizData;
using W3000.IFacadeService;

namespace W3000.FacadeService
{
	public class FacadeServiceFactory: MarshalByRefObject, IFacadeServiceFactory
	{
		public byte[] GetBizCreatorResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			BizCreatorService svr = new BizCreatorService(token);
			switch (actionName)
			{
				case "CreateBDBuilding" :
				{
					W3000.Data.BDBuildingData _result_  = svr.CreateBDBuilding((System.Int32)token.GetParameter(0),(System.Boolean)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "CreateUsrAccount" :
				{
					W3000.Data.UsrAccountData _result_  = svr.CreateUsrAccount();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "CreateUtilHoliday" :
				{
					W3000.Data.UtilHolidayData _result_  = svr.CreateUtilHoliday();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
			}
			return null;
		}
		public byte[] GetBizEmailResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			BizEmailService svr = new BizEmailService(token);
			switch (actionName)
			{
				case "SendEmail" :
				{
					System.String _result_  = svr.SendEmail((Cheke.EmailData.EmailMessageData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
			}
			return null;
		}
		public byte[] GetBizExcelResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			BizExcelService svr = new BizExcelService(token);
			switch (actionName)
			{
				case "GetExcelSheetsList" :
				{
					System.String[] _result_  = svr.GetExcelSheetsList((System.Byte[])token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetSchemaTable" :
				{
					System.Data.DataTable _result_  = svr.GetSchemaTable((System.Byte[])token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "LoadIntoDataSet" :
				{
					System.Data.DataSet _result_  = svr.LoadIntoDataSet((System.Byte[])token.GetParameter(0),(System.Boolean)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "LoadIntoDataTable" :
				{
					System.Data.DataTable _result_  = svr.LoadIntoDataTable((System.Byte[])token.GetParameter(0),(System.String)token.GetParameter(1),(System.Boolean)token.GetParameter(2));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
			}
			return null;
		}
		public byte[] GetBizLoginResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			BizLoginService svr = new BizLoginService(token);
			switch (actionName)
			{
				case "ChangePassword" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.ChangePassword((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetBRPermission" :
				{
					W3000.BizData.BizBRPermissionCollection _result_  = svr.GetBRPermission((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetDBPermission" :
				{
					W3000.BizData.BizDBPermissionCollection _result_  = svr.GetDBPermission((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Login" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Login();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "LoginByWeb" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.LoginByWeb((System.String)token.GetParameter(0),(System.String)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "RecoverPassword" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.RecoverPassword((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
			}
			return null;
		}
		private SecurityToken DeserializeToken(byte[] data)
		{
			using (System.IO.MemoryStream stream = new System.IO.MemoryStream(data))
			{
				return new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Deserialize(stream) as SecurityToken;
			}
		}
	}
}
