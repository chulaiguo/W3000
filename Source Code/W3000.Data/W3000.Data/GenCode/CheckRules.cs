using System;
using Cheke.BusinessEntity;
using W3000.Rules;

namespace W3000.Data
{
	public partial class ACIntvalHolidayMapData
	{
		protected override void CheckRules()
		{
			ACIntvalHolidayMapRuleData data = new ACIntvalHolidayMapRuleData();
			data.ACIntvalHolidayMapPK = this._aCIntvalHolidayMapPK;
			data.ACIntervalPK = this._aCIntervalPK;
			data.UtilHolidayPK = this._utilHolidayPK;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.End = this._end;
			data.Begin = this._begin;
			data.IVID = this._iVID;
			data.BDBuildingPK = this._bDBuildingPK;
			data.Date = this._date;
			data.Holiday = this._holiday;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACIntvalHolidayMapRule rule = new ACIntvalHolidayMapRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACAccessLevelDetailData
	{
		protected override void CheckRules()
		{
			ACAccessLevelDetailRuleData data = new ACAccessLevelDetailRuleData();
			data.ACAccessLevelDetailPK = this._aCAccessLevelDetailPK;
			data.ACAccessLevelPK = this._aCAccessLevelPK;
			data.ACMainZonePK = this._aCMainZonePK;
			data.ACTimecodePK = this._aCTimecodePK;
			data.FromACAccessLevelPK = this._fromACAccessLevelPK;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.MainZoneDescription = this._mainZoneDescription;
			data.MainZoneID = this._mainZoneID;
			data.ACPanelPK = this._aCPanelPK;
			data.TimecodeSummary = this._timecodeSummary;
			data.TCID = this._tCID;
			data.ALSummary = this._aLSummary;
			data.AccessLevelID = this._accessLevelID;
			data.BDBuildingPK = this._bDBuildingPK;
			data.UnitID = this._unitID;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACAccessLevelDetailRule rule = new ACAccessLevelDetailRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class UsrAccountBuildingMapData
	{
		protected override void CheckRules()
		{
			UsrAccountBuildingMapRuleData data = new UsrAccountBuildingMapRuleData();
			data.UsrAccountBuildingMapPK = this._usrAccountBuildingMapPK;
			data.UsrAccountPK = this._usrAccountPK;
			data.BDBuildingPK = this._bDBuildingPK;
			data.BuildingWide = this._buildingWide;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.AccessTC = this._accessTC;
			data.Permission = this._permission;
			data.Primary = this._primary;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;
			data.UserID = this._userID;

			UsrAccountBuildingMapRule rule = new UsrAccountBuildingMapRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class BDBuildingData
	{
		protected override void CheckRules()
		{
			BDBuildingRuleData data = new BDBuildingRuleData();
			data.BDBuildingPK = this._bDBuildingPK;
			data.BuildingID = this._buildingID;
			data.BuildingName = this._buildingName;
			data.Address1 = this._address1;
			data.StreetNumb = this._streetNumb;
			data.StreetName = this._streetName;
			data.Address2 = this._address2;
			data.City = this._city;
			data.State = this._state;
			data.Zipcode = this._zipcode;
			data.County = this._county;
			data.TimezoneID = this._timezoneID;
			data.Federal = this._federal;
			data.Phone = this._phone;
			data.Fax = this._fax;
			data.BldgNotes = this._bldgNotes;
			data.CardNotes = this._cardNotes;
			data.ElevTrapNotes = this._elevTrapNotes;
			data.VisitorNotes = this._visitorNotes;
			data.SystemTypeID = this._systemTypeID;
			data.CountryID = this._countryID;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.VisitorSiteCode = this._visitorSiteCode;
			data.WinUITypeID = this._winUITypeID;
			data.LastExportParkingTag = this._lastExportParkingTag;
			data.AutoIssueNotifyEmail = this._autoIssueNotifyEmail;
			data.CardKeyMode = this._cardKeyMode;
			data.AccessLevelMode = this._accessLevelMode;
			data.HotClient = this._hotClient;
			data.HotExpire = this._hotExpire;

			BDBuildingRule rule = new BDBuildingRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class BDTenantData
	{
		protected override void CheckRules()
		{
			BDTenantRuleData data = new BDTenantRuleData();
			data.BDTenantPK = this._bDTenantPK;
			data.BDBuildingPK = this._bDBuildingPK;
			data.Tenant = this._tenant;
			data.Suite = this._suite;
			data.Phone = this._phone;
			data.Fax = this._fax;
			data.Blocked = this._blocked;
			data.Federal = this._federal;
			data.TentNotes = this._tentNotes;
			data.CardNotes = this._cardNotes;
			data.VisitorNotes = this._visitorNotes;
			data.IsManagement = this._isManagement;
			data.Type = this._type;
			data.NoRecycleCard = this._noRecycleCard;
			data.SystemTypeID = this._systemTypeID;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.ParkingAccount = this._parkingAccount;
			data.CustInfo1 = this._custInfo1;
			data.CustInfo2 = this._custInfo2;
			data.CustInfo3 = this._custInfo3;
			data.CustInfo4 = this._custInfo4;
			data.CustInfo5 = this._custInfo5;
			data.CustInfo6 = this._custInfo6;
			data.CustInfo7 = this._custInfo7;
			data.CustInfo8 = this._custInfo8;
			data.DelExpiredCard = this._delExpiredCard;
			data.HotClient = this._hotClient;
			data.HotExpire = this._hotExpire;
			data.Email = this._email;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			BDTenantRule rule = new BDTenantRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class UtilSettingCategoryData
	{
		protected override void CheckRules()
		{
			UtilSettingCategoryRuleData data = new UtilSettingCategoryRuleData();
			data.UtilSettingCategoryPK = this._utilSettingCategoryPK;
			data.SettingCategoryID = this._settingCategoryID;
			data.SettingCategory = this._settingCategory;
			data.InstanceName = this._instanceName;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.BDBuildingPK = this._bDBuildingPK;

			UtilSettingCategoryRule rule = new UtilSettingCategoryRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class UtilSettingDetailData
	{
		protected override void CheckRules()
		{
			UtilSettingDetailRuleData data = new UtilSettingDetailRuleData();
			data.UtilSettingDetailPK = this._utilSettingDetailPK;
			data.UtilSettingCategoryPK = this._utilSettingCategoryPK;
			data.FieldName = this._fieldName;
			data.FieldValue = this._fieldValue;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.SettingCategory = this._settingCategory;
			data.SettingCategoryID = this._settingCategoryID;

			UtilSettingDetailRule rule = new UtilSettingDetailRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACOutputGroupMainZoneMapData
	{
		protected override void CheckRules()
		{
			ACOutputGroupMainZoneMapRuleData data = new ACOutputGroupMainZoneMapRuleData();
			data.ACOutputGroupMainZoneMapPK = this._aCOutputGroupMainZoneMapPK;
			data.ACOutputGroupPK = this._aCOutputGroupPK;
			data.ACMainZonePK = this._aCMainZonePK;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.MainZoneID = this._mainZoneID;
			data.ACPanelPK = this._aCPanelPK;
			data.GroupID = this._groupID;
			data.UnitID = this._unitID;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;
			data.BDBuildingPK = this._bDBuildingPK;

			ACOutputGroupMainZoneMapRule rule = new ACOutputGroupMainZoneMapRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACCardHolderData
	{
		protected override void CheckRules()
		{
			ACCardHolderRuleData data = new ACCardHolderRuleData();
			data.ACCardHolderPK = this._aCCardHolderPK;
			data.Sitecode = this._sitecode;
			data.Embossed = this._embossed;
			data.Encoded = this._encoded;
			data.CardTypeID = this._cardTypeID;
			data.FirstName = this._firstName;
			data.LastName = this._lastName;
			data.ValidFrom = this._validFrom;
			data.ValidThru = this._validThru;
			data.FIPS = this._fIPS;
			data.Pin = this._pin;
			data.BDTenantPK = this._bDTenantPK;
			data.Notes = this._notes;
			data.EventNotifyEmail = this._eventNotifyEmail;
			data.FireWarden = this._fireWarden;
			data.CustInfo1 = this._custInfo1;
			data.CustInfo2 = this._custInfo2;
			data.CustInfo3 = this._custInfo3;
			data.CustInfo4 = this._custInfo4;
			data.CustInfo5 = this._custInfo5;
			data.CustInfo6 = this._custInfo6;
			data.CustInfo7 = this._custInfo7;
			data.CustInfo8 = this._custInfo8;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Suite = this._suite;
			data.Tenant = this._tenant;
			data.BDBuildingPK = this._bDBuildingPK;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACCardHolderRule rule = new ACCardHolderRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACMainZoneData
	{
		protected override void CheckRules()
		{
			ACMainZoneRuleData data = new ACMainZoneRuleData();
			data.ACMainZonePK = this._aCMainZonePK;
			data.ACPanelPK = this._aCPanelPK;
			data.MainZoneID = this._mainZoneID;
			data.MainZoneTypeID = this._mainZoneTypeID;
			data.Description = this._description;
			data.ReaderName = this._readerName;
			data.ReaderTypeID = this._readerTypeID;
			data.ReverseColor = this._reverseColor;
			data.OutputGroup = this._outputGroup;
			data.NeedPin = this._needPin;
			data.AntiPassback = this._antiPassback;
			data.SoftAntiPassback = this._softAntiPassback;
			data.UnlockTimecode = this._unlockTimecode;
			data.UnlockOn1stRead = this._unlockOn1stRead;
			data.RexShuntOnly = this._rexShuntOnly;
			data.PulseTime = this._pulseTime;
			data.RelockByTimeout = this._relockByTimeout;
			data.ForceAMFormat = this._forceAMFormat;
			data.PropAMFFormat = this._propAMFFormat;
			data.Debounce = this._debounce;
			data.AllowOpenTime = this._allowOpenTime;
			data.NoPreAlarm = this._noPreAlarm;
			data.PostPreAlarm = this._postPreAlarm;
			data.PostDuration = this._postDuration;
			data.Notes = this._notes;
			data.EventNotifyEmail = this._eventNotifyEmail;
			data.IsPulsed = this._isPulsed;
			data.AlwaysToMAS = this._alwaysToMAS;
			data.CommentBeforePulse = this._commentBeforePulse;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Degrade = this._degrade;
			data.ReaderPassMode = this._readerPassMode;
			data.PanelZoneID = this._panelZoneID;
			data.LockTypeID = this._lockTypeID;
			data.Locked = this._locked;
			data.InputGroup = this._inputGroup;
			data.UnlockTempTC = this._unlockTempTC;
			data.UnlockTempBegin = this._unlockTempBegin;
			data.UnlockTempEnd = this._unlockTempEnd;
			data.BDBuildingPK = this._bDBuildingPK;
			data.UnitID = this._unitID;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACMainZoneRule rule = new ACMainZoneRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACIntervalData
	{
		protected override void CheckRules()
		{
			ACIntervalRuleData data = new ACIntervalRuleData();
			data.ACIntervalPK = this._aCIntervalPK;
			data.BDBuildingPK = this._bDBuildingPK;
			data.IVID = this._iVID;
			data.Begin = this._begin;
			data.End = this._end;
			data.Sun = this._sun;
			data.Mon = this._mon;
			data.Tue = this._tue;
			data.Wed = this._wed;
			data.Thu = this._thu;
			data.Fri = this._fri;
			data.Sat = this._sat;
			data.Hol = this._hol;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACIntervalRule rule = new ACIntervalRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACPanelHolidayMapData
	{
		protected override void CheckRules()
		{
			ACPanelHolidayMapRuleData data = new ACPanelHolidayMapRuleData();
			data.ACPanelHolidayMapPK = this._aCPanelHolidayMapPK;
			data.ACPanelPK = this._aCPanelPK;
			data.UtilHolidayPK = this._utilHolidayPK;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Date = this._date;
			data.Holiday = this._holiday;
			data.BDBuildingPK = this._bDBuildingPK;
			data.UnitID = this._unitID;

			ACPanelHolidayMapRule rule = new ACPanelHolidayMapRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACTimecodeData
	{
		protected override void CheckRules()
		{
			ACTimecodeRuleData data = new ACTimecodeRuleData();
			data.ACTimecodePK = this._aCTimecodePK;
			data.BDBuildingPK = this._bDBuildingPK;
			data.TCID = this._tCID;
			data.Summary = this._summary;
			data.Notes = this._notes;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACTimecodeRule rule = new ACTimecodeRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACTimecodeIntervalMapData
	{
		protected override void CheckRules()
		{
			ACTimecodeIntervalMapRuleData data = new ACTimecodeIntervalMapRuleData();
			data.ACTimecodeIntervalMapPK = this._aCTimecodeIntervalMapPK;
			data.ACTimecodePK = this._aCTimecodePK;
			data.ACIntervalPK = this._aCIntervalPK;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.End = this._end;
			data.Begin = this._begin;
			data.IVID = this._iVID;
			data.TCID = this._tCID;
			data.BDBuildingPK = this._bDBuildingPK;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACTimecodeIntervalMapRule rule = new ACTimecodeIntervalMapRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACAMFormatData
	{
		protected override void CheckRules()
		{
			ACAMFormatRuleData data = new ACAMFormatRuleData();
			data.ACAMFormatPK = this._aCAMFormatPK;
			data.BDBuildingPK = this._bDBuildingPK;
			data.AMFID = this._aMFID;
			data.Summary = this._summary;
			data.Notes = this._notes;
			data.ReportTC = this._reportTC;
			data.AlarmTC = this._alarmTC;
			data.PreAlarmTC = this._preAlarmTC;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACAMFormatRule rule = new ACAMFormatRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class BDBuildingHolidayMapData
	{
		protected override void CheckRules()
		{
			BDBuildingHolidayMapRuleData data = new BDBuildingHolidayMapRuleData();
			data.BDBuildingHolidayMapPK = this._bDBuildingHolidayMapPK;
			data.BDBuildingPK = this._bDBuildingPK;
			data.UtilHolidayPK = this._utilHolidayPK;
			data.ActionID = this._actionID;
			data.Notes = this._notes;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;
			data.Date = this._date;
			data.Holiday = this._holiday;

			BDBuildingHolidayMapRule rule = new BDBuildingHolidayMapRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACOutputGroupData
	{
		protected override void CheckRules()
		{
			ACOutputGroupRuleData data = new ACOutputGroupRuleData();
			data.ACOutputGroupPK = this._aCOutputGroupPK;
			data.ACPanelPK = this._aCPanelPK;
			data.GroupID = this._groupID;
			data.Summary = this._summary;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.BDBuildingPK = this._bDBuildingPK;
			data.UnitID = this._unitID;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACOutputGroupRule rule = new ACOutputGroupRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class BDTenantHolidayMapData
	{
		protected override void CheckRules()
		{
			BDTenantHolidayMapRuleData data = new BDTenantHolidayMapRuleData();
			data.BDTenantHolidayMapPK = this._bDTenantHolidayMapPK;
			data.BDTenantPK = this._bDTenantPK;
			data.UtilHolidayPK = this._utilHolidayPK;
			data.ActionID = this._actionID;
			data.Notes = this._notes;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Tenant = this._tenant;
			data.BDBuildingPK = this._bDBuildingPK;
			data.Date = this._date;
			data.Holiday = this._holiday;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			BDTenantHolidayMapRule rule = new BDTenantHolidayMapRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class LogRowsCountData
	{
		protected override void CheckRules()
		{
			LogRowsCountRuleData data = new LogRowsCountRuleData();
			data.LogRowsCountPK = this._logRowsCountPK;
			data.SessionID = this._sessionID;
			data.SessionDateTime = this._sessionDateTime;
			data.DBTableName = this._dBTableName;
			data.SequenceID = this._sequenceID;
			data.RowsCount = this._rowsCount;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;

			LogRowsCountRule rule = new LogRowsCountRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACInputGroupData
	{
		protected override void CheckRules()
		{
			ACInputGroupRuleData data = new ACInputGroupRuleData();
			data.ACInputGroupPK = this._aCInputGroupPK;
			data.ACPanelPK = this._aCPanelPK;
			data.GroupID = this._groupID;
			data.Summary = this._summary;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.BDBuildingPK = this._bDBuildingPK;
			data.UnitID = this._unitID;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACInputGroupRule rule = new ACInputGroupRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACInputData
	{
		protected override void CheckRules()
		{
			ACInputRuleData data = new ACInputRuleData();
			data.ACInputPK = this._aCInputPK;
			data.ACPanelPK = this._aCPanelPK;
			data.InputID = this._inputID;
			data.Description = this._description;
			data.Debounce = this._debounce;
			data.Reverse = this._reverse;
			data.ForceAMFormat = this._forceAMFormat;
			data.OffOnRestore = this._offOnRestore;
			data.External = this._external;
			data.Notes = this._notes;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.AlwaysToMAS = this._alwaysToMAS;
			data.PanelZoneID = this._panelZoneID;
			data.Locked = this._locked;
			data.BDBuildingPK = this._bDBuildingPK;
			data.UnitID = this._unitID;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACInputRule rule = new ACInputRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACFunctionCardData
	{
		protected override void CheckRules()
		{
			ACFunctionCardRuleData data = new ACFunctionCardRuleData();
			data.ACFunctionCardPK = this._aCFunctionCardPK;
			data.Sitecode = this._sitecode;
			data.Embossed = this._embossed;
			data.Encoded = this._encoded;
			data.CardTypeID = this._cardTypeID;
			data.BDTenantPK = this._bDTenantPK;
			data.FunctionID = this._functionID;
			data.FirstName = this._firstName;
			data.LastName = this._lastName;
			data.FIPS = this._fIPS;
			data.Pin = this._pin;
			data.ValidFrom = this._validFrom;
			data.ValidThru = this._validThru;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Suite = this._suite;
			data.Tenant = this._tenant;
			data.BDBuildingPK = this._bDBuildingPK;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACFunctionCardRule rule = new ACFunctionCardRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class UtilHolidayData
	{
		protected override void CheckRules()
		{
			UtilHolidayRuleData data = new UtilHolidayRuleData();
			data.UtilHolidayPK = this._utilHolidayPK;
			data.CountryID = this._countryID;
			data.Holiday = this._holiday;
			data.Date = this._date;
			data.Major = this._major;
			data.Federal = this._federal;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Default = this._default;
			data.ActionID = this._actionID;

			UtilHolidayRule rule = new UtilHolidayRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACAccessLevelData
	{
		protected override void CheckRules()
		{
			ACAccessLevelRuleData data = new ACAccessLevelRuleData();
			data.ACAccessLevelPK = this._aCAccessLevelPK;
			data.BDBuildingPK = this._bDBuildingPK;
			data.AccessLevelID = this._accessLevelID;
			data.Summary = this._summary;
			data.AsAL2 = this._asAL2;
			data.Notes = this._notes;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACAccessLevelRule rule = new ACAccessLevelRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACPanelFunctionCardMapData
	{
		protected override void CheckRules()
		{
			ACPanelFunctionCardMapRuleData data = new ACPanelFunctionCardMapRuleData();
			data.ACPanelFunctionCardMapPK = this._aCPanelFunctionCardMapPK;
			data.ACPanelPK = this._aCPanelPK;
			data.ACFunctionCardPK = this._aCFunctionCardPK;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.CardTypeID = this._cardTypeID;
			data.Encoded = this._encoded;
			data.Embossed = this._embossed;
			data.Sitecode = this._sitecode;
			data.BDBuildingPK = this._bDBuildingPK;
			data.UnitID = this._unitID;

			ACPanelFunctionCardMapRule rule = new ACPanelFunctionCardMapRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class LogDBDeleteActivityData
	{
		protected override void CheckRules()
		{
			LogDBDeleteActivityRuleData data = new LogDBDeleteActivityRuleData();
			data.LogDBDeleteActivityPK = this._logDBDeleteActivityPK;
			data.LogDateTime = this._logDateTime;
			data.DBTableName = this._dBTableName;
			data.RecordPK = this._recordPK;
			data.LastUpdated = this._lastUpdated;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;

			LogDBDeleteActivityRule rule = new LogDBDeleteActivityRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class UsrAccountData
	{
		protected override void CheckRules()
		{
			UsrAccountRuleData data = new UsrAccountRuleData();
			data.UsrAccountPK = this._usrAccountPK;
			data.UserID = this._userID;
			data.IsAdmin = this._isAdmin;
			data.IsCentral = this._isCentral;
			data.FirstName = this._firstName;
			data.LastName = this._lastName;
			data.Password = this._password;
			data.PwdExpireDate = this._pwdExpireDate;
			data.UsrGroupPK = this._usrGroupPK;
			data.BDTenantPK = this._bDTenantPK;
			data.CellPhone = this._cellPhone;
			data.HomePhone = this._homePhone;
			data.OfficePhone = this._officePhone;
			data.Email = this._email;
			data.LastLogin = this._lastLogin;
			data.TotalUsage = this._totalUsage;
			data.StartScreen = this._startScreen;
			data.PopupExtension = this._popupExtension;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Suite = this._suite;
			data.Tenant = this._tenant;
			data.BDBuildingPK = this._bDBuildingPK;
			data.UsrGroupName = this._usrGroupName;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			UsrAccountRule rule = new UsrAccountRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class LogDBEditActivityData
	{
		protected override void CheckRules()
		{
			LogDBEditActivityRuleData data = new LogDBEditActivityRuleData();
			data.LogDBEditActivityPK = this._logDBEditActivityPK;
			data.LogDateTime = this._logDateTime;
			data.DBTableName = this._dBTableName;
			data.RecordPK = this._recordPK;
			data.Category = this._category;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;

			LogDBEditActivityRule rule = new LogDBEditActivityRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACMasterCardData
	{
		protected override void CheckRules()
		{
			ACMasterCardRuleData data = new ACMasterCardRuleData();
			data.ACMasterCardPK = this._aCMasterCardPK;
			data.Sitecode = this._sitecode;
			data.Embossed = this._embossed;
			data.Encoded = this._encoded;
			data.CardTypeID = this._cardTypeID;
			data.FirstName = this._firstName;
			data.LastName = this._lastName;
			data.FIPS = this._fIPS;
			data.Pin = this._pin;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;

			ACMasterCardRule rule = new ACMasterCardRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACSupervisoryData
	{
		protected override void CheckRules()
		{
			ACSupervisoryRuleData data = new ACSupervisoryRuleData();
			data.ACSupervisoryPK = this._aCSupervisoryPK;
			data.ACPanelPK = this._aCPanelPK;
			data.SupervisoryID = this._supervisoryID;
			data.Description = this._description;
			data.Debounce = this._debounce;
			data.ForceAMFormat = this._forceAMFormat;
			data.External = this._external;
			data.Notes = this._notes;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.PanelZoneID = this._panelZoneID;
			data.Locked = this._locked;
			data.BDBuildingPK = this._bDBuildingPK;
			data.UnitID = this._unitID;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACSupervisoryRule rule = new ACSupervisoryRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class UsrGroupData
	{
		protected override void CheckRules()
		{
			UsrGroupRuleData data = new UsrGroupRuleData();
			data.UsrGroupPK = this._usrGroupPK;
			data.UsrGroupName = this._usrGroupName;
			data.Description = this._description;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;

			UsrGroupRule rule = new UsrGroupRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACCardHolderBuildingMapData
	{
		protected override void CheckRules()
		{
			ACCardHolderBuildingMapRuleData data = new ACCardHolderBuildingMapRuleData();
			data.ACCardHolderBuildingMapPK = this._aCCardHolderBuildingMapPK;
			data.ACCardHolderPK = this._aCCardHolderPK;
			data.BDBuildingPK = this._bDBuildingPK;
			data.AL1st = this._aL1st;
			data.AL2nd = this._aL2nd;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;
			data.LastName = this._lastName;
			data.FirstName = this._firstName;
			data.CardTypeID = this._cardTypeID;
			data.Encoded = this._encoded;
			data.Embossed = this._embossed;
			data.Sitecode = this._sitecode;

			ACCardHolderBuildingMapRule rule = new ACCardHolderBuildingMapRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class BDVisitorData
	{
		protected override void CheckRules()
		{
			BDVisitorRuleData data = new BDVisitorRuleData();
			data.BDVisitorPK = this._bDVisitorPK;
			data.BDTenantPK = this._bDTenantPK;
			data.FirstName = this._firstName;
			data.LastName = this._lastName;
			data.AuthorizedBy = this._authorizedBy;
			data.AuthorizedArea = this._authorizedArea;
			data.AuthorEmail = this._authorEmail;
			data.EmailNotify = this._emailNotify;
			data.ValidFrom = this._validFrom;
			data.ValidThru = this._validThru;
			data.Password = this._password;
			data.Special = this._special;
			data.Begin = this._begin;
			data.End = this._end;
			data.SiteCode = this._siteCode;
			data.Encoded = this._encoded;
			data.Scheduled = this._scheduled;
			data.ArrivedTime = this._arrivedTime;
			data.TurnstileAccess = this._turnstileAccess;
			data.BadgePrinted = this._badgePrinted;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Suite = this._suite;
			data.Tenant = this._tenant;
			data.BDBuildingPK = this._bDBuildingPK;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			BDVisitorRule rule = new BDVisitorRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class UsrGroupDBRuleData
	{
		protected override void CheckRules()
		{
			UsrGroupDBRuleRuleData data = new UsrGroupDBRuleRuleData();
			data.UsrGroupDBRulePK = this._usrGroupDBRulePK;
			data.UsrGroupPK = this._usrGroupPK;
			data.DBRuleID = this._dBRuleID;
			data.Selectable = this._selectable;
			data.Insertable = this._insertable;
			data.Editable = this._editable;
			data.Deletable = this._deletable;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.UsrGroupName = this._usrGroupName;

			UsrGroupDBRuleRule rule = new UsrGroupDBRuleRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACPanelData
	{
		protected override void CheckRules()
		{
			ACPanelRuleData data = new ACPanelRuleData();
			data.ACPanelPK = this._aCPanelPK;
			data.UnitID = this._unitID;
			data.BDBuildingPK = this._bDBuildingPK;
			data.SerialNumber = this._serialNumber;
			data.PanelName = this._panelName;
			data.BufferSize = this._bufferSize;
			data.DialUp = this._dialUp;
			data.UnitPhone = this._unitPhone;
			data.UnitPhoneCallerID = this._unitPhoneCallerID;
			data.UnitExt = this._unitExt;
			data.LongDistance = this._longDistance;
			data.ModemInitString = this._modemInitString;
			data.BaudRate = this._baudRate;
			data.HistoryPhone = this._historyPhone;
			data.AlarmPhone1 = this._alarmPhone1;
			data.AlarmPhone2 = this._alarmPhone2;
			data.DialingPrefixPanel = this._dialingPrefixPanel;
			data.DialingSuffixPanel = this._dialingSuffixPanel;
			data.DialOutEnabled = this._dialOutEnabled;
			data.DayLightSaving = this._dayLightSaving;
			data.OnSiteMonitor = this._onSiteMonitor;
			data.CentralDelay = this._centralDelay;
			data.ElevPulse = this._elevPulse;
			data.PanelTypeID = this._panelTypeID;
			data.UnbufferTC = this._unbufferTC;
			data.MandatoryUnbufferTC = this._mandatoryUnbufferTC;
			data.SwingerCount = this._swingerCount;
			data.SwingerTime = this._swingerTime;
			data.LoopNumb = this._loopNumb;
			data.PortNumb = this._portNumb;
			data.Notes = this._notes;
			data.Trouble = this._trouble;
			data.NoVersionCheck = this._noVersionCheck;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.DeviceId = this._deviceId;
			data.DBSyncSeconds = this._dBSyncSeconds;
			data.DBSaveMinutes = this._dBSaveMinutes;
			data.IsE150 = this._isE150;
			data.GroupID = this._groupID;
			data.NoAutoDownload = this._noAutoDownload;
			data.NoAutoDownloadStart = this._noAutoDownloadStart;
			data.Locked = this._locked;
			data.InDebug = this._inDebug;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			ACPanelRule rule = new ACPanelRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class UsrAccountDBRuleData
	{
		protected override void CheckRules()
		{
			UsrAccountDBRuleRuleData data = new UsrAccountDBRuleRuleData();
			data.UsrAccountDBRulePK = this._usrAccountDBRulePK;
			data.UsrAccountPK = this._usrAccountPK;
			data.DBRuleID = this._dBRuleID;
			data.Selectable = this._selectable;
			data.Insertable = this._insertable;
			data.Editable = this._editable;
			data.Deletable = this._deletable;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.UserID = this._userID;

			UsrAccountDBRuleRule rule = new UsrAccountDBRuleRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class UsrGroupBRRuleData
	{
		protected override void CheckRules()
		{
			UsrGroupBRRuleRuleData data = new UsrGroupBRRuleRuleData();
			data.UsrGroupBRRule = this._usrGroupBRRule;
			data.UsrGroupPK = this._usrGroupPK;
			data.BRRuleID = this._bRRuleID;
			data.Denied = this._denied;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.UsrGroupName = this._usrGroupName;

			UsrGroupBRRuleRule rule = new UsrGroupBRRuleRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class ACInputGroupInputMapData
	{
		protected override void CheckRules()
		{
			ACInputGroupInputMapRuleData data = new ACInputGroupInputMapRuleData();
			data.ACInputGroupInputMapPK = this._aCInputGroupInputMapPK;
			data.ACInputGroupPK = this._aCInputGroupPK;
			data.ACInputPK = this._aCInputPK;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.GroupID = this._groupID;
			data.ACPanelPK = this._aCPanelPK;
			data.InputID = this._inputID;
			data.UnitID = this._unitID;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;
			data.BDBuildingPK = this._bDBuildingPK;

			ACInputGroupInputMapRule rule = new ACInputGroupInputMapRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class UsrAccountBRRuleData
	{
		protected override void CheckRules()
		{
			UsrAccountBRRuleRuleData data = new UsrAccountBRRuleRuleData();
			data.UsrAccountBRRulePK = this._usrAccountBRRulePK;
			data.UsrAccountPK = this._usrAccountPK;
			data.BRRuleID = this._bRRuleID;
			data.Denied = this._denied;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.UserID = this._userID;

			UsrAccountBRRuleRule rule = new UsrAccountBRRuleRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

	public partial class UsrAccountTenantMapData
	{
		protected override void CheckRules()
		{
			UsrAccountTenantMapRuleData data = new UsrAccountTenantMapRuleData();
			data.UsrAccountTenantMapPK = this._usrAccountTenantMapPK;
			data.UsrAccountPK = this._usrAccountPK;
			data.BDTenantPK = this._bDTenantPK;
			data.CreatedOn = this._createdOn;
			data.CreatedBy = this._createdBy;
			data.ModifiedOn = this._modifiedOn;
			data.ModifiedBy = this._modifiedBy;
			data.Tenant = this._tenant;
			data.BDBuildingPK = this._bDBuildingPK;
			data.UserID = this._userID;
			data.Address1 = this._address1;
			data.BuildingID = this._buildingID;

			UsrAccountTenantMapRule rule = new UsrAccountTenantMapRule();
			string error = rule.CheckRules(data);
			if(error.Length > 0)
			{
				base.BrokenRules.Add(new Rule("BrokenRules", error));
			}
		}
	}

}
