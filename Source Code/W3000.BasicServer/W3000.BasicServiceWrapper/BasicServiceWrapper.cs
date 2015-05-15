using System;
using Cheke;
using W3000.Data;
using W3000.IBasicService;

namespace W3000.BasicServiceWrapper
{
	public static class ACAccessLevelWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACAccessLevelData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAccessLevelData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAccessLevelDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDataCollection GetByMappedACMainZone(System.Guid ACMainZonePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACMainZonePK";
			paraValues[0] = ACMainZonePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelResult("GetByMappedACMainZone", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelData GetByUK(System.Guid BDBuildingPK,System.Int16 AccessLevelID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;
			paraNames[1] = "AccessLevelID";
			paraValues[1] = AccessLevelID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelData;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelData GetByPK(System.Guid ACAccessLevelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACAccessLevelPK";
			paraValues[0] = ACAccessLevelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelData;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDataCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelResult("GetByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelResult("GetViewByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelViewCollection;
			}
			return _result_;
		}

	}

	public static class ACAccessLevelDetailWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACAccessLevelDetailData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAccessLevelDetailData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAccessLevelDetailDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDetailDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDetailDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDetailDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDetailDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDetailDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDetailDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDetailData GetByUK(System.Guid ACAccessLevelPK,System.Guid ACMainZonePK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "ACAccessLevelPK";
			paraValues[0] = ACAccessLevelPK;
			paraNames[1] = "ACMainZonePK";
			paraValues[1] = ACMainZonePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDetailData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDetailData;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDetailData GetByPK(System.Guid ACAccessLevelDetailPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACAccessLevelDetailPK";
			paraValues[0] = ACAccessLevelDetailPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDetailData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDetailData;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDetailDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDetailDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDetailDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDetailViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDetailViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDetailViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDetailDataCollection GetByACMainZone(System.Guid ACMainZonePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACMainZonePK";
			paraValues[0] = ACMainZonePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("GetByACMainZone", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDetailDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDetailDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDetailViewCollection GetViewByACMainZone(System.Guid ACMainZonePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACMainZonePK";
			paraValues[0] = ACMainZonePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("GetViewByACMainZone", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDetailViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDetailViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDetailDataCollection GetByACTimecode(System.Guid ACTimecodePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACTimecodePK";
			paraValues[0] = ACTimecodePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("GetByACTimecode", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDetailDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDetailDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDetailViewCollection GetViewByACTimecode(System.Guid ACTimecodePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACTimecodePK";
			paraValues[0] = ACTimecodePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("GetViewByACTimecode", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDetailViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDetailViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDetailDataCollection GetByACAccessLevel(System.Guid ACAccessLevelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACAccessLevelPK";
			paraValues[0] = ACAccessLevelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("GetByACAccessLevel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDetailDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDetailDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAccessLevelDetailViewCollection GetViewByACAccessLevel(System.Guid ACAccessLevelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACAccessLevelPK";
			paraValues[0] = ACAccessLevelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAccessLevelDetailResult("GetViewByACAccessLevel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAccessLevelDetailViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAccessLevelDetailViewCollection;
			}
			return _result_;
		}

	}

	public static class ACAMFormatWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACAMFormatData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAMFormatResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAMFormatData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAMFormatResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAMFormatDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAMFormatResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACAMFormatDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAMFormatResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAMFormatDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAMFormatDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAMFormatResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACAMFormatDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAMFormatResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAMFormatDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAMFormatDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAMFormatData GetByUK(System.Guid BDBuildingPK,System.Int16 AMFID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;
			paraNames[1] = "AMFID";
			paraValues[1] = AMFID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAMFormatResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAMFormatData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAMFormatData;
			}
			return _result_;
		}

		public static W3000.Data.ACAMFormatData GetByPK(System.Guid ACAMFormatPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACAMFormatPK";
			paraValues[0] = ACAMFormatPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAMFormatResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAMFormatData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAMFormatData;
			}
			return _result_;
		}

		public static W3000.Data.ACAMFormatDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAMFormatResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAMFormatDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAMFormatDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAMFormatViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAMFormatResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAMFormatViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAMFormatViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAMFormatDataCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAMFormatResult("GetByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAMFormatDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAMFormatDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACAMFormatViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACAMFormatResult("GetViewByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACAMFormatViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACAMFormatViewCollection;
			}
			return _result_;
		}

	}

	public static class ACCardHolderBuildingMapWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACCardHolderBuildingMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderBuildingMapResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACCardHolderBuildingMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderBuildingMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACCardHolderBuildingMapDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderBuildingMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderBuildingMapDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderBuildingMapResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderBuildingMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderBuildingMapDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderBuildingMapResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACCardHolderBuildingMapDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderBuildingMapResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderBuildingMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderBuildingMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderBuildingMapData GetByUK(System.Guid ACCardHolderPK,System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "ACCardHolderPK";
			paraValues[0] = ACCardHolderPK;
			paraNames[1] = "BDBuildingPK";
			paraValues[1] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderBuildingMapResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderBuildingMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderBuildingMapData;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderBuildingMapData GetByPK(System.Guid ACCardHolderBuildingMapPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACCardHolderBuildingMapPK";
			paraValues[0] = ACCardHolderBuildingMapPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderBuildingMapResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderBuildingMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderBuildingMapData;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderBuildingMapDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderBuildingMapResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderBuildingMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderBuildingMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderBuildingMapViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderBuildingMapResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderBuildingMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderBuildingMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderBuildingMapDataCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderBuildingMapResult("GetByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderBuildingMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderBuildingMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderBuildingMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderBuildingMapResult("GetViewByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderBuildingMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderBuildingMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderBuildingMapDataCollection GetByACCardHolder(System.Guid ACCardHolderPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACCardHolderPK";
			paraValues[0] = ACCardHolderPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderBuildingMapResult("GetByACCardHolder", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderBuildingMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderBuildingMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderBuildingMapViewCollection GetViewByACCardHolder(System.Guid ACCardHolderPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACCardHolderPK";
			paraValues[0] = ACCardHolderPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderBuildingMapResult("GetViewByACCardHolder", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderBuildingMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderBuildingMapViewCollection;
			}
			return _result_;
		}

	}

	public static class ACCardHolderWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACCardHolderData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACCardHolderData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACCardHolderDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderDataCollection GetByCriteria(W3000.Data.CriteriaACCardHolderView criteria, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "criteria";
			paraValues[0] = criteria;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetByCriteria", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderDataCollection GetByCriteria(W3000.Data.CriteriaACCardHolderView criteria,System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[3];
			object[] paraValues = new object[3];
			paraNames[0] = "criteria";
			paraValues[0] = criteria;
			paraNames[1] = "pageIndex";
			paraValues[1] = pageIndex;
			paraNames[2] = "pageSize";
			paraValues[2] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetByCriteria", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetCountByCriteria(W3000.Data.CriteriaACCardHolderView criteria, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "criteria";
			paraValues[0] = criteria;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetCountByCriteria", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACCardHolderDataCollection GetByLikeFirstName(System.String FirstName, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "FirstName";
			paraValues[0] = FirstName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetByLikeFirstName", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderDataCollection GetByLikeLastName(System.String LastName, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "LastName";
			paraValues[0] = LastName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetByLikeLastName", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderDataCollection GetByValidThru(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetByValidThru", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderDataCollection GetByMappedBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetByMappedBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACCardHolderDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderData GetByUK(System.Int32 Sitecode,System.Int32 Embossed,System.Int32 CardTypeID, SecurityToken token)
		{
			string[] paraNames = new string[3];
			object[] paraValues = new object[3];
			paraNames[0] = "Sitecode";
			paraValues[0] = Sitecode;
			paraNames[1] = "Embossed";
			paraValues[1] = Embossed;
			paraNames[2] = "CardTypeID";
			paraValues[2] = CardTypeID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderData;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderData GetByUK1(System.Int32 Sitecode,System.Int32 Encoded,System.Int32 CardTypeID, SecurityToken token)
		{
			string[] paraNames = new string[3];
			object[] paraValues = new object[3];
			paraNames[0] = "Sitecode";
			paraValues[0] = Sitecode;
			paraNames[1] = "Encoded";
			paraValues[1] = Encoded;
			paraNames[2] = "CardTypeID";
			paraValues[2] = CardTypeID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetByUK1", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderData;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderData GetByPK(System.Guid ACCardHolderPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACCardHolderPK";
			paraValues[0] = ACCardHolderPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderData;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderDataCollection GetByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetByBDTenant", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACCardHolderViewCollection GetViewByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACCardHolderResult("GetViewByBDTenant", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACCardHolderViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACCardHolderViewCollection;
			}
			return _result_;
		}

	}

	public static class ACFunctionCardWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACFunctionCardData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACFunctionCardData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACFunctionCardDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACFunctionCardDataCollection GetByLikeFirstName(System.String FirstName, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "FirstName";
			paraValues[0] = FirstName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("GetByLikeFirstName", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACFunctionCardDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACFunctionCardDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACFunctionCardDataCollection GetByLikeLastName(System.String LastName, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "LastName";
			paraValues[0] = LastName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("GetByLikeLastName", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACFunctionCardDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACFunctionCardDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACFunctionCardDataCollection GetByCardTypeID(System.Int32 CardTypeID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "CardTypeID";
			paraValues[0] = CardTypeID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("GetByCardTypeID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACFunctionCardDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACFunctionCardDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACFunctionCardDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACFunctionCardDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACFunctionCardDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACFunctionCardDataCollection GetByMappedACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("GetByMappedACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACFunctionCardDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACFunctionCardDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACFunctionCardDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACFunctionCardDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACFunctionCardDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACFunctionCardData GetByUK(System.Int32 Sitecode,System.Int32 Embossed,System.Int32 CardTypeID, SecurityToken token)
		{
			string[] paraNames = new string[3];
			object[] paraValues = new object[3];
			paraNames[0] = "Sitecode";
			paraValues[0] = Sitecode;
			paraNames[1] = "Embossed";
			paraValues[1] = Embossed;
			paraNames[2] = "CardTypeID";
			paraValues[2] = CardTypeID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACFunctionCardData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACFunctionCardData;
			}
			return _result_;
		}

		public static W3000.Data.ACFunctionCardData GetByUK1(System.Int32 Sitecode,System.Int32 Encoded,System.Int32 CardTypeID, SecurityToken token)
		{
			string[] paraNames = new string[3];
			object[] paraValues = new object[3];
			paraNames[0] = "Sitecode";
			paraValues[0] = Sitecode;
			paraNames[1] = "Encoded";
			paraValues[1] = Encoded;
			paraNames[2] = "CardTypeID";
			paraValues[2] = CardTypeID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("GetByUK1", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACFunctionCardData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACFunctionCardData;
			}
			return _result_;
		}

		public static W3000.Data.ACFunctionCardData GetByPK(System.Guid ACFunctionCardPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACFunctionCardPK";
			paraValues[0] = ACFunctionCardPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACFunctionCardData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACFunctionCardData;
			}
			return _result_;
		}

		public static W3000.Data.ACFunctionCardDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACFunctionCardDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACFunctionCardDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACFunctionCardViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACFunctionCardViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACFunctionCardViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACFunctionCardDataCollection GetByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("GetByBDTenant", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACFunctionCardDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACFunctionCardDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACFunctionCardViewCollection GetViewByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACFunctionCardResult("GetViewByBDTenant", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACFunctionCardViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACFunctionCardViewCollection;
			}
			return _result_;
		}

	}

	public static class ACInputWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACInputData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACInputDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputDataCollection GetByMappedACInputGroup(System.Guid ACInputGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACInputGroupPK";
			paraValues[0] = ACInputGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputResult("GetByMappedACInputGroup", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACInputDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputData GetByUK(System.Guid ACPanelPK,System.Byte PanelZoneID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;
			paraNames[1] = "PanelZoneID";
			paraValues[1] = PanelZoneID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputData;
			}
			return _result_;
		}

		public static W3000.Data.ACInputData GetByPK(System.Guid ACInputPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACInputPK";
			paraValues[0] = ACInputPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputData;
			}
			return _result_;
		}

		public static W3000.Data.ACInputDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputDataCollection GetByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputResult("GetByACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputViewCollection GetViewByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputResult("GetViewByACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputViewCollection;
			}
			return _result_;
		}

	}

	public static class ACInputGroupWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACInputGroupData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputGroupData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputGroupDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupDataCollection GetByMappedACInput(System.Guid ACInputPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACInputPK";
			paraValues[0] = ACInputPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupResult("GetByMappedACInput", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACInputGroupDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupData GetByUK(System.Guid ACPanelPK,System.Byte GroupID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;
			paraNames[1] = "GroupID";
			paraValues[1] = GroupID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupData;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupData GetByPK(System.Guid ACInputGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACInputGroupPK";
			paraValues[0] = ACInputGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupData;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupDataCollection GetByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupResult("GetByACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupViewCollection GetViewByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupResult("GetViewByACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupViewCollection;
			}
			return _result_;
		}

	}

	public static class ACInputGroupInputMapWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACInputGroupInputMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupInputMapResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputGroupInputMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupInputMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputGroupInputMapDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupInputMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupInputMapDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupInputMapResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupInputMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupInputMapDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupInputMapResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACInputGroupInputMapDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupInputMapResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupInputMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupInputMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupInputMapData GetByUK(System.Guid ACInputGroupPK,System.Guid ACInputPK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "ACInputGroupPK";
			paraValues[0] = ACInputGroupPK;
			paraNames[1] = "ACInputPK";
			paraValues[1] = ACInputPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupInputMapResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupInputMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupInputMapData;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupInputMapData GetByPK(System.Guid ACInputGroupInputMapPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACInputGroupInputMapPK";
			paraValues[0] = ACInputGroupInputMapPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupInputMapResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupInputMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupInputMapData;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupInputMapDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupInputMapResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupInputMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupInputMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupInputMapViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupInputMapResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupInputMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupInputMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupInputMapDataCollection GetByACInputGroup(System.Guid ACInputGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACInputGroupPK";
			paraValues[0] = ACInputGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupInputMapResult("GetByACInputGroup", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupInputMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupInputMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupInputMapViewCollection GetViewByACInputGroup(System.Guid ACInputGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACInputGroupPK";
			paraValues[0] = ACInputGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupInputMapResult("GetViewByACInputGroup", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupInputMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupInputMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupInputMapDataCollection GetByACInput(System.Guid ACInputPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACInputPK";
			paraValues[0] = ACInputPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupInputMapResult("GetByACInput", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupInputMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupInputMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACInputGroupInputMapViewCollection GetViewByACInput(System.Guid ACInputPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACInputPK";
			paraValues[0] = ACInputPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACInputGroupInputMapResult("GetViewByACInput", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACInputGroupInputMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACInputGroupInputMapViewCollection;
			}
			return _result_;
		}

	}

	public static class ACIntervalWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACIntervalData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntervalResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACIntervalData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntervalResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACIntervalDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntervalResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACIntervalDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntervalResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntervalDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntervalDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACIntervalDataCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilHolidayPK";
			paraValues[0] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntervalResult("GetByMappedUtilHoliday", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntervalDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntervalDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACIntervalDataCollection GetByMappedACTimecode(System.Guid ACTimecodePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACTimecodePK";
			paraValues[0] = ACTimecodePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntervalResult("GetByMappedACTimecode", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntervalDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntervalDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntervalResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACIntervalDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntervalResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntervalDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntervalDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACIntervalData GetByUK(System.Guid BDBuildingPK,System.Int16 IVID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;
			paraNames[1] = "IVID";
			paraValues[1] = IVID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntervalResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntervalData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntervalData;
			}
			return _result_;
		}

		public static W3000.Data.ACIntervalData GetByPK(System.Guid ACIntervalPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACIntervalPK";
			paraValues[0] = ACIntervalPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntervalResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntervalData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntervalData;
			}
			return _result_;
		}

		public static W3000.Data.ACIntervalDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntervalResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntervalDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntervalDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACIntervalViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntervalResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntervalViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntervalViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACIntervalDataCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntervalResult("GetByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntervalDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntervalDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACIntervalViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntervalResult("GetViewByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntervalViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntervalViewCollection;
			}
			return _result_;
		}

	}

	public static class ACIntvalHolidayMapWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACIntvalHolidayMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntvalHolidayMapResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACIntvalHolidayMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntvalHolidayMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACIntvalHolidayMapDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntvalHolidayMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACIntvalHolidayMapDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntvalHolidayMapResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntvalHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntvalHolidayMapDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntvalHolidayMapResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACIntvalHolidayMapDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntvalHolidayMapResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntvalHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntvalHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACIntvalHolidayMapData GetByUK(System.Guid ACIntervalPK,System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "ACIntervalPK";
			paraValues[0] = ACIntervalPK;
			paraNames[1] = "UtilHolidayPK";
			paraValues[1] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntvalHolidayMapResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntvalHolidayMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntvalHolidayMapData;
			}
			return _result_;
		}

		public static W3000.Data.ACIntvalHolidayMapData GetByPK(System.Guid ACIntvalHolidayMapPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACIntvalHolidayMapPK";
			paraValues[0] = ACIntvalHolidayMapPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntvalHolidayMapResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntvalHolidayMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntvalHolidayMapData;
			}
			return _result_;
		}

		public static W3000.Data.ACIntvalHolidayMapDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntvalHolidayMapResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntvalHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntvalHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACIntvalHolidayMapViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntvalHolidayMapResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntvalHolidayMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntvalHolidayMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACIntvalHolidayMapDataCollection GetByACInterval(System.Guid ACIntervalPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACIntervalPK";
			paraValues[0] = ACIntervalPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntvalHolidayMapResult("GetByACInterval", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntvalHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntvalHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACIntvalHolidayMapViewCollection GetViewByACInterval(System.Guid ACIntervalPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACIntervalPK";
			paraValues[0] = ACIntervalPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntvalHolidayMapResult("GetViewByACInterval", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntvalHolidayMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntvalHolidayMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACIntvalHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilHolidayPK";
			paraValues[0] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntvalHolidayMapResult("GetByUtilHoliday", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntvalHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntvalHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACIntvalHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilHolidayPK";
			paraValues[0] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACIntvalHolidayMapResult("GetViewByUtilHoliday", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACIntvalHolidayMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACIntvalHolidayMapViewCollection;
			}
			return _result_;
		}

	}

	public static class ACMainZoneWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACMainZoneData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACMainZoneData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACMainZoneDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACMainZoneDataCollection GetByReaderTypeID(System.Int32 ReaderTypeID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ReaderTypeID";
			paraValues[0] = ReaderTypeID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("GetByReaderTypeID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMainZoneDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMainZoneDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACMainZoneDataCollection GetByMainZoneTypeID(System.Int32 MainZoneTypeID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "MainZoneTypeID";
			paraValues[0] = MainZoneTypeID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("GetByMainZoneTypeID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMainZoneDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMainZoneDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACMainZoneDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMainZoneDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMainZoneDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACMainZoneDataCollection GetByMappedACOutputGroup(System.Guid ACOutputGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACOutputGroupPK";
			paraValues[0] = ACOutputGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("GetByMappedACOutputGroup", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMainZoneDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMainZoneDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACMainZoneDataCollection GetByMappedACTimecode(System.Guid ACTimecodePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACTimecodePK";
			paraValues[0] = ACTimecodePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("GetByMappedACTimecode", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMainZoneDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMainZoneDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACMainZoneDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMainZoneDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMainZoneDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACMainZoneData GetByUK(System.Guid ACPanelPK,System.Byte PanelZoneID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;
			paraNames[1] = "PanelZoneID";
			paraValues[1] = PanelZoneID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMainZoneData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMainZoneData;
			}
			return _result_;
		}

		public static W3000.Data.ACMainZoneData GetByPK(System.Guid ACMainZonePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACMainZonePK";
			paraValues[0] = ACMainZonePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMainZoneData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMainZoneData;
			}
			return _result_;
		}

		public static W3000.Data.ACMainZoneDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMainZoneDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMainZoneDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACMainZoneViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMainZoneViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMainZoneViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACMainZoneDataCollection GetByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("GetByACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMainZoneDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMainZoneDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACMainZoneViewCollection GetViewByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMainZoneResult("GetViewByACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMainZoneViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMainZoneViewCollection;
			}
			return _result_;
		}

	}

	public static class ACMasterCardWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACMasterCardData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMasterCardResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACMasterCardData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMasterCardResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACMasterCardDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMasterCardResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACMasterCardDataCollection GetByCardTypeID(System.Int32 CardTypeID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "CardTypeID";
			paraValues[0] = CardTypeID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMasterCardResult("GetByCardTypeID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMasterCardDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMasterCardDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACMasterCardDataCollection GetByLikeFirstName(System.String FirstName, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "FirstName";
			paraValues[0] = FirstName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMasterCardResult("GetByLikeFirstName", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMasterCardDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMasterCardDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACMasterCardDataCollection GetByLikeLastName(System.String LastName, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "LastName";
			paraValues[0] = LastName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMasterCardResult("GetByLikeLastName", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMasterCardDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMasterCardDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACMasterCardDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMasterCardResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMasterCardDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMasterCardDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMasterCardResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACMasterCardDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMasterCardResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMasterCardDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMasterCardDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACMasterCardData GetByUK(System.Int32 Sitecode,System.Int32 Embossed,System.Int32 CardTypeID, SecurityToken token)
		{
			string[] paraNames = new string[3];
			object[] paraValues = new object[3];
			paraNames[0] = "Sitecode";
			paraValues[0] = Sitecode;
			paraNames[1] = "Embossed";
			paraValues[1] = Embossed;
			paraNames[2] = "CardTypeID";
			paraValues[2] = CardTypeID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMasterCardResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMasterCardData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMasterCardData;
			}
			return _result_;
		}

		public static W3000.Data.ACMasterCardData GetByUK1(System.Int32 Sitecode,System.Int32 Encoded,System.Int32 CardTypeID, SecurityToken token)
		{
			string[] paraNames = new string[3];
			object[] paraValues = new object[3];
			paraNames[0] = "Sitecode";
			paraValues[0] = Sitecode;
			paraNames[1] = "Encoded";
			paraValues[1] = Encoded;
			paraNames[2] = "CardTypeID";
			paraValues[2] = CardTypeID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMasterCardResult("GetByUK1", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMasterCardData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMasterCardData;
			}
			return _result_;
		}

		public static W3000.Data.ACMasterCardData GetByPK(System.Guid ACMasterCardPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACMasterCardPK";
			paraValues[0] = ACMasterCardPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMasterCardResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMasterCardData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMasterCardData;
			}
			return _result_;
		}

		public static W3000.Data.ACMasterCardDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMasterCardResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMasterCardDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMasterCardDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACMasterCardViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACMasterCardResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACMasterCardViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACMasterCardViewCollection;
			}
			return _result_;
		}

	}

	public static class ACOutputGroupWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACOutputGroupData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACOutputGroupData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACOutputGroupDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupDataCollection GetByMappedACMainZone(System.Guid ACMainZonePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACMainZonePK";
			paraValues[0] = ACMainZonePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupResult("GetByMappedACMainZone", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACOutputGroupDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupData GetByUK(System.Guid ACPanelPK,System.Byte GroupID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;
			paraNames[1] = "GroupID";
			paraValues[1] = GroupID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupData;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupData GetByPK(System.Guid ACOutputGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACOutputGroupPK";
			paraValues[0] = ACOutputGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupData;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupDataCollection GetByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupResult("GetByACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupViewCollection GetViewByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupResult("GetViewByACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupViewCollection;
			}
			return _result_;
		}

	}

	public static class ACOutputGroupMainZoneMapWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACOutputGroupMainZoneMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupMainZoneMapResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACOutputGroupMainZoneMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupMainZoneMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACOutputGroupMainZoneMapDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupMainZoneMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupMainZoneMapDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupMainZoneMapResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupMainZoneMapDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupMainZoneMapResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACOutputGroupMainZoneMapDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupMainZoneMapResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupMainZoneMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupMainZoneMapData GetByUK(System.Guid ACOutputGroupPK,System.Guid ACMainZonePK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "ACOutputGroupPK";
			paraValues[0] = ACOutputGroupPK;
			paraNames[1] = "ACMainZonePK";
			paraValues[1] = ACMainZonePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupMainZoneMapResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupMainZoneMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupMainZoneMapData;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupMainZoneMapData GetByPK(System.Guid ACOutputGroupMainZoneMapPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACOutputGroupMainZoneMapPK";
			paraValues[0] = ACOutputGroupMainZoneMapPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupMainZoneMapResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupMainZoneMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupMainZoneMapData;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupMainZoneMapDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupMainZoneMapResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupMainZoneMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupMainZoneMapViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupMainZoneMapResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupMainZoneMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupMainZoneMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupMainZoneMapDataCollection GetByACMainZone(System.Guid ACMainZonePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACMainZonePK";
			paraValues[0] = ACMainZonePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupMainZoneMapResult("GetByACMainZone", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupMainZoneMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupMainZoneMapViewCollection GetViewByACMainZone(System.Guid ACMainZonePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACMainZonePK";
			paraValues[0] = ACMainZonePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupMainZoneMapResult("GetViewByACMainZone", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupMainZoneMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupMainZoneMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupMainZoneMapDataCollection GetByACOutputGroup(System.Guid ACOutputGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACOutputGroupPK";
			paraValues[0] = ACOutputGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupMainZoneMapResult("GetByACOutputGroup", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupMainZoneMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACOutputGroupMainZoneMapViewCollection GetViewByACOutputGroup(System.Guid ACOutputGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACOutputGroupPK";
			paraValues[0] = ACOutputGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACOutputGroupMainZoneMapResult("GetViewByACOutputGroup", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACOutputGroupMainZoneMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACOutputGroupMainZoneMapViewCollection;
			}
			return _result_;
		}

	}

	public static class ACPanelWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACPanelData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelDataCollection GetByPanelTypeID(System.Int32 PanelTypeID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "PanelTypeID";
			paraValues[0] = PanelTypeID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("GetByPanelTypeID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelDataCollection GetByLikeUnitPhone(System.String UnitPhone, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UnitPhone";
			paraValues[0] = UnitPhone;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("GetByLikeUnitPhone", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelDataCollection GetByLikeUnitPhoneCallerID(System.String UnitPhoneCallerID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UnitPhoneCallerID";
			paraValues[0] = UnitPhoneCallerID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("GetByLikeUnitPhoneCallerID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelDataCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilHolidayPK";
			paraValues[0] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("GetByMappedUtilHoliday", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelDataCollection GetByMappedACFunctionCard(System.Guid ACFunctionCardPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACFunctionCardPK";
			paraValues[0] = ACFunctionCardPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("GetByMappedACFunctionCard", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACPanelDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelData GetByUnitID(System.Int32 UnitID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UnitID";
			paraValues[0] = UnitID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("GetByUnitID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelData;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelData GetByPK(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelData;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelDataCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("GetByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelResult("GetViewByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelViewCollection;
			}
			return _result_;
		}

	}

	public static class ACPanelFunctionCardMapWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACPanelFunctionCardMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelFunctionCardMapResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelFunctionCardMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelFunctionCardMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelFunctionCardMapDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelFunctionCardMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelFunctionCardMapDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelFunctionCardMapResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelFunctionCardMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelFunctionCardMapDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelFunctionCardMapResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACPanelFunctionCardMapDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelFunctionCardMapResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelFunctionCardMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelFunctionCardMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelFunctionCardMapData GetByUK(System.Guid ACPanelPK,System.Guid ACFunctionCardPK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;
			paraNames[1] = "ACFunctionCardPK";
			paraValues[1] = ACFunctionCardPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelFunctionCardMapResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelFunctionCardMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelFunctionCardMapData;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelFunctionCardMapData GetByPK(System.Guid ACPanelFunctionCardMapPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelFunctionCardMapPK";
			paraValues[0] = ACPanelFunctionCardMapPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelFunctionCardMapResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelFunctionCardMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelFunctionCardMapData;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelFunctionCardMapDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelFunctionCardMapResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelFunctionCardMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelFunctionCardMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelFunctionCardMapViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelFunctionCardMapResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelFunctionCardMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelFunctionCardMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelFunctionCardMapDataCollection GetByACFunctionCard(System.Guid ACFunctionCardPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACFunctionCardPK";
			paraValues[0] = ACFunctionCardPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelFunctionCardMapResult("GetByACFunctionCard", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelFunctionCardMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelFunctionCardMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelFunctionCardMapViewCollection GetViewByACFunctionCard(System.Guid ACFunctionCardPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACFunctionCardPK";
			paraValues[0] = ACFunctionCardPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelFunctionCardMapResult("GetViewByACFunctionCard", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelFunctionCardMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelFunctionCardMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelFunctionCardMapDataCollection GetByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelFunctionCardMapResult("GetByACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelFunctionCardMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelFunctionCardMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelFunctionCardMapViewCollection GetViewByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelFunctionCardMapResult("GetViewByACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelFunctionCardMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelFunctionCardMapViewCollection;
			}
			return _result_;
		}

	}

	public static class ACPanelHolidayMapWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACPanelHolidayMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelHolidayMapResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelHolidayMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelHolidayMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelHolidayMapDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelHolidayMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelHolidayMapDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelHolidayMapResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelHolidayMapDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelHolidayMapResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACPanelHolidayMapDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelHolidayMapResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelHolidayMapData GetByUK(System.Guid ACPanelPK,System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;
			paraNames[1] = "UtilHolidayPK";
			paraValues[1] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelHolidayMapResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelHolidayMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelHolidayMapData;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelHolidayMapData GetByPK(System.Guid ACPanelHolidayMapPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelHolidayMapPK";
			paraValues[0] = ACPanelHolidayMapPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelHolidayMapResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelHolidayMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelHolidayMapData;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelHolidayMapDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelHolidayMapResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelHolidayMapViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelHolidayMapResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelHolidayMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelHolidayMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilHolidayPK";
			paraValues[0] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelHolidayMapResult("GetByUtilHoliday", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilHolidayPK";
			paraValues[0] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelHolidayMapResult("GetViewByUtilHoliday", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelHolidayMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelHolidayMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelHolidayMapDataCollection GetByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelHolidayMapResult("GetByACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACPanelHolidayMapViewCollection GetViewByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACPanelHolidayMapResult("GetViewByACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACPanelHolidayMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACPanelHolidayMapViewCollection;
			}
			return _result_;
		}

	}

	public static class ACSupervisoryWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACSupervisoryData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACSupervisoryResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACSupervisoryData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACSupervisoryResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACSupervisoryDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACSupervisoryResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACSupervisoryDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACSupervisoryResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACSupervisoryDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACSupervisoryDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACSupervisoryResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACSupervisoryDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACSupervisoryResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACSupervisoryDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACSupervisoryDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACSupervisoryData GetByUK(System.Guid ACPanelPK,System.Byte PanelZoneID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;
			paraNames[1] = "PanelZoneID";
			paraValues[1] = PanelZoneID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACSupervisoryResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACSupervisoryData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACSupervisoryData;
			}
			return _result_;
		}

		public static W3000.Data.ACSupervisoryData GetByPK(System.Guid ACSupervisoryPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACSupervisoryPK";
			paraValues[0] = ACSupervisoryPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACSupervisoryResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACSupervisoryData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACSupervisoryData;
			}
			return _result_;
		}

		public static W3000.Data.ACSupervisoryDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACSupervisoryResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACSupervisoryDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACSupervisoryDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACSupervisoryViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACSupervisoryResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACSupervisoryViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACSupervisoryViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACSupervisoryDataCollection GetByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACSupervisoryResult("GetByACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACSupervisoryDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACSupervisoryDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACSupervisoryViewCollection GetViewByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACSupervisoryResult("GetViewByACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACSupervisoryViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACSupervisoryViewCollection;
			}
			return _result_;
		}

	}

	public static class ACTimecodeWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACTimecodeData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACTimecodeData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACTimecodeDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeDataCollection GetByMappedACMainZone(System.Guid ACMainZonePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACMainZonePK";
			paraValues[0] = ACMainZonePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeResult("GetByMappedACMainZone", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeDataCollection GetByMappedACInterval(System.Guid ACIntervalPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACIntervalPK";
			paraValues[0] = ACIntervalPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeResult("GetByMappedACInterval", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACTimecodeDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeData GetByUK(System.Guid BDBuildingPK,System.Int16 TCID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;
			paraNames[1] = "TCID";
			paraValues[1] = TCID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeData;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeData GetByPK(System.Guid ACTimecodePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACTimecodePK";
			paraValues[0] = ACTimecodePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeData;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeDataCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeResult("GetByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeResult("GetViewByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeViewCollection;
			}
			return _result_;
		}

	}

	public static class ACTimecodeIntervalMapWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACTimecodeIntervalMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeIntervalMapResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACTimecodeIntervalMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeIntervalMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACTimecodeIntervalMapDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeIntervalMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeIntervalMapDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeIntervalMapResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeIntervalMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeIntervalMapDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeIntervalMapResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.ACTimecodeIntervalMapDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeIntervalMapResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeIntervalMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeIntervalMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeIntervalMapData GetByUK(System.Guid ACTimecodePK,System.Guid ACIntervalPK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "ACTimecodePK";
			paraValues[0] = ACTimecodePK;
			paraNames[1] = "ACIntervalPK";
			paraValues[1] = ACIntervalPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeIntervalMapResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeIntervalMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeIntervalMapData;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeIntervalMapData GetByPK(System.Guid ACTimecodeIntervalMapPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACTimecodeIntervalMapPK";
			paraValues[0] = ACTimecodeIntervalMapPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeIntervalMapResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeIntervalMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeIntervalMapData;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeIntervalMapDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeIntervalMapResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeIntervalMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeIntervalMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeIntervalMapViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeIntervalMapResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeIntervalMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeIntervalMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeIntervalMapDataCollection GetByACInterval(System.Guid ACIntervalPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACIntervalPK";
			paraValues[0] = ACIntervalPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeIntervalMapResult("GetByACInterval", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeIntervalMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeIntervalMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeIntervalMapViewCollection GetViewByACInterval(System.Guid ACIntervalPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACIntervalPK";
			paraValues[0] = ACIntervalPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeIntervalMapResult("GetViewByACInterval", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeIntervalMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeIntervalMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeIntervalMapDataCollection GetByACTimecode(System.Guid ACTimecodePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACTimecodePK";
			paraValues[0] = ACTimecodePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeIntervalMapResult("GetByACTimecode", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeIntervalMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeIntervalMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.ACTimecodeIntervalMapViewCollection GetViewByACTimecode(System.Guid ACTimecodePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACTimecodePK";
			paraValues[0] = ACTimecodePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetACTimecodeIntervalMapResult("GetViewByACTimecode", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.ACTimecodeIntervalMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.ACTimecodeIntervalMapViewCollection;
			}
			return _result_;
		}

	}

	public static class BDBuildingWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDBuildingData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDBuildingData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDBuildingDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingDataCollection GetByCriteria(W3000.Data.CriteriaBDBuildingView criteria, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "criteria";
			paraValues[0] = criteria;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetByCriteria", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingDataCollection GetByCriteria(W3000.Data.CriteriaBDBuildingView criteria,System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[3];
			object[] paraValues = new object[3];
			paraNames[0] = "criteria";
			paraValues[0] = criteria;
			paraNames[1] = "pageIndex";
			paraValues[1] = pageIndex;
			paraNames[2] = "pageSize";
			paraValues[2] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetByCriteria", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetCountByCriteria(W3000.Data.CriteriaBDBuildingView criteria, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "criteria";
			paraValues[0] = criteria;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetCountByCriteria", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.BDBuildingDataCollection GetBySystemTypeID(System.Int32 SystemTypeID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "SystemTypeID";
			paraValues[0] = SystemTypeID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetBySystemTypeID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingDataCollection GetByCountryID(System.Int32 CountryID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "CountryID";
			paraValues[0] = CountryID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetByCountryID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingDataCollection GetByLikeStreetNumb(System.String StreetNumb, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "StreetNumb";
			paraValues[0] = StreetNumb;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetByLikeStreetNumb", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingDataCollection GetByLikeStreetName(System.String StreetName, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "StreetName";
			paraValues[0] = StreetName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetByLikeStreetName", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingDataCollection GetByMappedUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetByMappedUsrAccount", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingDataCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilHolidayPK";
			paraValues[0] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetByMappedUtilHoliday", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingDataCollection GetByMappedACCardHolder(System.Guid ACCardHolderPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACCardHolderPK";
			paraValues[0] = ACCardHolderPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetByMappedACCardHolder", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.BDBuildingDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingData GetByAddress1(System.String Address1, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "Address1";
			paraValues[0] = Address1;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetByAddress1", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingData;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingData GetByBuildingID(System.Int32 BuildingID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BuildingID";
			paraValues[0] = BuildingID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetByBuildingID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingData;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingData GetByPK(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingData;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingViewCollection;
			}
			return _result_;
		}

	}

	public static class BDBuildingHolidayMapWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDBuildingHolidayMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingHolidayMapResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDBuildingHolidayMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingHolidayMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDBuildingHolidayMapDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingHolidayMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingHolidayMapResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.BDBuildingHolidayMapDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingHolidayMapResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingHolidayMapData GetByUK(System.Guid BDBuildingPK,System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;
			paraNames[1] = "UtilHolidayPK";
			paraValues[1] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingHolidayMapResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingHolidayMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingHolidayMapData;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingHolidayMapData GetByPK(System.Guid BDBuildingHolidayMapPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingHolidayMapPK";
			paraValues[0] = BDBuildingHolidayMapPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingHolidayMapResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingHolidayMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingHolidayMapData;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingHolidayMapDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingHolidayMapResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingHolidayMapViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingHolidayMapResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingHolidayMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingHolidayMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingHolidayMapDataCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingHolidayMapResult("GetByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingHolidayMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingHolidayMapResult("GetViewByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingHolidayMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingHolidayMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilHolidayPK";
			paraValues[0] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingHolidayMapResult("GetByUtilHoliday", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDBuildingHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilHolidayPK";
			paraValues[0] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDBuildingHolidayMapResult("GetViewByUtilHoliday", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDBuildingHolidayMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDBuildingHolidayMapViewCollection;
			}
			return _result_;
		}

	}

	public static class BDTenantWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDTenantData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDTenantData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDTenantDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantDataCollection GetBySystemTypeID(System.Int32 SystemTypeID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "SystemTypeID";
			paraValues[0] = SystemTypeID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("GetBySystemTypeID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantDataCollection GetByMappedUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("GetByMappedUsrAccount", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantDataCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilHolidayPK";
			paraValues[0] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("GetByMappedUtilHoliday", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.BDTenantDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantData GetByUK(System.Guid BDBuildingPK,System.String Tenant, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;
			paraNames[1] = "Tenant";
			paraValues[1] = Tenant;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantData;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantData GetByPK(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantData;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantDataCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("GetByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantResult("GetViewByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantViewCollection;
			}
			return _result_;
		}

	}

	public static class BDTenantHolidayMapWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDTenantHolidayMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantHolidayMapResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDTenantHolidayMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantHolidayMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDTenantHolidayMapDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantHolidayMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantHolidayMapResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.BDTenantHolidayMapDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantHolidayMapResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantHolidayMapData GetByUK(System.Guid BDTenantPK,System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;
			paraNames[1] = "UtilHolidayPK";
			paraValues[1] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantHolidayMapResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantHolidayMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantHolidayMapData;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantHolidayMapData GetByPK(System.Guid BDTenantHolidayMapPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantHolidayMapPK";
			paraValues[0] = BDTenantHolidayMapPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantHolidayMapResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantHolidayMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantHolidayMapData;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantHolidayMapDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantHolidayMapResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantHolidayMapViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantHolidayMapResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantHolidayMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantHolidayMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantHolidayMapDataCollection GetByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantHolidayMapResult("GetByBDTenant", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantHolidayMapViewCollection GetViewByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantHolidayMapResult("GetViewByBDTenant", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantHolidayMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantHolidayMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilHolidayPK";
			paraValues[0] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantHolidayMapResult("GetByUtilHoliday", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantHolidayMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantHolidayMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDTenantHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilHolidayPK";
			paraValues[0] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDTenantHolidayMapResult("GetViewByUtilHoliday", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDTenantHolidayMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDTenantHolidayMapViewCollection;
			}
			return _result_;
		}

	}

	public static class BDVisitorWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDVisitorData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDVisitorResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDVisitorData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDVisitorResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDVisitorDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDVisitorResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.BDVisitorDataCollection GetByValidThru(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDVisitorResult("GetByValidThru", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDVisitorDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDVisitorDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDVisitorDataCollection GetByLikeLastName(System.String LastName, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "LastName";
			paraValues[0] = LastName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDVisitorResult("GetByLikeLastName", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDVisitorDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDVisitorDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDVisitorDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDVisitorResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDVisitorDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDVisitorDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDVisitorResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.BDVisitorDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDVisitorResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDVisitorDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDVisitorDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDVisitorData GetByPK(System.Guid BDVisitorPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDVisitorPK";
			paraValues[0] = BDVisitorPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDVisitorResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDVisitorData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDVisitorData;
			}
			return _result_;
		}

		public static W3000.Data.BDVisitorDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDVisitorResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDVisitorDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDVisitorDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDVisitorViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDVisitorResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDVisitorViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDVisitorViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDVisitorDataCollection GetByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDVisitorResult("GetByBDTenant", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDVisitorDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDVisitorDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.BDVisitorViewCollection GetViewByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetBDVisitorResult("GetViewByBDTenant", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.BDVisitorViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.BDVisitorViewCollection;
			}
			return _result_;
		}

	}

	public static class LogDBDeleteActivityWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.LogDBDeleteActivityData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBDeleteActivityResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogDBDeleteActivityData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBDeleteActivityResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogDBDeleteActivityDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBDeleteActivityResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.LogDBDeleteActivityDataCollection GetByLogDateTime(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBDeleteActivityResult("GetByLogDateTime", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogDBDeleteActivityDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogDBDeleteActivityDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.LogDBDeleteActivityDataCollection GetByLogDateTime(System.DateTime begin,System.DateTime end,System.String tableName, SecurityToken token)
		{
			string[] paraNames = new string[3];
			object[] paraValues = new object[3];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();
			paraNames[2] = "tableName";
			paraValues[2] = tableName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBDeleteActivityResult("GetByLogDateTime", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogDBDeleteActivityDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogDBDeleteActivityDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.LogDBDeleteActivityData GetByPK(System.Guid LogDBDeleteActivityPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "LogDBDeleteActivityPK";
			paraValues[0] = LogDBDeleteActivityPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBDeleteActivityResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogDBDeleteActivityData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogDBDeleteActivityData;
			}
			return _result_;
		}

		public static W3000.Data.LogDBDeleteActivityDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBDeleteActivityResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogDBDeleteActivityDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogDBDeleteActivityDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.LogDBDeleteActivityViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBDeleteActivityResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogDBDeleteActivityViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogDBDeleteActivityViewCollection;
			}
			return _result_;
		}

	}

	public static class LogDBEditActivityWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.LogDBEditActivityData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBEditActivityResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogDBEditActivityData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBEditActivityResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogDBEditActivityDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBEditActivityResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.LogDBEditActivityDataCollection GetByLogDateTime(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBEditActivityResult("GetByLogDateTime", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogDBEditActivityDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogDBEditActivityDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.LogDBEditActivityDataCollection GetByLogDateTime(System.DateTime begin,System.DateTime end,System.Guid recordPK, SecurityToken token)
		{
			string[] paraNames = new string[3];
			object[] paraValues = new object[3];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();
			paraNames[2] = "recordPK";
			paraValues[2] = recordPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBEditActivityResult("GetByLogDateTime", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogDBEditActivityDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogDBEditActivityDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.LogDBEditActivityDataCollection GetByLogDateTime(System.DateTime begin,System.DateTime end,System.String tableName, SecurityToken token)
		{
			string[] paraNames = new string[3];
			object[] paraValues = new object[3];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();
			paraNames[2] = "tableName";
			paraValues[2] = tableName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBEditActivityResult("GetByLogDateTime", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogDBEditActivityDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogDBEditActivityDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.LogDBEditActivityDataCollection GetByDeleteRecords(System.DateTime begin,System.DateTime end,System.String tableName, SecurityToken token)
		{
			string[] paraNames = new string[3];
			object[] paraValues = new object[3];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();
			paraNames[2] = "tableName";
			paraValues[2] = tableName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBEditActivityResult("GetByDeleteRecords", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogDBEditActivityDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogDBEditActivityDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.LogDBEditActivityData GetDeletedRecord(System.DateTime lastUpdated,System.Guid recordPK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "lastUpdated";
			paraValues[0] = lastUpdated.ToUniversalTime();
			paraNames[1] = "recordPK";
			paraValues[1] = recordPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBEditActivityResult("GetDeletedRecord", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogDBEditActivityData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogDBEditActivityData;
			}
			return _result_;
		}

		public static W3000.Data.LogDBEditActivityData GetByPK(System.Guid LogDBEditActivityPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "LogDBEditActivityPK";
			paraValues[0] = LogDBEditActivityPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBEditActivityResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogDBEditActivityData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogDBEditActivityData;
			}
			return _result_;
		}

		public static W3000.Data.LogDBEditActivityDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBEditActivityResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogDBEditActivityDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogDBEditActivityDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.LogDBEditActivityViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogDBEditActivityResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogDBEditActivityViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogDBEditActivityViewCollection;
			}
			return _result_;
		}

	}

	public static class LogRowsCountWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.LogRowsCountData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogRowsCountResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogRowsCountData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogRowsCountResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogRowsCountDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogRowsCountResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.LogRowsCountDataCollection GetBySessionDateTime(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogRowsCountResult("GetBySessionDateTime", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogRowsCountDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogRowsCountDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.LogRowsCountDataCollection GetBySessionID(System.Guid SessionID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "SessionID";
			paraValues[0] = SessionID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogRowsCountResult("GetBySessionID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogRowsCountDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogRowsCountDataCollection;
			}
			return _result_;
		}

		public static System.Int32 DeleteBySessionDateTime(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogRowsCountResult("DeleteBySessionDateTime", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.LogRowsCountData GetByPK(System.Guid LogRowsCountPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "LogRowsCountPK";
			paraValues[0] = LogRowsCountPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogRowsCountResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogRowsCountData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogRowsCountData;
			}
			return _result_;
		}

		public static W3000.Data.LogRowsCountDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogRowsCountResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogRowsCountDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogRowsCountDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.LogRowsCountViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetLogRowsCountResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.LogRowsCountViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.LogRowsCountViewCollection;
			}
			return _result_;
		}

	}

	public static class UsrAccountBRRuleWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountBRRuleData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBRRuleResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountBRRuleData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBRRuleResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountBRRuleDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBRRuleResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBRRuleDataCollection GetByBRRuleID(System.Int32 BRRuleID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BRRuleID";
			paraValues[0] = BRRuleID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBRRuleResult("GetByBRRuleID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBRRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBRRuleDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBRRuleResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.UsrAccountBRRuleDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBRRuleResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBRRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBRRuleDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBRRuleData GetByUK(System.Guid UsrAccountPK,System.Int32 BRRuleID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;
			paraNames[1] = "BRRuleID";
			paraValues[1] = BRRuleID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBRRuleResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBRRuleData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBRRuleData;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBRRuleData GetByBRRuleID(System.Int32 BRRuleID,System.String userID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "BRRuleID";
			paraValues[0] = BRRuleID;
			paraNames[1] = "userID";
			paraValues[1] = userID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBRRuleResult("GetByBRRuleID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBRRuleData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBRRuleData;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBRRuleData GetByBRRuleID(System.Int32 BRRuleID,System.Guid UsrAccountPK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "BRRuleID";
			paraValues[0] = BRRuleID;
			paraNames[1] = "UsrAccountPK";
			paraValues[1] = UsrAccountPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBRRuleResult("GetByBRRuleID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBRRuleData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBRRuleData;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBRRuleData GetByPK(System.Guid UsrAccountBRRulePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountBRRulePK";
			paraValues[0] = UsrAccountBRRulePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBRRuleResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBRRuleData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBRRuleData;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBRRuleDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBRRuleResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBRRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBRRuleDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBRRuleViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBRRuleResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBRRuleViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBRRuleViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBRRuleDataCollection GetByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBRRuleResult("GetByUsrAccount", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBRRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBRRuleDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBRRuleViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBRRuleResult("GetViewByUsrAccount", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBRRuleViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBRRuleViewCollection;
			}
			return _result_;
		}

	}

	public static class UsrAccountBuildingMapWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountBuildingMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBuildingMapResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountBuildingMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBuildingMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountBuildingMapDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBuildingMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBuildingMapDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBuildingMapResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBuildingMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBuildingMapDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBuildingMapResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.UsrAccountBuildingMapDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBuildingMapResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBuildingMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBuildingMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBuildingMapData GetByUK(System.Guid UsrAccountPK,System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;
			paraNames[1] = "BDBuildingPK";
			paraValues[1] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBuildingMapResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBuildingMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBuildingMapData;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBuildingMapData GetByPK(System.Guid UsrAccountBuildingMapPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountBuildingMapPK";
			paraValues[0] = UsrAccountBuildingMapPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBuildingMapResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBuildingMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBuildingMapData;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBuildingMapDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBuildingMapResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBuildingMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBuildingMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBuildingMapViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBuildingMapResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBuildingMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBuildingMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBuildingMapDataCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBuildingMapResult("GetByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBuildingMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBuildingMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBuildingMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBuildingMapResult("GetViewByBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBuildingMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBuildingMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBuildingMapDataCollection GetByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBuildingMapResult("GetByUsrAccount", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBuildingMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBuildingMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountBuildingMapViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountBuildingMapResult("GetViewByUsrAccount", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountBuildingMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountBuildingMapViewCollection;
			}
			return _result_;
		}

	}

	public static class UsrAccountWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDataCollection GetByMappedBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetByMappedBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDataCollection GetByMappedBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetByMappedBDTenant", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.UsrAccountDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountData GetByUserID(System.String UserID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UserID";
			paraValues[0] = UserID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetByUserID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountData;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDataCollection GetByUsrGroupName(System.String UsrGroupName, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrGroupName";
			paraValues[0] = UsrGroupName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetByUsrGroupName", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDataCollection GetCentralUser( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetCentralUser", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDataCollection GetWebUser( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetWebUser", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDataCollection GetByModifiedOn(System.Boolean IsCentral,System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[3];
			object[] paraValues = new object[3];
			paraNames[0] = "IsCentral";
			paraValues[0] = IsCentral;
			paraNames[1] = "begin";
			paraValues[1] = begin.ToUniversalTime();
			paraNames[2] = "end";
			paraValues[2] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDataCollection;
			}
			return _result_;
		}

		public static System.Boolean IsTableExist(System.String tableName, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "tableName";
			paraValues[0] = tableName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("IsTableExist", BasicServiceBuilder.Serialize(_token_));
			System.Boolean _result_ =  (System.Boolean)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static System.String ExecuteNonQuery(System.String sql, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "sql";
			paraValues[0] = sql;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("ExecuteNonQuery", BasicServiceBuilder.Serialize(_token_));
			System.String _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as System.String;
			}
			return _result_;
		}

		public static System.String ExecuteScalar(System.String sql, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "sql";
			paraValues[0] = sql;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("ExecuteScalar", BasicServiceBuilder.Serialize(_token_));
			System.String _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as System.String;
			}
			return _result_;
		}

		public static System.Data.DataTable ExecuteDataTable(System.String sql, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "sql";
			paraValues[0] = sql;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("ExecuteDataTable", BasicServiceBuilder.Serialize(_token_));
			System.Data.DataTable _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as System.Data.DataTable;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountData GetByPK(System.Guid UsrAccountPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountData;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDataCollection GetByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetByBDTenant", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountViewCollection GetViewByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetViewByBDTenant", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDataCollection GetByUsrGroup(System.Guid UsrGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrGroupPK";
			paraValues[0] = UsrGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetByUsrGroup", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrGroupPK";
			paraValues[0] = UsrGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountResult("GetViewByUsrGroup", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountViewCollection;
			}
			return _result_;
		}

	}

	public static class UsrAccountDBRuleWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountDBRuleData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountDBRuleResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountDBRuleData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountDBRuleResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountDBRuleDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountDBRuleResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDBRuleDataCollection GetByDBRuleID(System.Int32 DBRuleID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "DBRuleID";
			paraValues[0] = DBRuleID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountDBRuleResult("GetByDBRuleID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDBRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDBRuleDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountDBRuleResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.UsrAccountDBRuleDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountDBRuleResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDBRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDBRuleDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDBRuleData GetByUK(System.Guid UsrAccountPK,System.Int32 DBRuleID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;
			paraNames[1] = "DBRuleID";
			paraValues[1] = DBRuleID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountDBRuleResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDBRuleData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDBRuleData;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDBRuleData GetByPK(System.Guid UsrAccountDBRulePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountDBRulePK";
			paraValues[0] = UsrAccountDBRulePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountDBRuleResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDBRuleData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDBRuleData;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDBRuleDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountDBRuleResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDBRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDBRuleDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDBRuleViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountDBRuleResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDBRuleViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDBRuleViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDBRuleDataCollection GetByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountDBRuleResult("GetByUsrAccount", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDBRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDBRuleDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountDBRuleViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountDBRuleResult("GetViewByUsrAccount", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountDBRuleViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountDBRuleViewCollection;
			}
			return _result_;
		}

	}

	public static class UsrAccountTenantMapWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountTenantMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountTenantMapResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountTenantMapData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountTenantMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountTenantMapDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountTenantMapResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountTenantMapDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountTenantMapResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountTenantMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountTenantMapDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountTenantMapResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.UsrAccountTenantMapDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountTenantMapResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountTenantMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountTenantMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountTenantMapData GetByUK(System.Guid UsrAccountPK,System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;
			paraNames[1] = "BDTenantPK";
			paraValues[1] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountTenantMapResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountTenantMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountTenantMapData;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountTenantMapData GetByPK(System.Guid UsrAccountTenantMapPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountTenantMapPK";
			paraValues[0] = UsrAccountTenantMapPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountTenantMapResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountTenantMapData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountTenantMapData;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountTenantMapDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountTenantMapResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountTenantMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountTenantMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountTenantMapViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountTenantMapResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountTenantMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountTenantMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountTenantMapDataCollection GetByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountTenantMapResult("GetByBDTenant", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountTenantMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountTenantMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountTenantMapViewCollection GetViewByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountTenantMapResult("GetViewByBDTenant", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountTenantMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountTenantMapViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountTenantMapDataCollection GetByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountTenantMapResult("GetByUsrAccount", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountTenantMapDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountTenantMapDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrAccountTenantMapViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrAccountPK";
			paraValues[0] = UsrAccountPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrAccountTenantMapResult("GetViewByUsrAccount", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrAccountTenantMapViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrAccountTenantMapViewCollection;
			}
			return _result_;
		}

	}

	public static class UsrGroupBRRuleWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrGroupBRRuleData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupBRRuleResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupBRRuleData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupBRRuleResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupBRRuleDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupBRRuleResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupBRRuleDataCollection GetByBRRuleID(System.Int32 BRRuleID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BRRuleID";
			paraValues[0] = BRRuleID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupBRRuleResult("GetByBRRuleID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupBRRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupBRRuleDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupBRRuleResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.UsrGroupBRRuleDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupBRRuleResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupBRRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupBRRuleDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupBRRuleData GetByUK(System.Guid UsrGroupPK,System.Int32 BRRuleID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "UsrGroupPK";
			paraValues[0] = UsrGroupPK;
			paraNames[1] = "BRRuleID";
			paraValues[1] = BRRuleID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupBRRuleResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupBRRuleData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupBRRuleData;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupBRRuleData GetByBRRuleID(System.Int32 BRRuleID,System.String UsrGroupName, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "BRRuleID";
			paraValues[0] = BRRuleID;
			paraNames[1] = "UsrGroupName";
			paraValues[1] = UsrGroupName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupBRRuleResult("GetByBRRuleID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupBRRuleData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupBRRuleData;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupBRRuleData GetByBRRuleID(System.Int32 BRRuleID,System.Guid UsrGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "BRRuleID";
			paraValues[0] = BRRuleID;
			paraNames[1] = "UsrGroupPK";
			paraValues[1] = UsrGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupBRRuleResult("GetByBRRuleID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupBRRuleData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupBRRuleData;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupBRRuleData GetByPK(System.Guid UsrGroupBRRule, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrGroupBRRule";
			paraValues[0] = UsrGroupBRRule;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupBRRuleResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupBRRuleData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupBRRuleData;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupBRRuleDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupBRRuleResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupBRRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupBRRuleDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupBRRuleViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupBRRuleResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupBRRuleViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupBRRuleViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupBRRuleDataCollection GetByUsrGroup(System.Guid UsrGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrGroupPK";
			paraValues[0] = UsrGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupBRRuleResult("GetByUsrGroup", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupBRRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupBRRuleDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupBRRuleViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrGroupPK";
			paraValues[0] = UsrGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupBRRuleResult("GetViewByUsrGroup", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupBRRuleViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupBRRuleViewCollection;
			}
			return _result_;
		}

	}

	public static class UsrGroupWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrGroupData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.UsrGroupDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupData GetByUsrGroupName(System.String UsrGroupName, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrGroupName";
			paraValues[0] = UsrGroupName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupResult("GetByUsrGroupName", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupData;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupData GetByPK(System.Guid UsrGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrGroupPK";
			paraValues[0] = UsrGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupData;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupViewCollection;
			}
			return _result_;
		}

	}

	public static class UsrGroupDBRuleWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrGroupDBRuleData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupDBRuleResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupDBRuleData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupDBRuleResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupDBRuleDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupDBRuleResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupDBRuleDataCollection GetByDBRuleID(System.Int32 DBRuleID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "DBRuleID";
			paraValues[0] = DBRuleID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupDBRuleResult("GetByDBRuleID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupDBRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupDBRuleDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupDBRuleResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.UsrGroupDBRuleDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupDBRuleResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupDBRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupDBRuleDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupDBRuleData GetByUK(System.Guid UsrGroupPK,System.Int32 DBRuleID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "UsrGroupPK";
			paraValues[0] = UsrGroupPK;
			paraNames[1] = "DBRuleID";
			paraValues[1] = DBRuleID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupDBRuleResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupDBRuleData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupDBRuleData;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupDBRuleData GetByPK(System.Guid UsrGroupDBRulePK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrGroupDBRulePK";
			paraValues[0] = UsrGroupDBRulePK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupDBRuleResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupDBRuleData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupDBRuleData;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupDBRuleDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupDBRuleResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupDBRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupDBRuleDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupDBRuleViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupDBRuleResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupDBRuleViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupDBRuleViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupDBRuleDataCollection GetByUsrGroup(System.Guid UsrGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrGroupPK";
			paraValues[0] = UsrGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupDBRuleResult("GetByUsrGroup", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupDBRuleDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupDBRuleDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UsrGroupDBRuleViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UsrGroupPK";
			paraValues[0] = UsrGroupPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUsrGroupDBRuleResult("GetViewByUsrGroup", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UsrGroupDBRuleViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UsrGroupDBRuleViewCollection;
			}
			return _result_;
		}

	}

	public static class UtilHolidayWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UtilHolidayData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilHolidayData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilHolidayDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.UtilHolidayDataCollection GetByCountryID(System.Int32 CountryID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "CountryID";
			paraValues[0] = CountryID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("GetByCountryID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilHolidayDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilHolidayDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UtilHolidayDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilHolidayDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilHolidayDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UtilHolidayDataCollection GetByMappedACInterval(System.Guid ACIntervalPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACIntervalPK";
			paraValues[0] = ACIntervalPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("GetByMappedACInterval", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilHolidayDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilHolidayDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UtilHolidayDataCollection GetByMappedACPanel(System.Guid ACPanelPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "ACPanelPK";
			paraValues[0] = ACPanelPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("GetByMappedACPanel", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilHolidayDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilHolidayDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UtilHolidayDataCollection GetByMappedBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDBuildingPK";
			paraValues[0] = BDBuildingPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("GetByMappedBDBuilding", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilHolidayDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilHolidayDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UtilHolidayDataCollection GetByMappedBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "BDTenantPK";
			paraValues[0] = BDTenantPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("GetByMappedBDTenant", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilHolidayDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilHolidayDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.UtilHolidayDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilHolidayDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilHolidayDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UtilHolidayData GetByUK(System.Int32 CountryID,System.String Holiday, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "CountryID";
			paraValues[0] = CountryID;
			paraNames[1] = "Holiday";
			paraValues[1] = Holiday;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilHolidayData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilHolidayData;
			}
			return _result_;
		}

		public static W3000.Data.UtilHolidayData GetByUK1(System.DateTime Date,System.Int32 CountryID, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "Date";
			paraValues[0] = Date.ToUniversalTime();
			paraNames[1] = "CountryID";
			paraValues[1] = CountryID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("GetByUK1", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilHolidayData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilHolidayData;
			}
			return _result_;
		}

		public static W3000.Data.UtilHolidayData GetByPK(System.Guid UtilHolidayPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilHolidayPK";
			paraValues[0] = UtilHolidayPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilHolidayData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilHolidayData;
			}
			return _result_;
		}

		public static W3000.Data.UtilHolidayDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilHolidayDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilHolidayDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UtilHolidayViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilHolidayResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilHolidayViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilHolidayViewCollection;
			}
			return _result_;
		}

	}

	public static class UtilSettingCategoryWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UtilSettingCategoryData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingCategoryResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilSettingCategoryData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingCategoryResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilSettingCategoryDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingCategoryResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.UtilSettingCategoryDataCollection GetBySettingCategoryID(System.Int32 SettingCategoryID, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "SettingCategoryID";
			paraValues[0] = SettingCategoryID;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingCategoryResult("GetBySettingCategoryID", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingCategoryDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingCategoryDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UtilSettingCategoryDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingCategoryResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingCategoryDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingCategoryDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingCategoryResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.UtilSettingCategoryDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingCategoryResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingCategoryDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingCategoryDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UtilSettingCategoryData GetByUK(System.Int32 SettingCategoryID,System.String InstanceName, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "SettingCategoryID";
			paraValues[0] = SettingCategoryID;
			paraNames[1] = "InstanceName";
			paraValues[1] = InstanceName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingCategoryResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingCategoryData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingCategoryData;
			}
			return _result_;
		}

		public static W3000.Data.UtilSettingCategoryData GetByPK(System.Guid UtilSettingCategoryPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilSettingCategoryPK";
			paraValues[0] = UtilSettingCategoryPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingCategoryResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingCategoryData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingCategoryData;
			}
			return _result_;
		}

		public static W3000.Data.UtilSettingCategoryDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingCategoryResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingCategoryDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingCategoryDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UtilSettingCategoryViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingCategoryResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingCategoryViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingCategoryViewCollection;
			}
			return _result_;
		}

	}

	public static class UtilSettingDetailWrapper
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UtilSettingDetailData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingDetailResult("Purge", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilSettingDetailData entity, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "entity";
			paraValues[0] = entity;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingDetailResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilSettingDetailDataCollection list, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "list";
			paraValues[0] = list;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingDetailResult("Save", BasicServiceBuilder.Serialize(_token_));
			Cheke.BusinessEntity.Result _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as Cheke.BusinessEntity.Result;
			}
			return _result_;
		}

		public static W3000.Data.UtilSettingDetailDataCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "begin";
			paraValues[0] = begin.ToUniversalTime();
			paraNames[1] = "end";
			paraValues[1] = end.ToUniversalTime();

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingDetailResult("GetByModifiedOn", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingDetailDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingDetailDataCollection;
			}
			return _result_;
		}

		public static System.Int32 GetAllCount( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingDetailResult("GetAllCount", BasicServiceBuilder.Serialize(_token_));
			System.Int32 _result_ =  (System.Int32)Compression.DecompressToObject(_data_);
			return _result_;
		}

		public static W3000.Data.UtilSettingDetailDataCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "pageIndex";
			paraValues[0] = pageIndex;
			paraNames[1] = "pageSize";
			paraValues[1] = pageSize;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingDetailResult("GetAllPage", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingDetailDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingDetailDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UtilSettingDetailData GetByUK(System.Guid UtilSettingCategoryPK,System.String FieldName, SecurityToken token)
		{
			string[] paraNames = new string[2];
			object[] paraValues = new object[2];
			paraNames[0] = "UtilSettingCategoryPK";
			paraValues[0] = UtilSettingCategoryPK;
			paraNames[1] = "FieldName";
			paraValues[1] = FieldName;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingDetailResult("GetByUK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingDetailData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingDetailData;
			}
			return _result_;
		}

		public static W3000.Data.UtilSettingDetailData GetByPK(System.Guid UtilSettingDetailPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilSettingDetailPK";
			paraValues[0] = UtilSettingDetailPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingDetailResult("GetByPK", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingDetailData _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingDetailData;
			}
			return _result_;
		}

		public static W3000.Data.UtilSettingDetailDataCollection GetAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingDetailResult("GetAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingDetailDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingDetailDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UtilSettingDetailViewCollection GetViewAll( SecurityToken token)
		{
			string[] paraNames = new string[0];
			object[] paraValues = new object[0];

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingDetailResult("GetViewAll", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingDetailViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingDetailViewCollection;
			}
			return _result_;
		}

		public static W3000.Data.UtilSettingDetailDataCollection GetByUtilSettingCategory(System.Guid UtilSettingCategoryPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilSettingCategoryPK";
			paraValues[0] = UtilSettingCategoryPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingDetailResult("GetByUtilSettingCategory", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingDetailDataCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingDetailDataCollection;
			}
			return _result_;
		}

		public static W3000.Data.UtilSettingDetailViewCollection GetViewByUtilSettingCategory(System.Guid UtilSettingCategoryPK, SecurityToken token)
		{
			string[] paraNames = new string[1];
			object[] paraValues = new object[1];
			paraNames[0] = "UtilSettingCategoryPK";
			paraValues[0] = UtilSettingCategoryPK;

			SecurityToken _token_ = SecurityToken.CreateFrameworkToken(token, paraNames, paraValues);

			byte[] _data_ = BasicServiceBuilder.Factory.GetUtilSettingDetailResult("GetViewByUtilSettingCategory", BasicServiceBuilder.Serialize(_token_));
			W3000.Data.UtilSettingDetailViewCollection _result_ = null;
			if(_data_ != null)
			{
				_result_ =  Compression.DecompressToObject(_data_) as W3000.Data.UtilSettingDetailViewCollection;
			}
			return _result_;
		}

	}

	internal static class BasicServiceBuilder
	{
		internal static byte[] Serialize(object obj)
		{
			using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
			{
				new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Serialize(stream, obj);
				return stream.ToArray();
			}
		}

		internal static IBasicServiceFactory Factory
		{
			get{ return (IBasicServiceFactory) Cheke.ClassFactory.ClassBuilder.GetFactory("W3000.BasicServiceFactory");}
		}
	}
}
