using System;
using Cheke;
using W3000.BasicServiceWrapper;
using W3000.Data;

namespace W3000.CreatorService
{
    public class BizCreator : BizBase
    {
        public BizCreator(SecurityToken token) : base(token)
        {
        }

        public UsrAccountData CreateUsrAccount()
        {
            UsrAccountData admin = new UsrAccountData();
            admin.Password = "hello";
            admin.PwdExpireDate = DateTime.Now.AddMonths(6);
            admin.TotalUsage = 0;
            admin.CreatedOn = DateTime.Now;
            admin.CreatedBy = base.UserId;
            admin.ModifiedOn = DateTime.Now;
            admin.ModifiedBy = base.UserId;

            return admin;
        }

        public BDBuildingData CreateBDBuilding(int countryID, bool isFederal)
        {
            BDBuildingData entity = new BDBuildingData();
            entity.BuildingID = 0;
            entity.CountryID = countryID;
            entity.Federal = isFederal;
            entity.VisitorSiteCode = new Random().Next(1, 255);

            //Holiday
            entity.BDBuildingHolidayMapList = new BDBuildingHolidayMapDataCollection();
            UtilHolidayDataCollection holidayList = UtilHolidayWrapper.GetByCountryID(countryID, base.TrustableToken);
            foreach (UtilHolidayData item in holidayList)
            {
                if(isFederal)
                {
                    if(!item.Federal)
                        continue;
                }
                else
                {
                    if (!item.Major && !item.Default)
                        continue;
                }

                BDBuildingHolidayMapData map = new BDBuildingHolidayMapData();
                map.CopyParent(entity);
                map.CopyParent(item);
                entity.BDBuildingHolidayMapList.Add(map);
            }

            //Internal
            entity.ACIntervalList = new ACIntervalDataCollection();
            ACIntervalData intervalUnlocked  = new ACIntervalData();
            intervalUnlocked.BDBuilding = entity;
            intervalUnlocked.IVID = 1;
            intervalUnlocked.Begin = "0000";
            intervalUnlocked.End = "2359";
            intervalUnlocked.Sun = true;
            intervalUnlocked.Mon = true;
            intervalUnlocked.Tue = true;
            intervalUnlocked.Wed = true;
            intervalUnlocked.Thu = true;
            intervalUnlocked.Fri = true;
            intervalUnlocked.Sat = true;
            intervalUnlocked.Hol = true;
            entity.ACIntervalList.Add(intervalUnlocked);

            ACIntervalData intervalLocked = new ACIntervalData();
            intervalLocked.BDBuilding = entity;
            intervalLocked.IVID = 2;
            intervalLocked.Begin = "0000";
            intervalLocked.End = "2359";
            intervalLocked.Sun = false;
            intervalLocked.Mon = false;
            intervalLocked.Tue = false;
            intervalLocked.Wed = false;
            intervalLocked.Thu = false;
            intervalLocked.Fri = false;
            intervalLocked.Sat = false;
            intervalLocked.Hol = false;
            entity.ACIntervalList.Add(intervalLocked);

            //Timecode
            entity.ACTimecodeList = new ACTimecodeDataCollection();
            ACTimecodeData timecodeUnlocked = new ACTimecodeData();
            timecodeUnlocked.BDBuilding = entity;
            timecodeUnlocked.TCID = 1;
            timecodeUnlocked.Summary = "24/7 Unlocked";
            entity.ACTimecodeList.Add(timecodeUnlocked);

            timecodeUnlocked.ACTimecodeIntervalMapList = new ACTimecodeIntervalMapDataCollection();
            ACTimecodeIntervalMapData timecodeIntervalMap = new ACTimecodeIntervalMapData();
            timecodeIntervalMap.CopyParent(timecodeUnlocked);
            timecodeIntervalMap.CopyParent(intervalUnlocked);
            timecodeUnlocked.ACTimecodeIntervalMapList.Add(timecodeIntervalMap);

            ACTimecodeData timecodeLocked = new ACTimecodeData();
            timecodeLocked.BDBuilding = entity;
            timecodeLocked.TCID = 2;
            timecodeLocked.Summary = "24/7 Locked";
            entity.ACTimecodeList.Add(timecodeLocked);

            timecodeLocked.ACTimecodeIntervalMapList = new ACTimecodeIntervalMapDataCollection();
            timecodeIntervalMap = new ACTimecodeIntervalMapData();
            timecodeIntervalMap.CopyParent(timecodeLocked);
            timecodeIntervalMap.CopyParent(intervalLocked);
            timecodeLocked.ACTimecodeIntervalMapList.Add(timecodeIntervalMap);

            //AMFormat
            entity.ACAMFormatList = new ACAMFormatDataCollection();
            ACAMFormatData amfMonitored = new ACAMFormatData();
            amfMonitored.BDBuilding = entity;
            amfMonitored.AMFID = 1;
            amfMonitored.Summary = "24/7 Monitored";
            amfMonitored.PreAlarmTC = 2;
            amfMonitored.AlarmTC = 2;
            amfMonitored.ReportTC = 2;
            entity.ACAMFormatList.Add(amfMonitored);

            ACAMFormatData amfShunted = new ACAMFormatData();
            amfShunted.BDBuilding = entity;
            amfShunted.AMFID = 2;
            amfShunted.Summary = "24/7 Shunted";
            amfShunted.PreAlarmTC = 1;
            amfShunted.AlarmTC = 1;
            amfShunted.ReportTC = 1;
            entity.ACAMFormatList.Add(amfShunted);

            //AccessLevel
            entity.ACAccessLevelList = new ACAccessLevelDataCollection();
            ACAccessLevelData dwMaster = new ACAccessLevelData();
            dwMaster.BDBuilding = entity;
            dwMaster.AccessLevelID = 1;
            dwMaster.Summary = "DATAWATCH MASTER";
            entity.ACAccessLevelList.Add(dwMaster);

            ACAccessLevelData bldgMaster = new ACAccessLevelData();
            bldgMaster.BDBuilding = entity;
            bldgMaster.AccessLevelID = 2;
            bldgMaster.Summary = "BUILDING MASTER";
            entity.ACAccessLevelList.Add(bldgMaster);

            return entity;
        }

        public UtilHolidayData CreateUtilHoliday()
        {
            UtilHolidayData entity = new UtilHolidayData();

            return entity;
        }
    }
}