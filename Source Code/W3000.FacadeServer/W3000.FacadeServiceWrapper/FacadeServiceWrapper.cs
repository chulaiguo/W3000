using System;
using Cheke;
using W3000.Data;
using W3000.IFacadeService;

namespace W3000.FacadeServiceWrapper
{
	public static class BizCreatorWrapper
	{
		public static W3000.Data.UsrAccountData CreateUsrAccount( SecurityToken token)
		{
			return CreateUsrAccount(FacadeServiceBuilder.GetFactory(), token);
		}

		private static W3000.Data.UsrAccountData CreateUsrAccount(IFacadeServiceFactory factory,  SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = factory.GetBizCreatorResult("CreateUsrAccount", FacadeServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountData;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingData CreateBDBuilding(System.Int32 countryID,System.Boolean isFederal, SecurityToken token)
		{
			return CreateBDBuilding(FacadeServiceBuilder.GetFactory(), countryID,isFederal,token);
		}

		private static W3000.Data.BDBuildingData CreateBDBuilding(IFacadeServiceFactory factory, System.Int32 countryID,System.Boolean isFederal, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "countryID";
			paraValues[0] = countryID;
			paraNames[1] = "isFederal";
			paraValues[1] = isFederal;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = factory.GetBizCreatorResult("CreateBDBuilding", FacadeServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingData;
			}
			return _result_;
		}

		public static W3000.Data.UtilHolidayData CreateUtilHoliday( SecurityToken token)
		{
			return CreateUtilHoliday(FacadeServiceBuilder.GetFactory(), token);
		}

		private static W3000.Data.UtilHolidayData CreateUtilHoliday(IFacadeServiceFactory factory,  SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = factory.GetBizCreatorResult("CreateUtilHoliday", FacadeServiceBuilder.Serialize(_token_));
			W3000.Data.UtilHolidayData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilHolidayData;
			}
			return _result_;
		}

	}

	public static class BizEmailWrapper
	{
		public static System.String SendEmail(Cheke.EmailData.EmailMessageData data, SecurityToken token)
		{
			return SendEmail(FacadeServiceBuilder.GetFactory(), data,token);
		}

		private static System.String SendEmail(IFacadeServiceFactory factory, Cheke.EmailData.EmailMessageData data, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "data";
			paraValues[0] = data;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = factory.GetBizEmailResult("SendEmail", FacadeServiceBuilder.Serialize(_token_));
			System.String _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as System.String;
			}
			return _result_;
		}

	}

	public static class BizExcelWrapper
	{
		public static System.Data.DataTable GetSchemaTable(System.Byte[] data, SecurityToken token)
		{
			return GetSchemaTable(FacadeServiceBuilder.GetFactory(), data,token);
		}

		private static System.Data.DataTable GetSchemaTable(IFacadeServiceFactory factory, System.Byte[] data, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "data";
			paraValues[0] = data;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = factory.GetBizExcelResult("GetSchemaTable", FacadeServiceBuilder.Serialize(_token_));
			System.Data.DataTable _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as System.Data.DataTable;
			}
			return _result_;
		}

		public static System.String[] GetExcelSheetsList(System.Byte[] data, SecurityToken token)
		{
			return GetExcelSheetsList(FacadeServiceBuilder.GetFactory(), data,token);
		}

