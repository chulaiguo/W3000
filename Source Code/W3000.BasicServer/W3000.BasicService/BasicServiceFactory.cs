using System;
using Cheke;
using W3000.Data;
using W3000.DataService;
using W3000.IBasicService;

namespace W3000.BasicService
{
	public class BasicServiceFactory: MarshalByRefObject, IBasicServiceFactory
	{
		public byte[] GetACAccessLevelResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACAccessLevelDataService svr = DataServiceFactory.CreateACAccessLevelDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACAccessLevelDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACAccessLevelDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDBuilding" :
				{
					W3000.Data.ACAccessLevelDataCollection _result_  = svr.GetByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedACMainZone" :
				{
					W3000.Data.ACAccessLevelDataCollection _result_  = svr.GetByMappedACMainZone((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACAccessLevelDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACAccessLevelData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACAccessLevelData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Int16)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACAccessLevelViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDBuilding" :
				{
					W3000.Data.ACAccessLevelViewCollection _result_  = svr.GetViewByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACAccessLevelData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACAccessLevelData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACAccessLevelDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACAccessLevelDetailResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACAccessLevelDetailDataService svr = DataServiceFactory.CreateACAccessLevelDetailDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACAccessLevelDetailDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACAccessLevelDetailDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACAccessLevel" :
				{
					W3000.Data.ACAccessLevelDetailDataCollection _result_  = svr.GetByACAccessLevel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACMainZone" :
				{
					W3000.Data.ACAccessLevelDetailDataCollection _result_  = svr.GetByACMainZone((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACTimecode" :
				{
					W3000.Data.ACAccessLevelDetailDataCollection _result_  = svr.GetByACTimecode((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACAccessLevelDetailDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACAccessLevelDetailData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACAccessLevelDetailData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Guid)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACAccessLevelDetailViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACAccessLevel" :
				{
					W3000.Data.ACAccessLevelDetailViewCollection _result_  = svr.GetViewByACAccessLevel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACMainZone" :
				{
					W3000.Data.ACAccessLevelDetailViewCollection _result_  = svr.GetViewByACMainZone((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACTimecode" :
				{
					W3000.Data.ACAccessLevelDetailViewCollection _result_  = svr.GetViewByACTimecode((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACAccessLevelDetailData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACAccessLevelDetailData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACAccessLevelDetailDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACAMFormatResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACAMFormatDataService svr = DataServiceFactory.CreateACAMFormatDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACAMFormatDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACAMFormatDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDBuilding" :
				{
					W3000.Data.ACAMFormatDataCollection _result_  = svr.GetByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACAMFormatDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACAMFormatData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACAMFormatData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Int16)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACAMFormatViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDBuilding" :
				{
					W3000.Data.ACAMFormatViewCollection _result_  = svr.GetViewByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACAMFormatData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACAMFormatData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACAMFormatDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACCardHolderBuildingMapResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACCardHolderBuildingMapDataService svr = DataServiceFactory.CreateACCardHolderBuildingMapDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACCardHolderBuildingMapDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACCardHolderBuildingMapDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACCardHolder" :
				{
					W3000.Data.ACCardHolderBuildingMapDataCollection _result_  = svr.GetByACCardHolder((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDBuilding" :
				{
					W3000.Data.ACCardHolderBuildingMapDataCollection _result_  = svr.GetByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACCardHolderBuildingMapDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACCardHolderBuildingMapData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACCardHolderBuildingMapData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Guid)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACCardHolderBuildingMapViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACCardHolder" :
				{
					W3000.Data.ACCardHolderBuildingMapViewCollection _result_  = svr.GetViewByACCardHolder((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDBuilding" :
				{
					W3000.Data.ACCardHolderBuildingMapViewCollection _result_  = svr.GetViewByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACCardHolderBuildingMapData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACCardHolderBuildingMapData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACCardHolderBuildingMapDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACCardHolderResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACCardHolderDataService svr = DataServiceFactory.CreateACCardHolderDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACCardHolderDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACCardHolderDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDTenant" :
				{
					W3000.Data.ACCardHolderDataCollection _result_  = svr.GetByBDTenant((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByCriteria" :
				{
					if(token.ParameterNames == "criteria")
					{
						W3000.Data.ACCardHolderDataCollection _result_  = svr.GetByCriteria((W3000.Data.CriteriaACCardHolderView)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "criteria|pageIndex|pageSize")
					{
						W3000.Data.ACCardHolderDataCollection _result_  = svr.GetByCriteria((W3000.Data.CriteriaACCardHolderView)token.GetParameter(0),(System.Int32)token.GetParameter(1),(System.Int32)token.GetParameter(2));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
				case "GetByLikeFirstName" :
				{
					W3000.Data.ACCardHolderDataCollection _result_  = svr.GetByLikeFirstName((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByLikeLastName" :
				{
					W3000.Data.ACCardHolderDataCollection _result_  = svr.GetByLikeLastName((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedBDBuilding" :
				{
					W3000.Data.ACCardHolderDataCollection _result_  = svr.GetByMappedBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACCardHolderDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACCardHolderData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACCardHolderData _result_  = svr.GetByUK((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1),(System.Int32)token.GetParameter(2));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK1" :
				{
					W3000.Data.ACCardHolderData _result_  = svr.GetByUK1((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1),(System.Int32)token.GetParameter(2));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByValidThru" :
				{
					W3000.Data.ACCardHolderDataCollection _result_  = svr.GetByValidThru(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetCountByCriteria" :
				{
					System.Int32 _result_  = svr.GetCountByCriteria((W3000.Data.CriteriaACCardHolderView)token.GetParameter(0));
					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACCardHolderViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDTenant" :
				{
					W3000.Data.ACCardHolderViewCollection _result_  = svr.GetViewByBDTenant((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACCardHolderData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACCardHolderData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACCardHolderDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACFunctionCardResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACFunctionCardDataService svr = DataServiceFactory.CreateACFunctionCardDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACFunctionCardDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACFunctionCardDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDTenant" :
				{
					W3000.Data.ACFunctionCardDataCollection _result_  = svr.GetByBDTenant((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByCardTypeID" :
				{
					W3000.Data.ACFunctionCardDataCollection _result_  = svr.GetByCardTypeID((System.Int32)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByLikeFirstName" :
				{
					W3000.Data.ACFunctionCardDataCollection _result_  = svr.GetByLikeFirstName((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByLikeLastName" :
				{
					W3000.Data.ACFunctionCardDataCollection _result_  = svr.GetByLikeLastName((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedACPanel" :
				{
					W3000.Data.ACFunctionCardDataCollection _result_  = svr.GetByMappedACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACFunctionCardDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACFunctionCardData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACFunctionCardData _result_  = svr.GetByUK((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1),(System.Int32)token.GetParameter(2));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK1" :
				{
					W3000.Data.ACFunctionCardData _result_  = svr.GetByUK1((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1),(System.Int32)token.GetParameter(2));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACFunctionCardViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDTenant" :
				{
					W3000.Data.ACFunctionCardViewCollection _result_  = svr.GetViewByBDTenant((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACFunctionCardData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACFunctionCardData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACFunctionCardDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACInputResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACInputDataService svr = DataServiceFactory.CreateACInputDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACInputDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACInputDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACPanel" :
				{
					W3000.Data.ACInputDataCollection _result_  = svr.GetByACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedACInputGroup" :
				{
					W3000.Data.ACInputDataCollection _result_  = svr.GetByMappedACInputGroup((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACInputDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACInputData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACInputData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Byte)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACInputViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACPanel" :
				{
					W3000.Data.ACInputViewCollection _result_  = svr.GetViewByACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACInputData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACInputData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACInputDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACInputGroupResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACInputGroupDataService svr = DataServiceFactory.CreateACInputGroupDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACInputGroupDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACInputGroupDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACPanel" :
				{
					W3000.Data.ACInputGroupDataCollection _result_  = svr.GetByACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedACInput" :
				{
					W3000.Data.ACInputGroupDataCollection _result_  = svr.GetByMappedACInput((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACInputGroupDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACInputGroupData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACInputGroupData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Byte)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACInputGroupViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACPanel" :
				{
					W3000.Data.ACInputGroupViewCollection _result_  = svr.GetViewByACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACInputGroupData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACInputGroupData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACInputGroupDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACInputGroupInputMapResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACInputGroupInputMapDataService svr = DataServiceFactory.CreateACInputGroupInputMapDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACInputGroupInputMapDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACInputGroupInputMapDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACInput" :
				{
					W3000.Data.ACInputGroupInputMapDataCollection _result_  = svr.GetByACInput((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACInputGroup" :
				{
					W3000.Data.ACInputGroupInputMapDataCollection _result_  = svr.GetByACInputGroup((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACInputGroupInputMapDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACInputGroupInputMapData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACInputGroupInputMapData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Guid)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACInputGroupInputMapViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACInput" :
				{
					W3000.Data.ACInputGroupInputMapViewCollection _result_  = svr.GetViewByACInput((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACInputGroup" :
				{
					W3000.Data.ACInputGroupInputMapViewCollection _result_  = svr.GetViewByACInputGroup((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACInputGroupInputMapData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACInputGroupInputMapData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACInputGroupInputMapDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACIntervalResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACIntervalDataService svr = DataServiceFactory.CreateACIntervalDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACIntervalDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACIntervalDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDBuilding" :
				{
					W3000.Data.ACIntervalDataCollection _result_  = svr.GetByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedACTimecode" :
				{
					W3000.Data.ACIntervalDataCollection _result_  = svr.GetByMappedACTimecode((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedUtilHoliday" :
				{
					W3000.Data.ACIntervalDataCollection _result_  = svr.GetByMappedUtilHoliday((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACIntervalDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACIntervalData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACIntervalData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Int16)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACIntervalViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDBuilding" :
				{
					W3000.Data.ACIntervalViewCollection _result_  = svr.GetViewByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACIntervalData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACIntervalData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACIntervalDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACIntvalHolidayMapResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACIntvalHolidayMapDataService svr = DataServiceFactory.CreateACIntvalHolidayMapDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACIntvalHolidayMapDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACIntvalHolidayMapDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACInterval" :
				{
					W3000.Data.ACIntvalHolidayMapDataCollection _result_  = svr.GetByACInterval((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACIntvalHolidayMapDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACIntvalHolidayMapData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACIntvalHolidayMapData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Guid)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUtilHoliday" :
				{
					W3000.Data.ACIntvalHolidayMapDataCollection _result_  = svr.GetByUtilHoliday((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACIntvalHolidayMapViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACInterval" :
				{
					W3000.Data.ACIntvalHolidayMapViewCollection _result_  = svr.GetViewByACInterval((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByUtilHoliday" :
				{
					W3000.Data.ACIntvalHolidayMapViewCollection _result_  = svr.GetViewByUtilHoliday((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACIntvalHolidayMapData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACIntvalHolidayMapData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACIntvalHolidayMapDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACMainZoneResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACMainZoneDataService svr = DataServiceFactory.CreateACMainZoneDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACMainZoneDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACMainZoneDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACPanel" :
				{
					W3000.Data.ACMainZoneDataCollection _result_  = svr.GetByACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMainZoneTypeID" :
				{
					W3000.Data.ACMainZoneDataCollection _result_  = svr.GetByMainZoneTypeID((System.Int32)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedACOutputGroup" :
				{
					W3000.Data.ACMainZoneDataCollection _result_  = svr.GetByMappedACOutputGroup((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedACTimecode" :
				{
					W3000.Data.ACMainZoneDataCollection _result_  = svr.GetByMappedACTimecode((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACMainZoneDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACMainZoneData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByReaderTypeID" :
				{
					W3000.Data.ACMainZoneDataCollection _result_  = svr.GetByReaderTypeID((System.Int32)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACMainZoneData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Byte)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACMainZoneViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACPanel" :
				{
					W3000.Data.ACMainZoneViewCollection _result_  = svr.GetViewByACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACMainZoneData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACMainZoneData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACMainZoneDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACMasterCardResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACMasterCardDataService svr = DataServiceFactory.CreateACMasterCardDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACMasterCardDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACMasterCardDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByCardTypeID" :
				{
					W3000.Data.ACMasterCardDataCollection _result_  = svr.GetByCardTypeID((System.Int32)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByLikeFirstName" :
				{
					W3000.Data.ACMasterCardDataCollection _result_  = svr.GetByLikeFirstName((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByLikeLastName" :
				{
					W3000.Data.ACMasterCardDataCollection _result_  = svr.GetByLikeLastName((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACMasterCardDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACMasterCardData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACMasterCardData _result_  = svr.GetByUK((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1),(System.Int32)token.GetParameter(2));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK1" :
				{
					W3000.Data.ACMasterCardData _result_  = svr.GetByUK1((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1),(System.Int32)token.GetParameter(2));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACMasterCardViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACMasterCardData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACMasterCardData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACMasterCardDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACOutputGroupResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACOutputGroupDataService svr = DataServiceFactory.CreateACOutputGroupDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACOutputGroupDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACOutputGroupDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACPanel" :
				{
					W3000.Data.ACOutputGroupDataCollection _result_  = svr.GetByACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedACMainZone" :
				{
					W3000.Data.ACOutputGroupDataCollection _result_  = svr.GetByMappedACMainZone((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACOutputGroupDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACOutputGroupData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACOutputGroupData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Byte)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACOutputGroupViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACPanel" :
				{
					W3000.Data.ACOutputGroupViewCollection _result_  = svr.GetViewByACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACOutputGroupData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACOutputGroupData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACOutputGroupDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACOutputGroupMainZoneMapResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACOutputGroupMainZoneMapDataService svr = DataServiceFactory.CreateACOutputGroupMainZoneMapDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACMainZone" :
				{
					W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_  = svr.GetByACMainZone((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACOutputGroup" :
				{
					W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_  = svr.GetByACOutputGroup((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACOutputGroupMainZoneMapData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACOutputGroupMainZoneMapData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Guid)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACOutputGroupMainZoneMapViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACMainZone" :
				{
					W3000.Data.ACOutputGroupMainZoneMapViewCollection _result_  = svr.GetViewByACMainZone((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACOutputGroup" :
				{
					W3000.Data.ACOutputGroupMainZoneMapViewCollection _result_  = svr.GetViewByACOutputGroup((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACOutputGroupMainZoneMapData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACOutputGroupMainZoneMapData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACOutputGroupMainZoneMapDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACPanelResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACPanelDataService svr = DataServiceFactory.CreateACPanelDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACPanelDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACPanelDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDBuilding" :
				{
					W3000.Data.ACPanelDataCollection _result_  = svr.GetByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByLikeUnitPhone" :
				{
					W3000.Data.ACPanelDataCollection _result_  = svr.GetByLikeUnitPhone((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByLikeUnitPhoneCallerID" :
				{
					W3000.Data.ACPanelDataCollection _result_  = svr.GetByLikeUnitPhoneCallerID((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedACFunctionCard" :
				{
					W3000.Data.ACPanelDataCollection _result_  = svr.GetByMappedACFunctionCard((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedUtilHoliday" :
				{
					W3000.Data.ACPanelDataCollection _result_  = svr.GetByMappedUtilHoliday((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACPanelDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPanelTypeID" :
				{
					W3000.Data.ACPanelDataCollection _result_  = svr.GetByPanelTypeID((System.Int32)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACPanelData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUnitID" :
				{
					W3000.Data.ACPanelData _result_  = svr.GetByUnitID((System.Int32)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACPanelViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDBuilding" :
				{
					W3000.Data.ACPanelViewCollection _result_  = svr.GetViewByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACPanelData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACPanelData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACPanelDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACPanelFunctionCardMapResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACPanelFunctionCardMapDataService svr = DataServiceFactory.CreateACPanelFunctionCardMapDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACPanelFunctionCardMapDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACPanelFunctionCardMapDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACFunctionCard" :
				{
					W3000.Data.ACPanelFunctionCardMapDataCollection _result_  = svr.GetByACFunctionCard((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACPanel" :
				{
					W3000.Data.ACPanelFunctionCardMapDataCollection _result_  = svr.GetByACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACPanelFunctionCardMapDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACPanelFunctionCardMapData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACPanelFunctionCardMapData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Guid)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACPanelFunctionCardMapViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACFunctionCard" :
				{
					W3000.Data.ACPanelFunctionCardMapViewCollection _result_  = svr.GetViewByACFunctionCard((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACPanel" :
				{
					W3000.Data.ACPanelFunctionCardMapViewCollection _result_  = svr.GetViewByACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACPanelFunctionCardMapData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACPanelFunctionCardMapData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACPanelFunctionCardMapDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACPanelHolidayMapResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACPanelHolidayMapDataService svr = DataServiceFactory.CreateACPanelHolidayMapDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACPanelHolidayMapDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACPanelHolidayMapDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACPanel" :
				{
					W3000.Data.ACPanelHolidayMapDataCollection _result_  = svr.GetByACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACPanelHolidayMapDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACPanelHolidayMapData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACPanelHolidayMapData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Guid)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUtilHoliday" :
				{
					W3000.Data.ACPanelHolidayMapDataCollection _result_  = svr.GetByUtilHoliday((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACPanelHolidayMapViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACPanel" :
				{
					W3000.Data.ACPanelHolidayMapViewCollection _result_  = svr.GetViewByACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByUtilHoliday" :
				{
					W3000.Data.ACPanelHolidayMapViewCollection _result_  = svr.GetViewByUtilHoliday((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACPanelHolidayMapData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACPanelHolidayMapData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACPanelHolidayMapDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACSupervisoryResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACSupervisoryDataService svr = DataServiceFactory.CreateACSupervisoryDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACSupervisoryDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACSupervisoryDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACPanel" :
				{
					W3000.Data.ACSupervisoryDataCollection _result_  = svr.GetByACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACSupervisoryDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACSupervisoryData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACSupervisoryData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Byte)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACSupervisoryViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACPanel" :
				{
					W3000.Data.ACSupervisoryViewCollection _result_  = svr.GetViewByACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACSupervisoryData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACSupervisoryData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACSupervisoryDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACTimecodeResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACTimecodeDataService svr = DataServiceFactory.CreateACTimecodeDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACTimecodeDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACTimecodeDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDBuilding" :
				{
					W3000.Data.ACTimecodeDataCollection _result_  = svr.GetByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedACInterval" :
				{
					W3000.Data.ACTimecodeDataCollection _result_  = svr.GetByMappedACInterval((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedACMainZone" :
				{
					W3000.Data.ACTimecodeDataCollection _result_  = svr.GetByMappedACMainZone((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACTimecodeDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACTimecodeData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACTimecodeData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Int16)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACTimecodeViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDBuilding" :
				{
					W3000.Data.ACTimecodeViewCollection _result_  = svr.GetViewByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACTimecodeData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACTimecodeData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACTimecodeDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetACTimecodeIntervalMapResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			ACTimecodeIntervalMapDataService svr = DataServiceFactory.CreateACTimecodeIntervalMapDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.ACTimecodeIntervalMapDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.ACTimecodeIntervalMapDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACInterval" :
				{
					W3000.Data.ACTimecodeIntervalMapDataCollection _result_  = svr.GetByACInterval((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByACTimecode" :
				{
					W3000.Data.ACTimecodeIntervalMapDataCollection _result_  = svr.GetByACTimecode((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.ACTimecodeIntervalMapDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.ACTimecodeIntervalMapData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.ACTimecodeIntervalMapData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Guid)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.ACTimecodeIntervalMapViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACInterval" :
				{
					W3000.Data.ACTimecodeIntervalMapViewCollection _result_  = svr.GetViewByACInterval((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByACTimecode" :
				{
					W3000.Data.ACTimecodeIntervalMapViewCollection _result_  = svr.GetViewByACTimecode((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.ACTimecodeIntervalMapData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACTimecodeIntervalMapData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.ACTimecodeIntervalMapDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetBDBuildingResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			BDBuildingDataService svr = DataServiceFactory.CreateBDBuildingDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.BDBuildingDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.BDBuildingDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByAddress1" :
				{
					W3000.Data.BDBuildingData _result_  = svr.GetByAddress1((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBuildingID" :
				{
					W3000.Data.BDBuildingData _result_  = svr.GetByBuildingID((System.Int32)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByCountryID" :
				{
					W3000.Data.BDBuildingDataCollection _result_  = svr.GetByCountryID((System.Int32)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByCriteria" :
				{
					if(token.ParameterNames == "criteria")
					{
						W3000.Data.BDBuildingDataCollection _result_  = svr.GetByCriteria((W3000.Data.CriteriaBDBuildingView)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "criteria|pageIndex|pageSize")
					{
						W3000.Data.BDBuildingDataCollection _result_  = svr.GetByCriteria((W3000.Data.CriteriaBDBuildingView)token.GetParameter(0),(System.Int32)token.GetParameter(1),(System.Int32)token.GetParameter(2));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
				case "GetByLikeStreetName" :
				{
					W3000.Data.BDBuildingDataCollection _result_  = svr.GetByLikeStreetName((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByLikeStreetNumb" :
				{
					W3000.Data.BDBuildingDataCollection _result_  = svr.GetByLikeStreetNumb((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedACCardHolder" :
				{
					W3000.Data.BDBuildingDataCollection _result_  = svr.GetByMappedACCardHolder((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedUsrAccount" :
				{
					W3000.Data.BDBuildingDataCollection _result_  = svr.GetByMappedUsrAccount((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedUtilHoliday" :
				{
					W3000.Data.BDBuildingDataCollection _result_  = svr.GetByMappedUtilHoliday((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.BDBuildingData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetBySystemTypeID" :
				{
					W3000.Data.BDBuildingDataCollection _result_  = svr.GetBySystemTypeID((System.Int32)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetCountByCriteria" :
				{
					System.Int32 _result_  = svr.GetCountByCriteria((W3000.Data.CriteriaBDBuildingView)token.GetParameter(0));
					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.BDBuildingViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.BDBuildingData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.BDBuildingData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.BDBuildingDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetBDBuildingHolidayMapResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			BDBuildingHolidayMapDataService svr = DataServiceFactory.CreateBDBuildingHolidayMapDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.BDBuildingHolidayMapDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.BDBuildingHolidayMapDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDBuilding" :
				{
					W3000.Data.BDBuildingHolidayMapDataCollection _result_  = svr.GetByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.BDBuildingHolidayMapData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.BDBuildingHolidayMapData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Guid)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUtilHoliday" :
				{
					W3000.Data.BDBuildingHolidayMapDataCollection _result_  = svr.GetByUtilHoliday((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.BDBuildingHolidayMapViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDBuilding" :
				{
					W3000.Data.BDBuildingHolidayMapViewCollection _result_  = svr.GetViewByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByUtilHoliday" :
				{
					W3000.Data.BDBuildingHolidayMapViewCollection _result_  = svr.GetViewByUtilHoliday((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.BDBuildingHolidayMapData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.BDBuildingHolidayMapData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.BDBuildingHolidayMapDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetBDTenantResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			BDTenantDataService svr = DataServiceFactory.CreateBDTenantDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.BDTenantDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.BDTenantDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDBuilding" :
				{
					W3000.Data.BDTenantDataCollection _result_  = svr.GetByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedUsrAccount" :
				{
					W3000.Data.BDTenantDataCollection _result_  = svr.GetByMappedUsrAccount((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedUtilHoliday" :
				{
					W3000.Data.BDTenantDataCollection _result_  = svr.GetByMappedUtilHoliday((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.BDTenantDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.BDTenantData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetBySystemTypeID" :
				{
					W3000.Data.BDTenantDataCollection _result_  = svr.GetBySystemTypeID((System.Int32)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.BDTenantData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.String)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.BDTenantViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDBuilding" :
				{
					W3000.Data.BDTenantViewCollection _result_  = svr.GetViewByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.BDTenantData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.BDTenantData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.BDTenantDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetBDTenantHolidayMapResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			BDTenantHolidayMapDataService svr = DataServiceFactory.CreateBDTenantHolidayMapDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.BDTenantHolidayMapDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.BDTenantHolidayMapDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDTenant" :
				{
					W3000.Data.BDTenantHolidayMapDataCollection _result_  = svr.GetByBDTenant((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.BDTenantHolidayMapData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.BDTenantHolidayMapData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Guid)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUtilHoliday" :
				{
					W3000.Data.BDTenantHolidayMapDataCollection _result_  = svr.GetByUtilHoliday((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.BDTenantHolidayMapViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDTenant" :
				{
					W3000.Data.BDTenantHolidayMapViewCollection _result_  = svr.GetViewByBDTenant((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByUtilHoliday" :
				{
					W3000.Data.BDTenantHolidayMapViewCollection _result_  = svr.GetViewByUtilHoliday((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.BDTenantHolidayMapData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.BDTenantHolidayMapData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.BDTenantHolidayMapDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetBDVisitorResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			BDVisitorDataService svr = DataServiceFactory.CreateBDVisitorDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.BDVisitorDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.BDVisitorDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDTenant" :
				{
					W3000.Data.BDVisitorDataCollection _result_  = svr.GetByBDTenant((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByLikeLastName" :
				{
					W3000.Data.BDVisitorDataCollection _result_  = svr.GetByLikeLastName((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.BDVisitorDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.BDVisitorData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByValidThru" :
				{
					W3000.Data.BDVisitorDataCollection _result_  = svr.GetByValidThru(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.BDVisitorViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDTenant" :
				{
					W3000.Data.BDVisitorViewCollection _result_  = svr.GetViewByBDTenant((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.BDVisitorData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.BDVisitorData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.BDVisitorDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetLogDBDeleteActivityResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			LogDBDeleteActivityDataService svr = DataServiceFactory.CreateLogDBDeleteActivityDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.LogDBDeleteActivityDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByLogDateTime" :
				{
					if(token.ParameterNames == "begin|end")
					{
						W3000.Data.LogDBDeleteActivityDataCollection _result_  = svr.GetByLogDateTime(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "begin|end|tableName")
					{
						W3000.Data.LogDBDeleteActivityDataCollection _result_  = svr.GetByLogDateTime(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime(),(System.String)token.GetParameter(2));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
				case "GetByPK" :
				{
					W3000.Data.LogDBDeleteActivityData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.LogDBDeleteActivityViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.LogDBDeleteActivityData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.LogDBDeleteActivityData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.LogDBDeleteActivityDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetLogDBEditActivityResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			LogDBEditActivityDataService svr = DataServiceFactory.CreateLogDBEditActivityDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.LogDBEditActivityDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByDeleteRecords" :
				{
					W3000.Data.LogDBEditActivityDataCollection _result_  = svr.GetByDeleteRecords(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime(),(System.String)token.GetParameter(2));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByLogDateTime" :
				{
					if(token.ParameterNames == "begin|end")
					{
						W3000.Data.LogDBEditActivityDataCollection _result_  = svr.GetByLogDateTime(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "begin|end|recordPK")
					{
						W3000.Data.LogDBEditActivityDataCollection _result_  = svr.GetByLogDateTime(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime(),(System.Guid)token.GetParameter(2));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "begin|end|tableName")
					{
						W3000.Data.LogDBEditActivityDataCollection _result_  = svr.GetByLogDateTime(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime(),(System.String)token.GetParameter(2));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
				case "GetByPK" :
				{
					W3000.Data.LogDBEditActivityData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetDeletedRecord" :
				{
					W3000.Data.LogDBEditActivityData _result_  = svr.GetDeletedRecord(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),(System.Guid)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.LogDBEditActivityViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.LogDBEditActivityData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.LogDBEditActivityData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.LogDBEditActivityDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetLogRowsCountResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			LogRowsCountDataService svr = DataServiceFactory.CreateLogRowsCountDataService(token, false);
			switch (actionName)
			{
				case "DeleteBySessionDateTime" :
				{
					System.Int32 _result_  = svr.DeleteBySessionDateTime(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					return Compression.Compress(_result_);
				}
				case "GetAll" :
				{
					W3000.Data.LogRowsCountDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.LogRowsCountData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetBySessionDateTime" :
				{
					W3000.Data.LogRowsCountDataCollection _result_  = svr.GetBySessionDateTime(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetBySessionID" :
				{
					W3000.Data.LogRowsCountDataCollection _result_  = svr.GetBySessionID((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.LogRowsCountViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.LogRowsCountData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.LogRowsCountData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.LogRowsCountDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetUsrAccountBRRuleResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			UsrAccountBRRuleDataService svr = DataServiceFactory.CreateUsrAccountBRRuleDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.UsrAccountBRRuleDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.UsrAccountBRRuleDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBRRuleID" :
				{
					if(token.ParameterNames == "BRRuleID")
					{
						W3000.Data.UsrAccountBRRuleDataCollection _result_  = svr.GetByBRRuleID((System.Int32)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "BRRuleID|userID")
					{
						W3000.Data.UsrAccountBRRuleData _result_  = svr.GetByBRRuleID((System.Int32)token.GetParameter(0),(System.String)token.GetParameter(1));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "BRRuleID|UsrAccountPK")
					{
						W3000.Data.UsrAccountBRRuleData _result_  = svr.GetByBRRuleID((System.Int32)token.GetParameter(0),(System.Guid)token.GetParameter(1));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
				case "GetByPK" :
				{
					W3000.Data.UsrAccountBRRuleData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.UsrAccountBRRuleData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUsrAccount" :
				{
					W3000.Data.UsrAccountBRRuleDataCollection _result_  = svr.GetByUsrAccount((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.UsrAccountBRRuleViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByUsrAccount" :
				{
					W3000.Data.UsrAccountBRRuleViewCollection _result_  = svr.GetViewByUsrAccount((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.UsrAccountBRRuleData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrAccountBRRuleData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrAccountBRRuleDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetUsrAccountBuildingMapResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			UsrAccountBuildingMapDataService svr = DataServiceFactory.CreateUsrAccountBuildingMapDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.UsrAccountBuildingMapDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.UsrAccountBuildingMapDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDBuilding" :
				{
					W3000.Data.UsrAccountBuildingMapDataCollection _result_  = svr.GetByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.UsrAccountBuildingMapDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.UsrAccountBuildingMapData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.UsrAccountBuildingMapData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Guid)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUsrAccount" :
				{
					W3000.Data.UsrAccountBuildingMapDataCollection _result_  = svr.GetByUsrAccount((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.UsrAccountBuildingMapViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDBuilding" :
				{
					W3000.Data.UsrAccountBuildingMapViewCollection _result_  = svr.GetViewByBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByUsrAccount" :
				{
					W3000.Data.UsrAccountBuildingMapViewCollection _result_  = svr.GetViewByUsrAccount((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.UsrAccountBuildingMapData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrAccountBuildingMapData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrAccountBuildingMapDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetUsrAccountResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			UsrAccountDataService svr = DataServiceFactory.CreateUsrAccountDataService(token, false);
			switch (actionName)
			{
				case "ExecuteDataTable" :
				{
					System.Data.DataTable _result_  = svr.ExecuteDataTable((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "ExecuteNonQuery" :
				{
					System.String _result_  = svr.ExecuteNonQuery((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "ExecuteScalar" :
				{
					System.String _result_  = svr.ExecuteScalar((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAll" :
				{
					W3000.Data.UsrAccountDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.UsrAccountDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDTenant" :
				{
					W3000.Data.UsrAccountDataCollection _result_  = svr.GetByBDTenant((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedBDBuilding" :
				{
					W3000.Data.UsrAccountDataCollection _result_  = svr.GetByMappedBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedBDTenant" :
				{
					W3000.Data.UsrAccountDataCollection _result_  = svr.GetByMappedBDTenant((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.UsrAccountDataCollection _result_  = svr.GetByModifiedOn((System.Boolean)token.GetParameter(0),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(2)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.UsrAccountData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUserID" :
				{
					W3000.Data.UsrAccountData _result_  = svr.GetByUserID((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUsrGroup" :
				{
					W3000.Data.UsrAccountDataCollection _result_  = svr.GetByUsrGroup((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUsrGroupName" :
				{
					W3000.Data.UsrAccountDataCollection _result_  = svr.GetByUsrGroupName((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetCentralUser" :
				{
					W3000.Data.UsrAccountDataCollection _result_  = svr.GetCentralUser();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.UsrAccountViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDTenant" :
				{
					W3000.Data.UsrAccountViewCollection _result_  = svr.GetViewByBDTenant((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByUsrGroup" :
				{
					W3000.Data.UsrAccountViewCollection _result_  = svr.GetViewByUsrGroup((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetWebUser" :
				{
					W3000.Data.UsrAccountDataCollection _result_  = svr.GetWebUser();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "IsTableExist" :
				{
					System.Boolean _result_  = svr.IsTableExist((System.String)token.GetParameter(0));
					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.UsrAccountData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrAccountData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrAccountDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetUsrAccountDBRuleResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			UsrAccountDBRuleDataService svr = DataServiceFactory.CreateUsrAccountDBRuleDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.UsrAccountDBRuleDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.UsrAccountDBRuleDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByDBRuleID" :
				{
					W3000.Data.UsrAccountDBRuleDataCollection _result_  = svr.GetByDBRuleID((System.Int32)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.UsrAccountDBRuleData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.UsrAccountDBRuleData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUsrAccount" :
				{
					W3000.Data.UsrAccountDBRuleDataCollection _result_  = svr.GetByUsrAccount((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.UsrAccountDBRuleViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByUsrAccount" :
				{
					W3000.Data.UsrAccountDBRuleViewCollection _result_  = svr.GetViewByUsrAccount((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.UsrAccountDBRuleData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrAccountDBRuleData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrAccountDBRuleDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetUsrAccountTenantMapResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			UsrAccountTenantMapDataService svr = DataServiceFactory.CreateUsrAccountTenantMapDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.UsrAccountTenantMapDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.UsrAccountTenantMapDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBDTenant" :
				{
					W3000.Data.UsrAccountTenantMapDataCollection _result_  = svr.GetByBDTenant((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.UsrAccountTenantMapDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.UsrAccountTenantMapData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.UsrAccountTenantMapData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Guid)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUsrAccount" :
				{
					W3000.Data.UsrAccountTenantMapDataCollection _result_  = svr.GetByUsrAccount((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.UsrAccountTenantMapViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByBDTenant" :
				{
					W3000.Data.UsrAccountTenantMapViewCollection _result_  = svr.GetViewByBDTenant((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByUsrAccount" :
				{
					W3000.Data.UsrAccountTenantMapViewCollection _result_  = svr.GetViewByUsrAccount((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.UsrAccountTenantMapData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrAccountTenantMapData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrAccountTenantMapDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetUsrGroupBRRuleResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			UsrGroupBRRuleDataService svr = DataServiceFactory.CreateUsrGroupBRRuleDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.UsrGroupBRRuleDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.UsrGroupBRRuleDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByBRRuleID" :
				{
					if(token.ParameterNames == "BRRuleID")
					{
						W3000.Data.UsrGroupBRRuleDataCollection _result_  = svr.GetByBRRuleID((System.Int32)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "BRRuleID|UsrGroupName")
					{
						W3000.Data.UsrGroupBRRuleData _result_  = svr.GetByBRRuleID((System.Int32)token.GetParameter(0),(System.String)token.GetParameter(1));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "BRRuleID|UsrGroupPK")
					{
						W3000.Data.UsrGroupBRRuleData _result_  = svr.GetByBRRuleID((System.Int32)token.GetParameter(0),(System.Guid)token.GetParameter(1));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
				case "GetByPK" :
				{
					W3000.Data.UsrGroupBRRuleData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.UsrGroupBRRuleData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUsrGroup" :
				{
					W3000.Data.UsrGroupBRRuleDataCollection _result_  = svr.GetByUsrGroup((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.UsrGroupBRRuleViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByUsrGroup" :
				{
					W3000.Data.UsrGroupBRRuleViewCollection _result_  = svr.GetViewByUsrGroup((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.UsrGroupBRRuleData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrGroupBRRuleData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrGroupBRRuleDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetUsrGroupResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			UsrGroupDataService svr = DataServiceFactory.CreateUsrGroupDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.UsrGroupDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.UsrGroupDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.UsrGroupData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUsrGroupName" :
				{
					W3000.Data.UsrGroupData _result_  = svr.GetByUsrGroupName((System.String)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.UsrGroupViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.UsrGroupData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrGroupData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrGroupDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetUsrGroupDBRuleResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			UsrGroupDBRuleDataService svr = DataServiceFactory.CreateUsrGroupDBRuleDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.UsrGroupDBRuleDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.UsrGroupDBRuleDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByDBRuleID" :
				{
					W3000.Data.UsrGroupDBRuleDataCollection _result_  = svr.GetByDBRuleID((System.Int32)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.UsrGroupDBRuleData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.UsrGroupDBRuleData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUsrGroup" :
				{
					W3000.Data.UsrGroupDBRuleDataCollection _result_  = svr.GetByUsrGroup((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.UsrGroupDBRuleViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByUsrGroup" :
				{
					W3000.Data.UsrGroupDBRuleViewCollection _result_  = svr.GetViewByUsrGroup((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.UsrGroupDBRuleData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrGroupDBRuleData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UsrGroupDBRuleDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetUtilHolidayResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			UtilHolidayDataService svr = DataServiceFactory.CreateUtilHolidayDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.UtilHolidayDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.UtilHolidayDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByCountryID" :
				{
					W3000.Data.UtilHolidayDataCollection _result_  = svr.GetByCountryID((System.Int32)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedACInterval" :
				{
					W3000.Data.UtilHolidayDataCollection _result_  = svr.GetByMappedACInterval((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedACPanel" :
				{
					W3000.Data.UtilHolidayDataCollection _result_  = svr.GetByMappedACPanel((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedBDBuilding" :
				{
					W3000.Data.UtilHolidayDataCollection _result_  = svr.GetByMappedBDBuilding((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByMappedBDTenant" :
				{
					W3000.Data.UtilHolidayDataCollection _result_  = svr.GetByMappedBDTenant((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.UtilHolidayDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.UtilHolidayData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.UtilHolidayData _result_  = svr.GetByUK((System.Int32)token.GetParameter(0),(System.String)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK1" :
				{
					W3000.Data.UtilHolidayData _result_  = svr.GetByUK1(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.UtilHolidayViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.UtilHolidayData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UtilHolidayData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UtilHolidayDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetUtilSettingCategoryResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			UtilSettingCategoryDataService svr = DataServiceFactory.CreateUtilSettingCategoryDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.UtilSettingCategoryDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.UtilSettingCategoryDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.UtilSettingCategoryDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.UtilSettingCategoryData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetBySettingCategoryID" :
				{
					W3000.Data.UtilSettingCategoryDataCollection _result_  = svr.GetBySettingCategoryID((System.Int32)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.UtilSettingCategoryData _result_  = svr.GetByUK((System.Int32)token.GetParameter(0),(System.String)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.UtilSettingCategoryViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.UtilSettingCategoryData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UtilSettingCategoryData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UtilSettingCategoryDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
				}
			}
			return null;
		}

		public byte[] GetUtilSettingDetailResult(string actionName, byte[] paras)
		{
			SecurityToken token = this.DeserializeToken(paras);
			DataServiceFactory.CheckAuthorize(token);
			UtilSettingDetailDataService svr = DataServiceFactory.CreateUtilSettingDetailDataService(token, false);
			switch (actionName)
			{
				case "GetAll" :
				{
					W3000.Data.UtilSettingDetailDataCollection _result_  = svr.GetAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetAllCount" :
				{
					System.Int32 _result_  = svr.GetAllCount();
					return Compression.Compress(_result_);
				}
				case "GetAllPage" :
				{
					W3000.Data.UtilSettingDetailDataCollection _result_  = svr.GetAllPage((System.Int32)token.GetParameter(0),(System.Int32)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByModifiedOn" :
				{
					W3000.Data.UtilSettingDetailDataCollection _result_  = svr.GetByModifiedOn(new DateTime(((DateTime)token.GetParameter(0)).Ticks, DateTimeKind.Utc).ToLocalTime(),new DateTime(((DateTime)token.GetParameter(1)).Ticks, DateTimeKind.Utc).ToLocalTime());
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByPK" :
				{
					W3000.Data.UtilSettingDetailData _result_  = svr.GetByPK((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUK" :
				{
					W3000.Data.UtilSettingDetailData _result_  = svr.GetByUK((System.Guid)token.GetParameter(0),(System.String)token.GetParameter(1));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetByUtilSettingCategory" :
				{
					W3000.Data.UtilSettingDetailDataCollection _result_  = svr.GetByUtilSettingCategory((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewAll" :
				{
					W3000.Data.UtilSettingDetailViewCollection _result_  = svr.GetViewAll();
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "GetViewByUtilSettingCategory" :
				{
					W3000.Data.UtilSettingDetailViewCollection _result_  = svr.GetViewByUtilSettingCategory((System.Guid)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Purge" :
				{
					Cheke.BusinessEntity.Result _result_  = svr.Purge((W3000.Data.UtilSettingDetailData)token.GetParameter(0));
					if(_result_ == null)
						return null;

					return Compression.Compress(_result_);
				}
				case "Save" :
				{
					if(token.ParameterNames == "entity")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UtilSettingDetailData)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					if(token.ParameterNames == "list")
					{
						Cheke.BusinessEntity.Result _result_  = svr.Save((W3000.Data.UtilSettingDetailDataCollection)token.GetParameter(0));
						if(_result_ == null)
							return null;

						return Compression.Compress(_result_);
					}
					return null;
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
