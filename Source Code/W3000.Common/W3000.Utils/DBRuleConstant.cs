using System;

namespace W3000.Utils
{
	[Serializable]
	public class DBRuleConstant
	{
		public const int _ACIntvalHolidayMap = 1001;
		public const int _ACAccessLevelDetail = 1002;
		public const int _UsrAccountBuildingMap = 1003;
		public const int _BDBuilding = 1004;
		public const int _BDTenant = 1005;
		public const int _ACOutputGroupMainZoneMap = 1008;
		public const int _ACCardHolder = 1009;
		public const int _ACMainZone = 1010;
		public const int _ACInterval = 1011;
		public const int _ACPanelHolidayMap = 1012;
		public const int _ACTimecode = 1013;
		public const int _ACTimecodeIntervalMap = 1014;
		public const int _ACAMFormat = 1015;
		public const int _BDBuildingHolidayMap = 1016;
		public const int _ACOutputGroup = 1017;
		public const int _BDTenantHolidayMap = 1018;
		public const int _ACInputGroup = 1019;
		public const int _ACInput = 1020;
		public const int _ACFunctionCard = 1021;
		public const int _ACAccessLevel = 1022;
		public const int _ACPanelFunctionCardMap = 1023;
		public const int _UtilHoliday = 1024;
		public const int _UsrAccount = 1026;
		public const int _ACMasterCard = 1028;
		public const int _ACSupervisory = 1029;
		public const int _UsrGroup = 1030;
		public const int _ACCardHolderBuildingMap = 1031;
		public const int _BDVisitor = 1032;
		public const int _UsrGroupDBRule = 1033;
		public const int _ACPanel = 1034;
		public const int _UsrAccountDBRule = 1035;
		public const int _UsrGroupBRRule = 1036;
		public const int _ACInputGroupInputMap = 1037;
		public const int _UsrAccountBRRule = 1038;
		public const int _UsrAccountTenantMap = 1039;

		private readonly int _id = 0;
		public int ID
		{
			get { return _id; }
		}

		private readonly string _tableName = string.Empty;
		public string TableName
		{
			get { return _tableName; }
		}

		private readonly string _description = string.Empty;
		public string Description
		{
			get { return _description; }
		}

		private DBRuleConstant(int id, string tableName, string description)
		{
			this._id = id;
			this._tableName = tableName;
			this._description = description;
		}

		public static DBRuleConstant[] GetAll()
		{
			DBRuleConstant[] list = new DBRuleConstant[]
			{
				new DBRuleConstant(_ACIntvalHolidayMap, "ACIntvalHolidayMap", "ACIntvalHolidayMap"),
				new DBRuleConstant(_ACAccessLevelDetail, "ACAccessLevelDetail", "ACAccessLevelDetail"),
				new DBRuleConstant(_UsrAccountBuildingMap, "UsrAccountBuildingMap", "UsrAccountBuildingMap"),
				new DBRuleConstant(_BDBuilding, "BDBuilding", "BDBuilding"),
				new DBRuleConstant(_BDTenant, "BDTenant", "BDTenant"),
				new DBRuleConstant(_ACOutputGroupMainZoneMap, "ACOutputGroupMainZoneMap", "ACOutputGroupMainZoneMap"),
				new DBRuleConstant(_ACCardHolder, "ACCardHolder", "ACCardHolder"),
				new DBRuleConstant(_ACMainZone, "ACMainZone", "ACMainZone"),
				new DBRuleConstant(_ACInterval, "ACInterval", "ACInterval"),
				new DBRuleConstant(_ACPanelHolidayMap, "ACPanelHolidayMap", "ACPanelHolidayMap"),
				new DBRuleConstant(_ACTimecode, "ACTimecode", "ACTimecode"),
				new DBRuleConstant(_ACTimecodeIntervalMap, "ACTimecodeIntervalMap", "ACTimecodeIntervalMap"),
				new DBRuleConstant(_ACAMFormat, "ACAMFormat", "ACAMFormat"),
				new DBRuleConstant(_BDBuildingHolidayMap, "BDBuildingHolidayMap", "BDBuildingHolidayMap"),
				new DBRuleConstant(_ACOutputGroup, "ACOutputGroup", "ACOutputGroup"),
				new DBRuleConstant(_BDTenantHolidayMap, "BDTenantHolidayMap", "BDTenantHolidayMap"),
				new DBRuleConstant(_ACInputGroup, "ACInputGroup", "ACInputGroup"),
				new DBRuleConstant(_ACInput, "ACInput", "ACInput"),
				new DBRuleConstant(_ACFunctionCard, "ACFunctionCard", "ACFunctionCard"),
				new DBRuleConstant(_ACAccessLevel, "ACAccessLevel", "ACAccessLevel"),
				new DBRuleConstant(_ACPanelFunctionCardMap, "ACPanelFunctionCardMap", "ACPanelFunctionCardMap"),
				new DBRuleConstant(_UtilHoliday, "UtilHoliday", "UtilHoliday"),
				new DBRuleConstant(_UsrAccount, "UsrAccount", "UsrAccount"),
				new DBRuleConstant(_ACMasterCard, "ACMasterCard", "ACMasterCard"),
				new DBRuleConstant(_ACSupervisory, "ACSupervisory", "ACSupervisory"),
				new DBRuleConstant(_UsrGroup, "UsrGroup", "UsrGroup"),
				new DBRuleConstant(_ACCardHolderBuildingMap, "ACCardHolderBuildingMap", "ACCardHolderBuildingMap"),
				new DBRuleConstant(_BDVisitor, "BDVisitor", "BDVisitor"),
				new DBRuleConstant(_UsrGroupDBRule, "UsrGroupDBRule", "UsrGroupDBRule"),
				new DBRuleConstant(_ACPanel, "ACPanel", "ACPanel"),
				new DBRuleConstant(_UsrAccountDBRule, "UsrAccountDBRule", "UsrAccountDBRule"),
				new DBRuleConstant(_UsrGroupBRRule, "UsrGroupBRRule", "UsrGroupBRRule"),
				new DBRuleConstant(_ACInputGroupInputMap, "ACInputGroupInputMap", "ACInputGroupInputMap"),
				new DBRuleConstant(_UsrAccountBRRule, "UsrAccountBRRule", "UsrAccountBRRule"),
				new DBRuleConstant(_UsrAccountTenantMap, "UsrAccountTenantMap", "UsrAccountTenantMap"),
			};
			return list;
		}

		public static DBRuleConstant DefaultValue
		{
			get { return new DBRuleConstant(0, "Undefined", "Undefined"); }
		}

		public static DBRuleConstant FindByID(int id)
		{
			DBRuleConstant[] list = GetAll();
			foreach (DBRuleConstant item in list)
			{
				if (item.ID == id)
					return item;
			}

			return DefaultValue;
		}

		public static DBRuleConstant FindByTableName(string tableName)
		{
			DBRuleConstant[] list = GetAll();
			foreach (DBRuleConstant item in list)
			{
				if (string.Compare(item.TableName, tableName, 0) == 0)
					return item;
			}

			return DefaultValue;
		}
	}
}