		private static System.String[] GetExcelSheetsList(IFacadeServiceFactory factory, System.Byte[] data, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "data";
			paraValues[0] = data;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = factory.GetBizExcelResult("GetExcelSheetsList", FacadeServiceBuilder.Serialize(_token_));
			System.String[] _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as System.String[];
			}
			return _result_;
		}

		public static System.Data.DataTable LoadIntoDataTable(System.Byte[] data,System.String sheet,System.Boolean header, SecurityToken token)
		{
			return LoadIntoDataTable(FacadeServiceBuilder.GetFactory(), data,sheet,header,token);
		}

		private static System.Data.DataTable LoadIntoDataTable(IFacadeServiceFactory factory, System.Byte[] data,System.String sheet,System.Boolean header, SecurityToken token)
		{
			string[] paraNames = new string[3];
			object[] paraValues = new object[3];
			paraNames[0] = "data";
			paraValues[0] = data;
			paraNames[1] = "sheet";
			paraValues[1] = sheet;
			paraNames[2] = "header";
			paraValues[2] = header;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = factory.GetBizExcelResult("LoadIntoDataTable", FacadeServiceBuilder.Serialize(_token_));
			System.Data.DataTable _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as System.Data.DataTable;
			}
			return _result_;
		}

		public static System.Data.DataSet LoadIntoDataSet(System.Byte[] data,System.Boolean header, SecurityToken token)
		{
			return LoadIntoDataSet(FacadeServiceBuilder.GetFactory(), data,header,token);
		}

		private static System.Data.DataSet LoadIntoDataSet(IFacadeServiceFactory factory, System.Byte[] data,System.Boolean header, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "data";
			paraValues[0] = data;
			paraNames[1] = "header";
			paraValues[1] = header;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = factory.GetBizExcelResult("LoadIntoDataSet", FacadeServiceBuilder.Serialize(_token_));
			System.Data.DataSet _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as System.Data.DataSet;
			}
			return _result_;
		}

	}

	public static class BizLoginWrapper
	{
		public static Cheke.BusinessEntity.Result Login( SecurityToken token)
		{
			return Login(FacadeServiceBuilder.GetFactory(), token);
		}

		private static Cheke.BusinessEntity.Result Login(IFacadeServiceFactory factory,  SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = factory.GetBizLoginResult("Login", FacadeServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result LoginByWeb(System.String userId,System.String md5Password, SecurityToken token)
		{
			return LoginByWeb(FacadeServiceBuilder.GetFactory(), userId,md5Password,token);
		}

		private static Cheke.BusinessEntity.Result LoginByWeb(IFacadeServiceFactory factory, System.String userId,System.String md5Password, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "userId";
			paraValues[0] = userId;
			paraNames[1] = "md5Password";
			paraValues[1] = md5Password;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = factory.GetBizLoginResult("LoginByWeb", FacadeServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result RecoverPassword(System.String userId, SecurityToken token)
		{
			return RecoverPassword(FacadeServiceBuilder.GetFactory(), userId,token);
		}

		private static Cheke.BusinessEntity.Result RecoverPassword(IFacadeServiceFactory factory, System.String userId, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "userId";
			paraValues[0] = userId;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = factory.GetBizLoginResult("RecoverPassword", FacadeServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result ChangePassword(System.String newPassword, SecurityToken token)
		{
			return ChangePassword(FacadeServiceBuilder.GetFactory(), newPassword,token);
		}

		private static Cheke.BusinessEntity.Result ChangePassword(IFacadeServiceFactory factory, System.String newPassword, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "newPassword";
			paraValues[0] = newPassword;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = factory.GetBizLoginResult("ChangePassword", FacadeServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.BizData.BizDBPermissionCollection GetDBPermission(System.String userID, SecurityToken token)
		{
			return GetDBPermission(FacadeServiceBuilder.GetFactory(), userID,token);
		}

		private static W3000.BizData.BizDBPermissionCollection GetDBPermission(IFacadeServiceFactory factory, System.String userID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "userID";
			paraValues[0] = userID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = factory.GetBizLoginResult("GetDBPermission", FacadeServiceBuilder.Serialize(_token_));
			W3000.BizData.BizDBPermissionCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.BizData.BizDBPermissionCollection;
			}
			return _result_;
		}

		public static W3000.BizData.BizBRPermissionCollection GetBRPermission(System.String userID, SecurityToken token)
		{
			return GetBRPermission(FacadeServiceBuilder.GetFactory(), userID,token);
		}

		private static W3000.BizData.BizBRPermissionCollection GetBRPermission(IFacadeServiceFactory factory, System.String userID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "userID";
			paraValues[0] = userID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = factory.GetBizLoginResult("GetBRPermission", FacadeServiceBuilder.Serialize(_token_));
			W3000.BizData.BizBRPermissionCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.BizData.BizBRPermissionCollection;
			}
			return _result_;
		}

	}

	internal static class FacadeServiceBuilder
	{
		internal static byte[] Serialize(object obj)
		{
			using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
			{
				new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Serialize(stream, obj);
				return stream.ToArray();
			}
		}

		internal static IFacadeServiceFactory GetFactory()
		{
			return (IFacadeServiceFactory) Cheke.ClassFactory.ClassBuilder.GetFactory("W3000.FacadeServiceFactory");
		}

		internal static IFacadeServiceFactory GetFactory(string location)
		{
			return Activator.GetObject(typeof(IFacadeServiceFactory), location) as IFacadeServiceFactory;
		}
	}
}
