using System;
using System.Data;
using System.Text;
using Cheke.BusinessEntity;

namespace W3000.Data
{
	[Serializable]
	public partial class ACIntvalHolidayMapData : BusinessBase
	{
		#region Fields
		private Guid _aCIntvalHolidayMapPK;
		private Guid _aCIntervalPK;
		private Guid _utilHolidayPK;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _end;
		private String _begin;
		private Int16 _iVID;
		private Guid _bDBuildingPK;
		private DateTime _date;
		private String _holiday;
		private String _address1;
		private Int32 _buildingID;

		#endregion

		#region Constructors
		public ACIntvalHolidayMapData()
		{
			this._aCIntvalHolidayMapPK = Guid.NewGuid();
			this._aCIntervalPK = Guid.Empty;
			this._utilHolidayPK = Guid.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._end = string.Empty;
			this._begin = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._date = DateTime.Now;
			this._holiday = string.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACIntvalHolidayMapData(ACIntvalHolidayMapData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACIntvalHolidayMapPK
		{
			get
			{
				return this._aCIntvalHolidayMapPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACIntvalHolidayMapPK", value);
				if (this._aCIntvalHolidayMapPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCIntvalHolidayMapPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACIntvalHolidayMapPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACIntervalPK
		{
			get
			{
				return this._aCIntervalPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACIntervalPK", value);
				if (this._aCIntervalPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCIntervalPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACIntervalPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid UtilHolidayPK
		{
			get
			{
				return this._utilHolidayPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UtilHolidayPK", value);
				if (this._utilHolidayPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._utilHolidayPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUtilHolidayPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String End
		{
			get
			{
				return this._end == null ? null : this._end.Trim();
			}
			set
			{
				 this._end = value == null ? null : value.Trim();
			}
		}

		public virtual String Begin
		{
			get
			{
				return this._begin == null ? null : this._begin.Trim();
			}
			set
			{
				 this._begin = value == null ? null : value.Trim();
			}
		}

		public virtual Int16 IVID
		{
			get
			{
				return this._iVID;
			}
			set
			{
				this._iVID = value;
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual DateTime Date
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._date.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._date = value.ToUniversalTime();
			}
		}

		public virtual String Holiday
		{
			get
			{
				return this._holiday == null ? null : this._holiday.Trim();
			}
			set
			{
				 this._holiday = value == null ? null : value.Trim();
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACIntvalHolidayMap";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual ACIntervalData ACInterval
		{
			get
			{
				ACIntervalData parent = new ACIntervalData();
				parent.ACIntervalPK = this.ACIntervalPK;
				parent.End = this.End;
				parent.Begin = this.Begin;
				parent.IVID = this.IVID;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACIntervalPK = value.ACIntervalPK;
				this.End = value.End;
				this.Begin = value.Begin;
				this.IVID = value.IVID;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual UtilHolidayData UtilHoliday
		{
			get
			{
				UtilHolidayData parent = new UtilHolidayData();
				parent.UtilHolidayPK = this.UtilHolidayPK;
				parent.Date = this.Date;
				parent.Holiday = this.Holiday;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UtilHolidayPK = value.UtilHolidayPK;
				this.Date = value.Date;
				this.Holiday = value.Holiday;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACIntvalHolidayMapData data = entity as ACIntvalHolidayMapData;
			if (data == null)
				return;

			this.ACIntervalPK = data.ACIntervalPK;
			this.UtilHolidayPK = data.UtilHolidayPK;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.End = data.End;
			this.Begin = data.Begin;
			this.IVID = data.IVID;
			this.BDBuildingPK = data.BDBuildingPK;
			this.Date = data.Date;
			this.Holiday = data.Holiday;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACIntvalHolidayMapPK = data.ACIntvalHolidayMapPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACIntvalHolidayMapData));
		}

		private bool InternalEquals(ACIntvalHolidayMapData obj)
		{
			if (this.ACIntvalHolidayMapPK.CompareTo(obj.ACIntvalHolidayMapPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACIntvalHolidayMapPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACIntvalHolidayMap:");
			builder.AppendFormat("{0}|", this.ACIntvalHolidayMapPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACIntvalHolidayMapPKChanged;
		private void OnACIntvalHolidayMapPKChanged(EventArgs e)
		{
			if ((this.ACIntvalHolidayMapPKChanged != null))
			{
				this.ACIntvalHolidayMapPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACIntervalPKChanged;
		private void OnACIntervalPKChanged(EventArgs e)
		{
			if ((this.ACIntervalPKChanged != null))
			{
				this.ACIntervalPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UtilHolidayPKChanged;
		private void OnUtilHolidayPKChanged(EventArgs e)
		{
			if ((this.UtilHolidayPKChanged != null))
			{
				this.UtilHolidayPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACAccessLevelDetailData : BusinessBase
	{
		#region Fields
		private Guid _aCAccessLevelDetailPK;
		private Guid _aCAccessLevelPK;
		private Guid _aCMainZonePK;
		private Guid _aCTimecodePK;
		private Guid _fromACAccessLevelPK;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _mainZoneDescription;
		private Byte _mainZoneID;
		private Guid _aCPanelPK;
		private String _timecodeSummary;
		private Int16 _tCID;
		private String _aLSummary;
		private Int16 _accessLevelID;
		private Guid _bDBuildingPK;
		private Int32 _unitID;
		private String _address1;
		private Int32 _buildingID;

		#endregion

		#region Constructors
		public ACAccessLevelDetailData()
		{
			this._aCAccessLevelDetailPK = Guid.NewGuid();
			this._aCAccessLevelPK = Guid.Empty;
			this._aCMainZonePK = Guid.Empty;
			this._aCTimecodePK = Guid.Empty;
			this._fromACAccessLevelPK = Guid.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._mainZoneDescription = string.Empty;
			this._aCPanelPK = Guid.Empty;
			this._timecodeSummary = string.Empty;
			this._aLSummary = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACAccessLevelDetailData(ACAccessLevelDetailData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACAccessLevelDetailPK
		{
			get
			{
				return this._aCAccessLevelDetailPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACAccessLevelDetailPK", value);
				if (this._aCAccessLevelDetailPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCAccessLevelDetailPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACAccessLevelDetailPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACAccessLevelPK
		{
			get
			{
				return this._aCAccessLevelPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACAccessLevelPK", value);
				if (this._aCAccessLevelPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCAccessLevelPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACAccessLevelPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACMainZonePK
		{
			get
			{
				return this._aCMainZonePK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACMainZonePK", value);
				if (this._aCMainZonePK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCMainZonePK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACMainZonePKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACTimecodePK
		{
			get
			{
				return this._aCTimecodePK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACTimecodePK", value);
				if (this._aCTimecodePK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCTimecodePK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACTimecodePKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid FromACAccessLevelPK
		{
			get
			{
				return this._fromACAccessLevelPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("FromACAccessLevelPK", value);
				if (this._fromACAccessLevelPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._fromACAccessLevelPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFromACAccessLevelPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String MainZoneDescription
		{
			get
			{
				return this._mainZoneDescription == null ? null : this._mainZoneDescription.Trim();
			}
			set
			{
				 this._mainZoneDescription = value == null ? null : value.Trim();
			}
		}

		public virtual Byte MainZoneID
		{
			get
			{
				return this._mainZoneID;
			}
			set
			{
				this._mainZoneID = value;
			}
		}

		public virtual Guid ACPanelPK
		{
			get
			{
				return this._aCPanelPK;
			}
			set
			{
				this._aCPanelPK = value;
			}
		}

		public virtual String TimecodeSummary
		{
			get
			{
				return this._timecodeSummary == null ? null : this._timecodeSummary.Trim();
			}
			set
			{
				 this._timecodeSummary = value == null ? null : value.Trim();
			}
		}

		public virtual Int16 TCID
		{
			get
			{
				return this._tCID;
			}
			set
			{
				this._tCID = value;
			}
		}

		public virtual String ALSummary
		{
			get
			{
				return this._aLSummary == null ? null : this._aLSummary.Trim();
			}
			set
			{
				 this._aLSummary = value == null ? null : value.Trim();
			}
		}

		public virtual Int16 AccessLevelID
		{
			get
			{
				return this._accessLevelID;
			}
			set
			{
				this._accessLevelID = value;
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual Int32 UnitID
		{
			get
			{
				return this._unitID;
			}
			set
			{
				this._unitID = value;
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACAccessLevelDetail";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual ACAccessLevelData ACAccessLevel
		{
			get
			{
				ACAccessLevelData parent = new ACAccessLevelData();
				parent.ACAccessLevelPK = this.ACAccessLevelPK;
				parent.Summary = this.ALSummary;
				parent.AccessLevelID = this.AccessLevelID;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACAccessLevelPK = value.ACAccessLevelPK;
				this.ALSummary = value.Summary;
				this.AccessLevelID = value.AccessLevelID;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		public virtual ACMainZoneData ACMainZone
		{
			get
			{
				ACMainZoneData parent = new ACMainZoneData();
				parent.ACMainZonePK = this.ACMainZonePK;
				parent.Description = this.MainZoneDescription;
				parent.MainZoneID = this.MainZoneID;
				parent.ACPanelPK = this.ACPanelPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACMainZonePK = value.ACMainZonePK;
				this.MainZoneDescription = value.Description;
				this.MainZoneID = value.MainZoneID;
				this.ACPanelPK = value.ACPanelPK;
			}
		}

		public virtual ACPanelData ACPanel
		{
			get
			{
				ACPanelData parent = new ACPanelData();
				parent.ACPanelPK = this.ACPanelPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual ACTimecodeData ACTimecode
		{
			get
			{
				ACTimecodeData parent = new ACTimecodeData();
				parent.ACTimecodePK = this.ACTimecodePK;
				parent.Summary = this.TimecodeSummary;
				parent.TCID = this.TCID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACTimecodePK = value.ACTimecodePK;
				this.TimecodeSummary = value.Summary;
				this.TCID = value.TCID;
			}
		}

		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACAccessLevelDetailData data = entity as ACAccessLevelDetailData;
			if (data == null)
				return;

			this.ACAccessLevelPK = data.ACAccessLevelPK;
			this.ACMainZonePK = data.ACMainZonePK;
			this.ACTimecodePK = data.ACTimecodePK;
			this.FromACAccessLevelPK = data.FromACAccessLevelPK;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.MainZoneDescription = data.MainZoneDescription;
			this.MainZoneID = data.MainZoneID;
			this.ACPanelPK = data.ACPanelPK;
			this.TimecodeSummary = data.TimecodeSummary;
			this.TCID = data.TCID;
			this.ALSummary = data.ALSummary;
			this.AccessLevelID = data.AccessLevelID;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UnitID = data.UnitID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACAccessLevelDetailPK = data.ACAccessLevelDetailPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACAccessLevelDetailData));
		}

		private bool InternalEquals(ACAccessLevelDetailData obj)
		{
			if (this.ACAccessLevelDetailPK.CompareTo(obj.ACAccessLevelDetailPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACAccessLevelDetailPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACAccessLevelDetail:");
			builder.AppendFormat("{0}|", this.ACAccessLevelDetailPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACAccessLevelDetailPKChanged;
		private void OnACAccessLevelDetailPKChanged(EventArgs e)
		{
			if ((this.ACAccessLevelDetailPKChanged != null))
			{
				this.ACAccessLevelDetailPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACAccessLevelPKChanged;
		private void OnACAccessLevelPKChanged(EventArgs e)
		{
			if ((this.ACAccessLevelPKChanged != null))
			{
				this.ACAccessLevelPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACMainZonePKChanged;
		private void OnACMainZonePKChanged(EventArgs e)
		{
			if ((this.ACMainZonePKChanged != null))
			{
				this.ACMainZonePKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACTimecodePKChanged;
		private void OnACTimecodePKChanged(EventArgs e)
		{
			if ((this.ACTimecodePKChanged != null))
			{
				this.ACTimecodePKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FromACAccessLevelPKChanged;
		private void OnFromACAccessLevelPKChanged(EventArgs e)
		{
			if ((this.FromACAccessLevelPKChanged != null))
			{
				this.FromACAccessLevelPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class UsrAccountBuildingMapData : BusinessBase
	{
		#region Fields
		private Guid _usrAccountBuildingMapPK;
		private Guid _usrAccountPK;
		private Guid _bDBuildingPK;
		private Boolean _buildingWide;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private Int16 _accessTC;
		private Int32 _permission;
		private Boolean _primary;
		private String _address1;
		private Int32 _buildingID;
		private String _userID;

		#endregion

		#region Constructors
		public UsrAccountBuildingMapData()
		{
			this._usrAccountBuildingMapPK = Guid.NewGuid();
			this._usrAccountPK = Guid.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._address1 = string.Empty;
			this._userID = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public UsrAccountBuildingMapData(UsrAccountBuildingMapData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid UsrAccountBuildingMapPK
		{
			get
			{
				return this._usrAccountBuildingMapPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrAccountBuildingMapPK", value);
				if (this._usrAccountBuildingMapPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrAccountBuildingMapPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrAccountBuildingMapPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid UsrAccountPK
		{
			get
			{
				return this._usrAccountPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrAccountPK", value);
				if (this._usrAccountPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrAccountPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrAccountPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDBuildingPK", value);
				if (this._bDBuildingPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDBuildingPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDBuildingPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean BuildingWide
		{
			get
			{
				return this._buildingWide;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BuildingWide", value);
				if (this._buildingWide != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._buildingWide = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBuildingWideChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual Int16 AccessTC
		{
			get
			{
				return this._accessTC;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AccessTC", value);
				if (this._accessTC != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._accessTC = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAccessTCChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 Permission
		{
			get
			{
				return this._permission;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Permission", value);
				if (this._permission != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._permission = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPermissionChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Primary
		{
			get
			{
				return this._primary;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Primary", value);
				if (this._primary != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._primary = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPrimaryChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		public virtual String UserID
		{
			get
			{
				return this._userID == null ? null : this._userID.Trim();
			}
			set
			{
				 this._userID = value == null ? null : value.Trim();
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "UsrAccountBuildingMap";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual UsrAccountData UsrAccount
		{
			get
			{
				UsrAccountData parent = new UsrAccountData();
				parent.UsrAccountPK = this.UsrAccountPK;
				parent.UserID = this.UserID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UsrAccountPK = value.UsrAccountPK;
				this.UserID = value.UserID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			UsrAccountBuildingMapData data = entity as UsrAccountBuildingMapData;
			if (data == null)
				return;

			this.UsrAccountPK = data.UsrAccountPK;
			this.BDBuildingPK = data.BDBuildingPK;
			this.BuildingWide = data.BuildingWide;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.AccessTC = data.AccessTC;
			this.Permission = data.Permission;
			this.Primary = data.Primary;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			this.UserID = data.UserID;
			if (all)
			{
				this.UsrAccountBuildingMapPK = data.UsrAccountBuildingMapPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as UsrAccountBuildingMapData));
		}

		private bool InternalEquals(UsrAccountBuildingMapData obj)
		{
			if (this.UsrAccountBuildingMapPK.CompareTo(obj.UsrAccountBuildingMapPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.UsrAccountBuildingMapPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("UsrAccountBuildingMap:");
			builder.AppendFormat("{0}|", this.UsrAccountBuildingMapPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrAccountBuildingMapPKChanged;
		private void OnUsrAccountBuildingMapPKChanged(EventArgs e)
		{
			if ((this.UsrAccountBuildingMapPKChanged != null))
			{
				this.UsrAccountBuildingMapPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrAccountPKChanged;
		private void OnUsrAccountPKChanged(EventArgs e)
		{
			if ((this.UsrAccountPKChanged != null))
			{
				this.UsrAccountPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDBuildingPKChanged;
		private void OnBDBuildingPKChanged(EventArgs e)
		{
			if ((this.BDBuildingPKChanged != null))
			{
				this.BDBuildingPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BuildingWideChanged;
		private void OnBuildingWideChanged(EventArgs e)
		{
			if ((this.BuildingWideChanged != null))
			{
				this.BuildingWideChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AccessTCChanged;
		private void OnAccessTCChanged(EventArgs e)
		{
			if ((this.AccessTCChanged != null))
			{
				this.AccessTCChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PermissionChanged;
		private void OnPermissionChanged(EventArgs e)
		{
			if ((this.PermissionChanged != null))
			{
				this.PermissionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PrimaryChanged;
		private void OnPrimaryChanged(EventArgs e)
		{
			if ((this.PrimaryChanged != null))
			{
				this.PrimaryChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class BDBuildingData : BusinessBase
	{
		#region Fields
		private Guid _bDBuildingPK;
		private Int32 _buildingID;
		private String _buildingName;
		private String _address1;
		private String _streetNumb;
		private String _streetName;
		private String _address2;
		private String _city;
		private String _state;
		private String _zipcode;
		private String _county;
		private Int32 _timezoneID;
		private Boolean _federal;
		private String _phone;
		private String _fax;
		private String _bldgNotes;
		private String _cardNotes;
		private String _elevTrapNotes;
		private String _visitorNotes;
		private Int32 _systemTypeID;
		private Int32 _countryID;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private Int32 _visitorSiteCode;
		private Int32 _winUITypeID;
		private DateTime _lastExportParkingTag;
		private String _autoIssueNotifyEmail;
		private Byte _cardKeyMode;
		private String _accessLevelMode;
		private Boolean _hotClient;
		private DateTime _hotExpire;

		private UsrAccountBuildingMapDataCollection _usrAccountBuildingMapList;
		private ACPanelDataCollection _aCPanelList;
		private BDTenantDataCollection _bDTenantList;
		private BDBuildingHolidayMapDataCollection _bDBuildingHolidayMapList;
		private ACIntervalDataCollection _aCIntervalList;
		private ACTimecodeDataCollection _aCTimecodeList;
		private ACAMFormatDataCollection _aCAMFormatList;
		private ACAccessLevelDataCollection _aCAccessLevelList;
		private ACCardHolderBuildingMapDataCollection _aCCardHolderBuildingMapList;
		#endregion

		#region Constructors
		public BDBuildingData()
		{
			this._bDBuildingPK = Guid.NewGuid();
			this._buildingName = string.Empty;
			this._address1 = string.Empty;
			this._streetNumb = string.Empty;
			this._streetName = string.Empty;
			this._address2 = string.Empty;
			this._city = string.Empty;
			this._state = string.Empty;
			this._zipcode = string.Empty;
			this._county = string.Empty;
			this._phone = string.Empty;
			this._fax = string.Empty;
			this._bldgNotes = string.Empty;
			this._cardNotes = string.Empty;
			this._elevTrapNotes = string.Empty;
			this._visitorNotes = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._lastExportParkingTag = DateTime.Now;
			this._autoIssueNotifyEmail = string.Empty;
			this._accessLevelMode = string.Empty;
			this._hotExpire = DateTime.Now;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public BDBuildingData(BDBuildingData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDBuildingPK", value);
				if (this._bDBuildingPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDBuildingPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDBuildingPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BuildingID", value);
				if (this._buildingID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._buildingID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBuildingIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String BuildingName
		{
			get
			{
				return this._buildingName == null ? null : this._buildingName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BuildingName", value);
				if (this._buildingName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._buildingName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBuildingNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Address1", value);
				if (this._address1 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._address1 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAddress1Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String StreetNumb
		{
			get
			{
				return this._streetNumb == null ? null : this._streetNumb.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("StreetNumb", value);
				if (this._streetNumb != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._streetNumb = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnStreetNumbChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String StreetName
		{
			get
			{
				return this._streetName == null ? null : this._streetName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("StreetName", value);
				if (this._streetName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._streetName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnStreetNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Address2
		{
			get
			{
				return this._address2 == null ? null : this._address2.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Address2", value);
				if (this._address2 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._address2 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAddress2Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String City
		{
			get
			{
				return this._city == null ? null : this._city.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("City", value);
				if (this._city != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._city = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCityChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String State
		{
			get
			{
				return this._state == null ? null : this._state.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("State", value);
				if (this._state != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._state = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnStateChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Zipcode
		{
			get
			{
				return this._zipcode == null ? null : this._zipcode.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Zipcode", value);
				if (this._zipcode != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._zipcode = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnZipcodeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String County
		{
			get
			{
				return this._county == null ? null : this._county.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("County", value);
				if (this._county != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._county = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCountyChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 TimezoneID
		{
			get
			{
				return this._timezoneID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("TimezoneID", value);
				if (this._timezoneID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._timezoneID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnTimezoneIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Federal
		{
			get
			{
				return this._federal;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Federal", value);
				if (this._federal != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._federal = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFederalChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Phone
		{
			get
			{
				return this._phone == null ? null : this._phone.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Phone", value);
				if (this._phone != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._phone = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPhoneChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Fax
		{
			get
			{
				return this._fax == null ? null : this._fax.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Fax", value);
				if (this._fax != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._fax = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFaxChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String BldgNotes
		{
			get
			{
				return this._bldgNotes == null ? null : this._bldgNotes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BldgNotes", value);
				if (this._bldgNotes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bldgNotes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBldgNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CardNotes
		{
			get
			{
				return this._cardNotes == null ? null : this._cardNotes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CardNotes", value);
				if (this._cardNotes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._cardNotes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCardNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String ElevTrapNotes
		{
			get
			{
				return this._elevTrapNotes == null ? null : this._elevTrapNotes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ElevTrapNotes", value);
				if (this._elevTrapNotes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._elevTrapNotes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnElevTrapNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String VisitorNotes
		{
			get
			{
				return this._visitorNotes == null ? null : this._visitorNotes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("VisitorNotes", value);
				if (this._visitorNotes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._visitorNotes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnVisitorNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 SystemTypeID
		{
			get
			{
				return this._systemTypeID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("SystemTypeID", value);
				if (this._systemTypeID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._systemTypeID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSystemTypeIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 CountryID
		{
			get
			{
				return this._countryID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CountryID", value);
				if (this._countryID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._countryID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCountryIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 VisitorSiteCode
		{
			get
			{
				return this._visitorSiteCode;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("VisitorSiteCode", value);
				if (this._visitorSiteCode != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._visitorSiteCode = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnVisitorSiteCodeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 WinUITypeID
		{
			get
			{
				return this._winUITypeID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("WinUITypeID", value);
				if (this._winUITypeID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._winUITypeID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnWinUITypeIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime LastExportParkingTag
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._lastExportParkingTag.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LastExportParkingTag", value);
				if (this._lastExportParkingTag != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._lastExportParkingTag = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLastExportParkingTagChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String AutoIssueNotifyEmail
		{
			get
			{
				return this._autoIssueNotifyEmail == null ? null : this._autoIssueNotifyEmail.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AutoIssueNotifyEmail", value);
				if (this._autoIssueNotifyEmail != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._autoIssueNotifyEmail = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAutoIssueNotifyEmailChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte CardKeyMode
		{
			get
			{
				return this._cardKeyMode;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CardKeyMode", value);
				if (this._cardKeyMode != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._cardKeyMode = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCardKeyModeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String AccessLevelMode
		{
			get
			{
				return this._accessLevelMode == null ? null : this._accessLevelMode.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AccessLevelMode", value);
				if (this._accessLevelMode != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._accessLevelMode = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAccessLevelModeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean HotClient
		{
			get
			{
				return this._hotClient;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("HotClient", value);
				if (this._hotClient != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._hotClient = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnHotClientChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime HotExpire
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._hotExpire.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("HotExpire", value);
				if (this._hotExpire != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._hotExpire = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnHotExpireChanged(EventArgs.Empty);
					}
				}
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "BDBuilding";
			}
		}
		#endregion

		#region Children
		public virtual UsrAccountBuildingMapDataCollection UsrAccountBuildingMapList
		{
			get
			{
				return this._usrAccountBuildingMapList;
			}
			set
			{
				this._usrAccountBuildingMapList = value;
			}
		}

		public virtual ACPanelDataCollection ACPanelList
		{
			get
			{
				return this._aCPanelList;
			}
			set
			{
				this._aCPanelList = value;
			}
		}

		public virtual BDTenantDataCollection BDTenantList
		{
			get
			{
				return this._bDTenantList;
			}
			set
			{
				this._bDTenantList = value;
			}
		}

		public virtual BDBuildingHolidayMapDataCollection BDBuildingHolidayMapList
		{
			get
			{
				return this._bDBuildingHolidayMapList;
			}
			set
			{
				this._bDBuildingHolidayMapList = value;
			}
		}

		public virtual ACIntervalDataCollection ACIntervalList
		{
			get
			{
				return this._aCIntervalList;
			}
			set
			{
				this._aCIntervalList = value;
			}
		}

		public virtual ACTimecodeDataCollection ACTimecodeList
		{
			get
			{
				return this._aCTimecodeList;
			}
			set
			{
				this._aCTimecodeList = value;
			}
		}

		public virtual ACAMFormatDataCollection ACAMFormatList
		{
			get
			{
				return this._aCAMFormatList;
			}
			set
			{
				this._aCAMFormatList = value;
			}
		}

		public virtual ACAccessLevelDataCollection ACAccessLevelList
		{
			get
			{
				return this._aCAccessLevelList;
			}
			set
			{
				this._aCAccessLevelList = value;
			}
		}

		public virtual ACCardHolderBuildingMapDataCollection ACCardHolderBuildingMapList
		{
			get
			{
				return this._aCCardHolderBuildingMapList;
			}
			set
			{
				this._aCCardHolderBuildingMapList = value;
			}
		}

		#endregion

		#region Parents
		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			BDBuildingData data = entity as BDBuildingData;
			if (data == null)
				return;

			this.BuildingID = data.BuildingID;
			this.BuildingName = data.BuildingName;
			this.Address1 = data.Address1;
			this.StreetNumb = data.StreetNumb;
			this.StreetName = data.StreetName;
			this.Address2 = data.Address2;
			this.City = data.City;
			this.State = data.State;
			this.Zipcode = data.Zipcode;
			this.County = data.County;
			this.TimezoneID = data.TimezoneID;
			this.Federal = data.Federal;
			this.Phone = data.Phone;
			this.Fax = data.Fax;
			this.BldgNotes = data.BldgNotes;
			this.CardNotes = data.CardNotes;
			this.ElevTrapNotes = data.ElevTrapNotes;
			this.VisitorNotes = data.VisitorNotes;
			this.SystemTypeID = data.SystemTypeID;
			this.CountryID = data.CountryID;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.VisitorSiteCode = data.VisitorSiteCode;
			this.WinUITypeID = data.WinUITypeID;
			this.LastExportParkingTag = data.LastExportParkingTag;
			this.AutoIssueNotifyEmail = data.AutoIssueNotifyEmail;
			this.CardKeyMode = data.CardKeyMode;
			this.AccessLevelMode = data.AccessLevelMode;
			this.HotClient = data.HotClient;
			this.HotExpire = data.HotExpire;
			if (all)
			{
				this.BDBuildingPK = data.BDBuildingPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			BDBuildingData data = entity as BDBuildingData;
			if (data == null)
				return;

			if (data.UsrAccountBuildingMapList != null)
			{
				this.UsrAccountBuildingMapList = new UsrAccountBuildingMapDataCollection(data.UsrAccountBuildingMapList);
			}
			if (data.ACPanelList != null)
			{
				this.ACPanelList = new ACPanelDataCollection(data.ACPanelList);
			}
			if (data.BDTenantList != null)
			{
				this.BDTenantList = new BDTenantDataCollection(data.BDTenantList);
			}
			if (data.BDBuildingHolidayMapList != null)
			{
				this.BDBuildingHolidayMapList = new BDBuildingHolidayMapDataCollection(data.BDBuildingHolidayMapList);
			}
			if (data.ACIntervalList != null)
			{
				this.ACIntervalList = new ACIntervalDataCollection(data.ACIntervalList);
			}
			if (data.ACTimecodeList != null)
			{
				this.ACTimecodeList = new ACTimecodeDataCollection(data.ACTimecodeList);
			}
			if (data.ACAMFormatList != null)
			{
				this.ACAMFormatList = new ACAMFormatDataCollection(data.ACAMFormatList);
			}
			if (data.ACAccessLevelList != null)
			{
				this.ACAccessLevelList = new ACAccessLevelDataCollection(data.ACAccessLevelList);
			}
			if (data.ACCardHolderBuildingMapList != null)
			{
				this.ACCardHolderBuildingMapList = new ACCardHolderBuildingMapDataCollection(data.ACCardHolderBuildingMapList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.UsrAccountBuildingMapList != null)
			{
				this.UsrAccountBuildingMapList.AcceptChanges();
			}
			if (this.ACPanelList != null)
			{
				this.ACPanelList.AcceptChanges();
			}
			if (this.BDTenantList != null)
			{
				this.BDTenantList.AcceptChanges();
			}
			if (this.BDBuildingHolidayMapList != null)
			{
				this.BDBuildingHolidayMapList.AcceptChanges();
			}
			if (this.ACIntervalList != null)
			{
				this.ACIntervalList.AcceptChanges();
			}
			if (this.ACTimecodeList != null)
			{
				this.ACTimecodeList.AcceptChanges();
			}
			if (this.ACAMFormatList != null)
			{
				this.ACAMFormatList.AcceptChanges();
			}
			if (this.ACAccessLevelList != null)
			{
				this.ACAccessLevelList.AcceptChanges();
			}
			if (this.ACCardHolderBuildingMapList != null)
			{
				this.ACCardHolderBuildingMapList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as BDBuildingData));
		}

		private bool InternalEquals(BDBuildingData obj)
		{
			if (this.BDBuildingPK.CompareTo(obj.BDBuildingPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.BDBuildingPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("BDBuilding:");
			builder.AppendFormat("{0}|", this.BDBuildingPK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.UsrAccountBuildingMapList != null && this.UsrAccountBuildingMapList.IsDirty)
				{
					return true;
				}
				if (this.ACPanelList != null && this.ACPanelList.IsDirty)
				{
					return true;
				}
				if (this.BDTenantList != null && this.BDTenantList.IsDirty)
				{
					return true;
				}
				if (this.BDBuildingHolidayMapList != null && this.BDBuildingHolidayMapList.IsDirty)
				{
					return true;
				}
				if (this.ACIntervalList != null && this.ACIntervalList.IsDirty)
				{
					return true;
				}
				if (this.ACTimecodeList != null && this.ACTimecodeList.IsDirty)
				{
					return true;
				}
				if (this.ACAMFormatList != null && this.ACAMFormatList.IsDirty)
				{
					return true;
				}
				if (this.ACAccessLevelList != null && this.ACAccessLevelList.IsDirty)
				{
					return true;
				}
				if (this.ACCardHolderBuildingMapList != null && this.ACCardHolderBuildingMapList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.UsrAccountBuildingMapList != null && !this.UsrAccountBuildingMapList.IsValid)
				{
					return false;
				}
				if (this.ACPanelList != null && !this.ACPanelList.IsValid)
				{
					return false;
				}
				if (this.BDTenantList != null && !this.BDTenantList.IsValid)
				{
					return false;
				}
				if (this.BDBuildingHolidayMapList != null && !this.BDBuildingHolidayMapList.IsValid)
				{
					return false;
				}
				if (this.ACIntervalList != null && !this.ACIntervalList.IsValid)
				{
					return false;
				}
				if (this.ACTimecodeList != null && !this.ACTimecodeList.IsValid)
				{
					return false;
				}
				if (this.ACAMFormatList != null && !this.ACAMFormatList.IsValid)
				{
					return false;
				}
				if (this.ACAccessLevelList != null && !this.ACAccessLevelList.IsValid)
				{
					return false;
				}
				if (this.ACCardHolderBuildingMapList != null && !this.ACCardHolderBuildingMapList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler BDBuildingPKChanged;
		private void OnBDBuildingPKChanged(EventArgs e)
		{
			if ((this.BDBuildingPKChanged != null))
			{
				this.BDBuildingPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BuildingIDChanged;
		private void OnBuildingIDChanged(EventArgs e)
		{
			if ((this.BuildingIDChanged != null))
			{
				this.BuildingIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BuildingNameChanged;
		private void OnBuildingNameChanged(EventArgs e)
		{
			if ((this.BuildingNameChanged != null))
			{
				this.BuildingNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler Address1Changed;
		private void OnAddress1Changed(EventArgs e)
		{
			if ((this.Address1Changed != null))
			{
				this.Address1Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler StreetNumbChanged;
		private void OnStreetNumbChanged(EventArgs e)
		{
			if ((this.StreetNumbChanged != null))
			{
				this.StreetNumbChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler StreetNameChanged;
		private void OnStreetNameChanged(EventArgs e)
		{
			if ((this.StreetNameChanged != null))
			{
				this.StreetNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler Address2Changed;
		private void OnAddress2Changed(EventArgs e)
		{
			if ((this.Address2Changed != null))
			{
				this.Address2Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CityChanged;
		private void OnCityChanged(EventArgs e)
		{
			if ((this.CityChanged != null))
			{
				this.CityChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler StateChanged;
		private void OnStateChanged(EventArgs e)
		{
			if ((this.StateChanged != null))
			{
				this.StateChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ZipcodeChanged;
		private void OnZipcodeChanged(EventArgs e)
		{
			if ((this.ZipcodeChanged != null))
			{
				this.ZipcodeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CountyChanged;
		private void OnCountyChanged(EventArgs e)
		{
			if ((this.CountyChanged != null))
			{
				this.CountyChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler TimezoneIDChanged;
		private void OnTimezoneIDChanged(EventArgs e)
		{
			if ((this.TimezoneIDChanged != null))
			{
				this.TimezoneIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FederalChanged;
		private void OnFederalChanged(EventArgs e)
		{
			if ((this.FederalChanged != null))
			{
				this.FederalChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PhoneChanged;
		private void OnPhoneChanged(EventArgs e)
		{
			if ((this.PhoneChanged != null))
			{
				this.PhoneChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FaxChanged;
		private void OnFaxChanged(EventArgs e)
		{
			if ((this.FaxChanged != null))
			{
				this.FaxChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BldgNotesChanged;
		private void OnBldgNotesChanged(EventArgs e)
		{
			if ((this.BldgNotesChanged != null))
			{
				this.BldgNotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CardNotesChanged;
		private void OnCardNotesChanged(EventArgs e)
		{
			if ((this.CardNotesChanged != null))
			{
				this.CardNotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ElevTrapNotesChanged;
		private void OnElevTrapNotesChanged(EventArgs e)
		{
			if ((this.ElevTrapNotesChanged != null))
			{
				this.ElevTrapNotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler VisitorNotesChanged;
		private void OnVisitorNotesChanged(EventArgs e)
		{
			if ((this.VisitorNotesChanged != null))
			{
				this.VisitorNotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SystemTypeIDChanged;
		private void OnSystemTypeIDChanged(EventArgs e)
		{
			if ((this.SystemTypeIDChanged != null))
			{
				this.SystemTypeIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CountryIDChanged;
		private void OnCountryIDChanged(EventArgs e)
		{
			if ((this.CountryIDChanged != null))
			{
				this.CountryIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler VisitorSiteCodeChanged;
		private void OnVisitorSiteCodeChanged(EventArgs e)
		{
			if ((this.VisitorSiteCodeChanged != null))
			{
				this.VisitorSiteCodeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler WinUITypeIDChanged;
		private void OnWinUITypeIDChanged(EventArgs e)
		{
			if ((this.WinUITypeIDChanged != null))
			{
				this.WinUITypeIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LastExportParkingTagChanged;
		private void OnLastExportParkingTagChanged(EventArgs e)
		{
			if ((this.LastExportParkingTagChanged != null))
			{
				this.LastExportParkingTagChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AutoIssueNotifyEmailChanged;
		private void OnAutoIssueNotifyEmailChanged(EventArgs e)
		{
			if ((this.AutoIssueNotifyEmailChanged != null))
			{
				this.AutoIssueNotifyEmailChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CardKeyModeChanged;
		private void OnCardKeyModeChanged(EventArgs e)
		{
			if ((this.CardKeyModeChanged != null))
			{
				this.CardKeyModeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AccessLevelModeChanged;
		private void OnAccessLevelModeChanged(EventArgs e)
		{
			if ((this.AccessLevelModeChanged != null))
			{
				this.AccessLevelModeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler HotClientChanged;
		private void OnHotClientChanged(EventArgs e)
		{
			if ((this.HotClientChanged != null))
			{
				this.HotClientChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler HotExpireChanged;
		private void OnHotExpireChanged(EventArgs e)
		{
			if ((this.HotExpireChanged != null))
			{
				this.HotExpireChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class BDTenantData : BusinessBase
	{
		#region Fields
		private Guid _bDTenantPK;
		private Guid _bDBuildingPK;
		private String _tenant;
		private String _suite;
		private String _phone;
		private String _fax;
		private Boolean _blocked;
		private Boolean _federal;
		private String _tentNotes;
		private String _cardNotes;
		private String _visitorNotes;
		private Boolean _isManagement;
		private String _type;
		private Boolean _noRecycleCard;
		private Int32 _systemTypeID;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _parkingAccount;
		private String _custInfo1;
		private String _custInfo2;
		private String _custInfo3;
		private String _custInfo4;
		private String _custInfo5;
		private String _custInfo6;
		private String _custInfo7;
		private String _custInfo8;
		private Boolean _delExpiredCard;
		private Boolean _hotClient;
		private DateTime _hotExpire;
		private String _email;
		private String _address1;
		private Int32 _buildingID;

		private UsrAccountTenantMapDataCollection _usrAccountTenantMapList;
		private UsrAccountDataCollection _usrAccountList;
		private ACFunctionCardDataCollection _aCFunctionCardList;
		private BDTenantHolidayMapDataCollection _bDTenantHolidayMapList;
		private ACCardHolderDataCollection _aCCardHolderList;
		private BDVisitorDataCollection _bDVisitorList;
		#endregion

		#region Constructors
		public BDTenantData()
		{
			this._bDTenantPK = Guid.NewGuid();
			this._bDBuildingPK = Guid.Empty;
			this._tenant = string.Empty;
			this._suite = string.Empty;
			this._phone = string.Empty;
			this._fax = string.Empty;
			this._tentNotes = string.Empty;
			this._cardNotes = string.Empty;
			this._visitorNotes = string.Empty;
			this._type = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._parkingAccount = string.Empty;
			this._custInfo1 = string.Empty;
			this._custInfo2 = string.Empty;
			this._custInfo3 = string.Empty;
			this._custInfo4 = string.Empty;
			this._custInfo5 = string.Empty;
			this._custInfo6 = string.Empty;
			this._custInfo7 = string.Empty;
			this._custInfo8 = string.Empty;
			this._hotExpire = DateTime.Now;
			this._email = string.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public BDTenantData(BDTenantData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid BDTenantPK
		{
			get
			{
				return this._bDTenantPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDTenantPK", value);
				if (this._bDTenantPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDTenantPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDTenantPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDBuildingPK", value);
				if (this._bDBuildingPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDBuildingPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDBuildingPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Tenant
		{
			get
			{
				return this._tenant == null ? null : this._tenant.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Tenant", value);
				if (this._tenant != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._tenant = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnTenantChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Suite
		{
			get
			{
				return this._suite == null ? null : this._suite.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Suite", value);
				if (this._suite != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._suite = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSuiteChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Phone
		{
			get
			{
				return this._phone == null ? null : this._phone.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Phone", value);
				if (this._phone != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._phone = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPhoneChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Fax
		{
			get
			{
				return this._fax == null ? null : this._fax.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Fax", value);
				if (this._fax != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._fax = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFaxChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Blocked
		{
			get
			{
				return this._blocked;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Blocked", value);
				if (this._blocked != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._blocked = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBlockedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Federal
		{
			get
			{
				return this._federal;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Federal", value);
				if (this._federal != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._federal = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFederalChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String TentNotes
		{
			get
			{
				return this._tentNotes == null ? null : this._tentNotes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("TentNotes", value);
				if (this._tentNotes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._tentNotes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnTentNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CardNotes
		{
			get
			{
				return this._cardNotes == null ? null : this._cardNotes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CardNotes", value);
				if (this._cardNotes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._cardNotes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCardNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String VisitorNotes
		{
			get
			{
				return this._visitorNotes == null ? null : this._visitorNotes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("VisitorNotes", value);
				if (this._visitorNotes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._visitorNotes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnVisitorNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean IsManagement
		{
			get
			{
				return this._isManagement;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("IsManagement", value);
				if (this._isManagement != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._isManagement = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnIsManagementChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Type
		{
			get
			{
				return this._type == null ? null : this._type.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Type", value);
				if (this._type != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._type = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnTypeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean NoRecycleCard
		{
			get
			{
				return this._noRecycleCard;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("NoRecycleCard", value);
				if (this._noRecycleCard != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._noRecycleCard = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNoRecycleCardChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 SystemTypeID
		{
			get
			{
				return this._systemTypeID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("SystemTypeID", value);
				if (this._systemTypeID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._systemTypeID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSystemTypeIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String ParkingAccount
		{
			get
			{
				return this._parkingAccount == null ? null : this._parkingAccount.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ParkingAccount", value);
				if (this._parkingAccount != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._parkingAccount = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnParkingAccountChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo1
		{
			get
			{
				return this._custInfo1 == null ? null : this._custInfo1.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo1", value);
				if (this._custInfo1 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo1 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo1Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo2
		{
			get
			{
				return this._custInfo2 == null ? null : this._custInfo2.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo2", value);
				if (this._custInfo2 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo2 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo2Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo3
		{
			get
			{
				return this._custInfo3 == null ? null : this._custInfo3.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo3", value);
				if (this._custInfo3 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo3 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo3Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo4
		{
			get
			{
				return this._custInfo4 == null ? null : this._custInfo4.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo4", value);
				if (this._custInfo4 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo4 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo4Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo5
		{
			get
			{
				return this._custInfo5 == null ? null : this._custInfo5.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo5", value);
				if (this._custInfo5 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo5 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo5Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo6
		{
			get
			{
				return this._custInfo6 == null ? null : this._custInfo6.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo6", value);
				if (this._custInfo6 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo6 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo6Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo7
		{
			get
			{
				return this._custInfo7 == null ? null : this._custInfo7.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo7", value);
				if (this._custInfo7 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo7 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo7Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo8
		{
			get
			{
				return this._custInfo8 == null ? null : this._custInfo8.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo8", value);
				if (this._custInfo8 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo8 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo8Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean DelExpiredCard
		{
			get
			{
				return this._delExpiredCard;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("DelExpiredCard", value);
				if (this._delExpiredCard != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._delExpiredCard = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDelExpiredCardChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean HotClient
		{
			get
			{
				return this._hotClient;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("HotClient", value);
				if (this._hotClient != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._hotClient = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnHotClientChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime HotExpire
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._hotExpire.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("HotExpire", value);
				if (this._hotExpire != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._hotExpire = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnHotExpireChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Email
		{
			get
			{
				return this._email == null ? null : this._email.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Email", value);
				if (this._email != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._email = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEmailChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "BDTenant";
			}
		}
		#endregion

		#region Children
		public virtual UsrAccountTenantMapDataCollection UsrAccountTenantMapList
		{
			get
			{
				return this._usrAccountTenantMapList;
			}
			set
			{
				this._usrAccountTenantMapList = value;
			}
		}

		public virtual UsrAccountDataCollection UsrAccountList
		{
			get
			{
				return this._usrAccountList;
			}
			set
			{
				this._usrAccountList = value;
			}
		}

		public virtual ACFunctionCardDataCollection ACFunctionCardList
		{
			get
			{
				return this._aCFunctionCardList;
			}
			set
			{
				this._aCFunctionCardList = value;
			}
		}

		public virtual BDTenantHolidayMapDataCollection BDTenantHolidayMapList
		{
			get
			{
				return this._bDTenantHolidayMapList;
			}
			set
			{
				this._bDTenantHolidayMapList = value;
			}
		}

		public virtual ACCardHolderDataCollection ACCardHolderList
		{
			get
			{
				return this._aCCardHolderList;
			}
			set
			{
				this._aCCardHolderList = value;
			}
		}

		public virtual BDVisitorDataCollection BDVisitorList
		{
			get
			{
				return this._bDVisitorList;
			}
			set
			{
				this._bDVisitorList = value;
			}
		}

		#endregion

		#region Parents
		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			BDTenantData data = entity as BDTenantData;
			if (data == null)
				return;

			this.BDBuildingPK = data.BDBuildingPK;
			this.Tenant = data.Tenant;
			this.Suite = data.Suite;
			this.Phone = data.Phone;
			this.Fax = data.Fax;
			this.Blocked = data.Blocked;
			this.Federal = data.Federal;
			this.TentNotes = data.TentNotes;
			this.CardNotes = data.CardNotes;
			this.VisitorNotes = data.VisitorNotes;
			this.IsManagement = data.IsManagement;
			this.Type = data.Type;
			this.NoRecycleCard = data.NoRecycleCard;
			this.SystemTypeID = data.SystemTypeID;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.ParkingAccount = data.ParkingAccount;
			this.CustInfo1 = data.CustInfo1;
			this.CustInfo2 = data.CustInfo2;
			this.CustInfo3 = data.CustInfo3;
			this.CustInfo4 = data.CustInfo4;
			this.CustInfo5 = data.CustInfo5;
			this.CustInfo6 = data.CustInfo6;
			this.CustInfo7 = data.CustInfo7;
			this.CustInfo8 = data.CustInfo8;
			this.DelExpiredCard = data.DelExpiredCard;
			this.HotClient = data.HotClient;
			this.HotExpire = data.HotExpire;
			this.Email = data.Email;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.BDTenantPK = data.BDTenantPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			BDTenantData data = entity as BDTenantData;
			if (data == null)
				return;

			if (data.UsrAccountTenantMapList != null)
			{
				this.UsrAccountTenantMapList = new UsrAccountTenantMapDataCollection(data.UsrAccountTenantMapList);
			}
			if (data.UsrAccountList != null)
			{
				this.UsrAccountList = new UsrAccountDataCollection(data.UsrAccountList);
			}
			if (data.ACFunctionCardList != null)
			{
				this.ACFunctionCardList = new ACFunctionCardDataCollection(data.ACFunctionCardList);
			}
			if (data.BDTenantHolidayMapList != null)
			{
				this.BDTenantHolidayMapList = new BDTenantHolidayMapDataCollection(data.BDTenantHolidayMapList);
			}
			if (data.ACCardHolderList != null)
			{
				this.ACCardHolderList = new ACCardHolderDataCollection(data.ACCardHolderList);
			}
			if (data.BDVisitorList != null)
			{
				this.BDVisitorList = new BDVisitorDataCollection(data.BDVisitorList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.UsrAccountTenantMapList != null)
			{
				this.UsrAccountTenantMapList.AcceptChanges();
			}
			if (this.UsrAccountList != null)
			{
				this.UsrAccountList.AcceptChanges();
			}
			if (this.ACFunctionCardList != null)
			{
				this.ACFunctionCardList.AcceptChanges();
			}
			if (this.BDTenantHolidayMapList != null)
			{
				this.BDTenantHolidayMapList.AcceptChanges();
			}
			if (this.ACCardHolderList != null)
			{
				this.ACCardHolderList.AcceptChanges();
			}
			if (this.BDVisitorList != null)
			{
				this.BDVisitorList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as BDTenantData));
		}

		private bool InternalEquals(BDTenantData obj)
		{
			if (this.BDTenantPK.CompareTo(obj.BDTenantPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.BDTenantPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("BDTenant:");
			builder.AppendFormat("{0}|", this.BDTenantPK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.UsrAccountTenantMapList != null && this.UsrAccountTenantMapList.IsDirty)
				{
					return true;
				}
				if (this.UsrAccountList != null && this.UsrAccountList.IsDirty)
				{
					return true;
				}
				if (this.ACFunctionCardList != null && this.ACFunctionCardList.IsDirty)
				{
					return true;
				}
				if (this.BDTenantHolidayMapList != null && this.BDTenantHolidayMapList.IsDirty)
				{
					return true;
				}
				if (this.ACCardHolderList != null && this.ACCardHolderList.IsDirty)
				{
					return true;
				}
				if (this.BDVisitorList != null && this.BDVisitorList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.UsrAccountTenantMapList != null && !this.UsrAccountTenantMapList.IsValid)
				{
					return false;
				}
				if (this.UsrAccountList != null && !this.UsrAccountList.IsValid)
				{
					return false;
				}
				if (this.ACFunctionCardList != null && !this.ACFunctionCardList.IsValid)
				{
					return false;
				}
				if (this.BDTenantHolidayMapList != null && !this.BDTenantHolidayMapList.IsValid)
				{
					return false;
				}
				if (this.ACCardHolderList != null && !this.ACCardHolderList.IsValid)
				{
					return false;
				}
				if (this.BDVisitorList != null && !this.BDVisitorList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler BDTenantPKChanged;
		private void OnBDTenantPKChanged(EventArgs e)
		{
			if ((this.BDTenantPKChanged != null))
			{
				this.BDTenantPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDBuildingPKChanged;
		private void OnBDBuildingPKChanged(EventArgs e)
		{
			if ((this.BDBuildingPKChanged != null))
			{
				this.BDBuildingPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler TenantChanged;
		private void OnTenantChanged(EventArgs e)
		{
			if ((this.TenantChanged != null))
			{
				this.TenantChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SuiteChanged;
		private void OnSuiteChanged(EventArgs e)
		{
			if ((this.SuiteChanged != null))
			{
				this.SuiteChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PhoneChanged;
		private void OnPhoneChanged(EventArgs e)
		{
			if ((this.PhoneChanged != null))
			{
				this.PhoneChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FaxChanged;
		private void OnFaxChanged(EventArgs e)
		{
			if ((this.FaxChanged != null))
			{
				this.FaxChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BlockedChanged;
		private void OnBlockedChanged(EventArgs e)
		{
			if ((this.BlockedChanged != null))
			{
				this.BlockedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FederalChanged;
		private void OnFederalChanged(EventArgs e)
		{
			if ((this.FederalChanged != null))
			{
				this.FederalChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler TentNotesChanged;
		private void OnTentNotesChanged(EventArgs e)
		{
			if ((this.TentNotesChanged != null))
			{
				this.TentNotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CardNotesChanged;
		private void OnCardNotesChanged(EventArgs e)
		{
			if ((this.CardNotesChanged != null))
			{
				this.CardNotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler VisitorNotesChanged;
		private void OnVisitorNotesChanged(EventArgs e)
		{
			if ((this.VisitorNotesChanged != null))
			{
				this.VisitorNotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler IsManagementChanged;
		private void OnIsManagementChanged(EventArgs e)
		{
			if ((this.IsManagementChanged != null))
			{
				this.IsManagementChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler TypeChanged;
		private void OnTypeChanged(EventArgs e)
		{
			if ((this.TypeChanged != null))
			{
				this.TypeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NoRecycleCardChanged;
		private void OnNoRecycleCardChanged(EventArgs e)
		{
			if ((this.NoRecycleCardChanged != null))
			{
				this.NoRecycleCardChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SystemTypeIDChanged;
		private void OnSystemTypeIDChanged(EventArgs e)
		{
			if ((this.SystemTypeIDChanged != null))
			{
				this.SystemTypeIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ParkingAccountChanged;
		private void OnParkingAccountChanged(EventArgs e)
		{
			if ((this.ParkingAccountChanged != null))
			{
				this.ParkingAccountChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo1Changed;
		private void OnCustInfo1Changed(EventArgs e)
		{
			if ((this.CustInfo1Changed != null))
			{
				this.CustInfo1Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo2Changed;
		private void OnCustInfo2Changed(EventArgs e)
		{
			if ((this.CustInfo2Changed != null))
			{
				this.CustInfo2Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo3Changed;
		private void OnCustInfo3Changed(EventArgs e)
		{
			if ((this.CustInfo3Changed != null))
			{
				this.CustInfo3Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo4Changed;
		private void OnCustInfo4Changed(EventArgs e)
		{
			if ((this.CustInfo4Changed != null))
			{
				this.CustInfo4Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo5Changed;
		private void OnCustInfo5Changed(EventArgs e)
		{
			if ((this.CustInfo5Changed != null))
			{
				this.CustInfo5Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo6Changed;
		private void OnCustInfo6Changed(EventArgs e)
		{
			if ((this.CustInfo6Changed != null))
			{
				this.CustInfo6Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo7Changed;
		private void OnCustInfo7Changed(EventArgs e)
		{
			if ((this.CustInfo7Changed != null))
			{
				this.CustInfo7Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo8Changed;
		private void OnCustInfo8Changed(EventArgs e)
		{
			if ((this.CustInfo8Changed != null))
			{
				this.CustInfo8Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DelExpiredCardChanged;
		private void OnDelExpiredCardChanged(EventArgs e)
		{
			if ((this.DelExpiredCardChanged != null))
			{
				this.DelExpiredCardChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler HotClientChanged;
		private void OnHotClientChanged(EventArgs e)
		{
			if ((this.HotClientChanged != null))
			{
				this.HotClientChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler HotExpireChanged;
		private void OnHotExpireChanged(EventArgs e)
		{
			if ((this.HotExpireChanged != null))
			{
				this.HotExpireChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EmailChanged;
		private void OnEmailChanged(EventArgs e)
		{
			if ((this.EmailChanged != null))
			{
				this.EmailChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class UtilSettingCategoryData : BusinessBase
	{
		#region Fields
		private Guid _utilSettingCategoryPK;
		private Int32 _settingCategoryID;
		private String _settingCategory;
		private String _instanceName;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private Guid _bDBuildingPK;

		private UtilSettingDetailDataCollection _utilSettingDetailList;
		#endregion

		#region Constructors
		public UtilSettingCategoryData()
		{
			this._utilSettingCategoryPK = Guid.NewGuid();
			this._settingCategory = string.Empty;
			this._instanceName = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._bDBuildingPK = Guid.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public UtilSettingCategoryData(UtilSettingCategoryData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid UtilSettingCategoryPK
		{
			get
			{
				return this._utilSettingCategoryPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UtilSettingCategoryPK", value);
				if (this._utilSettingCategoryPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._utilSettingCategoryPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUtilSettingCategoryPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 SettingCategoryID
		{
			get
			{
				return this._settingCategoryID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("SettingCategoryID", value);
				if (this._settingCategoryID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._settingCategoryID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSettingCategoryIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String SettingCategory
		{
			get
			{
				return this._settingCategory == null ? null : this._settingCategory.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("SettingCategory", value);
				if (this._settingCategory != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._settingCategory = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSettingCategoryChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String InstanceName
		{
			get
			{
				return this._instanceName == null ? null : this._instanceName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("InstanceName", value);
				if (this._instanceName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._instanceName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnInstanceNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDBuildingPK", value);
				if (this._bDBuildingPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDBuildingPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDBuildingPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "UtilSettingCategory";
			}
		}
		#endregion

		#region Children
		public virtual UtilSettingDetailDataCollection UtilSettingDetailList
		{
			get
			{
				return this._utilSettingDetailList;
			}
			set
			{
				this._utilSettingDetailList = value;
			}
		}

		#endregion

		#region Parents
		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			UtilSettingCategoryData data = entity as UtilSettingCategoryData;
			if (data == null)
				return;

			this.SettingCategoryID = data.SettingCategoryID;
			this.SettingCategory = data.SettingCategory;
			this.InstanceName = data.InstanceName;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.BDBuildingPK = data.BDBuildingPK;
			if (all)
			{
				this.UtilSettingCategoryPK = data.UtilSettingCategoryPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			UtilSettingCategoryData data = entity as UtilSettingCategoryData;
			if (data == null)
				return;

			if (data.UtilSettingDetailList != null)
			{
				this.UtilSettingDetailList = new UtilSettingDetailDataCollection(data.UtilSettingDetailList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.UtilSettingDetailList != null)
			{
				this.UtilSettingDetailList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as UtilSettingCategoryData));
		}

		private bool InternalEquals(UtilSettingCategoryData obj)
		{
			if (this.UtilSettingCategoryPK.CompareTo(obj.UtilSettingCategoryPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.UtilSettingCategoryPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("UtilSettingCategory:");
			builder.AppendFormat("{0}|", this.UtilSettingCategoryPK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.UtilSettingDetailList != null && this.UtilSettingDetailList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.UtilSettingDetailList != null && !this.UtilSettingDetailList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler UtilSettingCategoryPKChanged;
		private void OnUtilSettingCategoryPKChanged(EventArgs e)
		{
			if ((this.UtilSettingCategoryPKChanged != null))
			{
				this.UtilSettingCategoryPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SettingCategoryIDChanged;
		private void OnSettingCategoryIDChanged(EventArgs e)
		{
			if ((this.SettingCategoryIDChanged != null))
			{
				this.SettingCategoryIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SettingCategoryChanged;
		private void OnSettingCategoryChanged(EventArgs e)
		{
			if ((this.SettingCategoryChanged != null))
			{
				this.SettingCategoryChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler InstanceNameChanged;
		private void OnInstanceNameChanged(EventArgs e)
		{
			if ((this.InstanceNameChanged != null))
			{
				this.InstanceNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDBuildingPKChanged;
		private void OnBDBuildingPKChanged(EventArgs e)
		{
			if ((this.BDBuildingPKChanged != null))
			{
				this.BDBuildingPKChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class UtilSettingDetailData : BusinessBase
	{
		#region Fields
		private Guid _utilSettingDetailPK;
		private Guid _utilSettingCategoryPK;
		private String _fieldName;
		private String _fieldValue;
		private Byte[] _picture;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _settingCategory;
		private Int32 _settingCategoryID;

		#endregion

		#region Constructors
		public UtilSettingDetailData()
		{
			this._utilSettingDetailPK = Guid.NewGuid();
			this._utilSettingCategoryPK = Guid.Empty;
			this._fieldName = string.Empty;
			this._fieldValue = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._settingCategory = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public UtilSettingDetailData(UtilSettingDetailData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid UtilSettingDetailPK
		{
			get
			{
				return this._utilSettingDetailPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UtilSettingDetailPK", value);
				if (this._utilSettingDetailPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._utilSettingDetailPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUtilSettingDetailPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid UtilSettingCategoryPK
		{
			get
			{
				return this._utilSettingCategoryPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UtilSettingCategoryPK", value);
				if (this._utilSettingCategoryPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._utilSettingCategoryPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUtilSettingCategoryPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String FieldName
		{
			get
			{
				return this._fieldName == null ? null : this._fieldName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("FieldName", value);
				if (this._fieldName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._fieldName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFieldNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String FieldValue
		{
			get
			{
				return this._fieldValue == null ? null : this._fieldValue.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("FieldValue", value);
				if (this._fieldValue != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._fieldValue = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFieldValueChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte[] Picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Picture", value);
				if (this._picture != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._picture = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPictureChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String SettingCategory
		{
			get
			{
				return this._settingCategory == null ? null : this._settingCategory.Trim();
			}
			set
			{
				 this._settingCategory = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 SettingCategoryID
		{
			get
			{
				return this._settingCategoryID;
			}
			set
			{
				this._settingCategoryID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "UtilSettingDetail";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual UtilSettingCategoryData UtilSettingCategory
		{
			get
			{
				UtilSettingCategoryData parent = new UtilSettingCategoryData();
				parent.UtilSettingCategoryPK = this.UtilSettingCategoryPK;
				parent.SettingCategory = this.SettingCategory;
				parent.SettingCategoryID = this.SettingCategoryID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UtilSettingCategoryPK = value.UtilSettingCategoryPK;
				this.SettingCategory = value.SettingCategory;
				this.SettingCategoryID = value.SettingCategoryID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			UtilSettingDetailData data = entity as UtilSettingDetailData;
			if (data == null)
				return;

			this.UtilSettingCategoryPK = data.UtilSettingCategoryPK;
			this.FieldName = data.FieldName;
			this.FieldValue = data.FieldValue;
			this.Picture = data.Picture;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.SettingCategory = data.SettingCategory;
			this.SettingCategoryID = data.SettingCategoryID;
			if (all)
			{
				this.UtilSettingDetailPK = data.UtilSettingDetailPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as UtilSettingDetailData));
		}

		private bool InternalEquals(UtilSettingDetailData obj)
		{
			if (this.UtilSettingDetailPK.CompareTo(obj.UtilSettingDetailPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.UtilSettingDetailPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("UtilSettingDetail:");
			builder.AppendFormat("{0}|", this.UtilSettingDetailPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler UtilSettingDetailPKChanged;
		private void OnUtilSettingDetailPKChanged(EventArgs e)
		{
			if ((this.UtilSettingDetailPKChanged != null))
			{
				this.UtilSettingDetailPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UtilSettingCategoryPKChanged;
		private void OnUtilSettingCategoryPKChanged(EventArgs e)
		{
			if ((this.UtilSettingCategoryPKChanged != null))
			{
				this.UtilSettingCategoryPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FieldNameChanged;
		private void OnFieldNameChanged(EventArgs e)
		{
			if ((this.FieldNameChanged != null))
			{
				this.FieldNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FieldValueChanged;
		private void OnFieldValueChanged(EventArgs e)
		{
			if ((this.FieldValueChanged != null))
			{
				this.FieldValueChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PictureChanged;
		private void OnPictureChanged(EventArgs e)
		{
			if ((this.PictureChanged != null))
			{
				this.PictureChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACOutputGroupMainZoneMapData : BusinessBase
	{
		#region Fields
		private Guid _aCOutputGroupMainZoneMapPK;
		private Guid _aCOutputGroupPK;
		private Guid _aCMainZonePK;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private Byte _mainZoneID;
		private Guid _aCPanelPK;
		private Byte _groupID;
		private Int32 _unitID;
		private String _address1;
		private Int32 _buildingID;
		private Guid _bDBuildingPK;

		#endregion

		#region Constructors
		public ACOutputGroupMainZoneMapData()
		{
			this._aCOutputGroupMainZoneMapPK = Guid.NewGuid();
			this._aCOutputGroupPK = Guid.Empty;
			this._aCMainZonePK = Guid.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._aCPanelPK = Guid.Empty;
			this._address1 = string.Empty;
			this._bDBuildingPK = Guid.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACOutputGroupMainZoneMapData(ACOutputGroupMainZoneMapData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACOutputGroupMainZoneMapPK
		{
			get
			{
				return this._aCOutputGroupMainZoneMapPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACOutputGroupMainZoneMapPK", value);
				if (this._aCOutputGroupMainZoneMapPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCOutputGroupMainZoneMapPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACOutputGroupMainZoneMapPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACOutputGroupPK
		{
			get
			{
				return this._aCOutputGroupPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACOutputGroupPK", value);
				if (this._aCOutputGroupPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCOutputGroupPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACOutputGroupPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACMainZonePK
		{
			get
			{
				return this._aCMainZonePK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACMainZonePK", value);
				if (this._aCMainZonePK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCMainZonePK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACMainZonePKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual Byte MainZoneID
		{
			get
			{
				return this._mainZoneID;
			}
			set
			{
				this._mainZoneID = value;
			}
		}

		public virtual Guid ACPanelPK
		{
			get
			{
				return this._aCPanelPK;
			}
			set
			{
				this._aCPanelPK = value;
			}
		}

		public virtual Byte GroupID
		{
			get
			{
				return this._groupID;
			}
			set
			{
				this._groupID = value;
			}
		}

		public virtual Int32 UnitID
		{
			get
			{
				return this._unitID;
			}
			set
			{
				this._unitID = value;
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACOutputGroupMainZoneMap";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual ACMainZoneData ACMainZone
		{
			get
			{
				ACMainZoneData parent = new ACMainZoneData();
				parent.ACMainZonePK = this.ACMainZonePK;
				parent.MainZoneID = this.MainZoneID;
				parent.ACPanelPK = this.ACPanelPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACMainZonePK = value.ACMainZonePK;
				this.MainZoneID = value.MainZoneID;
				this.ACPanelPK = value.ACPanelPK;
			}
		}

		public virtual ACOutputGroupData ACOutputGroup
		{
			get
			{
				ACOutputGroupData parent = new ACOutputGroupData();
				parent.ACOutputGroupPK = this.ACOutputGroupPK;
				parent.GroupID = this.GroupID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACOutputGroupPK = value.ACOutputGroupPK;
				this.GroupID = value.GroupID;
			}
		}

		public virtual ACPanelData ACPanel
		{
			get
			{
				ACPanelData parent = new ACPanelData();
				parent.ACPanelPK = this.ACPanelPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACOutputGroupMainZoneMapData data = entity as ACOutputGroupMainZoneMapData;
			if (data == null)
				return;

			this.ACOutputGroupPK = data.ACOutputGroupPK;
			this.ACMainZonePK = data.ACMainZonePK;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.MainZoneID = data.MainZoneID;
			this.ACPanelPK = data.ACPanelPK;
			this.GroupID = data.GroupID;
			this.UnitID = data.UnitID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			this.BDBuildingPK = data.BDBuildingPK;
			if (all)
			{
				this.ACOutputGroupMainZoneMapPK = data.ACOutputGroupMainZoneMapPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACOutputGroupMainZoneMapData));
		}

		private bool InternalEquals(ACOutputGroupMainZoneMapData obj)
		{
			if (this.ACOutputGroupMainZoneMapPK.CompareTo(obj.ACOutputGroupMainZoneMapPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACOutputGroupMainZoneMapPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACOutputGroupMainZoneMap:");
			builder.AppendFormat("{0}|", this.ACOutputGroupMainZoneMapPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACOutputGroupMainZoneMapPKChanged;
		private void OnACOutputGroupMainZoneMapPKChanged(EventArgs e)
		{
			if ((this.ACOutputGroupMainZoneMapPKChanged != null))
			{
				this.ACOutputGroupMainZoneMapPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACOutputGroupPKChanged;
		private void OnACOutputGroupPKChanged(EventArgs e)
		{
			if ((this.ACOutputGroupPKChanged != null))
			{
				this.ACOutputGroupPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACMainZonePKChanged;
		private void OnACMainZonePKChanged(EventArgs e)
		{
			if ((this.ACMainZonePKChanged != null))
			{
				this.ACMainZonePKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACCardHolderData : BusinessBase
	{
		#region Fields
		private Guid _aCCardHolderPK;
		private Int32 _sitecode;
		private Int32 _embossed;
		private Int32 _encoded;
		private Int32 _cardTypeID;
		private String _firstName;
		private String _lastName;
		private Byte[] _photo;
		private DateTime _validFrom;
		private DateTime _validThru;
		private Boolean _fIPS;
		private Int32 _pin;
		private Guid _bDTenantPK;
		private String _notes;
		private String _eventNotifyEmail;
		private Boolean _fireWarden;
		private String _custInfo1;
		private String _custInfo2;
		private String _custInfo3;
		private String _custInfo4;
		private String _custInfo5;
		private String _custInfo6;
		private String _custInfo7;
		private String _custInfo8;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _suite;
		private String _tenant;
		private Guid _bDBuildingPK;
		private String _address1;
		private Int32 _buildingID;

		private ACCardHolderBuildingMapDataCollection _aCCardHolderBuildingMapList;
		#endregion

		#region Constructors
		public ACCardHolderData()
		{
			this._aCCardHolderPK = Guid.NewGuid();
			this._firstName = string.Empty;
			this._lastName = string.Empty;
			this._validFrom = DateTime.Now;
			this._validThru = DateTime.Now;
			this._bDTenantPK = Guid.Empty;
			this._notes = string.Empty;
			this._eventNotifyEmail = string.Empty;
			this._custInfo1 = string.Empty;
			this._custInfo2 = string.Empty;
			this._custInfo3 = string.Empty;
			this._custInfo4 = string.Empty;
			this._custInfo5 = string.Empty;
			this._custInfo6 = string.Empty;
			this._custInfo7 = string.Empty;
			this._custInfo8 = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._suite = string.Empty;
			this._tenant = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACCardHolderData(ACCardHolderData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACCardHolderPK
		{
			get
			{
				return this._aCCardHolderPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACCardHolderPK", value);
				if (this._aCCardHolderPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCCardHolderPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACCardHolderPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 Sitecode
		{
			get
			{
				return this._sitecode;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Sitecode", value);
				if (this._sitecode != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._sitecode = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSitecodeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 Embossed
		{
			get
			{
				return this._embossed;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Embossed", value);
				if (this._embossed != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._embossed = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEmbossedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 Encoded
		{
			get
			{
				return this._encoded;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Encoded", value);
				if (this._encoded != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._encoded = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEncodedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 CardTypeID
		{
			get
			{
				return this._cardTypeID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CardTypeID", value);
				if (this._cardTypeID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._cardTypeID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCardTypeIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String FirstName
		{
			get
			{
				return this._firstName == null ? null : this._firstName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("FirstName", value);
				if (this._firstName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._firstName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFirstNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String LastName
		{
			get
			{
				return this._lastName == null ? null : this._lastName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LastName", value);
				if (this._lastName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._lastName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLastNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte[] Photo
		{
			get
			{
				return this._photo;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Photo", value);
				if (this._photo != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._photo = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPhotoChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime ValidFrom
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._validFrom.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ValidFrom", value);
				if (this._validFrom != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._validFrom = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnValidFromChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime ValidThru
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._validThru.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ValidThru", value);
				if (this._validThru != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._validThru = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnValidThruChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean FIPS
		{
			get
			{
				return this._fIPS;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("FIPS", value);
				if (this._fIPS != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._fIPS = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFIPSChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 Pin
		{
			get
			{
				return this._pin;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Pin", value);
				if (this._pin != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._pin = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPinChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDTenantPK
		{
			get
			{
				return this._bDTenantPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDTenantPK", value);
				if (this._bDTenantPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDTenantPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDTenantPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Notes
		{
			get
			{
				return this._notes == null ? null : this._notes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Notes", value);
				if (this._notes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._notes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String EventNotifyEmail
		{
			get
			{
				return this._eventNotifyEmail == null ? null : this._eventNotifyEmail.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("EventNotifyEmail", value);
				if (this._eventNotifyEmail != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._eventNotifyEmail = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEventNotifyEmailChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean FireWarden
		{
			get
			{
				return this._fireWarden;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("FireWarden", value);
				if (this._fireWarden != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._fireWarden = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFireWardenChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo1
		{
			get
			{
				return this._custInfo1 == null ? null : this._custInfo1.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo1", value);
				if (this._custInfo1 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo1 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo1Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo2
		{
			get
			{
				return this._custInfo2 == null ? null : this._custInfo2.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo2", value);
				if (this._custInfo2 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo2 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo2Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo3
		{
			get
			{
				return this._custInfo3 == null ? null : this._custInfo3.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo3", value);
				if (this._custInfo3 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo3 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo3Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo4
		{
			get
			{
				return this._custInfo4 == null ? null : this._custInfo4.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo4", value);
				if (this._custInfo4 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo4 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo4Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo5
		{
			get
			{
				return this._custInfo5 == null ? null : this._custInfo5.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo5", value);
				if (this._custInfo5 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo5 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo5Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo6
		{
			get
			{
				return this._custInfo6 == null ? null : this._custInfo6.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo6", value);
				if (this._custInfo6 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo6 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo6Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo7
		{
			get
			{
				return this._custInfo7 == null ? null : this._custInfo7.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo7", value);
				if (this._custInfo7 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo7 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo7Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CustInfo8
		{
			get
			{
				return this._custInfo8 == null ? null : this._custInfo8.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CustInfo8", value);
				if (this._custInfo8 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._custInfo8 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCustInfo8Changed(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String Suite
		{
			get
			{
				return this._suite == null ? null : this._suite.Trim();
			}
			set
			{
				 this._suite = value == null ? null : value.Trim();
			}
		}

		public virtual String Tenant
		{
			get
			{
				return this._tenant == null ? null : this._tenant.Trim();
			}
			set
			{
				 this._tenant = value == null ? null : value.Trim();
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACCardHolder";
			}
		}
		#endregion

		#region Children
		public virtual ACCardHolderBuildingMapDataCollection ACCardHolderBuildingMapList
		{
			get
			{
				return this._aCCardHolderBuildingMapList;
			}
			set
			{
				this._aCCardHolderBuildingMapList = value;
			}
		}

		#endregion

		#region Parents
		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual BDTenantData BDTenant
		{
			get
			{
				BDTenantData parent = new BDTenantData();
				parent.BDTenantPK = this.BDTenantPK;
				parent.Suite = this.Suite;
				parent.Tenant = this.Tenant;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDTenantPK = value.BDTenantPK;
				this.Suite = value.Suite;
				this.Tenant = value.Tenant;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACCardHolderData data = entity as ACCardHolderData;
			if (data == null)
				return;

			this.Sitecode = data.Sitecode;
			this.Embossed = data.Embossed;
			this.Encoded = data.Encoded;
			this.CardTypeID = data.CardTypeID;
			this.FirstName = data.FirstName;
			this.LastName = data.LastName;
			this.Photo = data.Photo;
			this.ValidFrom = data.ValidFrom;
			this.ValidThru = data.ValidThru;
			this.FIPS = data.FIPS;
			this.Pin = data.Pin;
			this.BDTenantPK = data.BDTenantPK;
			this.Notes = data.Notes;
			this.EventNotifyEmail = data.EventNotifyEmail;
			this.FireWarden = data.FireWarden;
			this.CustInfo1 = data.CustInfo1;
			this.CustInfo2 = data.CustInfo2;
			this.CustInfo3 = data.CustInfo3;
			this.CustInfo4 = data.CustInfo4;
			this.CustInfo5 = data.CustInfo5;
			this.CustInfo6 = data.CustInfo6;
			this.CustInfo7 = data.CustInfo7;
			this.CustInfo8 = data.CustInfo8;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Suite = data.Suite;
			this.Tenant = data.Tenant;
			this.BDBuildingPK = data.BDBuildingPK;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACCardHolderPK = data.ACCardHolderPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			ACCardHolderData data = entity as ACCardHolderData;
			if (data == null)
				return;

			if (data.ACCardHolderBuildingMapList != null)
			{
				this.ACCardHolderBuildingMapList = new ACCardHolderBuildingMapDataCollection(data.ACCardHolderBuildingMapList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.ACCardHolderBuildingMapList != null)
			{
				this.ACCardHolderBuildingMapList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACCardHolderData));
		}

		private bool InternalEquals(ACCardHolderData obj)
		{
			if (this.ACCardHolderPK.CompareTo(obj.ACCardHolderPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACCardHolderPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACCardHolder:");
			builder.AppendFormat("{0}|", this.ACCardHolderPK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.ACCardHolderBuildingMapList != null && this.ACCardHolderBuildingMapList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.ACCardHolderBuildingMapList != null && !this.ACCardHolderBuildingMapList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACCardHolderPKChanged;
		private void OnACCardHolderPKChanged(EventArgs e)
		{
			if ((this.ACCardHolderPKChanged != null))
			{
				this.ACCardHolderPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SitecodeChanged;
		private void OnSitecodeChanged(EventArgs e)
		{
			if ((this.SitecodeChanged != null))
			{
				this.SitecodeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EmbossedChanged;
		private void OnEmbossedChanged(EventArgs e)
		{
			if ((this.EmbossedChanged != null))
			{
				this.EmbossedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EncodedChanged;
		private void OnEncodedChanged(EventArgs e)
		{
			if ((this.EncodedChanged != null))
			{
				this.EncodedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CardTypeIDChanged;
		private void OnCardTypeIDChanged(EventArgs e)
		{
			if ((this.CardTypeIDChanged != null))
			{
				this.CardTypeIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FirstNameChanged;
		private void OnFirstNameChanged(EventArgs e)
		{
			if ((this.FirstNameChanged != null))
			{
				this.FirstNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LastNameChanged;
		private void OnLastNameChanged(EventArgs e)
		{
			if ((this.LastNameChanged != null))
			{
				this.LastNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PhotoChanged;
		private void OnPhotoChanged(EventArgs e)
		{
			if ((this.PhotoChanged != null))
			{
				this.PhotoChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ValidFromChanged;
		private void OnValidFromChanged(EventArgs e)
		{
			if ((this.ValidFromChanged != null))
			{
				this.ValidFromChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ValidThruChanged;
		private void OnValidThruChanged(EventArgs e)
		{
			if ((this.ValidThruChanged != null))
			{
				this.ValidThruChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FIPSChanged;
		private void OnFIPSChanged(EventArgs e)
		{
			if ((this.FIPSChanged != null))
			{
				this.FIPSChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PinChanged;
		private void OnPinChanged(EventArgs e)
		{
			if ((this.PinChanged != null))
			{
				this.PinChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDTenantPKChanged;
		private void OnBDTenantPKChanged(EventArgs e)
		{
			if ((this.BDTenantPKChanged != null))
			{
				this.BDTenantPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NotesChanged;
		private void OnNotesChanged(EventArgs e)
		{
			if ((this.NotesChanged != null))
			{
				this.NotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EventNotifyEmailChanged;
		private void OnEventNotifyEmailChanged(EventArgs e)
		{
			if ((this.EventNotifyEmailChanged != null))
			{
				this.EventNotifyEmailChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FireWardenChanged;
		private void OnFireWardenChanged(EventArgs e)
		{
			if ((this.FireWardenChanged != null))
			{
				this.FireWardenChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo1Changed;
		private void OnCustInfo1Changed(EventArgs e)
		{
			if ((this.CustInfo1Changed != null))
			{
				this.CustInfo1Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo2Changed;
		private void OnCustInfo2Changed(EventArgs e)
		{
			if ((this.CustInfo2Changed != null))
			{
				this.CustInfo2Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo3Changed;
		private void OnCustInfo3Changed(EventArgs e)
		{
			if ((this.CustInfo3Changed != null))
			{
				this.CustInfo3Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo4Changed;
		private void OnCustInfo4Changed(EventArgs e)
		{
			if ((this.CustInfo4Changed != null))
			{
				this.CustInfo4Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo5Changed;
		private void OnCustInfo5Changed(EventArgs e)
		{
			if ((this.CustInfo5Changed != null))
			{
				this.CustInfo5Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo6Changed;
		private void OnCustInfo6Changed(EventArgs e)
		{
			if ((this.CustInfo6Changed != null))
			{
				this.CustInfo6Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo7Changed;
		private void OnCustInfo7Changed(EventArgs e)
		{
			if ((this.CustInfo7Changed != null))
			{
				this.CustInfo7Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CustInfo8Changed;
		private void OnCustInfo8Changed(EventArgs e)
		{
			if ((this.CustInfo8Changed != null))
			{
				this.CustInfo8Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACMainZoneData : BusinessBase
	{
		#region Fields
		private Guid _aCMainZonePK;
		private Guid _aCPanelPK;
		private Byte _mainZoneID;
		private Int32 _mainZoneTypeID;
		private String _description;
		private String _readerName;
		private Int32 _readerTypeID;
		private Boolean _reverseColor;
		private Byte _outputGroup;
		private Boolean _needPin;
		private String _antiPassback;
		private Boolean _softAntiPassback;
		private Int16 _unlockTimecode;
		private Boolean _unlockOn1stRead;
		private Boolean _rexShuntOnly;
		private Int16 _pulseTime;
		private Boolean _relockByTimeout;
		private Int16 _forceAMFormat;
		private Int16 _propAMFFormat;
		private Int16 _debounce;
		private Int16 _allowOpenTime;
		private Boolean _noPreAlarm;
		private String _postPreAlarm;
		private Int16 _postDuration;
		private String _notes;
		private String _eventNotifyEmail;
		private Boolean _isPulsed;
		private Boolean _alwaysToMAS;
		private Boolean _commentBeforePulse;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private Boolean _degrade;
		private String _readerPassMode;
		private Byte _panelZoneID;
		private Int32 _lockTypeID;
		private Boolean _locked;
		private Byte _inputGroup;
		private Int16 _unlockTempTC;
		private DateTime _unlockTempBegin;
		private DateTime _unlockTempEnd;
		private Guid _bDBuildingPK;
		private Int32 _unitID;
		private String _address1;
		private Int32 _buildingID;

		private ACOutputGroupMainZoneMapDataCollection _aCOutputGroupMainZoneMapList;
		private ACAccessLevelDetailDataCollection _aCAccessLevelDetailList;
		#endregion

		#region Constructors
		public ACMainZoneData()
		{
			this._aCMainZonePK = Guid.NewGuid();
			this._aCPanelPK = Guid.Empty;
			this._description = string.Empty;
			this._readerName = string.Empty;
			this._antiPassback = string.Empty;
			this._postPreAlarm = string.Empty;
			this._notes = string.Empty;
			this._eventNotifyEmail = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._readerPassMode = string.Empty;
			this._unlockTempBegin = DateTime.Now;
			this._unlockTempEnd = DateTime.Now;
			this._bDBuildingPK = Guid.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACMainZoneData(ACMainZoneData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACMainZonePK
		{
			get
			{
				return this._aCMainZonePK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACMainZonePK", value);
				if (this._aCMainZonePK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCMainZonePK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACMainZonePKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACPanelPK
		{
			get
			{
				return this._aCPanelPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACPanelPK", value);
				if (this._aCPanelPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCPanelPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACPanelPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte MainZoneID
		{
			get
			{
				return this._mainZoneID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("MainZoneID", value);
				if (this._mainZoneID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._mainZoneID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnMainZoneIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 MainZoneTypeID
		{
			get
			{
				return this._mainZoneTypeID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("MainZoneTypeID", value);
				if (this._mainZoneTypeID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._mainZoneTypeID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnMainZoneTypeIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Description
		{
			get
			{
				return this._description == null ? null : this._description.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Description", value);
				if (this._description != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._description = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDescriptionChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String ReaderName
		{
			get
			{
				return this._readerName == null ? null : this._readerName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ReaderName", value);
				if (this._readerName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._readerName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnReaderNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 ReaderTypeID
		{
			get
			{
				return this._readerTypeID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ReaderTypeID", value);
				if (this._readerTypeID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._readerTypeID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnReaderTypeIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean ReverseColor
		{
			get
			{
				return this._reverseColor;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ReverseColor", value);
				if (this._reverseColor != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._reverseColor = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnReverseColorChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte OutputGroup
		{
			get
			{
				return this._outputGroup;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("OutputGroup", value);
				if (this._outputGroup != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._outputGroup = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnOutputGroupChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean NeedPin
		{
			get
			{
				return this._needPin;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("NeedPin", value);
				if (this._needPin != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._needPin = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNeedPinChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String AntiPassback
		{
			get
			{
				return this._antiPassback == null ? null : this._antiPassback.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AntiPassback", value);
				if (this._antiPassback != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._antiPassback = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAntiPassbackChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean SoftAntiPassback
		{
			get
			{
				return this._softAntiPassback;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("SoftAntiPassback", value);
				if (this._softAntiPassback != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._softAntiPassback = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSoftAntiPassbackChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 UnlockTimecode
		{
			get
			{
				return this._unlockTimecode;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UnlockTimecode", value);
				if (this._unlockTimecode != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._unlockTimecode = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUnlockTimecodeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean UnlockOn1stRead
		{
			get
			{
				return this._unlockOn1stRead;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UnlockOn1stRead", value);
				if (this._unlockOn1stRead != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._unlockOn1stRead = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUnlockOn1stReadChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean RexShuntOnly
		{
			get
			{
				return this._rexShuntOnly;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("RexShuntOnly", value);
				if (this._rexShuntOnly != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._rexShuntOnly = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnRexShuntOnlyChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 PulseTime
		{
			get
			{
				return this._pulseTime;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("PulseTime", value);
				if (this._pulseTime != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._pulseTime = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPulseTimeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean RelockByTimeout
		{
			get
			{
				return this._relockByTimeout;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("RelockByTimeout", value);
				if (this._relockByTimeout != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._relockByTimeout = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnRelockByTimeoutChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 ForceAMFormat
		{
			get
			{
				return this._forceAMFormat;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ForceAMFormat", value);
				if (this._forceAMFormat != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._forceAMFormat = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnForceAMFormatChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 PropAMFFormat
		{
			get
			{
				return this._propAMFFormat;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("PropAMFFormat", value);
				if (this._propAMFFormat != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._propAMFFormat = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPropAMFFormatChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 Debounce
		{
			get
			{
				return this._debounce;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Debounce", value);
				if (this._debounce != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._debounce = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDebounceChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 AllowOpenTime
		{
			get
			{
				return this._allowOpenTime;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AllowOpenTime", value);
				if (this._allowOpenTime != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._allowOpenTime = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAllowOpenTimeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean NoPreAlarm
		{
			get
			{
				return this._noPreAlarm;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("NoPreAlarm", value);
				if (this._noPreAlarm != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._noPreAlarm = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNoPreAlarmChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String PostPreAlarm
		{
			get
			{
				return this._postPreAlarm == null ? null : this._postPreAlarm.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("PostPreAlarm", value);
				if (this._postPreAlarm != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._postPreAlarm = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPostPreAlarmChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 PostDuration
		{
			get
			{
				return this._postDuration;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("PostDuration", value);
				if (this._postDuration != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._postDuration = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPostDurationChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Notes
		{
			get
			{
				return this._notes == null ? null : this._notes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Notes", value);
				if (this._notes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._notes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String EventNotifyEmail
		{
			get
			{
				return this._eventNotifyEmail == null ? null : this._eventNotifyEmail.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("EventNotifyEmail", value);
				if (this._eventNotifyEmail != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._eventNotifyEmail = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEventNotifyEmailChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean IsPulsed
		{
			get
			{
				return this._isPulsed;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("IsPulsed", value);
				if (this._isPulsed != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._isPulsed = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnIsPulsedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean AlwaysToMAS
		{
			get
			{
				return this._alwaysToMAS;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AlwaysToMAS", value);
				if (this._alwaysToMAS != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._alwaysToMAS = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAlwaysToMASChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean CommentBeforePulse
		{
			get
			{
				return this._commentBeforePulse;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CommentBeforePulse", value);
				if (this._commentBeforePulse != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._commentBeforePulse = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCommentBeforePulseChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual Boolean Degrade
		{
			get
			{
				return this._degrade;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Degrade", value);
				if (this._degrade != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._degrade = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDegradeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String ReaderPassMode
		{
			get
			{
				return this._readerPassMode == null ? null : this._readerPassMode.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ReaderPassMode", value);
				if (this._readerPassMode != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._readerPassMode = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnReaderPassModeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte PanelZoneID
		{
			get
			{
				return this._panelZoneID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("PanelZoneID", value);
				if (this._panelZoneID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._panelZoneID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPanelZoneIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 LockTypeID
		{
			get
			{
				return this._lockTypeID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LockTypeID", value);
				if (this._lockTypeID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._lockTypeID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLockTypeIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Locked
		{
			get
			{
				return this._locked;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Locked", value);
				if (this._locked != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._locked = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLockedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte InputGroup
		{
			get
			{
				return this._inputGroup;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("InputGroup", value);
				if (this._inputGroup != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._inputGroup = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnInputGroupChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 UnlockTempTC
		{
			get
			{
				return this._unlockTempTC;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UnlockTempTC", value);
				if (this._unlockTempTC != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._unlockTempTC = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUnlockTempTCChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime UnlockTempBegin
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._unlockTempBegin.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UnlockTempBegin", value);
				if (this._unlockTempBegin != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._unlockTempBegin = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUnlockTempBeginChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime UnlockTempEnd
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._unlockTempEnd.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UnlockTempEnd", value);
				if (this._unlockTempEnd != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._unlockTempEnd = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUnlockTempEndChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual Int32 UnitID
		{
			get
			{
				return this._unitID;
			}
			set
			{
				this._unitID = value;
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACMainZone";
			}
		}
		#endregion

		#region Children
		public virtual ACOutputGroupMainZoneMapDataCollection ACOutputGroupMainZoneMapList
		{
			get
			{
				return this._aCOutputGroupMainZoneMapList;
			}
			set
			{
				this._aCOutputGroupMainZoneMapList = value;
			}
		}

		public virtual ACAccessLevelDetailDataCollection ACAccessLevelDetailList
		{
			get
			{
				return this._aCAccessLevelDetailList;
			}
			set
			{
				this._aCAccessLevelDetailList = value;
			}
		}

		#endregion

		#region Parents
		public virtual ACPanelData ACPanel
		{
			get
			{
				ACPanelData parent = new ACPanelData();
				parent.ACPanelPK = this.ACPanelPK;
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.BDBuildingPK = value.BDBuildingPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACMainZoneData data = entity as ACMainZoneData;
			if (data == null)
				return;

			this.ACPanelPK = data.ACPanelPK;
			this.MainZoneID = data.MainZoneID;
			this.MainZoneTypeID = data.MainZoneTypeID;
			this.Description = data.Description;
			this.ReaderName = data.ReaderName;
			this.ReaderTypeID = data.ReaderTypeID;
			this.ReverseColor = data.ReverseColor;
			this.OutputGroup = data.OutputGroup;
			this.NeedPin = data.NeedPin;
			this.AntiPassback = data.AntiPassback;
			this.SoftAntiPassback = data.SoftAntiPassback;
			this.UnlockTimecode = data.UnlockTimecode;
			this.UnlockOn1stRead = data.UnlockOn1stRead;
			this.RexShuntOnly = data.RexShuntOnly;
			this.PulseTime = data.PulseTime;
			this.RelockByTimeout = data.RelockByTimeout;
			this.ForceAMFormat = data.ForceAMFormat;
			this.PropAMFFormat = data.PropAMFFormat;
			this.Debounce = data.Debounce;
			this.AllowOpenTime = data.AllowOpenTime;
			this.NoPreAlarm = data.NoPreAlarm;
			this.PostPreAlarm = data.PostPreAlarm;
			this.PostDuration = data.PostDuration;
			this.Notes = data.Notes;
			this.EventNotifyEmail = data.EventNotifyEmail;
			this.IsPulsed = data.IsPulsed;
			this.AlwaysToMAS = data.AlwaysToMAS;
			this.CommentBeforePulse = data.CommentBeforePulse;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Degrade = data.Degrade;
			this.ReaderPassMode = data.ReaderPassMode;
			this.PanelZoneID = data.PanelZoneID;
			this.LockTypeID = data.LockTypeID;
			this.Locked = data.Locked;
			this.InputGroup = data.InputGroup;
			this.UnlockTempTC = data.UnlockTempTC;
			this.UnlockTempBegin = data.UnlockTempBegin;
			this.UnlockTempEnd = data.UnlockTempEnd;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UnitID = data.UnitID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACMainZonePK = data.ACMainZonePK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			ACMainZoneData data = entity as ACMainZoneData;
			if (data == null)
				return;

			if (data.ACOutputGroupMainZoneMapList != null)
			{
				this.ACOutputGroupMainZoneMapList = new ACOutputGroupMainZoneMapDataCollection(data.ACOutputGroupMainZoneMapList);
			}
			if (data.ACAccessLevelDetailList != null)
			{
				this.ACAccessLevelDetailList = new ACAccessLevelDetailDataCollection(data.ACAccessLevelDetailList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.ACOutputGroupMainZoneMapList != null)
			{
				this.ACOutputGroupMainZoneMapList.AcceptChanges();
			}
			if (this.ACAccessLevelDetailList != null)
			{
				this.ACAccessLevelDetailList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACMainZoneData));
		}

		private bool InternalEquals(ACMainZoneData obj)
		{
			if (this.ACMainZonePK.CompareTo(obj.ACMainZonePK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACMainZonePK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACMainZone:");
			builder.AppendFormat("{0}|", this.ACMainZonePK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.ACOutputGroupMainZoneMapList != null && this.ACOutputGroupMainZoneMapList.IsDirty)
				{
					return true;
				}
				if (this.ACAccessLevelDetailList != null && this.ACAccessLevelDetailList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.ACOutputGroupMainZoneMapList != null && !this.ACOutputGroupMainZoneMapList.IsValid)
				{
					return false;
				}
				if (this.ACAccessLevelDetailList != null && !this.ACAccessLevelDetailList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACMainZonePKChanged;
		private void OnACMainZonePKChanged(EventArgs e)
		{
			if ((this.ACMainZonePKChanged != null))
			{
				this.ACMainZonePKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACPanelPKChanged;
		private void OnACPanelPKChanged(EventArgs e)
		{
			if ((this.ACPanelPKChanged != null))
			{
				this.ACPanelPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler MainZoneIDChanged;
		private void OnMainZoneIDChanged(EventArgs e)
		{
			if ((this.MainZoneIDChanged != null))
			{
				this.MainZoneIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler MainZoneTypeIDChanged;
		private void OnMainZoneTypeIDChanged(EventArgs e)
		{
			if ((this.MainZoneTypeIDChanged != null))
			{
				this.MainZoneTypeIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DescriptionChanged;
		private void OnDescriptionChanged(EventArgs e)
		{
			if ((this.DescriptionChanged != null))
			{
				this.DescriptionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ReaderNameChanged;
		private void OnReaderNameChanged(EventArgs e)
		{
			if ((this.ReaderNameChanged != null))
			{
				this.ReaderNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ReaderTypeIDChanged;
		private void OnReaderTypeIDChanged(EventArgs e)
		{
			if ((this.ReaderTypeIDChanged != null))
			{
				this.ReaderTypeIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ReverseColorChanged;
		private void OnReverseColorChanged(EventArgs e)
		{
			if ((this.ReverseColorChanged != null))
			{
				this.ReverseColorChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler OutputGroupChanged;
		private void OnOutputGroupChanged(EventArgs e)
		{
			if ((this.OutputGroupChanged != null))
			{
				this.OutputGroupChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NeedPinChanged;
		private void OnNeedPinChanged(EventArgs e)
		{
			if ((this.NeedPinChanged != null))
			{
				this.NeedPinChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AntiPassbackChanged;
		private void OnAntiPassbackChanged(EventArgs e)
		{
			if ((this.AntiPassbackChanged != null))
			{
				this.AntiPassbackChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SoftAntiPassbackChanged;
		private void OnSoftAntiPassbackChanged(EventArgs e)
		{
			if ((this.SoftAntiPassbackChanged != null))
			{
				this.SoftAntiPassbackChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UnlockTimecodeChanged;
		private void OnUnlockTimecodeChanged(EventArgs e)
		{
			if ((this.UnlockTimecodeChanged != null))
			{
				this.UnlockTimecodeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UnlockOn1stReadChanged;
		private void OnUnlockOn1stReadChanged(EventArgs e)
		{
			if ((this.UnlockOn1stReadChanged != null))
			{
				this.UnlockOn1stReadChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RexShuntOnlyChanged;
		private void OnRexShuntOnlyChanged(EventArgs e)
		{
			if ((this.RexShuntOnlyChanged != null))
			{
				this.RexShuntOnlyChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PulseTimeChanged;
		private void OnPulseTimeChanged(EventArgs e)
		{
			if ((this.PulseTimeChanged != null))
			{
				this.PulseTimeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RelockByTimeoutChanged;
		private void OnRelockByTimeoutChanged(EventArgs e)
		{
			if ((this.RelockByTimeoutChanged != null))
			{
				this.RelockByTimeoutChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ForceAMFormatChanged;
		private void OnForceAMFormatChanged(EventArgs e)
		{
			if ((this.ForceAMFormatChanged != null))
			{
				this.ForceAMFormatChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PropAMFFormatChanged;
		private void OnPropAMFFormatChanged(EventArgs e)
		{
			if ((this.PropAMFFormatChanged != null))
			{
				this.PropAMFFormatChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DebounceChanged;
		private void OnDebounceChanged(EventArgs e)
		{
			if ((this.DebounceChanged != null))
			{
				this.DebounceChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AllowOpenTimeChanged;
		private void OnAllowOpenTimeChanged(EventArgs e)
		{
			if ((this.AllowOpenTimeChanged != null))
			{
				this.AllowOpenTimeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NoPreAlarmChanged;
		private void OnNoPreAlarmChanged(EventArgs e)
		{
			if ((this.NoPreAlarmChanged != null))
			{
				this.NoPreAlarmChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PostPreAlarmChanged;
		private void OnPostPreAlarmChanged(EventArgs e)
		{
			if ((this.PostPreAlarmChanged != null))
			{
				this.PostPreAlarmChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PostDurationChanged;
		private void OnPostDurationChanged(EventArgs e)
		{
			if ((this.PostDurationChanged != null))
			{
				this.PostDurationChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NotesChanged;
		private void OnNotesChanged(EventArgs e)
		{
			if ((this.NotesChanged != null))
			{
				this.NotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EventNotifyEmailChanged;
		private void OnEventNotifyEmailChanged(EventArgs e)
		{
			if ((this.EventNotifyEmailChanged != null))
			{
				this.EventNotifyEmailChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler IsPulsedChanged;
		private void OnIsPulsedChanged(EventArgs e)
		{
			if ((this.IsPulsedChanged != null))
			{
				this.IsPulsedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AlwaysToMASChanged;
		private void OnAlwaysToMASChanged(EventArgs e)
		{
			if ((this.AlwaysToMASChanged != null))
			{
				this.AlwaysToMASChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CommentBeforePulseChanged;
		private void OnCommentBeforePulseChanged(EventArgs e)
		{
			if ((this.CommentBeforePulseChanged != null))
			{
				this.CommentBeforePulseChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DegradeChanged;
		private void OnDegradeChanged(EventArgs e)
		{
			if ((this.DegradeChanged != null))
			{
				this.DegradeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ReaderPassModeChanged;
		private void OnReaderPassModeChanged(EventArgs e)
		{
			if ((this.ReaderPassModeChanged != null))
			{
				this.ReaderPassModeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PanelZoneIDChanged;
		private void OnPanelZoneIDChanged(EventArgs e)
		{
			if ((this.PanelZoneIDChanged != null))
			{
				this.PanelZoneIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LockTypeIDChanged;
		private void OnLockTypeIDChanged(EventArgs e)
		{
			if ((this.LockTypeIDChanged != null))
			{
				this.LockTypeIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LockedChanged;
		private void OnLockedChanged(EventArgs e)
		{
			if ((this.LockedChanged != null))
			{
				this.LockedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler InputGroupChanged;
		private void OnInputGroupChanged(EventArgs e)
		{
			if ((this.InputGroupChanged != null))
			{
				this.InputGroupChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UnlockTempTCChanged;
		private void OnUnlockTempTCChanged(EventArgs e)
		{
			if ((this.UnlockTempTCChanged != null))
			{
				this.UnlockTempTCChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UnlockTempBeginChanged;
		private void OnUnlockTempBeginChanged(EventArgs e)
		{
			if ((this.UnlockTempBeginChanged != null))
			{
				this.UnlockTempBeginChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UnlockTempEndChanged;
		private void OnUnlockTempEndChanged(EventArgs e)
		{
			if ((this.UnlockTempEndChanged != null))
			{
				this.UnlockTempEndChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACIntervalData : BusinessBase
	{
		#region Fields
		private Guid _aCIntervalPK;
		private Guid _bDBuildingPK;
		private Int16 _iVID;
		private String _begin;
		private String _end;
		private Boolean _sun;
		private Boolean _mon;
		private Boolean _tue;
		private Boolean _wed;
		private Boolean _thu;
		private Boolean _fri;
		private Boolean _sat;
		private Boolean _hol;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _address1;
		private Int32 _buildingID;

		private ACIntvalHolidayMapDataCollection _aCIntvalHolidayMapList;
		private ACTimecodeIntervalMapDataCollection _aCTimecodeIntervalMapList;
		#endregion

		#region Constructors
		public ACIntervalData()
		{
			this._aCIntervalPK = Guid.NewGuid();
			this._bDBuildingPK = Guid.Empty;
			this._begin = string.Empty;
			this._end = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACIntervalData(ACIntervalData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACIntervalPK
		{
			get
			{
				return this._aCIntervalPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACIntervalPK", value);
				if (this._aCIntervalPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCIntervalPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACIntervalPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDBuildingPK", value);
				if (this._bDBuildingPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDBuildingPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDBuildingPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 IVID
		{
			get
			{
				return this._iVID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("IVID", value);
				if (this._iVID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._iVID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnIVIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Begin
		{
			get
			{
				return this._begin == null ? null : this._begin.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Begin", value);
				if (this._begin != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._begin = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBeginChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String End
		{
			get
			{
				return this._end == null ? null : this._end.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("End", value);
				if (this._end != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._end = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEndChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Sun
		{
			get
			{
				return this._sun;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Sun", value);
				if (this._sun != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._sun = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSunChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Mon
		{
			get
			{
				return this._mon;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Mon", value);
				if (this._mon != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._mon = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnMonChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Tue
		{
			get
			{
				return this._tue;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Tue", value);
				if (this._tue != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._tue = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnTueChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Wed
		{
			get
			{
				return this._wed;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Wed", value);
				if (this._wed != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._wed = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnWedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Thu
		{
			get
			{
				return this._thu;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Thu", value);
				if (this._thu != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._thu = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnThuChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Fri
		{
			get
			{
				return this._fri;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Fri", value);
				if (this._fri != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._fri = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFriChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Sat
		{
			get
			{
				return this._sat;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Sat", value);
				if (this._sat != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._sat = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSatChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Hol
		{
			get
			{
				return this._hol;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Hol", value);
				if (this._hol != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._hol = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnHolChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACInterval";
			}
		}
		#endregion

		#region Children
		public virtual ACIntvalHolidayMapDataCollection ACIntvalHolidayMapList
		{
			get
			{
				return this._aCIntvalHolidayMapList;
			}
			set
			{
				this._aCIntvalHolidayMapList = value;
			}
		}

		public virtual ACTimecodeIntervalMapDataCollection ACTimecodeIntervalMapList
		{
			get
			{
				return this._aCTimecodeIntervalMapList;
			}
			set
			{
				this._aCTimecodeIntervalMapList = value;
			}
		}

		#endregion

		#region Parents
		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACIntervalData data = entity as ACIntervalData;
			if (data == null)
				return;

			this.BDBuildingPK = data.BDBuildingPK;
			this.IVID = data.IVID;
			this.Begin = data.Begin;
			this.End = data.End;
			this.Sun = data.Sun;
			this.Mon = data.Mon;
			this.Tue = data.Tue;
			this.Wed = data.Wed;
			this.Thu = data.Thu;
			this.Fri = data.Fri;
			this.Sat = data.Sat;
			this.Hol = data.Hol;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACIntervalPK = data.ACIntervalPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			ACIntervalData data = entity as ACIntervalData;
			if (data == null)
				return;

			if (data.ACIntvalHolidayMapList != null)
			{
				this.ACIntvalHolidayMapList = new ACIntvalHolidayMapDataCollection(data.ACIntvalHolidayMapList);
			}
			if (data.ACTimecodeIntervalMapList != null)
			{
				this.ACTimecodeIntervalMapList = new ACTimecodeIntervalMapDataCollection(data.ACTimecodeIntervalMapList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.ACIntvalHolidayMapList != null)
			{
				this.ACIntvalHolidayMapList.AcceptChanges();
			}
			if (this.ACTimecodeIntervalMapList != null)
			{
				this.ACTimecodeIntervalMapList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACIntervalData));
		}

		private bool InternalEquals(ACIntervalData obj)
		{
			if (this.ACIntervalPK.CompareTo(obj.ACIntervalPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACIntervalPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACInterval:");
			builder.AppendFormat("{0}|", this.ACIntervalPK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.ACIntvalHolidayMapList != null && this.ACIntvalHolidayMapList.IsDirty)
				{
					return true;
				}
				if (this.ACTimecodeIntervalMapList != null && this.ACTimecodeIntervalMapList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.ACIntvalHolidayMapList != null && !this.ACIntvalHolidayMapList.IsValid)
				{
					return false;
				}
				if (this.ACTimecodeIntervalMapList != null && !this.ACTimecodeIntervalMapList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACIntervalPKChanged;
		private void OnACIntervalPKChanged(EventArgs e)
		{
			if ((this.ACIntervalPKChanged != null))
			{
				this.ACIntervalPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDBuildingPKChanged;
		private void OnBDBuildingPKChanged(EventArgs e)
		{
			if ((this.BDBuildingPKChanged != null))
			{
				this.BDBuildingPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler IVIDChanged;
		private void OnIVIDChanged(EventArgs e)
		{
			if ((this.IVIDChanged != null))
			{
				this.IVIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BeginChanged;
		private void OnBeginChanged(EventArgs e)
		{
			if ((this.BeginChanged != null))
			{
				this.BeginChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EndChanged;
		private void OnEndChanged(EventArgs e)
		{
			if ((this.EndChanged != null))
			{
				this.EndChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SunChanged;
		private void OnSunChanged(EventArgs e)
		{
			if ((this.SunChanged != null))
			{
				this.SunChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler MonChanged;
		private void OnMonChanged(EventArgs e)
		{
			if ((this.MonChanged != null))
			{
				this.MonChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler TueChanged;
		private void OnTueChanged(EventArgs e)
		{
			if ((this.TueChanged != null))
			{
				this.TueChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler WedChanged;
		private void OnWedChanged(EventArgs e)
		{
			if ((this.WedChanged != null))
			{
				this.WedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ThuChanged;
		private void OnThuChanged(EventArgs e)
		{
			if ((this.ThuChanged != null))
			{
				this.ThuChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FriChanged;
		private void OnFriChanged(EventArgs e)
		{
			if ((this.FriChanged != null))
			{
				this.FriChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SatChanged;
		private void OnSatChanged(EventArgs e)
		{
			if ((this.SatChanged != null))
			{
				this.SatChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler HolChanged;
		private void OnHolChanged(EventArgs e)
		{
			if ((this.HolChanged != null))
			{
				this.HolChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACPanelHolidayMapData : BusinessBase
	{
		#region Fields
		private Guid _aCPanelHolidayMapPK;
		private Guid _aCPanelPK;
		private Guid _utilHolidayPK;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private DateTime _date;
		private String _holiday;
		private Guid _bDBuildingPK;
		private Int32 _unitID;
		private String _address1;
		private Int32 _buildingID;

		#endregion

		#region Constructors
		public ACPanelHolidayMapData()
		{
			this._aCPanelHolidayMapPK = Guid.NewGuid();
			this._aCPanelPK = Guid.Empty;
			this._utilHolidayPK = Guid.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._date = DateTime.Now;
			this._holiday = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACPanelHolidayMapData(ACPanelHolidayMapData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACPanelHolidayMapPK
		{
			get
			{
				return this._aCPanelHolidayMapPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACPanelHolidayMapPK", value);
				if (this._aCPanelHolidayMapPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCPanelHolidayMapPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACPanelHolidayMapPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACPanelPK
		{
			get
			{
				return this._aCPanelPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACPanelPK", value);
				if (this._aCPanelPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCPanelPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACPanelPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid UtilHolidayPK
		{
			get
			{
				return this._utilHolidayPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UtilHolidayPK", value);
				if (this._utilHolidayPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._utilHolidayPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUtilHolidayPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual DateTime Date
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._date.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._date = value.ToUniversalTime();
			}
		}

		public virtual String Holiday
		{
			get
			{
				return this._holiday == null ? null : this._holiday.Trim();
			}
			set
			{
				 this._holiday = value == null ? null : value.Trim();
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual Int32 UnitID
		{
			get
			{
				return this._unitID;
			}
			set
			{
				this._unitID = value;
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACPanelHolidayMap";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual ACPanelData ACPanel
		{
			get
			{
				ACPanelData parent = new ACPanelData();
				parent.ACPanelPK = this.ACPanelPK;
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.BDBuildingPK = value.BDBuildingPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual UtilHolidayData UtilHoliday
		{
			get
			{
				UtilHolidayData parent = new UtilHolidayData();
				parent.UtilHolidayPK = this.UtilHolidayPK;
				parent.Date = this.Date;
				parent.Holiday = this.Holiday;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UtilHolidayPK = value.UtilHolidayPK;
				this.Date = value.Date;
				this.Holiday = value.Holiday;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACPanelHolidayMapData data = entity as ACPanelHolidayMapData;
			if (data == null)
				return;

			this.ACPanelPK = data.ACPanelPK;
			this.UtilHolidayPK = data.UtilHolidayPK;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Date = data.Date;
			this.Holiday = data.Holiday;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UnitID = data.UnitID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACPanelHolidayMapPK = data.ACPanelHolidayMapPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACPanelHolidayMapData));
		}

		private bool InternalEquals(ACPanelHolidayMapData obj)
		{
			if (this.ACPanelHolidayMapPK.CompareTo(obj.ACPanelHolidayMapPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACPanelHolidayMapPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACPanelHolidayMap:");
			builder.AppendFormat("{0}|", this.ACPanelHolidayMapPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACPanelHolidayMapPKChanged;
		private void OnACPanelHolidayMapPKChanged(EventArgs e)
		{
			if ((this.ACPanelHolidayMapPKChanged != null))
			{
				this.ACPanelHolidayMapPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACPanelPKChanged;
		private void OnACPanelPKChanged(EventArgs e)
		{
			if ((this.ACPanelPKChanged != null))
			{
				this.ACPanelPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UtilHolidayPKChanged;
		private void OnUtilHolidayPKChanged(EventArgs e)
		{
			if ((this.UtilHolidayPKChanged != null))
			{
				this.UtilHolidayPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACTimecodeData : BusinessBase
	{
		#region Fields
		private Guid _aCTimecodePK;
		private Guid _bDBuildingPK;
		private Int16 _tCID;
		private String _summary;
		private String _notes;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _address1;
		private Int32 _buildingID;

		private ACAccessLevelDetailDataCollection _aCAccessLevelDetailList;
		private ACTimecodeIntervalMapDataCollection _aCTimecodeIntervalMapList;
		#endregion

		#region Constructors
		public ACTimecodeData()
		{
			this._aCTimecodePK = Guid.NewGuid();
			this._bDBuildingPK = Guid.Empty;
			this._summary = string.Empty;
			this._notes = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACTimecodeData(ACTimecodeData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACTimecodePK
		{
			get
			{
				return this._aCTimecodePK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACTimecodePK", value);
				if (this._aCTimecodePK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCTimecodePK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACTimecodePKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDBuildingPK", value);
				if (this._bDBuildingPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDBuildingPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDBuildingPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 TCID
		{
			get
			{
				return this._tCID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("TCID", value);
				if (this._tCID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._tCID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnTCIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Summary
		{
			get
			{
				return this._summary == null ? null : this._summary.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Summary", value);
				if (this._summary != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._summary = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSummaryChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Notes
		{
			get
			{
				return this._notes == null ? null : this._notes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Notes", value);
				if (this._notes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._notes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACTimecode";
			}
		}
		#endregion

		#region Children
		public virtual ACAccessLevelDetailDataCollection ACAccessLevelDetailList
		{
			get
			{
				return this._aCAccessLevelDetailList;
			}
			set
			{
				this._aCAccessLevelDetailList = value;
			}
		}

		public virtual ACTimecodeIntervalMapDataCollection ACTimecodeIntervalMapList
		{
			get
			{
				return this._aCTimecodeIntervalMapList;
			}
			set
			{
				this._aCTimecodeIntervalMapList = value;
			}
		}

		#endregion

		#region Parents
		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACTimecodeData data = entity as ACTimecodeData;
			if (data == null)
				return;

			this.BDBuildingPK = data.BDBuildingPK;
			this.TCID = data.TCID;
			this.Summary = data.Summary;
			this.Notes = data.Notes;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACTimecodePK = data.ACTimecodePK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			ACTimecodeData data = entity as ACTimecodeData;
			if (data == null)
				return;

			if (data.ACAccessLevelDetailList != null)
			{
				this.ACAccessLevelDetailList = new ACAccessLevelDetailDataCollection(data.ACAccessLevelDetailList);
			}
			if (data.ACTimecodeIntervalMapList != null)
			{
				this.ACTimecodeIntervalMapList = new ACTimecodeIntervalMapDataCollection(data.ACTimecodeIntervalMapList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.ACAccessLevelDetailList != null)
			{
				this.ACAccessLevelDetailList.AcceptChanges();
			}
			if (this.ACTimecodeIntervalMapList != null)
			{
				this.ACTimecodeIntervalMapList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACTimecodeData));
		}

		private bool InternalEquals(ACTimecodeData obj)
		{
			if (this.ACTimecodePK.CompareTo(obj.ACTimecodePK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACTimecodePK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACTimecode:");
			builder.AppendFormat("{0}|", this.ACTimecodePK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.ACAccessLevelDetailList != null && this.ACAccessLevelDetailList.IsDirty)
				{
					return true;
				}
				if (this.ACTimecodeIntervalMapList != null && this.ACTimecodeIntervalMapList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.ACAccessLevelDetailList != null && !this.ACAccessLevelDetailList.IsValid)
				{
					return false;
				}
				if (this.ACTimecodeIntervalMapList != null && !this.ACTimecodeIntervalMapList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACTimecodePKChanged;
		private void OnACTimecodePKChanged(EventArgs e)
		{
			if ((this.ACTimecodePKChanged != null))
			{
				this.ACTimecodePKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDBuildingPKChanged;
		private void OnBDBuildingPKChanged(EventArgs e)
		{
			if ((this.BDBuildingPKChanged != null))
			{
				this.BDBuildingPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler TCIDChanged;
		private void OnTCIDChanged(EventArgs e)
		{
			if ((this.TCIDChanged != null))
			{
				this.TCIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SummaryChanged;
		private void OnSummaryChanged(EventArgs e)
		{
			if ((this.SummaryChanged != null))
			{
				this.SummaryChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NotesChanged;
		private void OnNotesChanged(EventArgs e)
		{
			if ((this.NotesChanged != null))
			{
				this.NotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACTimecodeIntervalMapData : BusinessBase
	{
		#region Fields
		private Guid _aCTimecodeIntervalMapPK;
		private Guid _aCTimecodePK;
		private Guid _aCIntervalPK;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _end;
		private String _begin;
		private Int16 _iVID;
		private Int16 _tCID;
		private Guid _bDBuildingPK;
		private String _address1;
		private Int32 _buildingID;

		#endregion

		#region Constructors
		public ACTimecodeIntervalMapData()
		{
			this._aCTimecodeIntervalMapPK = Guid.NewGuid();
			this._aCTimecodePK = Guid.Empty;
			this._aCIntervalPK = Guid.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._end = string.Empty;
			this._begin = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACTimecodeIntervalMapData(ACTimecodeIntervalMapData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACTimecodeIntervalMapPK
		{
			get
			{
				return this._aCTimecodeIntervalMapPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACTimecodeIntervalMapPK", value);
				if (this._aCTimecodeIntervalMapPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCTimecodeIntervalMapPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACTimecodeIntervalMapPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACTimecodePK
		{
			get
			{
				return this._aCTimecodePK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACTimecodePK", value);
				if (this._aCTimecodePK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCTimecodePK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACTimecodePKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACIntervalPK
		{
			get
			{
				return this._aCIntervalPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACIntervalPK", value);
				if (this._aCIntervalPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCIntervalPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACIntervalPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String End
		{
			get
			{
				return this._end == null ? null : this._end.Trim();
			}
			set
			{
				 this._end = value == null ? null : value.Trim();
			}
		}

		public virtual String Begin
		{
			get
			{
				return this._begin == null ? null : this._begin.Trim();
			}
			set
			{
				 this._begin = value == null ? null : value.Trim();
			}
		}

		public virtual Int16 IVID
		{
			get
			{
				return this._iVID;
			}
			set
			{
				this._iVID = value;
			}
		}

		public virtual Int16 TCID
		{
			get
			{
				return this._tCID;
			}
			set
			{
				this._tCID = value;
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACTimecodeIntervalMap";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual ACIntervalData ACInterval
		{
			get
			{
				ACIntervalData parent = new ACIntervalData();
				parent.ACIntervalPK = this.ACIntervalPK;
				parent.End = this.End;
				parent.Begin = this.Begin;
				parent.IVID = this.IVID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACIntervalPK = value.ACIntervalPK;
				this.End = value.End;
				this.Begin = value.Begin;
				this.IVID = value.IVID;
			}
		}

		public virtual ACTimecodeData ACTimecode
		{
			get
			{
				ACTimecodeData parent = new ACTimecodeData();
				parent.ACTimecodePK = this.ACTimecodePK;
				parent.TCID = this.TCID;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACTimecodePK = value.ACTimecodePK;
				this.TCID = value.TCID;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACTimecodeIntervalMapData data = entity as ACTimecodeIntervalMapData;
			if (data == null)
				return;

			this.ACTimecodePK = data.ACTimecodePK;
			this.ACIntervalPK = data.ACIntervalPK;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.End = data.End;
			this.Begin = data.Begin;
			this.IVID = data.IVID;
			this.TCID = data.TCID;
			this.BDBuildingPK = data.BDBuildingPK;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACTimecodeIntervalMapPK = data.ACTimecodeIntervalMapPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACTimecodeIntervalMapData));
		}

		private bool InternalEquals(ACTimecodeIntervalMapData obj)
		{
			if (this.ACTimecodeIntervalMapPK.CompareTo(obj.ACTimecodeIntervalMapPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACTimecodeIntervalMapPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACTimecodeIntervalMap:");
			builder.AppendFormat("{0}|", this.ACTimecodeIntervalMapPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACTimecodeIntervalMapPKChanged;
		private void OnACTimecodeIntervalMapPKChanged(EventArgs e)
		{
			if ((this.ACTimecodeIntervalMapPKChanged != null))
			{
				this.ACTimecodeIntervalMapPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACTimecodePKChanged;
		private void OnACTimecodePKChanged(EventArgs e)
		{
			if ((this.ACTimecodePKChanged != null))
			{
				this.ACTimecodePKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACIntervalPKChanged;
		private void OnACIntervalPKChanged(EventArgs e)
		{
			if ((this.ACIntervalPKChanged != null))
			{
				this.ACIntervalPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACAMFormatData : BusinessBase
	{
		#region Fields
		private Guid _aCAMFormatPK;
		private Guid _bDBuildingPK;
		private Int16 _aMFID;
		private String _summary;
		private String _notes;
		private Int16 _reportTC;
		private Int16 _alarmTC;
		private Int16 _preAlarmTC;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _address1;
		private Int32 _buildingID;

		#endregion

		#region Constructors
		public ACAMFormatData()
		{
			this._aCAMFormatPK = Guid.NewGuid();
			this._bDBuildingPK = Guid.Empty;
			this._summary = string.Empty;
			this._notes = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACAMFormatData(ACAMFormatData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACAMFormatPK
		{
			get
			{
				return this._aCAMFormatPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACAMFormatPK", value);
				if (this._aCAMFormatPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCAMFormatPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACAMFormatPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDBuildingPK", value);
				if (this._bDBuildingPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDBuildingPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDBuildingPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 AMFID
		{
			get
			{
				return this._aMFID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AMFID", value);
				if (this._aMFID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aMFID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAMFIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Summary
		{
			get
			{
				return this._summary == null ? null : this._summary.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Summary", value);
				if (this._summary != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._summary = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSummaryChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Notes
		{
			get
			{
				return this._notes == null ? null : this._notes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Notes", value);
				if (this._notes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._notes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 ReportTC
		{
			get
			{
				return this._reportTC;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ReportTC", value);
				if (this._reportTC != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._reportTC = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnReportTCChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 AlarmTC
		{
			get
			{
				return this._alarmTC;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AlarmTC", value);
				if (this._alarmTC != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._alarmTC = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAlarmTCChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 PreAlarmTC
		{
			get
			{
				return this._preAlarmTC;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("PreAlarmTC", value);
				if (this._preAlarmTC != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._preAlarmTC = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPreAlarmTCChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACAMFormat";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACAMFormatData data = entity as ACAMFormatData;
			if (data == null)
				return;

			this.BDBuildingPK = data.BDBuildingPK;
			this.AMFID = data.AMFID;
			this.Summary = data.Summary;
			this.Notes = data.Notes;
			this.ReportTC = data.ReportTC;
			this.AlarmTC = data.AlarmTC;
			this.PreAlarmTC = data.PreAlarmTC;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACAMFormatPK = data.ACAMFormatPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACAMFormatData));
		}

		private bool InternalEquals(ACAMFormatData obj)
		{
			if (this.ACAMFormatPK.CompareTo(obj.ACAMFormatPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACAMFormatPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACAMFormat:");
			builder.AppendFormat("{0}|", this.ACAMFormatPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACAMFormatPKChanged;
		private void OnACAMFormatPKChanged(EventArgs e)
		{
			if ((this.ACAMFormatPKChanged != null))
			{
				this.ACAMFormatPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDBuildingPKChanged;
		private void OnBDBuildingPKChanged(EventArgs e)
		{
			if ((this.BDBuildingPKChanged != null))
			{
				this.BDBuildingPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AMFIDChanged;
		private void OnAMFIDChanged(EventArgs e)
		{
			if ((this.AMFIDChanged != null))
			{
				this.AMFIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SummaryChanged;
		private void OnSummaryChanged(EventArgs e)
		{
			if ((this.SummaryChanged != null))
			{
				this.SummaryChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NotesChanged;
		private void OnNotesChanged(EventArgs e)
		{
			if ((this.NotesChanged != null))
			{
				this.NotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ReportTCChanged;
		private void OnReportTCChanged(EventArgs e)
		{
			if ((this.ReportTCChanged != null))
			{
				this.ReportTCChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AlarmTCChanged;
		private void OnAlarmTCChanged(EventArgs e)
		{
			if ((this.AlarmTCChanged != null))
			{
				this.AlarmTCChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PreAlarmTCChanged;
		private void OnPreAlarmTCChanged(EventArgs e)
		{
			if ((this.PreAlarmTCChanged != null))
			{
				this.PreAlarmTCChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class BDBuildingHolidayMapData : BusinessBase
	{
		#region Fields
		private Guid _bDBuildingHolidayMapPK;
		private Guid _bDBuildingPK;
		private Guid _utilHolidayPK;
		private Int32 _actionID;
		private String _notes;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _address1;
		private Int32 _buildingID;
		private DateTime _date;
		private String _holiday;

		#endregion

		#region Constructors
		public BDBuildingHolidayMapData()
		{
			this._bDBuildingHolidayMapPK = Guid.NewGuid();
			this._bDBuildingPK = Guid.Empty;
			this._utilHolidayPK = Guid.Empty;
			this._notes = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._address1 = string.Empty;
			this._date = DateTime.Now;
			this._holiday = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public BDBuildingHolidayMapData(BDBuildingHolidayMapData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid BDBuildingHolidayMapPK
		{
			get
			{
				return this._bDBuildingHolidayMapPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDBuildingHolidayMapPK", value);
				if (this._bDBuildingHolidayMapPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDBuildingHolidayMapPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDBuildingHolidayMapPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDBuildingPK", value);
				if (this._bDBuildingPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDBuildingPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDBuildingPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid UtilHolidayPK
		{
			get
			{
				return this._utilHolidayPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UtilHolidayPK", value);
				if (this._utilHolidayPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._utilHolidayPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUtilHolidayPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 ActionID
		{
			get
			{
				return this._actionID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ActionID", value);
				if (this._actionID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._actionID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnActionIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Notes
		{
			get
			{
				return this._notes == null ? null : this._notes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Notes", value);
				if (this._notes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._notes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		public virtual DateTime Date
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._date.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._date = value.ToUniversalTime();
			}
		}

		public virtual String Holiday
		{
			get
			{
				return this._holiday == null ? null : this._holiday.Trim();
			}
			set
			{
				 this._holiday = value == null ? null : value.Trim();
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "BDBuildingHolidayMap";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual UtilHolidayData UtilHoliday
		{
			get
			{
				UtilHolidayData parent = new UtilHolidayData();
				parent.UtilHolidayPK = this.UtilHolidayPK;
				parent.Date = this.Date;
				parent.Holiday = this.Holiday;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UtilHolidayPK = value.UtilHolidayPK;
				this.Date = value.Date;
				this.Holiday = value.Holiday;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			BDBuildingHolidayMapData data = entity as BDBuildingHolidayMapData;
			if (data == null)
				return;

			this.BDBuildingPK = data.BDBuildingPK;
			this.UtilHolidayPK = data.UtilHolidayPK;
			this.ActionID = data.ActionID;
			this.Notes = data.Notes;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			this.Date = data.Date;
			this.Holiday = data.Holiday;
			if (all)
			{
				this.BDBuildingHolidayMapPK = data.BDBuildingHolidayMapPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as BDBuildingHolidayMapData));
		}

		private bool InternalEquals(BDBuildingHolidayMapData obj)
		{
			if (this.BDBuildingHolidayMapPK.CompareTo(obj.BDBuildingHolidayMapPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.BDBuildingHolidayMapPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("BDBuildingHolidayMap:");
			builder.AppendFormat("{0}|", this.BDBuildingHolidayMapPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler BDBuildingHolidayMapPKChanged;
		private void OnBDBuildingHolidayMapPKChanged(EventArgs e)
		{
			if ((this.BDBuildingHolidayMapPKChanged != null))
			{
				this.BDBuildingHolidayMapPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDBuildingPKChanged;
		private void OnBDBuildingPKChanged(EventArgs e)
		{
			if ((this.BDBuildingPKChanged != null))
			{
				this.BDBuildingPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UtilHolidayPKChanged;
		private void OnUtilHolidayPKChanged(EventArgs e)
		{
			if ((this.UtilHolidayPKChanged != null))
			{
				this.UtilHolidayPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ActionIDChanged;
		private void OnActionIDChanged(EventArgs e)
		{
			if ((this.ActionIDChanged != null))
			{
				this.ActionIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NotesChanged;
		private void OnNotesChanged(EventArgs e)
		{
			if ((this.NotesChanged != null))
			{
				this.NotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACOutputGroupData : BusinessBase
	{
		#region Fields
		private Guid _aCOutputGroupPK;
		private Guid _aCPanelPK;
		private Byte _groupID;
		private String _summary;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private Guid _bDBuildingPK;
		private Int32 _unitID;
		private String _address1;
		private Int32 _buildingID;

		private ACOutputGroupMainZoneMapDataCollection _aCOutputGroupMainZoneMapList;
		#endregion

		#region Constructors
		public ACOutputGroupData()
		{
			this._aCOutputGroupPK = Guid.NewGuid();
			this._aCPanelPK = Guid.Empty;
			this._summary = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACOutputGroupData(ACOutputGroupData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACOutputGroupPK
		{
			get
			{
				return this._aCOutputGroupPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACOutputGroupPK", value);
				if (this._aCOutputGroupPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCOutputGroupPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACOutputGroupPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACPanelPK
		{
			get
			{
				return this._aCPanelPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACPanelPK", value);
				if (this._aCPanelPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCPanelPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACPanelPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte GroupID
		{
			get
			{
				return this._groupID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("GroupID", value);
				if (this._groupID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._groupID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnGroupIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Summary
		{
			get
			{
				return this._summary == null ? null : this._summary.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Summary", value);
				if (this._summary != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._summary = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSummaryChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual Int32 UnitID
		{
			get
			{
				return this._unitID;
			}
			set
			{
				this._unitID = value;
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACOutputGroup";
			}
		}
		#endregion

		#region Children
		public virtual ACOutputGroupMainZoneMapDataCollection ACOutputGroupMainZoneMapList
		{
			get
			{
				return this._aCOutputGroupMainZoneMapList;
			}
			set
			{
				this._aCOutputGroupMainZoneMapList = value;
			}
		}

		#endregion

		#region Parents
		public virtual ACPanelData ACPanel
		{
			get
			{
				ACPanelData parent = new ACPanelData();
				parent.ACPanelPK = this.ACPanelPK;
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.BDBuildingPK = value.BDBuildingPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACOutputGroupData data = entity as ACOutputGroupData;
			if (data == null)
				return;

			this.ACPanelPK = data.ACPanelPK;
			this.GroupID = data.GroupID;
			this.Summary = data.Summary;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UnitID = data.UnitID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACOutputGroupPK = data.ACOutputGroupPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			ACOutputGroupData data = entity as ACOutputGroupData;
			if (data == null)
				return;

			if (data.ACOutputGroupMainZoneMapList != null)
			{
				this.ACOutputGroupMainZoneMapList = new ACOutputGroupMainZoneMapDataCollection(data.ACOutputGroupMainZoneMapList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.ACOutputGroupMainZoneMapList != null)
			{
				this.ACOutputGroupMainZoneMapList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACOutputGroupData));
		}

		private bool InternalEquals(ACOutputGroupData obj)
		{
			if (this.ACOutputGroupPK.CompareTo(obj.ACOutputGroupPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACOutputGroupPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACOutputGroup:");
			builder.AppendFormat("{0}|", this.ACOutputGroupPK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.ACOutputGroupMainZoneMapList != null && this.ACOutputGroupMainZoneMapList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.ACOutputGroupMainZoneMapList != null && !this.ACOutputGroupMainZoneMapList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACOutputGroupPKChanged;
		private void OnACOutputGroupPKChanged(EventArgs e)
		{
			if ((this.ACOutputGroupPKChanged != null))
			{
				this.ACOutputGroupPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACPanelPKChanged;
		private void OnACPanelPKChanged(EventArgs e)
		{
			if ((this.ACPanelPKChanged != null))
			{
				this.ACPanelPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler GroupIDChanged;
		private void OnGroupIDChanged(EventArgs e)
		{
			if ((this.GroupIDChanged != null))
			{
				this.GroupIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SummaryChanged;
		private void OnSummaryChanged(EventArgs e)
		{
			if ((this.SummaryChanged != null))
			{
				this.SummaryChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class BDTenantHolidayMapData : BusinessBase
	{
		#region Fields
		private Guid _bDTenantHolidayMapPK;
		private Guid _bDTenantPK;
		private Guid _utilHolidayPK;
		private Int32 _actionID;
		private String _notes;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _tenant;
		private Guid _bDBuildingPK;
		private DateTime _date;
		private String _holiday;
		private String _address1;
		private Int32 _buildingID;

		#endregion

		#region Constructors
		public BDTenantHolidayMapData()
		{
			this._bDTenantHolidayMapPK = Guid.NewGuid();
			this._bDTenantPK = Guid.Empty;
			this._utilHolidayPK = Guid.Empty;
			this._notes = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._tenant = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._date = DateTime.Now;
			this._holiday = string.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public BDTenantHolidayMapData(BDTenantHolidayMapData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid BDTenantHolidayMapPK
		{
			get
			{
				return this._bDTenantHolidayMapPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDTenantHolidayMapPK", value);
				if (this._bDTenantHolidayMapPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDTenantHolidayMapPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDTenantHolidayMapPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDTenantPK
		{
			get
			{
				return this._bDTenantPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDTenantPK", value);
				if (this._bDTenantPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDTenantPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDTenantPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid UtilHolidayPK
		{
			get
			{
				return this._utilHolidayPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UtilHolidayPK", value);
				if (this._utilHolidayPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._utilHolidayPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUtilHolidayPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 ActionID
		{
			get
			{
				return this._actionID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ActionID", value);
				if (this._actionID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._actionID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnActionIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Notes
		{
			get
			{
				return this._notes == null ? null : this._notes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Notes", value);
				if (this._notes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._notes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String Tenant
		{
			get
			{
				return this._tenant == null ? null : this._tenant.Trim();
			}
			set
			{
				 this._tenant = value == null ? null : value.Trim();
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual DateTime Date
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._date.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._date = value.ToUniversalTime();
			}
		}

		public virtual String Holiday
		{
			get
			{
				return this._holiday == null ? null : this._holiday.Trim();
			}
			set
			{
				 this._holiday = value == null ? null : value.Trim();
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "BDTenantHolidayMap";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual BDTenantData BDTenant
		{
			get
			{
				BDTenantData parent = new BDTenantData();
				parent.BDTenantPK = this.BDTenantPK;
				parent.Tenant = this.Tenant;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDTenantPK = value.BDTenantPK;
				this.Tenant = value.Tenant;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		public virtual UtilHolidayData UtilHoliday
		{
			get
			{
				UtilHolidayData parent = new UtilHolidayData();
				parent.UtilHolidayPK = this.UtilHolidayPK;
				parent.Date = this.Date;
				parent.Holiday = this.Holiday;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UtilHolidayPK = value.UtilHolidayPK;
				this.Date = value.Date;
				this.Holiday = value.Holiday;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			BDTenantHolidayMapData data = entity as BDTenantHolidayMapData;
			if (data == null)
				return;

			this.BDTenantPK = data.BDTenantPK;
			this.UtilHolidayPK = data.UtilHolidayPK;
			this.ActionID = data.ActionID;
			this.Notes = data.Notes;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Tenant = data.Tenant;
			this.BDBuildingPK = data.BDBuildingPK;
			this.Date = data.Date;
			this.Holiday = data.Holiday;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.BDTenantHolidayMapPK = data.BDTenantHolidayMapPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as BDTenantHolidayMapData));
		}

		private bool InternalEquals(BDTenantHolidayMapData obj)
		{
			if (this.BDTenantHolidayMapPK.CompareTo(obj.BDTenantHolidayMapPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.BDTenantHolidayMapPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("BDTenantHolidayMap:");
			builder.AppendFormat("{0}|", this.BDTenantHolidayMapPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler BDTenantHolidayMapPKChanged;
		private void OnBDTenantHolidayMapPKChanged(EventArgs e)
		{
			if ((this.BDTenantHolidayMapPKChanged != null))
			{
				this.BDTenantHolidayMapPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDTenantPKChanged;
		private void OnBDTenantPKChanged(EventArgs e)
		{
			if ((this.BDTenantPKChanged != null))
			{
				this.BDTenantPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UtilHolidayPKChanged;
		private void OnUtilHolidayPKChanged(EventArgs e)
		{
			if ((this.UtilHolidayPKChanged != null))
			{
				this.UtilHolidayPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ActionIDChanged;
		private void OnActionIDChanged(EventArgs e)
		{
			if ((this.ActionIDChanged != null))
			{
				this.ActionIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NotesChanged;
		private void OnNotesChanged(EventArgs e)
		{
			if ((this.NotesChanged != null))
			{
				this.NotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class LogRowsCountData : BusinessBase
	{
		#region Fields
		private Guid _logRowsCountPK;
		private Guid _sessionID;
		private DateTime _sessionDateTime;
		private String _dBTableName;
		private Int32 _sequenceID;
		private Int32 _rowsCount;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;

		#endregion

		#region Constructors
		public LogRowsCountData()
		{
			this._logRowsCountPK = Guid.NewGuid();
			this._sessionID = Guid.Empty;
			this._sessionDateTime = DateTime.Now;
			this._dBTableName = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public LogRowsCountData(LogRowsCountData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid LogRowsCountPK
		{
			get
			{
				return this._logRowsCountPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LogRowsCountPK", value);
				if (this._logRowsCountPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._logRowsCountPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLogRowsCountPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid SessionID
		{
			get
			{
				return this._sessionID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("SessionID", value);
				if (this._sessionID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._sessionID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSessionIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime SessionDateTime
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._sessionDateTime.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("SessionDateTime", value);
				if (this._sessionDateTime != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._sessionDateTime = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSessionDateTimeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String DBTableName
		{
			get
			{
				return this._dBTableName == null ? null : this._dBTableName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("DBTableName", value);
				if (this._dBTableName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._dBTableName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDBTableNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 SequenceID
		{
			get
			{
				return this._sequenceID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("SequenceID", value);
				if (this._sequenceID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._sequenceID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSequenceIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 RowsCount
		{
			get
			{
				return this._rowsCount;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("RowsCount", value);
				if (this._rowsCount != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._rowsCount = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnRowsCountChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "LogRowsCount";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			LogRowsCountData data = entity as LogRowsCountData;
			if (data == null)
				return;

			this.SessionID = data.SessionID;
			this.SessionDateTime = data.SessionDateTime;
			this.DBTableName = data.DBTableName;
			this.SequenceID = data.SequenceID;
			this.RowsCount = data.RowsCount;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			if (all)
			{
				this.LogRowsCountPK = data.LogRowsCountPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as LogRowsCountData));
		}

		private bool InternalEquals(LogRowsCountData obj)
		{
			if (this.LogRowsCountPK.CompareTo(obj.LogRowsCountPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.LogRowsCountPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("LogRowsCount:");
			builder.AppendFormat("{0}|", this.LogRowsCountPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler LogRowsCountPKChanged;
		private void OnLogRowsCountPKChanged(EventArgs e)
		{
			if ((this.LogRowsCountPKChanged != null))
			{
				this.LogRowsCountPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SessionIDChanged;
		private void OnSessionIDChanged(EventArgs e)
		{
			if ((this.SessionIDChanged != null))
			{
				this.SessionIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SessionDateTimeChanged;
		private void OnSessionDateTimeChanged(EventArgs e)
		{
			if ((this.SessionDateTimeChanged != null))
			{
				this.SessionDateTimeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DBTableNameChanged;
		private void OnDBTableNameChanged(EventArgs e)
		{
			if ((this.DBTableNameChanged != null))
			{
				this.DBTableNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SequenceIDChanged;
		private void OnSequenceIDChanged(EventArgs e)
		{
			if ((this.SequenceIDChanged != null))
			{
				this.SequenceIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowsCountChanged;
		private void OnRowsCountChanged(EventArgs e)
		{
			if ((this.RowsCountChanged != null))
			{
				this.RowsCountChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACInputGroupData : BusinessBase
	{
		#region Fields
		private Guid _aCInputGroupPK;
		private Guid _aCPanelPK;
		private Byte _groupID;
		private String _summary;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private Guid _bDBuildingPK;
		private Int32 _unitID;
		private String _address1;
		private Int32 _buildingID;

		private ACInputGroupInputMapDataCollection _aCInputGroupInputMapList;
		#endregion

		#region Constructors
		public ACInputGroupData()
		{
			this._aCInputGroupPK = Guid.NewGuid();
			this._aCPanelPK = Guid.Empty;
			this._summary = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACInputGroupData(ACInputGroupData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACInputGroupPK
		{
			get
			{
				return this._aCInputGroupPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACInputGroupPK", value);
				if (this._aCInputGroupPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCInputGroupPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACInputGroupPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACPanelPK
		{
			get
			{
				return this._aCPanelPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACPanelPK", value);
				if (this._aCPanelPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCPanelPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACPanelPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte GroupID
		{
			get
			{
				return this._groupID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("GroupID", value);
				if (this._groupID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._groupID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnGroupIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Summary
		{
			get
			{
				return this._summary == null ? null : this._summary.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Summary", value);
				if (this._summary != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._summary = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSummaryChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual Int32 UnitID
		{
			get
			{
				return this._unitID;
			}
			set
			{
				this._unitID = value;
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACInputGroup";
			}
		}
		#endregion

		#region Children
		public virtual ACInputGroupInputMapDataCollection ACInputGroupInputMapList
		{
			get
			{
				return this._aCInputGroupInputMapList;
			}
			set
			{
				this._aCInputGroupInputMapList = value;
			}
		}

		#endregion

		#region Parents
		public virtual ACPanelData ACPanel
		{
			get
			{
				ACPanelData parent = new ACPanelData();
				parent.ACPanelPK = this.ACPanelPK;
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.BDBuildingPK = value.BDBuildingPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACInputGroupData data = entity as ACInputGroupData;
			if (data == null)
				return;

			this.ACPanelPK = data.ACPanelPK;
			this.GroupID = data.GroupID;
			this.Summary = data.Summary;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UnitID = data.UnitID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACInputGroupPK = data.ACInputGroupPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			ACInputGroupData data = entity as ACInputGroupData;
			if (data == null)
				return;

			if (data.ACInputGroupInputMapList != null)
			{
				this.ACInputGroupInputMapList = new ACInputGroupInputMapDataCollection(data.ACInputGroupInputMapList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.ACInputGroupInputMapList != null)
			{
				this.ACInputGroupInputMapList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACInputGroupData));
		}

		private bool InternalEquals(ACInputGroupData obj)
		{
			if (this.ACInputGroupPK.CompareTo(obj.ACInputGroupPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACInputGroupPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACInputGroup:");
			builder.AppendFormat("{0}|", this.ACInputGroupPK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.ACInputGroupInputMapList != null && this.ACInputGroupInputMapList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.ACInputGroupInputMapList != null && !this.ACInputGroupInputMapList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACInputGroupPKChanged;
		private void OnACInputGroupPKChanged(EventArgs e)
		{
			if ((this.ACInputGroupPKChanged != null))
			{
				this.ACInputGroupPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACPanelPKChanged;
		private void OnACPanelPKChanged(EventArgs e)
		{
			if ((this.ACPanelPKChanged != null))
			{
				this.ACPanelPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler GroupIDChanged;
		private void OnGroupIDChanged(EventArgs e)
		{
			if ((this.GroupIDChanged != null))
			{
				this.GroupIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SummaryChanged;
		private void OnSummaryChanged(EventArgs e)
		{
			if ((this.SummaryChanged != null))
			{
				this.SummaryChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACInputData : BusinessBase
	{
		#region Fields
		private Guid _aCInputPK;
		private Guid _aCPanelPK;
		private Byte _inputID;
		private String _description;
		private Int16 _debounce;
		private Boolean _reverse;
		private Int16 _forceAMFormat;
		private Boolean _offOnRestore;
		private Boolean _external;
		private String _notes;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private Boolean _alwaysToMAS;
		private Byte _panelZoneID;
		private Boolean _locked;
		private Guid _bDBuildingPK;
		private Int32 _unitID;
		private String _address1;
		private Int32 _buildingID;

		private ACInputGroupInputMapDataCollection _aCInputGroupInputMapList;
		#endregion

		#region Constructors
		public ACInputData()
		{
			this._aCInputPK = Guid.NewGuid();
			this._aCPanelPK = Guid.Empty;
			this._description = string.Empty;
			this._notes = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACInputData(ACInputData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACInputPK
		{
			get
			{
				return this._aCInputPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACInputPK", value);
				if (this._aCInputPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCInputPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACInputPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACPanelPK
		{
			get
			{
				return this._aCPanelPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACPanelPK", value);
				if (this._aCPanelPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCPanelPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACPanelPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte InputID
		{
			get
			{
				return this._inputID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("InputID", value);
				if (this._inputID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._inputID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnInputIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Description
		{
			get
			{
				return this._description == null ? null : this._description.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Description", value);
				if (this._description != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._description = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDescriptionChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 Debounce
		{
			get
			{
				return this._debounce;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Debounce", value);
				if (this._debounce != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._debounce = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDebounceChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Reverse
		{
			get
			{
				return this._reverse;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Reverse", value);
				if (this._reverse != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._reverse = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnReverseChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 ForceAMFormat
		{
			get
			{
				return this._forceAMFormat;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ForceAMFormat", value);
				if (this._forceAMFormat != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._forceAMFormat = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnForceAMFormatChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean OffOnRestore
		{
			get
			{
				return this._offOnRestore;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("OffOnRestore", value);
				if (this._offOnRestore != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._offOnRestore = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnOffOnRestoreChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean External
		{
			get
			{
				return this._external;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("External", value);
				if (this._external != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._external = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnExternalChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Notes
		{
			get
			{
				return this._notes == null ? null : this._notes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Notes", value);
				if (this._notes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._notes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual Boolean AlwaysToMAS
		{
			get
			{
				return this._alwaysToMAS;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AlwaysToMAS", value);
				if (this._alwaysToMAS != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._alwaysToMAS = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAlwaysToMASChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte PanelZoneID
		{
			get
			{
				return this._panelZoneID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("PanelZoneID", value);
				if (this._panelZoneID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._panelZoneID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPanelZoneIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Locked
		{
			get
			{
				return this._locked;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Locked", value);
				if (this._locked != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._locked = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLockedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual Int32 UnitID
		{
			get
			{
				return this._unitID;
			}
			set
			{
				this._unitID = value;
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACInput";
			}
		}
		#endregion

		#region Children
		public virtual ACInputGroupInputMapDataCollection ACInputGroupInputMapList
		{
			get
			{
				return this._aCInputGroupInputMapList;
			}
			set
			{
				this._aCInputGroupInputMapList = value;
			}
		}

		#endregion

		#region Parents
		public virtual ACPanelData ACPanel
		{
			get
			{
				ACPanelData parent = new ACPanelData();
				parent.ACPanelPK = this.ACPanelPK;
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.BDBuildingPK = value.BDBuildingPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACInputData data = entity as ACInputData;
			if (data == null)
				return;

			this.ACPanelPK = data.ACPanelPK;
			this.InputID = data.InputID;
			this.Description = data.Description;
			this.Debounce = data.Debounce;
			this.Reverse = data.Reverse;
			this.ForceAMFormat = data.ForceAMFormat;
			this.OffOnRestore = data.OffOnRestore;
			this.External = data.External;
			this.Notes = data.Notes;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.AlwaysToMAS = data.AlwaysToMAS;
			this.PanelZoneID = data.PanelZoneID;
			this.Locked = data.Locked;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UnitID = data.UnitID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACInputPK = data.ACInputPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			ACInputData data = entity as ACInputData;
			if (data == null)
				return;

			if (data.ACInputGroupInputMapList != null)
			{
				this.ACInputGroupInputMapList = new ACInputGroupInputMapDataCollection(data.ACInputGroupInputMapList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.ACInputGroupInputMapList != null)
			{
				this.ACInputGroupInputMapList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACInputData));
		}

		private bool InternalEquals(ACInputData obj)
		{
			if (this.ACInputPK.CompareTo(obj.ACInputPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACInputPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACInput:");
			builder.AppendFormat("{0}|", this.ACInputPK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.ACInputGroupInputMapList != null && this.ACInputGroupInputMapList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.ACInputGroupInputMapList != null && !this.ACInputGroupInputMapList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACInputPKChanged;
		private void OnACInputPKChanged(EventArgs e)
		{
			if ((this.ACInputPKChanged != null))
			{
				this.ACInputPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACPanelPKChanged;
		private void OnACPanelPKChanged(EventArgs e)
		{
			if ((this.ACPanelPKChanged != null))
			{
				this.ACPanelPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler InputIDChanged;
		private void OnInputIDChanged(EventArgs e)
		{
			if ((this.InputIDChanged != null))
			{
				this.InputIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DescriptionChanged;
		private void OnDescriptionChanged(EventArgs e)
		{
			if ((this.DescriptionChanged != null))
			{
				this.DescriptionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DebounceChanged;
		private void OnDebounceChanged(EventArgs e)
		{
			if ((this.DebounceChanged != null))
			{
				this.DebounceChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ReverseChanged;
		private void OnReverseChanged(EventArgs e)
		{
			if ((this.ReverseChanged != null))
			{
				this.ReverseChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ForceAMFormatChanged;
		private void OnForceAMFormatChanged(EventArgs e)
		{
			if ((this.ForceAMFormatChanged != null))
			{
				this.ForceAMFormatChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler OffOnRestoreChanged;
		private void OnOffOnRestoreChanged(EventArgs e)
		{
			if ((this.OffOnRestoreChanged != null))
			{
				this.OffOnRestoreChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ExternalChanged;
		private void OnExternalChanged(EventArgs e)
		{
			if ((this.ExternalChanged != null))
			{
				this.ExternalChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NotesChanged;
		private void OnNotesChanged(EventArgs e)
		{
			if ((this.NotesChanged != null))
			{
				this.NotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AlwaysToMASChanged;
		private void OnAlwaysToMASChanged(EventArgs e)
		{
			if ((this.AlwaysToMASChanged != null))
			{
				this.AlwaysToMASChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PanelZoneIDChanged;
		private void OnPanelZoneIDChanged(EventArgs e)
		{
			if ((this.PanelZoneIDChanged != null))
			{
				this.PanelZoneIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LockedChanged;
		private void OnLockedChanged(EventArgs e)
		{
			if ((this.LockedChanged != null))
			{
				this.LockedChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACFunctionCardData : BusinessBase
	{
		#region Fields
		private Guid _aCFunctionCardPK;
		private Int32 _sitecode;
		private Int32 _embossed;
		private Int32 _encoded;
		private Int32 _cardTypeID;
		private Guid _bDTenantPK;
		private Int32 _functionID;
		private String _firstName;
		private String _lastName;
		private Boolean _fIPS;
		private Int32 _pin;
		private DateTime _validFrom;
		private DateTime _validThru;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _suite;
		private String _tenant;
		private Guid _bDBuildingPK;
		private String _address1;
		private Int32 _buildingID;

		private ACPanelFunctionCardMapDataCollection _aCPanelFunctionCardMapList;
		#endregion

		#region Constructors
		public ACFunctionCardData()
		{
			this._aCFunctionCardPK = Guid.NewGuid();
			this._bDTenantPK = Guid.Empty;
			this._firstName = string.Empty;
			this._lastName = string.Empty;
			this._validFrom = DateTime.Now;
			this._validThru = DateTime.Now;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._suite = string.Empty;
			this._tenant = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACFunctionCardData(ACFunctionCardData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACFunctionCardPK
		{
			get
			{
				return this._aCFunctionCardPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACFunctionCardPK", value);
				if (this._aCFunctionCardPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCFunctionCardPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACFunctionCardPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 Sitecode
		{
			get
			{
				return this._sitecode;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Sitecode", value);
				if (this._sitecode != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._sitecode = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSitecodeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 Embossed
		{
			get
			{
				return this._embossed;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Embossed", value);
				if (this._embossed != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._embossed = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEmbossedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 Encoded
		{
			get
			{
				return this._encoded;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Encoded", value);
				if (this._encoded != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._encoded = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEncodedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 CardTypeID
		{
			get
			{
				return this._cardTypeID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CardTypeID", value);
				if (this._cardTypeID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._cardTypeID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCardTypeIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDTenantPK
		{
			get
			{
				return this._bDTenantPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDTenantPK", value);
				if (this._bDTenantPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDTenantPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDTenantPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 FunctionID
		{
			get
			{
				return this._functionID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("FunctionID", value);
				if (this._functionID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._functionID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFunctionIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String FirstName
		{
			get
			{
				return this._firstName == null ? null : this._firstName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("FirstName", value);
				if (this._firstName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._firstName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFirstNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String LastName
		{
			get
			{
				return this._lastName == null ? null : this._lastName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LastName", value);
				if (this._lastName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._lastName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLastNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean FIPS
		{
			get
			{
				return this._fIPS;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("FIPS", value);
				if (this._fIPS != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._fIPS = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFIPSChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 Pin
		{
			get
			{
				return this._pin;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Pin", value);
				if (this._pin != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._pin = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPinChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime ValidFrom
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._validFrom.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ValidFrom", value);
				if (this._validFrom != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._validFrom = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnValidFromChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime ValidThru
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._validThru.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ValidThru", value);
				if (this._validThru != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._validThru = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnValidThruChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String Suite
		{
			get
			{
				return this._suite == null ? null : this._suite.Trim();
			}
			set
			{
				 this._suite = value == null ? null : value.Trim();
			}
		}

		public virtual String Tenant
		{
			get
			{
				return this._tenant == null ? null : this._tenant.Trim();
			}
			set
			{
				 this._tenant = value == null ? null : value.Trim();
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACFunctionCard";
			}
		}
		#endregion

		#region Children
		public virtual ACPanelFunctionCardMapDataCollection ACPanelFunctionCardMapList
		{
			get
			{
				return this._aCPanelFunctionCardMapList;
			}
			set
			{
				this._aCPanelFunctionCardMapList = value;
			}
		}

		#endregion

		#region Parents
		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual BDTenantData BDTenant
		{
			get
			{
				BDTenantData parent = new BDTenantData();
				parent.BDTenantPK = this.BDTenantPK;
				parent.Suite = this.Suite;
				parent.Tenant = this.Tenant;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDTenantPK = value.BDTenantPK;
				this.Suite = value.Suite;
				this.Tenant = value.Tenant;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACFunctionCardData data = entity as ACFunctionCardData;
			if (data == null)
				return;

			this.Sitecode = data.Sitecode;
			this.Embossed = data.Embossed;
			this.Encoded = data.Encoded;
			this.CardTypeID = data.CardTypeID;
			this.BDTenantPK = data.BDTenantPK;
			this.FunctionID = data.FunctionID;
			this.FirstName = data.FirstName;
			this.LastName = data.LastName;
			this.FIPS = data.FIPS;
			this.Pin = data.Pin;
			this.ValidFrom = data.ValidFrom;
			this.ValidThru = data.ValidThru;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Suite = data.Suite;
			this.Tenant = data.Tenant;
			this.BDBuildingPK = data.BDBuildingPK;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACFunctionCardPK = data.ACFunctionCardPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			ACFunctionCardData data = entity as ACFunctionCardData;
			if (data == null)
				return;

			if (data.ACPanelFunctionCardMapList != null)
			{
				this.ACPanelFunctionCardMapList = new ACPanelFunctionCardMapDataCollection(data.ACPanelFunctionCardMapList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.ACPanelFunctionCardMapList != null)
			{
				this.ACPanelFunctionCardMapList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACFunctionCardData));
		}

		private bool InternalEquals(ACFunctionCardData obj)
		{
			if (this.ACFunctionCardPK.CompareTo(obj.ACFunctionCardPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACFunctionCardPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACFunctionCard:");
			builder.AppendFormat("{0}|", this.ACFunctionCardPK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.ACPanelFunctionCardMapList != null && this.ACPanelFunctionCardMapList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.ACPanelFunctionCardMapList != null && !this.ACPanelFunctionCardMapList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACFunctionCardPKChanged;
		private void OnACFunctionCardPKChanged(EventArgs e)
		{
			if ((this.ACFunctionCardPKChanged != null))
			{
				this.ACFunctionCardPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SitecodeChanged;
		private void OnSitecodeChanged(EventArgs e)
		{
			if ((this.SitecodeChanged != null))
			{
				this.SitecodeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EmbossedChanged;
		private void OnEmbossedChanged(EventArgs e)
		{
			if ((this.EmbossedChanged != null))
			{
				this.EmbossedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EncodedChanged;
		private void OnEncodedChanged(EventArgs e)
		{
			if ((this.EncodedChanged != null))
			{
				this.EncodedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CardTypeIDChanged;
		private void OnCardTypeIDChanged(EventArgs e)
		{
			if ((this.CardTypeIDChanged != null))
			{
				this.CardTypeIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDTenantPKChanged;
		private void OnBDTenantPKChanged(EventArgs e)
		{
			if ((this.BDTenantPKChanged != null))
			{
				this.BDTenantPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FunctionIDChanged;
		private void OnFunctionIDChanged(EventArgs e)
		{
			if ((this.FunctionIDChanged != null))
			{
				this.FunctionIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FirstNameChanged;
		private void OnFirstNameChanged(EventArgs e)
		{
			if ((this.FirstNameChanged != null))
			{
				this.FirstNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LastNameChanged;
		private void OnLastNameChanged(EventArgs e)
		{
			if ((this.LastNameChanged != null))
			{
				this.LastNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FIPSChanged;
		private void OnFIPSChanged(EventArgs e)
		{
			if ((this.FIPSChanged != null))
			{
				this.FIPSChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PinChanged;
		private void OnPinChanged(EventArgs e)
		{
			if ((this.PinChanged != null))
			{
				this.PinChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ValidFromChanged;
		private void OnValidFromChanged(EventArgs e)
		{
			if ((this.ValidFromChanged != null))
			{
				this.ValidFromChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ValidThruChanged;
		private void OnValidThruChanged(EventArgs e)
		{
			if ((this.ValidThruChanged != null))
			{
				this.ValidThruChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class UtilHolidayData : BusinessBase
	{
		#region Fields
		private Guid _utilHolidayPK;
		private Int32 _countryID;
		private String _holiday;
		private DateTime _date;
		private Boolean _major;
		private Boolean _federal;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private Boolean _default;
		private Int32 _actionID;

		private BDTenantHolidayMapDataCollection _bDTenantHolidayMapList;
		private BDBuildingHolidayMapDataCollection _bDBuildingHolidayMapList;
		private ACPanelHolidayMapDataCollection _aCPanelHolidayMapList;
		private ACIntvalHolidayMapDataCollection _aCIntvalHolidayMapList;
		#endregion

		#region Constructors
		public UtilHolidayData()
		{
			this._utilHolidayPK = Guid.NewGuid();
			this._holiday = string.Empty;
			this._date = DateTime.Now;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public UtilHolidayData(UtilHolidayData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid UtilHolidayPK
		{
			get
			{
				return this._utilHolidayPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UtilHolidayPK", value);
				if (this._utilHolidayPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._utilHolidayPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUtilHolidayPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 CountryID
		{
			get
			{
				return this._countryID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CountryID", value);
				if (this._countryID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._countryID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCountryIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Holiday
		{
			get
			{
				return this._holiday == null ? null : this._holiday.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Holiday", value);
				if (this._holiday != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._holiday = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnHolidayChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime Date
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._date.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Date", value);
				if (this._date != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._date = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDateChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Major
		{
			get
			{
				return this._major;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Major", value);
				if (this._major != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._major = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnMajorChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Federal
		{
			get
			{
				return this._federal;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Federal", value);
				if (this._federal != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._federal = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFederalChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual Boolean Default
		{
			get
			{
				return this._default;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Default", value);
				if (this._default != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._default = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDefaultChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 ActionID
		{
			get
			{
				return this._actionID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ActionID", value);
				if (this._actionID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._actionID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnActionIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "UtilHoliday";
			}
		}
		#endregion

		#region Children
		public virtual BDTenantHolidayMapDataCollection BDTenantHolidayMapList
		{
			get
			{
				return this._bDTenantHolidayMapList;
			}
			set
			{
				this._bDTenantHolidayMapList = value;
			}
		}

		public virtual BDBuildingHolidayMapDataCollection BDBuildingHolidayMapList
		{
			get
			{
				return this._bDBuildingHolidayMapList;
			}
			set
			{
				this._bDBuildingHolidayMapList = value;
			}
		}

		public virtual ACPanelHolidayMapDataCollection ACPanelHolidayMapList
		{
			get
			{
				return this._aCPanelHolidayMapList;
			}
			set
			{
				this._aCPanelHolidayMapList = value;
			}
		}

		public virtual ACIntvalHolidayMapDataCollection ACIntvalHolidayMapList
		{
			get
			{
				return this._aCIntvalHolidayMapList;
			}
			set
			{
				this._aCIntvalHolidayMapList = value;
			}
		}

		#endregion

		#region Parents
		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			UtilHolidayData data = entity as UtilHolidayData;
			if (data == null)
				return;

			this.CountryID = data.CountryID;
			this.Holiday = data.Holiday;
			this.Date = data.Date;
			this.Major = data.Major;
			this.Federal = data.Federal;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Default = data.Default;
			this.ActionID = data.ActionID;
			if (all)
			{
				this.UtilHolidayPK = data.UtilHolidayPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			UtilHolidayData data = entity as UtilHolidayData;
			if (data == null)
				return;

			if (data.BDTenantHolidayMapList != null)
			{
				this.BDTenantHolidayMapList = new BDTenantHolidayMapDataCollection(data.BDTenantHolidayMapList);
			}
			if (data.BDBuildingHolidayMapList != null)
			{
				this.BDBuildingHolidayMapList = new BDBuildingHolidayMapDataCollection(data.BDBuildingHolidayMapList);
			}
			if (data.ACPanelHolidayMapList != null)
			{
				this.ACPanelHolidayMapList = new ACPanelHolidayMapDataCollection(data.ACPanelHolidayMapList);
			}
			if (data.ACIntvalHolidayMapList != null)
			{
				this.ACIntvalHolidayMapList = new ACIntvalHolidayMapDataCollection(data.ACIntvalHolidayMapList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.BDTenantHolidayMapList != null)
			{
				this.BDTenantHolidayMapList.AcceptChanges();
			}
			if (this.BDBuildingHolidayMapList != null)
			{
				this.BDBuildingHolidayMapList.AcceptChanges();
			}
			if (this.ACPanelHolidayMapList != null)
			{
				this.ACPanelHolidayMapList.AcceptChanges();
			}
			if (this.ACIntvalHolidayMapList != null)
			{
				this.ACIntvalHolidayMapList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as UtilHolidayData));
		}

		private bool InternalEquals(UtilHolidayData obj)
		{
			if (this.UtilHolidayPK.CompareTo(obj.UtilHolidayPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.UtilHolidayPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("UtilHoliday:");
			builder.AppendFormat("{0}|", this.UtilHolidayPK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.BDTenantHolidayMapList != null && this.BDTenantHolidayMapList.IsDirty)
				{
					return true;
				}
				if (this.BDBuildingHolidayMapList != null && this.BDBuildingHolidayMapList.IsDirty)
				{
					return true;
				}
				if (this.ACPanelHolidayMapList != null && this.ACPanelHolidayMapList.IsDirty)
				{
					return true;
				}
				if (this.ACIntvalHolidayMapList != null && this.ACIntvalHolidayMapList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.BDTenantHolidayMapList != null && !this.BDTenantHolidayMapList.IsValid)
				{
					return false;
				}
				if (this.BDBuildingHolidayMapList != null && !this.BDBuildingHolidayMapList.IsValid)
				{
					return false;
				}
				if (this.ACPanelHolidayMapList != null && !this.ACPanelHolidayMapList.IsValid)
				{
					return false;
				}
				if (this.ACIntvalHolidayMapList != null && !this.ACIntvalHolidayMapList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler UtilHolidayPKChanged;
		private void OnUtilHolidayPKChanged(EventArgs e)
		{
			if ((this.UtilHolidayPKChanged != null))
			{
				this.UtilHolidayPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CountryIDChanged;
		private void OnCountryIDChanged(EventArgs e)
		{
			if ((this.CountryIDChanged != null))
			{
				this.CountryIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler HolidayChanged;
		private void OnHolidayChanged(EventArgs e)
		{
			if ((this.HolidayChanged != null))
			{
				this.HolidayChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DateChanged;
		private void OnDateChanged(EventArgs e)
		{
			if ((this.DateChanged != null))
			{
				this.DateChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler MajorChanged;
		private void OnMajorChanged(EventArgs e)
		{
			if ((this.MajorChanged != null))
			{
				this.MajorChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FederalChanged;
		private void OnFederalChanged(EventArgs e)
		{
			if ((this.FederalChanged != null))
			{
				this.FederalChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DefaultChanged;
		private void OnDefaultChanged(EventArgs e)
		{
			if ((this.DefaultChanged != null))
			{
				this.DefaultChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ActionIDChanged;
		private void OnActionIDChanged(EventArgs e)
		{
			if ((this.ActionIDChanged != null))
			{
				this.ActionIDChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACAccessLevelData : BusinessBase
	{
		#region Fields
		private Guid _aCAccessLevelPK;
		private Guid _bDBuildingPK;
		private Int16 _accessLevelID;
		private String _summary;
		private Boolean _asAL2;
		private String _notes;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _address1;
		private Int32 _buildingID;

		private ACAccessLevelDetailDataCollection _aCAccessLevelDetailList;
		#endregion

		#region Constructors
		public ACAccessLevelData()
		{
			this._aCAccessLevelPK = Guid.NewGuid();
			this._bDBuildingPK = Guid.Empty;
			this._summary = string.Empty;
			this._notes = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACAccessLevelData(ACAccessLevelData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACAccessLevelPK
		{
			get
			{
				return this._aCAccessLevelPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACAccessLevelPK", value);
				if (this._aCAccessLevelPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCAccessLevelPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACAccessLevelPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDBuildingPK", value);
				if (this._bDBuildingPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDBuildingPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDBuildingPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 AccessLevelID
		{
			get
			{
				return this._accessLevelID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AccessLevelID", value);
				if (this._accessLevelID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._accessLevelID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAccessLevelIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Summary
		{
			get
			{
				return this._summary == null ? null : this._summary.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Summary", value);
				if (this._summary != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._summary = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSummaryChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean AsAL2
		{
			get
			{
				return this._asAL2;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AsAL2", value);
				if (this._asAL2 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._asAL2 = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAsAL2Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Notes
		{
			get
			{
				return this._notes == null ? null : this._notes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Notes", value);
				if (this._notes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._notes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACAccessLevel";
			}
		}
		#endregion

		#region Children
		public virtual ACAccessLevelDetailDataCollection ACAccessLevelDetailList
		{
			get
			{
				return this._aCAccessLevelDetailList;
			}
			set
			{
				this._aCAccessLevelDetailList = value;
			}
		}

		#endregion

		#region Parents
		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACAccessLevelData data = entity as ACAccessLevelData;
			if (data == null)
				return;

			this.BDBuildingPK = data.BDBuildingPK;
			this.AccessLevelID = data.AccessLevelID;
			this.Summary = data.Summary;
			this.AsAL2 = data.AsAL2;
			this.Notes = data.Notes;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACAccessLevelPK = data.ACAccessLevelPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			ACAccessLevelData data = entity as ACAccessLevelData;
			if (data == null)
				return;

			if (data.ACAccessLevelDetailList != null)
			{
				this.ACAccessLevelDetailList = new ACAccessLevelDetailDataCollection(data.ACAccessLevelDetailList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.ACAccessLevelDetailList != null)
			{
				this.ACAccessLevelDetailList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACAccessLevelData));
		}

		private bool InternalEquals(ACAccessLevelData obj)
		{
			if (this.ACAccessLevelPK.CompareTo(obj.ACAccessLevelPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACAccessLevelPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACAccessLevel:");
			builder.AppendFormat("{0}|", this.ACAccessLevelPK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.ACAccessLevelDetailList != null && this.ACAccessLevelDetailList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.ACAccessLevelDetailList != null && !this.ACAccessLevelDetailList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACAccessLevelPKChanged;
		private void OnACAccessLevelPKChanged(EventArgs e)
		{
			if ((this.ACAccessLevelPKChanged != null))
			{
				this.ACAccessLevelPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDBuildingPKChanged;
		private void OnBDBuildingPKChanged(EventArgs e)
		{
			if ((this.BDBuildingPKChanged != null))
			{
				this.BDBuildingPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AccessLevelIDChanged;
		private void OnAccessLevelIDChanged(EventArgs e)
		{
			if ((this.AccessLevelIDChanged != null))
			{
				this.AccessLevelIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SummaryChanged;
		private void OnSummaryChanged(EventArgs e)
		{
			if ((this.SummaryChanged != null))
			{
				this.SummaryChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AsAL2Changed;
		private void OnAsAL2Changed(EventArgs e)
		{
			if ((this.AsAL2Changed != null))
			{
				this.AsAL2Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NotesChanged;
		private void OnNotesChanged(EventArgs e)
		{
			if ((this.NotesChanged != null))
			{
				this.NotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACPanelFunctionCardMapData : BusinessBase
	{
		#region Fields
		private Guid _aCPanelFunctionCardMapPK;
		private Guid _aCPanelPK;
		private Guid _aCFunctionCardPK;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private Int32 _cardTypeID;
		private Int32 _encoded;
		private Int32 _embossed;
		private Int32 _sitecode;
		private Guid _bDBuildingPK;
		private Int32 _unitID;
		private String _address1;
		private Int32 _buildingID;

		#endregion

		#region Constructors
		public ACPanelFunctionCardMapData()
		{
			this._aCPanelFunctionCardMapPK = Guid.NewGuid();
			this._aCPanelPK = Guid.Empty;
			this._aCFunctionCardPK = Guid.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACPanelFunctionCardMapData(ACPanelFunctionCardMapData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACPanelFunctionCardMapPK
		{
			get
			{
				return this._aCPanelFunctionCardMapPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACPanelFunctionCardMapPK", value);
				if (this._aCPanelFunctionCardMapPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCPanelFunctionCardMapPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACPanelFunctionCardMapPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACPanelPK
		{
			get
			{
				return this._aCPanelPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACPanelPK", value);
				if (this._aCPanelPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCPanelPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACPanelPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACFunctionCardPK
		{
			get
			{
				return this._aCFunctionCardPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACFunctionCardPK", value);
				if (this._aCFunctionCardPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCFunctionCardPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACFunctionCardPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 CardTypeID
		{
			get
			{
				return this._cardTypeID;
			}
			set
			{
				this._cardTypeID = value;
			}
		}

		public virtual Int32 Encoded
		{
			get
			{
				return this._encoded;
			}
			set
			{
				this._encoded = value;
			}
		}

		public virtual Int32 Embossed
		{
			get
			{
				return this._embossed;
			}
			set
			{
				this._embossed = value;
			}
		}

		public virtual Int32 Sitecode
		{
			get
			{
				return this._sitecode;
			}
			set
			{
				this._sitecode = value;
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual Int32 UnitID
		{
			get
			{
				return this._unitID;
			}
			set
			{
				this._unitID = value;
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACPanelFunctionCardMap";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual ACFunctionCardData ACFunctionCard
		{
			get
			{
				ACFunctionCardData parent = new ACFunctionCardData();
				parent.ACFunctionCardPK = this.ACFunctionCardPK;
				parent.CardTypeID = this.CardTypeID;
				parent.Encoded = this.Encoded;
				parent.Embossed = this.Embossed;
				parent.Sitecode = this.Sitecode;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACFunctionCardPK = value.ACFunctionCardPK;
				this.CardTypeID = value.CardTypeID;
				this.Encoded = value.Encoded;
				this.Embossed = value.Embossed;
				this.Sitecode = value.Sitecode;
			}
		}

		public virtual ACPanelData ACPanel
		{
			get
			{
				ACPanelData parent = new ACPanelData();
				parent.ACPanelPK = this.ACPanelPK;
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.BDBuildingPK = value.BDBuildingPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACPanelFunctionCardMapData data = entity as ACPanelFunctionCardMapData;
			if (data == null)
				return;

			this.ACPanelPK = data.ACPanelPK;
			this.ACFunctionCardPK = data.ACFunctionCardPK;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.CardTypeID = data.CardTypeID;
			this.Encoded = data.Encoded;
			this.Embossed = data.Embossed;
			this.Sitecode = data.Sitecode;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UnitID = data.UnitID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACPanelFunctionCardMapPK = data.ACPanelFunctionCardMapPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACPanelFunctionCardMapData));
		}

		private bool InternalEquals(ACPanelFunctionCardMapData obj)
		{
			if (this.ACPanelFunctionCardMapPK.CompareTo(obj.ACPanelFunctionCardMapPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACPanelFunctionCardMapPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACPanelFunctionCardMap:");
			builder.AppendFormat("{0}|", this.ACPanelFunctionCardMapPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACPanelFunctionCardMapPKChanged;
		private void OnACPanelFunctionCardMapPKChanged(EventArgs e)
		{
			if ((this.ACPanelFunctionCardMapPKChanged != null))
			{
				this.ACPanelFunctionCardMapPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACPanelPKChanged;
		private void OnACPanelPKChanged(EventArgs e)
		{
			if ((this.ACPanelPKChanged != null))
			{
				this.ACPanelPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACFunctionCardPKChanged;
		private void OnACFunctionCardPKChanged(EventArgs e)
		{
			if ((this.ACFunctionCardPKChanged != null))
			{
				this.ACFunctionCardPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class LogDBDeleteActivityData : BusinessBase
	{
		#region Fields
		private Guid _logDBDeleteActivityPK;
		private DateTime _logDateTime;
		private String _dBTableName;
		private Guid _recordPK;
		private DateTime _lastUpdated;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;

		#endregion

		#region Constructors
		public LogDBDeleteActivityData()
		{
			this._logDBDeleteActivityPK = Guid.NewGuid();
			this._logDateTime = DateTime.Now;
			this._dBTableName = string.Empty;
			this._recordPK = Guid.Empty;
			this._lastUpdated = DateTime.Now;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public LogDBDeleteActivityData(LogDBDeleteActivityData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid LogDBDeleteActivityPK
		{
			get
			{
				return this._logDBDeleteActivityPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LogDBDeleteActivityPK", value);
				if (this._logDBDeleteActivityPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._logDBDeleteActivityPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLogDBDeleteActivityPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime LogDateTime
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._logDateTime.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LogDateTime", value);
				if (this._logDateTime != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._logDateTime = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLogDateTimeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String DBTableName
		{
			get
			{
				return this._dBTableName == null ? null : this._dBTableName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("DBTableName", value);
				if (this._dBTableName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._dBTableName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDBTableNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid RecordPK
		{
			get
			{
				return this._recordPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("RecordPK", value);
				if (this._recordPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._recordPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnRecordPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime LastUpdated
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._lastUpdated.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LastUpdated", value);
				if (this._lastUpdated != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._lastUpdated = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLastUpdatedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "LogDBDeleteActivity";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			LogDBDeleteActivityData data = entity as LogDBDeleteActivityData;
			if (data == null)
				return;

			this.LogDateTime = data.LogDateTime;
			this.DBTableName = data.DBTableName;
			this.RecordPK = data.RecordPK;
			this.LastUpdated = data.LastUpdated;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			if (all)
			{
				this.LogDBDeleteActivityPK = data.LogDBDeleteActivityPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as LogDBDeleteActivityData));
		}

		private bool InternalEquals(LogDBDeleteActivityData obj)
		{
			if (this.LogDBDeleteActivityPK.CompareTo(obj.LogDBDeleteActivityPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.LogDBDeleteActivityPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("LogDBDeleteActivity:");
			builder.AppendFormat("{0}|", this.LogDBDeleteActivityPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler LogDBDeleteActivityPKChanged;
		private void OnLogDBDeleteActivityPKChanged(EventArgs e)
		{
			if ((this.LogDBDeleteActivityPKChanged != null))
			{
				this.LogDBDeleteActivityPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LogDateTimeChanged;
		private void OnLogDateTimeChanged(EventArgs e)
		{
			if ((this.LogDateTimeChanged != null))
			{
				this.LogDateTimeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DBTableNameChanged;
		private void OnDBTableNameChanged(EventArgs e)
		{
			if ((this.DBTableNameChanged != null))
			{
				this.DBTableNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RecordPKChanged;
		private void OnRecordPKChanged(EventArgs e)
		{
			if ((this.RecordPKChanged != null))
			{
				this.RecordPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LastUpdatedChanged;
		private void OnLastUpdatedChanged(EventArgs e)
		{
			if ((this.LastUpdatedChanged != null))
			{
				this.LastUpdatedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class UsrAccountData : BusinessBase
	{
		#region Fields
		private Guid _usrAccountPK;
		private String _userID;
		private Boolean _isAdmin;
		private Boolean _isCentral;
		private String _firstName;
		private String _lastName;
		private String _password;
		private DateTime _pwdExpireDate;
		private Guid _usrGroupPK;
		private Guid _bDTenantPK;
		private String _cellPhone;
		private String _homePhone;
		private String _officePhone;
		private String _email;
		private DateTime _lastLogin;
		private Int32 _totalUsage;
		private String _startScreen;
		private Int32 _popupExtension;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _suite;
		private String _tenant;
		private Guid _bDBuildingPK;
		private String _usrGroupName;
		private String _address1;
		private Int32 _buildingID;

		private UsrAccountBuildingMapDataCollection _usrAccountBuildingMapList;
		private UsrAccountBRRuleDataCollection _usrAccountBRRuleList;
		private UsrAccountDBRuleDataCollection _usrAccountDBRuleList;
		private UsrAccountTenantMapDataCollection _usrAccountTenantMapList;
		#endregion

		#region Constructors
		public UsrAccountData()
		{
			this._usrAccountPK = Guid.NewGuid();
			this._userID = string.Empty;
			this._firstName = string.Empty;
			this._lastName = string.Empty;
			this._password = string.Empty;
			this._pwdExpireDate = DateTime.Now;
			this._usrGroupPK = Guid.Empty;
			this._bDTenantPK = Guid.Empty;
			this._cellPhone = string.Empty;
			this._homePhone = string.Empty;
			this._officePhone = string.Empty;
			this._email = string.Empty;
			this._lastLogin = DateTime.Now;
			this._startScreen = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._suite = string.Empty;
			this._tenant = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._usrGroupName = string.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public UsrAccountData(UsrAccountData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid UsrAccountPK
		{
			get
			{
				return this._usrAccountPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrAccountPK", value);
				if (this._usrAccountPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrAccountPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrAccountPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String UserID
		{
			get
			{
				return this._userID == null ? null : this._userID.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UserID", value);
				if (this._userID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._userID = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUserIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean IsAdmin
		{
			get
			{
				return this._isAdmin;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("IsAdmin", value);
				if (this._isAdmin != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._isAdmin = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnIsAdminChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean IsCentral
		{
			get
			{
				return this._isCentral;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("IsCentral", value);
				if (this._isCentral != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._isCentral = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnIsCentralChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String FirstName
		{
			get
			{
				return this._firstName == null ? null : this._firstName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("FirstName", value);
				if (this._firstName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._firstName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFirstNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String LastName
		{
			get
			{
				return this._lastName == null ? null : this._lastName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LastName", value);
				if (this._lastName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._lastName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLastNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Password
		{
			get
			{
				return this._password == null ? null : this._password.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Password", value);
				if (this._password != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._password = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPasswordChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime PwdExpireDate
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._pwdExpireDate.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("PwdExpireDate", value);
				if (this._pwdExpireDate != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._pwdExpireDate = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPwdExpireDateChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid UsrGroupPK
		{
			get
			{
				return this._usrGroupPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrGroupPK", value);
				if (this._usrGroupPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrGroupPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrGroupPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDTenantPK
		{
			get
			{
				return this._bDTenantPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDTenantPK", value);
				if (this._bDTenantPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDTenantPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDTenantPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String CellPhone
		{
			get
			{
				return this._cellPhone == null ? null : this._cellPhone.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CellPhone", value);
				if (this._cellPhone != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._cellPhone = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCellPhoneChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String HomePhone
		{
			get
			{
				return this._homePhone == null ? null : this._homePhone.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("HomePhone", value);
				if (this._homePhone != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._homePhone = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnHomePhoneChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String OfficePhone
		{
			get
			{
				return this._officePhone == null ? null : this._officePhone.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("OfficePhone", value);
				if (this._officePhone != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._officePhone = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnOfficePhoneChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Email
		{
			get
			{
				return this._email == null ? null : this._email.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Email", value);
				if (this._email != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._email = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEmailChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime LastLogin
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._lastLogin.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LastLogin", value);
				if (this._lastLogin != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._lastLogin = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLastLoginChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 TotalUsage
		{
			get
			{
				return this._totalUsage;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("TotalUsage", value);
				if (this._totalUsage != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._totalUsage = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnTotalUsageChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String StartScreen
		{
			get
			{
				return this._startScreen == null ? null : this._startScreen.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("StartScreen", value);
				if (this._startScreen != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._startScreen = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnStartScreenChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 PopupExtension
		{
			get
			{
				return this._popupExtension;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("PopupExtension", value);
				if (this._popupExtension != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._popupExtension = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPopupExtensionChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String Suite
		{
			get
			{
				return this._suite == null ? null : this._suite.Trim();
			}
			set
			{
				 this._suite = value == null ? null : value.Trim();
			}
		}

		public virtual String Tenant
		{
			get
			{
				return this._tenant == null ? null : this._tenant.Trim();
			}
			set
			{
				 this._tenant = value == null ? null : value.Trim();
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual String UsrGroupName
		{
			get
			{
				return this._usrGroupName == null ? null : this._usrGroupName.Trim();
			}
			set
			{
				 this._usrGroupName = value == null ? null : value.Trim();
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "UsrAccount";
			}
		}
		#endregion

		#region Children
		public virtual UsrAccountBuildingMapDataCollection UsrAccountBuildingMapList
		{
			get
			{
				return this._usrAccountBuildingMapList;
			}
			set
			{
				this._usrAccountBuildingMapList = value;
			}
		}

		public virtual UsrAccountBRRuleDataCollection UsrAccountBRRuleList
		{
			get
			{
				return this._usrAccountBRRuleList;
			}
			set
			{
				this._usrAccountBRRuleList = value;
			}
		}

		public virtual UsrAccountDBRuleDataCollection UsrAccountDBRuleList
		{
			get
			{
				return this._usrAccountDBRuleList;
			}
			set
			{
				this._usrAccountDBRuleList = value;
			}
		}

		public virtual UsrAccountTenantMapDataCollection UsrAccountTenantMapList
		{
			get
			{
				return this._usrAccountTenantMapList;
			}
			set
			{
				this._usrAccountTenantMapList = value;
			}
		}

		#endregion

		#region Parents
		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual BDTenantData BDTenant
		{
			get
			{
				BDTenantData parent = new BDTenantData();
				parent.BDTenantPK = this.BDTenantPK;
				parent.Suite = this.Suite;
				parent.Tenant = this.Tenant;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDTenantPK = value.BDTenantPK;
				this.Suite = value.Suite;
				this.Tenant = value.Tenant;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		public virtual UsrGroupData UsrGroup
		{
			get
			{
				UsrGroupData parent = new UsrGroupData();
				parent.UsrGroupPK = this.UsrGroupPK;
				parent.UsrGroupName = this.UsrGroupName;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UsrGroupPK = value.UsrGroupPK;
				this.UsrGroupName = value.UsrGroupName;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			UsrAccountData data = entity as UsrAccountData;
			if (data == null)
				return;

			this.UserID = data.UserID;
			this.IsAdmin = data.IsAdmin;
			this.IsCentral = data.IsCentral;
			this.FirstName = data.FirstName;
			this.LastName = data.LastName;
			this.Password = data.Password;
			this.PwdExpireDate = data.PwdExpireDate;
			this.UsrGroupPK = data.UsrGroupPK;
			this.BDTenantPK = data.BDTenantPK;
			this.CellPhone = data.CellPhone;
			this.HomePhone = data.HomePhone;
			this.OfficePhone = data.OfficePhone;
			this.Email = data.Email;
			this.LastLogin = data.LastLogin;
			this.TotalUsage = data.TotalUsage;
			this.StartScreen = data.StartScreen;
			this.PopupExtension = data.PopupExtension;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Suite = data.Suite;
			this.Tenant = data.Tenant;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UsrGroupName = data.UsrGroupName;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.UsrAccountPK = data.UsrAccountPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			UsrAccountData data = entity as UsrAccountData;
			if (data == null)
				return;

			if (data.UsrAccountBuildingMapList != null)
			{
				this.UsrAccountBuildingMapList = new UsrAccountBuildingMapDataCollection(data.UsrAccountBuildingMapList);
			}
			if (data.UsrAccountBRRuleList != null)
			{
				this.UsrAccountBRRuleList = new UsrAccountBRRuleDataCollection(data.UsrAccountBRRuleList);
			}
			if (data.UsrAccountDBRuleList != null)
			{
				this.UsrAccountDBRuleList = new UsrAccountDBRuleDataCollection(data.UsrAccountDBRuleList);
			}
			if (data.UsrAccountTenantMapList != null)
			{
				this.UsrAccountTenantMapList = new UsrAccountTenantMapDataCollection(data.UsrAccountTenantMapList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.UsrAccountBuildingMapList != null)
			{
				this.UsrAccountBuildingMapList.AcceptChanges();
			}
			if (this.UsrAccountBRRuleList != null)
			{
				this.UsrAccountBRRuleList.AcceptChanges();
			}
			if (this.UsrAccountDBRuleList != null)
			{
				this.UsrAccountDBRuleList.AcceptChanges();
			}
			if (this.UsrAccountTenantMapList != null)
			{
				this.UsrAccountTenantMapList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as UsrAccountData));
		}

		private bool InternalEquals(UsrAccountData obj)
		{
			if (this.UsrAccountPK.CompareTo(obj.UsrAccountPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.UsrAccountPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("UsrAccount:");
			builder.AppendFormat("{0}|", this.UsrAccountPK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.UsrAccountBuildingMapList != null && this.UsrAccountBuildingMapList.IsDirty)
				{
					return true;
				}
				if (this.UsrAccountBRRuleList != null && this.UsrAccountBRRuleList.IsDirty)
				{
					return true;
				}
				if (this.UsrAccountDBRuleList != null && this.UsrAccountDBRuleList.IsDirty)
				{
					return true;
				}
				if (this.UsrAccountTenantMapList != null && this.UsrAccountTenantMapList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.UsrAccountBuildingMapList != null && !this.UsrAccountBuildingMapList.IsValid)
				{
					return false;
				}
				if (this.UsrAccountBRRuleList != null && !this.UsrAccountBRRuleList.IsValid)
				{
					return false;
				}
				if (this.UsrAccountDBRuleList != null && !this.UsrAccountDBRuleList.IsValid)
				{
					return false;
				}
				if (this.UsrAccountTenantMapList != null && !this.UsrAccountTenantMapList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrAccountPKChanged;
		private void OnUsrAccountPKChanged(EventArgs e)
		{
			if ((this.UsrAccountPKChanged != null))
			{
				this.UsrAccountPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UserIDChanged;
		private void OnUserIDChanged(EventArgs e)
		{
			if ((this.UserIDChanged != null))
			{
				this.UserIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler IsAdminChanged;
		private void OnIsAdminChanged(EventArgs e)
		{
			if ((this.IsAdminChanged != null))
			{
				this.IsAdminChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler IsCentralChanged;
		private void OnIsCentralChanged(EventArgs e)
		{
			if ((this.IsCentralChanged != null))
			{
				this.IsCentralChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FirstNameChanged;
		private void OnFirstNameChanged(EventArgs e)
		{
			if ((this.FirstNameChanged != null))
			{
				this.FirstNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LastNameChanged;
		private void OnLastNameChanged(EventArgs e)
		{
			if ((this.LastNameChanged != null))
			{
				this.LastNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PasswordChanged;
		private void OnPasswordChanged(EventArgs e)
		{
			if ((this.PasswordChanged != null))
			{
				this.PasswordChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PwdExpireDateChanged;
		private void OnPwdExpireDateChanged(EventArgs e)
		{
			if ((this.PwdExpireDateChanged != null))
			{
				this.PwdExpireDateChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrGroupPKChanged;
		private void OnUsrGroupPKChanged(EventArgs e)
		{
			if ((this.UsrGroupPKChanged != null))
			{
				this.UsrGroupPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDTenantPKChanged;
		private void OnBDTenantPKChanged(EventArgs e)
		{
			if ((this.BDTenantPKChanged != null))
			{
				this.BDTenantPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CellPhoneChanged;
		private void OnCellPhoneChanged(EventArgs e)
		{
			if ((this.CellPhoneChanged != null))
			{
				this.CellPhoneChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler HomePhoneChanged;
		private void OnHomePhoneChanged(EventArgs e)
		{
			if ((this.HomePhoneChanged != null))
			{
				this.HomePhoneChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler OfficePhoneChanged;
		private void OnOfficePhoneChanged(EventArgs e)
		{
			if ((this.OfficePhoneChanged != null))
			{
				this.OfficePhoneChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EmailChanged;
		private void OnEmailChanged(EventArgs e)
		{
			if ((this.EmailChanged != null))
			{
				this.EmailChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LastLoginChanged;
		private void OnLastLoginChanged(EventArgs e)
		{
			if ((this.LastLoginChanged != null))
			{
				this.LastLoginChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler TotalUsageChanged;
		private void OnTotalUsageChanged(EventArgs e)
		{
			if ((this.TotalUsageChanged != null))
			{
				this.TotalUsageChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler StartScreenChanged;
		private void OnStartScreenChanged(EventArgs e)
		{
			if ((this.StartScreenChanged != null))
			{
				this.StartScreenChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PopupExtensionChanged;
		private void OnPopupExtensionChanged(EventArgs e)
		{
			if ((this.PopupExtensionChanged != null))
			{
				this.PopupExtensionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class LogDBEditActivityData : BusinessBase
	{
		#region Fields
		private Guid _logDBEditActivityPK;
		private DateTime _logDateTime;
		private String _dBTableName;
		private Guid _recordPK;
		private String _category;
		private Byte[] _recordDetail;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;

		#endregion

		#region Constructors
		public LogDBEditActivityData()
		{
			this._logDBEditActivityPK = Guid.NewGuid();
			this._logDateTime = DateTime.Now;
			this._dBTableName = string.Empty;
			this._recordPK = Guid.Empty;
			this._category = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public LogDBEditActivityData(LogDBEditActivityData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid LogDBEditActivityPK
		{
			get
			{
				return this._logDBEditActivityPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LogDBEditActivityPK", value);
				if (this._logDBEditActivityPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._logDBEditActivityPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLogDBEditActivityPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime LogDateTime
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._logDateTime.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LogDateTime", value);
				if (this._logDateTime != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._logDateTime = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLogDateTimeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String DBTableName
		{
			get
			{
				return this._dBTableName == null ? null : this._dBTableName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("DBTableName", value);
				if (this._dBTableName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._dBTableName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDBTableNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid RecordPK
		{
			get
			{
				return this._recordPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("RecordPK", value);
				if (this._recordPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._recordPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnRecordPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Category
		{
			get
			{
				return this._category == null ? null : this._category.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Category", value);
				if (this._category != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._category = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCategoryChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte[] RecordDetail
		{
			get
			{
				return this._recordDetail;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("RecordDetail", value);
				if (this._recordDetail != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._recordDetail = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnRecordDetailChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "LogDBEditActivity";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			LogDBEditActivityData data = entity as LogDBEditActivityData;
			if (data == null)
				return;

			this.LogDateTime = data.LogDateTime;
			this.DBTableName = data.DBTableName;
			this.RecordPK = data.RecordPK;
			this.Category = data.Category;
			this.RecordDetail = data.RecordDetail;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			if (all)
			{
				this.LogDBEditActivityPK = data.LogDBEditActivityPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as LogDBEditActivityData));
		}

		private bool InternalEquals(LogDBEditActivityData obj)
		{
			if (this.LogDBEditActivityPK.CompareTo(obj.LogDBEditActivityPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.LogDBEditActivityPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("LogDBEditActivity:");
			builder.AppendFormat("{0}|", this.LogDBEditActivityPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler LogDBEditActivityPKChanged;
		private void OnLogDBEditActivityPKChanged(EventArgs e)
		{
			if ((this.LogDBEditActivityPKChanged != null))
			{
				this.LogDBEditActivityPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LogDateTimeChanged;
		private void OnLogDateTimeChanged(EventArgs e)
		{
			if ((this.LogDateTimeChanged != null))
			{
				this.LogDateTimeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DBTableNameChanged;
		private void OnDBTableNameChanged(EventArgs e)
		{
			if ((this.DBTableNameChanged != null))
			{
				this.DBTableNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RecordPKChanged;
		private void OnRecordPKChanged(EventArgs e)
		{
			if ((this.RecordPKChanged != null))
			{
				this.RecordPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CategoryChanged;
		private void OnCategoryChanged(EventArgs e)
		{
			if ((this.CategoryChanged != null))
			{
				this.CategoryChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RecordDetailChanged;
		private void OnRecordDetailChanged(EventArgs e)
		{
			if ((this.RecordDetailChanged != null))
			{
				this.RecordDetailChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACMasterCardData : BusinessBase
	{
		#region Fields
		private Guid _aCMasterCardPK;
		private Int32 _sitecode;
		private Int32 _embossed;
		private Int32 _encoded;
		private Int32 _cardTypeID;
		private String _firstName;
		private String _lastName;
		private Byte[] _photo;
		private Boolean _fIPS;
		private Int32 _pin;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;

		#endregion

		#region Constructors
		public ACMasterCardData()
		{
			this._aCMasterCardPK = Guid.NewGuid();
			this._firstName = string.Empty;
			this._lastName = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACMasterCardData(ACMasterCardData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACMasterCardPK
		{
			get
			{
				return this._aCMasterCardPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACMasterCardPK", value);
				if (this._aCMasterCardPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCMasterCardPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACMasterCardPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 Sitecode
		{
			get
			{
				return this._sitecode;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Sitecode", value);
				if (this._sitecode != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._sitecode = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSitecodeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 Embossed
		{
			get
			{
				return this._embossed;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Embossed", value);
				if (this._embossed != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._embossed = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEmbossedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 Encoded
		{
			get
			{
				return this._encoded;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Encoded", value);
				if (this._encoded != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._encoded = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEncodedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 CardTypeID
		{
			get
			{
				return this._cardTypeID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CardTypeID", value);
				if (this._cardTypeID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._cardTypeID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCardTypeIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String FirstName
		{
			get
			{
				return this._firstName == null ? null : this._firstName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("FirstName", value);
				if (this._firstName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._firstName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFirstNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String LastName
		{
			get
			{
				return this._lastName == null ? null : this._lastName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LastName", value);
				if (this._lastName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._lastName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLastNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte[] Photo
		{
			get
			{
				return this._photo;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Photo", value);
				if (this._photo != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._photo = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPhotoChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean FIPS
		{
			get
			{
				return this._fIPS;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("FIPS", value);
				if (this._fIPS != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._fIPS = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFIPSChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 Pin
		{
			get
			{
				return this._pin;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Pin", value);
				if (this._pin != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._pin = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPinChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACMasterCard";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACMasterCardData data = entity as ACMasterCardData;
			if (data == null)
				return;

			this.Sitecode = data.Sitecode;
			this.Embossed = data.Embossed;
			this.Encoded = data.Encoded;
			this.CardTypeID = data.CardTypeID;
			this.FirstName = data.FirstName;
			this.LastName = data.LastName;
			this.Photo = data.Photo;
			this.FIPS = data.FIPS;
			this.Pin = data.Pin;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			if (all)
			{
				this.ACMasterCardPK = data.ACMasterCardPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACMasterCardData));
		}

		private bool InternalEquals(ACMasterCardData obj)
		{
			if (this.ACMasterCardPK.CompareTo(obj.ACMasterCardPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACMasterCardPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACMasterCard:");
			builder.AppendFormat("{0}|", this.ACMasterCardPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACMasterCardPKChanged;
		private void OnACMasterCardPKChanged(EventArgs e)
		{
			if ((this.ACMasterCardPKChanged != null))
			{
				this.ACMasterCardPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SitecodeChanged;
		private void OnSitecodeChanged(EventArgs e)
		{
			if ((this.SitecodeChanged != null))
			{
				this.SitecodeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EmbossedChanged;
		private void OnEmbossedChanged(EventArgs e)
		{
			if ((this.EmbossedChanged != null))
			{
				this.EmbossedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EncodedChanged;
		private void OnEncodedChanged(EventArgs e)
		{
			if ((this.EncodedChanged != null))
			{
				this.EncodedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CardTypeIDChanged;
		private void OnCardTypeIDChanged(EventArgs e)
		{
			if ((this.CardTypeIDChanged != null))
			{
				this.CardTypeIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FirstNameChanged;
		private void OnFirstNameChanged(EventArgs e)
		{
			if ((this.FirstNameChanged != null))
			{
				this.FirstNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LastNameChanged;
		private void OnLastNameChanged(EventArgs e)
		{
			if ((this.LastNameChanged != null))
			{
				this.LastNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PhotoChanged;
		private void OnPhotoChanged(EventArgs e)
		{
			if ((this.PhotoChanged != null))
			{
				this.PhotoChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FIPSChanged;
		private void OnFIPSChanged(EventArgs e)
		{
			if ((this.FIPSChanged != null))
			{
				this.FIPSChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PinChanged;
		private void OnPinChanged(EventArgs e)
		{
			if ((this.PinChanged != null))
			{
				this.PinChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACSupervisoryData : BusinessBase
	{
		#region Fields
		private Guid _aCSupervisoryPK;
		private Guid _aCPanelPK;
		private Byte _supervisoryID;
		private String _description;
		private Int16 _debounce;
		private Int16 _forceAMFormat;
		private Boolean _external;
		private String _notes;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private Byte _panelZoneID;
		private Boolean _locked;
		private Guid _bDBuildingPK;
		private Int32 _unitID;
		private String _address1;
		private Int32 _buildingID;

		#endregion

		#region Constructors
		public ACSupervisoryData()
		{
			this._aCSupervisoryPK = Guid.NewGuid();
			this._aCPanelPK = Guid.Empty;
			this._description = string.Empty;
			this._notes = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACSupervisoryData(ACSupervisoryData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACSupervisoryPK
		{
			get
			{
				return this._aCSupervisoryPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACSupervisoryPK", value);
				if (this._aCSupervisoryPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCSupervisoryPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACSupervisoryPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACPanelPK
		{
			get
			{
				return this._aCPanelPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACPanelPK", value);
				if (this._aCPanelPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCPanelPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACPanelPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte SupervisoryID
		{
			get
			{
				return this._supervisoryID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("SupervisoryID", value);
				if (this._supervisoryID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._supervisoryID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSupervisoryIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Description
		{
			get
			{
				return this._description == null ? null : this._description.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Description", value);
				if (this._description != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._description = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDescriptionChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 Debounce
		{
			get
			{
				return this._debounce;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Debounce", value);
				if (this._debounce != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._debounce = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDebounceChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 ForceAMFormat
		{
			get
			{
				return this._forceAMFormat;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ForceAMFormat", value);
				if (this._forceAMFormat != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._forceAMFormat = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnForceAMFormatChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean External
		{
			get
			{
				return this._external;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("External", value);
				if (this._external != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._external = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnExternalChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Notes
		{
			get
			{
				return this._notes == null ? null : this._notes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Notes", value);
				if (this._notes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._notes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual Byte PanelZoneID
		{
			get
			{
				return this._panelZoneID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("PanelZoneID", value);
				if (this._panelZoneID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._panelZoneID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPanelZoneIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Locked
		{
			get
			{
				return this._locked;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Locked", value);
				if (this._locked != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._locked = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLockedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual Int32 UnitID
		{
			get
			{
				return this._unitID;
			}
			set
			{
				this._unitID = value;
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACSupervisory";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual ACPanelData ACPanel
		{
			get
			{
				ACPanelData parent = new ACPanelData();
				parent.ACPanelPK = this.ACPanelPK;
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.BDBuildingPK = value.BDBuildingPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACSupervisoryData data = entity as ACSupervisoryData;
			if (data == null)
				return;

			this.ACPanelPK = data.ACPanelPK;
			this.SupervisoryID = data.SupervisoryID;
			this.Description = data.Description;
			this.Debounce = data.Debounce;
			this.ForceAMFormat = data.ForceAMFormat;
			this.External = data.External;
			this.Notes = data.Notes;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.PanelZoneID = data.PanelZoneID;
			this.Locked = data.Locked;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UnitID = data.UnitID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACSupervisoryPK = data.ACSupervisoryPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACSupervisoryData));
		}

		private bool InternalEquals(ACSupervisoryData obj)
		{
			if (this.ACSupervisoryPK.CompareTo(obj.ACSupervisoryPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACSupervisoryPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACSupervisory:");
			builder.AppendFormat("{0}|", this.ACSupervisoryPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACSupervisoryPKChanged;
		private void OnACSupervisoryPKChanged(EventArgs e)
		{
			if ((this.ACSupervisoryPKChanged != null))
			{
				this.ACSupervisoryPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACPanelPKChanged;
		private void OnACPanelPKChanged(EventArgs e)
		{
			if ((this.ACPanelPKChanged != null))
			{
				this.ACPanelPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SupervisoryIDChanged;
		private void OnSupervisoryIDChanged(EventArgs e)
		{
			if ((this.SupervisoryIDChanged != null))
			{
				this.SupervisoryIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DescriptionChanged;
		private void OnDescriptionChanged(EventArgs e)
		{
			if ((this.DescriptionChanged != null))
			{
				this.DescriptionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DebounceChanged;
		private void OnDebounceChanged(EventArgs e)
		{
			if ((this.DebounceChanged != null))
			{
				this.DebounceChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ForceAMFormatChanged;
		private void OnForceAMFormatChanged(EventArgs e)
		{
			if ((this.ForceAMFormatChanged != null))
			{
				this.ForceAMFormatChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ExternalChanged;
		private void OnExternalChanged(EventArgs e)
		{
			if ((this.ExternalChanged != null))
			{
				this.ExternalChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NotesChanged;
		private void OnNotesChanged(EventArgs e)
		{
			if ((this.NotesChanged != null))
			{
				this.NotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PanelZoneIDChanged;
		private void OnPanelZoneIDChanged(EventArgs e)
		{
			if ((this.PanelZoneIDChanged != null))
			{
				this.PanelZoneIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LockedChanged;
		private void OnLockedChanged(EventArgs e)
		{
			if ((this.LockedChanged != null))
			{
				this.LockedChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class UsrGroupData : BusinessBase
	{
		#region Fields
		private Guid _usrGroupPK;
		private String _usrGroupName;
		private String _description;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;

		private UsrGroupDBRuleDataCollection _usrGroupDBRuleList;
		private UsrGroupBRRuleDataCollection _usrGroupBRRuleList;
		private UsrAccountDataCollection _usrAccountList;
		#endregion

		#region Constructors
		public UsrGroupData()
		{
			this._usrGroupPK = Guid.NewGuid();
			this._usrGroupName = string.Empty;
			this._description = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public UsrGroupData(UsrGroupData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid UsrGroupPK
		{
			get
			{
				return this._usrGroupPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrGroupPK", value);
				if (this._usrGroupPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrGroupPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrGroupPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String UsrGroupName
		{
			get
			{
				return this._usrGroupName == null ? null : this._usrGroupName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrGroupName", value);
				if (this._usrGroupName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrGroupName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrGroupNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Description
		{
			get
			{
				return this._description == null ? null : this._description.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Description", value);
				if (this._description != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._description = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDescriptionChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "UsrGroup";
			}
		}
		#endregion

		#region Children
		public virtual UsrGroupDBRuleDataCollection UsrGroupDBRuleList
		{
			get
			{
				return this._usrGroupDBRuleList;
			}
			set
			{
				this._usrGroupDBRuleList = value;
			}
		}

		public virtual UsrGroupBRRuleDataCollection UsrGroupBRRuleList
		{
			get
			{
				return this._usrGroupBRRuleList;
			}
			set
			{
				this._usrGroupBRRuleList = value;
			}
		}

		public virtual UsrAccountDataCollection UsrAccountList
		{
			get
			{
				return this._usrAccountList;
			}
			set
			{
				this._usrAccountList = value;
			}
		}

		#endregion

		#region Parents
		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			UsrGroupData data = entity as UsrGroupData;
			if (data == null)
				return;

			this.UsrGroupName = data.UsrGroupName;
			this.Description = data.Description;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			if (all)
			{
				this.UsrGroupPK = data.UsrGroupPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			UsrGroupData data = entity as UsrGroupData;
			if (data == null)
				return;

			if (data.UsrGroupDBRuleList != null)
			{
				this.UsrGroupDBRuleList = new UsrGroupDBRuleDataCollection(data.UsrGroupDBRuleList);
			}
			if (data.UsrGroupBRRuleList != null)
			{
				this.UsrGroupBRRuleList = new UsrGroupBRRuleDataCollection(data.UsrGroupBRRuleList);
			}
			if (data.UsrAccountList != null)
			{
				this.UsrAccountList = new UsrAccountDataCollection(data.UsrAccountList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.UsrGroupDBRuleList != null)
			{
				this.UsrGroupDBRuleList.AcceptChanges();
			}
			if (this.UsrGroupBRRuleList != null)
			{
				this.UsrGroupBRRuleList.AcceptChanges();
			}
			if (this.UsrAccountList != null)
			{
				this.UsrAccountList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as UsrGroupData));
		}

		private bool InternalEquals(UsrGroupData obj)
		{
			if (this.UsrGroupPK.CompareTo(obj.UsrGroupPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.UsrGroupPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("UsrGroup:");
			builder.AppendFormat("{0}|", this.UsrGroupPK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.UsrGroupDBRuleList != null && this.UsrGroupDBRuleList.IsDirty)
				{
					return true;
				}
				if (this.UsrGroupBRRuleList != null && this.UsrGroupBRRuleList.IsDirty)
				{
					return true;
				}
				if (this.UsrAccountList != null && this.UsrAccountList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.UsrGroupDBRuleList != null && !this.UsrGroupDBRuleList.IsValid)
				{
					return false;
				}
				if (this.UsrGroupBRRuleList != null && !this.UsrGroupBRRuleList.IsValid)
				{
					return false;
				}
				if (this.UsrAccountList != null && !this.UsrAccountList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrGroupPKChanged;
		private void OnUsrGroupPKChanged(EventArgs e)
		{
			if ((this.UsrGroupPKChanged != null))
			{
				this.UsrGroupPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrGroupNameChanged;
		private void OnUsrGroupNameChanged(EventArgs e)
		{
			if ((this.UsrGroupNameChanged != null))
			{
				this.UsrGroupNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DescriptionChanged;
		private void OnDescriptionChanged(EventArgs e)
		{
			if ((this.DescriptionChanged != null))
			{
				this.DescriptionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACCardHolderBuildingMapData : BusinessBase
	{
		#region Fields
		private Guid _aCCardHolderBuildingMapPK;
		private Guid _aCCardHolderPK;
		private Guid _bDBuildingPK;
		private Int16 _aL1st;
		private Int16 _aL2nd;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _address1;
		private Int32 _buildingID;
		private String _lastName;
		private String _firstName;
		private Int32 _cardTypeID;
		private Int32 _encoded;
		private Int32 _embossed;
		private Int32 _sitecode;

		#endregion

		#region Constructors
		public ACCardHolderBuildingMapData()
		{
			this._aCCardHolderBuildingMapPK = Guid.NewGuid();
			this._aCCardHolderPK = Guid.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._address1 = string.Empty;
			this._lastName = string.Empty;
			this._firstName = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACCardHolderBuildingMapData(ACCardHolderBuildingMapData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACCardHolderBuildingMapPK
		{
			get
			{
				return this._aCCardHolderBuildingMapPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACCardHolderBuildingMapPK", value);
				if (this._aCCardHolderBuildingMapPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCCardHolderBuildingMapPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACCardHolderBuildingMapPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACCardHolderPK
		{
			get
			{
				return this._aCCardHolderPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACCardHolderPK", value);
				if (this._aCCardHolderPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCCardHolderPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACCardHolderPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDBuildingPK", value);
				if (this._bDBuildingPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDBuildingPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDBuildingPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 AL1st
		{
			get
			{
				return this._aL1st;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AL1st", value);
				if (this._aL1st != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aL1st = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAL1stChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 AL2nd
		{
			get
			{
				return this._aL2nd;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AL2nd", value);
				if (this._aL2nd != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aL2nd = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAL2ndChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		public virtual String LastName
		{
			get
			{
				return this._lastName == null ? null : this._lastName.Trim();
			}
			set
			{
				 this._lastName = value == null ? null : value.Trim();
			}
		}

		public virtual String FirstName
		{
			get
			{
				return this._firstName == null ? null : this._firstName.Trim();
			}
			set
			{
				 this._firstName = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 CardTypeID
		{
			get
			{
				return this._cardTypeID;
			}
			set
			{
				this._cardTypeID = value;
			}
		}

		public virtual Int32 Encoded
		{
			get
			{
				return this._encoded;
			}
			set
			{
				this._encoded = value;
			}
		}

		public virtual Int32 Embossed
		{
			get
			{
				return this._embossed;
			}
			set
			{
				this._embossed = value;
			}
		}

		public virtual Int32 Sitecode
		{
			get
			{
				return this._sitecode;
			}
			set
			{
				this._sitecode = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACCardHolderBuildingMap";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual ACCardHolderData ACCardHolder
		{
			get
			{
				ACCardHolderData parent = new ACCardHolderData();
				parent.ACCardHolderPK = this.ACCardHolderPK;
				parent.LastName = this.LastName;
				parent.FirstName = this.FirstName;
				parent.CardTypeID = this.CardTypeID;
				parent.Encoded = this.Encoded;
				parent.Embossed = this.Embossed;
				parent.Sitecode = this.Sitecode;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACCardHolderPK = value.ACCardHolderPK;
				this.LastName = value.LastName;
				this.FirstName = value.FirstName;
				this.CardTypeID = value.CardTypeID;
				this.Encoded = value.Encoded;
				this.Embossed = value.Embossed;
				this.Sitecode = value.Sitecode;
			}
		}

		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACCardHolderBuildingMapData data = entity as ACCardHolderBuildingMapData;
			if (data == null)
				return;

			this.ACCardHolderPK = data.ACCardHolderPK;
			this.BDBuildingPK = data.BDBuildingPK;
			this.AL1st = data.AL1st;
			this.AL2nd = data.AL2nd;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			this.LastName = data.LastName;
			this.FirstName = data.FirstName;
			this.CardTypeID = data.CardTypeID;
			this.Encoded = data.Encoded;
			this.Embossed = data.Embossed;
			this.Sitecode = data.Sitecode;
			if (all)
			{
				this.ACCardHolderBuildingMapPK = data.ACCardHolderBuildingMapPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACCardHolderBuildingMapData));
		}

		private bool InternalEquals(ACCardHolderBuildingMapData obj)
		{
			if (this.ACCardHolderBuildingMapPK.CompareTo(obj.ACCardHolderBuildingMapPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACCardHolderBuildingMapPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACCardHolderBuildingMap:");
			builder.AppendFormat("{0}|", this.ACCardHolderBuildingMapPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACCardHolderBuildingMapPKChanged;
		private void OnACCardHolderBuildingMapPKChanged(EventArgs e)
		{
			if ((this.ACCardHolderBuildingMapPKChanged != null))
			{
				this.ACCardHolderBuildingMapPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACCardHolderPKChanged;
		private void OnACCardHolderPKChanged(EventArgs e)
		{
			if ((this.ACCardHolderPKChanged != null))
			{
				this.ACCardHolderPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDBuildingPKChanged;
		private void OnBDBuildingPKChanged(EventArgs e)
		{
			if ((this.BDBuildingPKChanged != null))
			{
				this.BDBuildingPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AL1stChanged;
		private void OnAL1stChanged(EventArgs e)
		{
			if ((this.AL1stChanged != null))
			{
				this.AL1stChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AL2ndChanged;
		private void OnAL2ndChanged(EventArgs e)
		{
			if ((this.AL2ndChanged != null))
			{
				this.AL2ndChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class BDVisitorData : BusinessBase
	{
		#region Fields
		private Guid _bDVisitorPK;
		private Guid _bDTenantPK;
		private String _firstName;
		private String _lastName;
		private String _authorizedBy;
		private String _authorizedArea;
		private String _authorEmail;
		private Boolean _emailNotify;
		private DateTime _validFrom;
		private DateTime _validThru;
		private String _password;
		private String _special;
		private Byte[] _photo;
		private String _begin;
		private String _end;
		private Int32 _siteCode;
		private Int32 _encoded;
		private Boolean _scheduled;
		private DateTime _arrivedTime;
		private Int64 _turnstileAccess;
		private Boolean _badgePrinted;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _suite;
		private String _tenant;
		private Guid _bDBuildingPK;
		private String _address1;
		private Int32 _buildingID;

		#endregion

		#region Constructors
		public BDVisitorData()
		{
			this._bDVisitorPK = Guid.NewGuid();
			this._bDTenantPK = Guid.Empty;
			this._firstName = string.Empty;
			this._lastName = string.Empty;
			this._authorizedBy = string.Empty;
			this._authorizedArea = string.Empty;
			this._authorEmail = string.Empty;
			this._validFrom = DateTime.Now;
			this._validThru = DateTime.Now;
			this._password = string.Empty;
			this._special = string.Empty;
			this._begin = string.Empty;
			this._end = string.Empty;
			this._arrivedTime = DateTime.Now;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._suite = string.Empty;
			this._tenant = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public BDVisitorData(BDVisitorData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid BDVisitorPK
		{
			get
			{
				return this._bDVisitorPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDVisitorPK", value);
				if (this._bDVisitorPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDVisitorPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDVisitorPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDTenantPK
		{
			get
			{
				return this._bDTenantPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDTenantPK", value);
				if (this._bDTenantPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDTenantPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDTenantPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String FirstName
		{
			get
			{
				return this._firstName == null ? null : this._firstName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("FirstName", value);
				if (this._firstName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._firstName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnFirstNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String LastName
		{
			get
			{
				return this._lastName == null ? null : this._lastName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LastName", value);
				if (this._lastName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._lastName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLastNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String AuthorizedBy
		{
			get
			{
				return this._authorizedBy == null ? null : this._authorizedBy.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AuthorizedBy", value);
				if (this._authorizedBy != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._authorizedBy = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAuthorizedByChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String AuthorizedArea
		{
			get
			{
				return this._authorizedArea == null ? null : this._authorizedArea.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AuthorizedArea", value);
				if (this._authorizedArea != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._authorizedArea = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAuthorizedAreaChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String AuthorEmail
		{
			get
			{
				return this._authorEmail == null ? null : this._authorEmail.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AuthorEmail", value);
				if (this._authorEmail != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._authorEmail = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAuthorEmailChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean EmailNotify
		{
			get
			{
				return this._emailNotify;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("EmailNotify", value);
				if (this._emailNotify != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._emailNotify = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEmailNotifyChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime ValidFrom
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._validFrom.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ValidFrom", value);
				if (this._validFrom != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._validFrom = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnValidFromChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime ValidThru
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._validThru.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ValidThru", value);
				if (this._validThru != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._validThru = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnValidThruChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Password
		{
			get
			{
				return this._password == null ? null : this._password.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Password", value);
				if (this._password != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._password = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPasswordChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Special
		{
			get
			{
				return this._special == null ? null : this._special.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Special", value);
				if (this._special != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._special = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSpecialChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte[] Photo
		{
			get
			{
				return this._photo;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Photo", value);
				if (this._photo != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._photo = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPhotoChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Begin
		{
			get
			{
				return this._begin == null ? null : this._begin.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Begin", value);
				if (this._begin != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._begin = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBeginChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String End
		{
			get
			{
				return this._end == null ? null : this._end.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("End", value);
				if (this._end != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._end = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEndChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 SiteCode
		{
			get
			{
				return this._siteCode;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("SiteCode", value);
				if (this._siteCode != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._siteCode = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSiteCodeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 Encoded
		{
			get
			{
				return this._encoded;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Encoded", value);
				if (this._encoded != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._encoded = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEncodedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Scheduled
		{
			get
			{
				return this._scheduled;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Scheduled", value);
				if (this._scheduled != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._scheduled = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnScheduledChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime ArrivedTime
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._arrivedTime.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ArrivedTime", value);
				if (this._arrivedTime != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._arrivedTime = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnArrivedTimeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int64 TurnstileAccess
		{
			get
			{
				return this._turnstileAccess;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("TurnstileAccess", value);
				if (this._turnstileAccess != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._turnstileAccess = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnTurnstileAccessChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean BadgePrinted
		{
			get
			{
				return this._badgePrinted;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BadgePrinted", value);
				if (this._badgePrinted != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._badgePrinted = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBadgePrintedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String Suite
		{
			get
			{
				return this._suite == null ? null : this._suite.Trim();
			}
			set
			{
				 this._suite = value == null ? null : value.Trim();
			}
		}

		public virtual String Tenant
		{
			get
			{
				return this._tenant == null ? null : this._tenant.Trim();
			}
			set
			{
				 this._tenant = value == null ? null : value.Trim();
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "BDVisitor";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual BDTenantData BDTenant
		{
			get
			{
				BDTenantData parent = new BDTenantData();
				parent.BDTenantPK = this.BDTenantPK;
				parent.Suite = this.Suite;
				parent.Tenant = this.Tenant;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDTenantPK = value.BDTenantPK;
				this.Suite = value.Suite;
				this.Tenant = value.Tenant;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			BDVisitorData data = entity as BDVisitorData;
			if (data == null)
				return;

			this.BDTenantPK = data.BDTenantPK;
			this.FirstName = data.FirstName;
			this.LastName = data.LastName;
			this.AuthorizedBy = data.AuthorizedBy;
			this.AuthorizedArea = data.AuthorizedArea;
			this.AuthorEmail = data.AuthorEmail;
			this.EmailNotify = data.EmailNotify;
			this.ValidFrom = data.ValidFrom;
			this.ValidThru = data.ValidThru;
			this.Password = data.Password;
			this.Special = data.Special;
			this.Photo = data.Photo;
			this.Begin = data.Begin;
			this.End = data.End;
			this.SiteCode = data.SiteCode;
			this.Encoded = data.Encoded;
			this.Scheduled = data.Scheduled;
			this.ArrivedTime = data.ArrivedTime;
			this.TurnstileAccess = data.TurnstileAccess;
			this.BadgePrinted = data.BadgePrinted;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Suite = data.Suite;
			this.Tenant = data.Tenant;
			this.BDBuildingPK = data.BDBuildingPK;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.BDVisitorPK = data.BDVisitorPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as BDVisitorData));
		}

		private bool InternalEquals(BDVisitorData obj)
		{
			if (this.BDVisitorPK.CompareTo(obj.BDVisitorPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.BDVisitorPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("BDVisitor:");
			builder.AppendFormat("{0}|", this.BDVisitorPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler BDVisitorPKChanged;
		private void OnBDVisitorPKChanged(EventArgs e)
		{
			if ((this.BDVisitorPKChanged != null))
			{
				this.BDVisitorPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDTenantPKChanged;
		private void OnBDTenantPKChanged(EventArgs e)
		{
			if ((this.BDTenantPKChanged != null))
			{
				this.BDTenantPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler FirstNameChanged;
		private void OnFirstNameChanged(EventArgs e)
		{
			if ((this.FirstNameChanged != null))
			{
				this.FirstNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LastNameChanged;
		private void OnLastNameChanged(EventArgs e)
		{
			if ((this.LastNameChanged != null))
			{
				this.LastNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AuthorizedByChanged;
		private void OnAuthorizedByChanged(EventArgs e)
		{
			if ((this.AuthorizedByChanged != null))
			{
				this.AuthorizedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AuthorizedAreaChanged;
		private void OnAuthorizedAreaChanged(EventArgs e)
		{
			if ((this.AuthorizedAreaChanged != null))
			{
				this.AuthorizedAreaChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AuthorEmailChanged;
		private void OnAuthorEmailChanged(EventArgs e)
		{
			if ((this.AuthorEmailChanged != null))
			{
				this.AuthorEmailChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EmailNotifyChanged;
		private void OnEmailNotifyChanged(EventArgs e)
		{
			if ((this.EmailNotifyChanged != null))
			{
				this.EmailNotifyChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ValidFromChanged;
		private void OnValidFromChanged(EventArgs e)
		{
			if ((this.ValidFromChanged != null))
			{
				this.ValidFromChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ValidThruChanged;
		private void OnValidThruChanged(EventArgs e)
		{
			if ((this.ValidThruChanged != null))
			{
				this.ValidThruChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PasswordChanged;
		private void OnPasswordChanged(EventArgs e)
		{
			if ((this.PasswordChanged != null))
			{
				this.PasswordChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SpecialChanged;
		private void OnSpecialChanged(EventArgs e)
		{
			if ((this.SpecialChanged != null))
			{
				this.SpecialChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PhotoChanged;
		private void OnPhotoChanged(EventArgs e)
		{
			if ((this.PhotoChanged != null))
			{
				this.PhotoChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BeginChanged;
		private void OnBeginChanged(EventArgs e)
		{
			if ((this.BeginChanged != null))
			{
				this.BeginChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EndChanged;
		private void OnEndChanged(EventArgs e)
		{
			if ((this.EndChanged != null))
			{
				this.EndChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SiteCodeChanged;
		private void OnSiteCodeChanged(EventArgs e)
		{
			if ((this.SiteCodeChanged != null))
			{
				this.SiteCodeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EncodedChanged;
		private void OnEncodedChanged(EventArgs e)
		{
			if ((this.EncodedChanged != null))
			{
				this.EncodedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ScheduledChanged;
		private void OnScheduledChanged(EventArgs e)
		{
			if ((this.ScheduledChanged != null))
			{
				this.ScheduledChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ArrivedTimeChanged;
		private void OnArrivedTimeChanged(EventArgs e)
		{
			if ((this.ArrivedTimeChanged != null))
			{
				this.ArrivedTimeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler TurnstileAccessChanged;
		private void OnTurnstileAccessChanged(EventArgs e)
		{
			if ((this.TurnstileAccessChanged != null))
			{
				this.TurnstileAccessChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BadgePrintedChanged;
		private void OnBadgePrintedChanged(EventArgs e)
		{
			if ((this.BadgePrintedChanged != null))
			{
				this.BadgePrintedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class UsrGroupDBRuleData : BusinessBase
	{
		#region Fields
		private Guid _usrGroupDBRulePK;
		private Guid _usrGroupPK;
		private Int32 _dBRuleID;
		private Boolean _selectable;
		private Boolean _insertable;
		private Boolean _editable;
		private Boolean _deletable;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _usrGroupName;

		#endregion

		#region Constructors
		public UsrGroupDBRuleData()
		{
			this._usrGroupDBRulePK = Guid.NewGuid();
			this._usrGroupPK = Guid.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._usrGroupName = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public UsrGroupDBRuleData(UsrGroupDBRuleData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid UsrGroupDBRulePK
		{
			get
			{
				return this._usrGroupDBRulePK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrGroupDBRulePK", value);
				if (this._usrGroupDBRulePK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrGroupDBRulePK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrGroupDBRulePKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid UsrGroupPK
		{
			get
			{
				return this._usrGroupPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrGroupPK", value);
				if (this._usrGroupPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrGroupPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrGroupPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 DBRuleID
		{
			get
			{
				return this._dBRuleID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("DBRuleID", value);
				if (this._dBRuleID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._dBRuleID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDBRuleIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Selectable
		{
			get
			{
				return this._selectable;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Selectable", value);
				if (this._selectable != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._selectable = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSelectableChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Insertable
		{
			get
			{
				return this._insertable;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Insertable", value);
				if (this._insertable != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._insertable = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnInsertableChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Editable
		{
			get
			{
				return this._editable;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Editable", value);
				if (this._editable != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._editable = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEditableChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Deletable
		{
			get
			{
				return this._deletable;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Deletable", value);
				if (this._deletable != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._deletable = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDeletableChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String UsrGroupName
		{
			get
			{
				return this._usrGroupName == null ? null : this._usrGroupName.Trim();
			}
			set
			{
				 this._usrGroupName = value == null ? null : value.Trim();
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "UsrGroupDBRule";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual UsrGroupData UsrGroup
		{
			get
			{
				UsrGroupData parent = new UsrGroupData();
				parent.UsrGroupPK = this.UsrGroupPK;
				parent.UsrGroupName = this.UsrGroupName;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UsrGroupPK = value.UsrGroupPK;
				this.UsrGroupName = value.UsrGroupName;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			UsrGroupDBRuleData data = entity as UsrGroupDBRuleData;
			if (data == null)
				return;

			this.UsrGroupPK = data.UsrGroupPK;
			this.DBRuleID = data.DBRuleID;
			this.Selectable = data.Selectable;
			this.Insertable = data.Insertable;
			this.Editable = data.Editable;
			this.Deletable = data.Deletable;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.UsrGroupName = data.UsrGroupName;
			if (all)
			{
				this.UsrGroupDBRulePK = data.UsrGroupDBRulePK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as UsrGroupDBRuleData));
		}

		private bool InternalEquals(UsrGroupDBRuleData obj)
		{
			if (this.UsrGroupDBRulePK.CompareTo(obj.UsrGroupDBRulePK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.UsrGroupDBRulePK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("UsrGroupDBRule:");
			builder.AppendFormat("{0}|", this.UsrGroupDBRulePK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrGroupDBRulePKChanged;
		private void OnUsrGroupDBRulePKChanged(EventArgs e)
		{
			if ((this.UsrGroupDBRulePKChanged != null))
			{
				this.UsrGroupDBRulePKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrGroupPKChanged;
		private void OnUsrGroupPKChanged(EventArgs e)
		{
			if ((this.UsrGroupPKChanged != null))
			{
				this.UsrGroupPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DBRuleIDChanged;
		private void OnDBRuleIDChanged(EventArgs e)
		{
			if ((this.DBRuleIDChanged != null))
			{
				this.DBRuleIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SelectableChanged;
		private void OnSelectableChanged(EventArgs e)
		{
			if ((this.SelectableChanged != null))
			{
				this.SelectableChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler InsertableChanged;
		private void OnInsertableChanged(EventArgs e)
		{
			if ((this.InsertableChanged != null))
			{
				this.InsertableChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EditableChanged;
		private void OnEditableChanged(EventArgs e)
		{
			if ((this.EditableChanged != null))
			{
				this.EditableChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DeletableChanged;
		private void OnDeletableChanged(EventArgs e)
		{
			if ((this.DeletableChanged != null))
			{
				this.DeletableChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACPanelData : BusinessBase
	{
		#region Fields
		private Guid _aCPanelPK;
		private Int32 _unitID;
		private Guid _bDBuildingPK;
		private String _serialNumber;
		private String _panelName;
		private Int16 _bufferSize;
		private Boolean _dialUp;
		private String _unitPhone;
		private String _unitPhoneCallerID;
		private String _unitExt;
		private Boolean _longDistance;
		private String _modemInitString;
		private Int32 _baudRate;
		private String _historyPhone;
		private String _alarmPhone1;
		private String _alarmPhone2;
		private String _dialingPrefixPanel;
		private String _dialingSuffixPanel;
		private Boolean _dialOutEnabled;
		private Boolean _dayLightSaving;
		private Boolean _onSiteMonitor;
		private Byte _centralDelay;
		private Byte _elevPulse;
		private Int32 _panelTypeID;
		private Int16 _unbufferTC;
		private Int16 _mandatoryUnbufferTC;
		private Int16 _swingerCount;
		private Int16 _swingerTime;
		private Byte _loopNumb;
		private Byte _portNumb;
		private String _notes;
		private Boolean _trouble;
		private Boolean _noVersionCheck;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private Guid _deviceId;
		private Int32 _dBSyncSeconds;
		private Int32 _dBSaveMinutes;
		private Boolean _isE150;
		private Byte _groupID;
		private Boolean _noAutoDownload;
		private DateTime _noAutoDownloadStart;
		private Boolean _locked;
		private Boolean _inDebug;
		private String _address1;
		private Int32 _buildingID;

		private ACInputDataCollection _aCInputList;
		private ACSupervisoryDataCollection _aCSupervisoryList;
		private ACPanelHolidayMapDataCollection _aCPanelHolidayMapList;
		private ACMainZoneDataCollection _aCMainZoneList;
		private ACPanelFunctionCardMapDataCollection _aCPanelFunctionCardMapList;
		private ACOutputGroupDataCollection _aCOutputGroupList;
		private ACInputGroupDataCollection _aCInputGroupList;
		#endregion

		#region Constructors
		public ACPanelData()
		{
			this._aCPanelPK = Guid.NewGuid();
			this._bDBuildingPK = Guid.Empty;
			this._serialNumber = string.Empty;
			this._panelName = string.Empty;
			this._unitPhone = string.Empty;
			this._unitPhoneCallerID = string.Empty;
			this._unitExt = string.Empty;
			this._modemInitString = string.Empty;
			this._historyPhone = string.Empty;
			this._alarmPhone1 = string.Empty;
			this._alarmPhone2 = string.Empty;
			this._dialingPrefixPanel = string.Empty;
			this._dialingSuffixPanel = string.Empty;
			this._notes = string.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._deviceId = Guid.Empty;
			this._noAutoDownloadStart = DateTime.Now;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACPanelData(ACPanelData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACPanelPK
		{
			get
			{
				return this._aCPanelPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACPanelPK", value);
				if (this._aCPanelPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCPanelPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACPanelPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 UnitID
		{
			get
			{
				return this._unitID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UnitID", value);
				if (this._unitID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._unitID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUnitIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDBuildingPK", value);
				if (this._bDBuildingPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDBuildingPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDBuildingPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String SerialNumber
		{
			get
			{
				return this._serialNumber == null ? null : this._serialNumber.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("SerialNumber", value);
				if (this._serialNumber != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._serialNumber = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSerialNumberChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String PanelName
		{
			get
			{
				return this._panelName == null ? null : this._panelName.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("PanelName", value);
				if (this._panelName != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._panelName = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPanelNameChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 BufferSize
		{
			get
			{
				return this._bufferSize;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BufferSize", value);
				if (this._bufferSize != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bufferSize = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBufferSizeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean DialUp
		{
			get
			{
				return this._dialUp;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("DialUp", value);
				if (this._dialUp != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._dialUp = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDialUpChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String UnitPhone
		{
			get
			{
				return this._unitPhone == null ? null : this._unitPhone.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UnitPhone", value);
				if (this._unitPhone != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._unitPhone = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUnitPhoneChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String UnitPhoneCallerID
		{
			get
			{
				return this._unitPhoneCallerID == null ? null : this._unitPhoneCallerID.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UnitPhoneCallerID", value);
				if (this._unitPhoneCallerID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._unitPhoneCallerID = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUnitPhoneCallerIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String UnitExt
		{
			get
			{
				return this._unitExt == null ? null : this._unitExt.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UnitExt", value);
				if (this._unitExt != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._unitExt = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUnitExtChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean LongDistance
		{
			get
			{
				return this._longDistance;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LongDistance", value);
				if (this._longDistance != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._longDistance = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLongDistanceChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String ModemInitString
		{
			get
			{
				return this._modemInitString == null ? null : this._modemInitString.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ModemInitString", value);
				if (this._modemInitString != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._modemInitString = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnModemInitStringChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 BaudRate
		{
			get
			{
				return this._baudRate;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BaudRate", value);
				if (this._baudRate != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._baudRate = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBaudRateChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String HistoryPhone
		{
			get
			{
				return this._historyPhone == null ? null : this._historyPhone.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("HistoryPhone", value);
				if (this._historyPhone != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._historyPhone = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnHistoryPhoneChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String AlarmPhone1
		{
			get
			{
				return this._alarmPhone1 == null ? null : this._alarmPhone1.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AlarmPhone1", value);
				if (this._alarmPhone1 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._alarmPhone1 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAlarmPhone1Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String AlarmPhone2
		{
			get
			{
				return this._alarmPhone2 == null ? null : this._alarmPhone2.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("AlarmPhone2", value);
				if (this._alarmPhone2 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._alarmPhone2 = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnAlarmPhone2Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String DialingPrefixPanel
		{
			get
			{
				return this._dialingPrefixPanel == null ? null : this._dialingPrefixPanel.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("DialingPrefixPanel", value);
				if (this._dialingPrefixPanel != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._dialingPrefixPanel = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDialingPrefixPanelChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String DialingSuffixPanel
		{
			get
			{
				return this._dialingSuffixPanel == null ? null : this._dialingSuffixPanel.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("DialingSuffixPanel", value);
				if (this._dialingSuffixPanel != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._dialingSuffixPanel = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDialingSuffixPanelChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean DialOutEnabled
		{
			get
			{
				return this._dialOutEnabled;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("DialOutEnabled", value);
				if (this._dialOutEnabled != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._dialOutEnabled = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDialOutEnabledChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean DayLightSaving
		{
			get
			{
				return this._dayLightSaving;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("DayLightSaving", value);
				if (this._dayLightSaving != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._dayLightSaving = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDayLightSavingChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean OnSiteMonitor
		{
			get
			{
				return this._onSiteMonitor;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("OnSiteMonitor", value);
				if (this._onSiteMonitor != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._onSiteMonitor = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnOnSiteMonitorChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte CentralDelay
		{
			get
			{
				return this._centralDelay;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("CentralDelay", value);
				if (this._centralDelay != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._centralDelay = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnCentralDelayChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte ElevPulse
		{
			get
			{
				return this._elevPulse;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ElevPulse", value);
				if (this._elevPulse != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._elevPulse = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnElevPulseChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 PanelTypeID
		{
			get
			{
				return this._panelTypeID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("PanelTypeID", value);
				if (this._panelTypeID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._panelTypeID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPanelTypeIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 UnbufferTC
		{
			get
			{
				return this._unbufferTC;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UnbufferTC", value);
				if (this._unbufferTC != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._unbufferTC = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUnbufferTCChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 MandatoryUnbufferTC
		{
			get
			{
				return this._mandatoryUnbufferTC;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("MandatoryUnbufferTC", value);
				if (this._mandatoryUnbufferTC != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._mandatoryUnbufferTC = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnMandatoryUnbufferTCChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 SwingerCount
		{
			get
			{
				return this._swingerCount;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("SwingerCount", value);
				if (this._swingerCount != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._swingerCount = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSwingerCountChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int16 SwingerTime
		{
			get
			{
				return this._swingerTime;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("SwingerTime", value);
				if (this._swingerTime != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._swingerTime = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSwingerTimeChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte LoopNumb
		{
			get
			{
				return this._loopNumb;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("LoopNumb", value);
				if (this._loopNumb != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._loopNumb = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLoopNumbChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte PortNumb
		{
			get
			{
				return this._portNumb;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("PortNumb", value);
				if (this._portNumb != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._portNumb = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnPortNumbChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Notes
		{
			get
			{
				return this._notes == null ? null : this._notes.Trim();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Notes", value);
				if (this._notes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._notes = value == null ? null : value.Trim();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNotesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Trouble
		{
			get
			{
				return this._trouble;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Trouble", value);
				if (this._trouble != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._trouble = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnTroubleChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean NoVersionCheck
		{
			get
			{
				return this._noVersionCheck;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("NoVersionCheck", value);
				if (this._noVersionCheck != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._noVersionCheck = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNoVersionCheckChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual Guid DeviceId
		{
			get
			{
				return this._deviceId;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("DeviceId", value);
				if (this._deviceId != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._deviceId = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDeviceIdChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 DBSyncSeconds
		{
			get
			{
				return this._dBSyncSeconds;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("DBSyncSeconds", value);
				if (this._dBSyncSeconds != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._dBSyncSeconds = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDBSyncSecondsChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 DBSaveMinutes
		{
			get
			{
				return this._dBSaveMinutes;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("DBSaveMinutes", value);
				if (this._dBSaveMinutes != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._dBSaveMinutes = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDBSaveMinutesChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean IsE150
		{
			get
			{
				return this._isE150;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("IsE150", value);
				if (this._isE150 != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._isE150 = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnIsE150Changed(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Byte GroupID
		{
			get
			{
				return this._groupID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("GroupID", value);
				if (this._groupID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._groupID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnGroupIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean NoAutoDownload
		{
			get
			{
				return this._noAutoDownload;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("NoAutoDownload", value);
				if (this._noAutoDownload != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._noAutoDownload = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNoAutoDownloadChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual DateTime NoAutoDownloadStart
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._noAutoDownloadStart.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("NoAutoDownloadStart", value);
				if (this._noAutoDownloadStart != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._noAutoDownloadStart = value.ToUniversalTime();
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnNoAutoDownloadStartChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Locked
		{
			get
			{
				return this._locked;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Locked", value);
				if (this._locked != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._locked = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnLockedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean InDebug
		{
			get
			{
				return this._inDebug;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("InDebug", value);
				if (this._inDebug != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._inDebug = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnInDebugChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACPanel";
			}
		}
		#endregion

		#region Children
		public virtual ACInputDataCollection ACInputList
		{
			get
			{
				return this._aCInputList;
			}
			set
			{
				this._aCInputList = value;
			}
		}

		public virtual ACSupervisoryDataCollection ACSupervisoryList
		{
			get
			{
				return this._aCSupervisoryList;
			}
			set
			{
				this._aCSupervisoryList = value;
			}
		}

		public virtual ACPanelHolidayMapDataCollection ACPanelHolidayMapList
		{
			get
			{
				return this._aCPanelHolidayMapList;
			}
			set
			{
				this._aCPanelHolidayMapList = value;
			}
		}

		public virtual ACMainZoneDataCollection ACMainZoneList
		{
			get
			{
				return this._aCMainZoneList;
			}
			set
			{
				this._aCMainZoneList = value;
			}
		}

		public virtual ACPanelFunctionCardMapDataCollection ACPanelFunctionCardMapList
		{
			get
			{
				return this._aCPanelFunctionCardMapList;
			}
			set
			{
				this._aCPanelFunctionCardMapList = value;
			}
		}

		public virtual ACOutputGroupDataCollection ACOutputGroupList
		{
			get
			{
				return this._aCOutputGroupList;
			}
			set
			{
				this._aCOutputGroupList = value;
			}
		}

		public virtual ACInputGroupDataCollection ACInputGroupList
		{
			get
			{
				return this._aCInputGroupList;
			}
			set
			{
				this._aCInputGroupList = value;
			}
		}

		#endregion

		#region Parents
		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACPanelData data = entity as ACPanelData;
			if (data == null)
				return;

			this.UnitID = data.UnitID;
			this.BDBuildingPK = data.BDBuildingPK;
			this.SerialNumber = data.SerialNumber;
			this.PanelName = data.PanelName;
			this.BufferSize = data.BufferSize;
			this.DialUp = data.DialUp;
			this.UnitPhone = data.UnitPhone;
			this.UnitPhoneCallerID = data.UnitPhoneCallerID;
			this.UnitExt = data.UnitExt;
			this.LongDistance = data.LongDistance;
			this.ModemInitString = data.ModemInitString;
			this.BaudRate = data.BaudRate;
			this.HistoryPhone = data.HistoryPhone;
			this.AlarmPhone1 = data.AlarmPhone1;
			this.AlarmPhone2 = data.AlarmPhone2;
			this.DialingPrefixPanel = data.DialingPrefixPanel;
			this.DialingSuffixPanel = data.DialingSuffixPanel;
			this.DialOutEnabled = data.DialOutEnabled;
			this.DayLightSaving = data.DayLightSaving;
			this.OnSiteMonitor = data.OnSiteMonitor;
			this.CentralDelay = data.CentralDelay;
			this.ElevPulse = data.ElevPulse;
			this.PanelTypeID = data.PanelTypeID;
			this.UnbufferTC = data.UnbufferTC;
			this.MandatoryUnbufferTC = data.MandatoryUnbufferTC;
			this.SwingerCount = data.SwingerCount;
			this.SwingerTime = data.SwingerTime;
			this.LoopNumb = data.LoopNumb;
			this.PortNumb = data.PortNumb;
			this.Notes = data.Notes;
			this.Trouble = data.Trouble;
			this.NoVersionCheck = data.NoVersionCheck;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.DeviceId = data.DeviceId;
			this.DBSyncSeconds = data.DBSyncSeconds;
			this.DBSaveMinutes = data.DBSaveMinutes;
			this.IsE150 = data.IsE150;
			this.GroupID = data.GroupID;
			this.NoAutoDownload = data.NoAutoDownload;
			this.NoAutoDownloadStart = data.NoAutoDownloadStart;
			this.Locked = data.Locked;
			this.InDebug = data.InDebug;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.ACPanelPK = data.ACPanelPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		protected override void CloneChildren(BusinessBase entity)
		{
			ACPanelData data = entity as ACPanelData;
			if (data == null)
				return;

			if (data.ACInputList != null)
			{
				this.ACInputList = new ACInputDataCollection(data.ACInputList);
			}
			if (data.ACSupervisoryList != null)
			{
				this.ACSupervisoryList = new ACSupervisoryDataCollection(data.ACSupervisoryList);
			}
			if (data.ACPanelHolidayMapList != null)
			{
				this.ACPanelHolidayMapList = new ACPanelHolidayMapDataCollection(data.ACPanelHolidayMapList);
			}
			if (data.ACMainZoneList != null)
			{
				this.ACMainZoneList = new ACMainZoneDataCollection(data.ACMainZoneList);
			}
			if (data.ACPanelFunctionCardMapList != null)
			{
				this.ACPanelFunctionCardMapList = new ACPanelFunctionCardMapDataCollection(data.ACPanelFunctionCardMapList);
			}
			if (data.ACOutputGroupList != null)
			{
				this.ACOutputGroupList = new ACOutputGroupDataCollection(data.ACOutputGroupList);
			}
			if (data.ACInputGroupList != null)
			{
				this.ACInputGroupList = new ACInputGroupDataCollection(data.ACInputGroupList);
			}
		}

		public override void AcceptChanges()
		{
			base.AcceptChanges();

			if (this.ACInputList != null)
			{
				this.ACInputList.AcceptChanges();
			}
			if (this.ACSupervisoryList != null)
			{
				this.ACSupervisoryList.AcceptChanges();
			}
			if (this.ACPanelHolidayMapList != null)
			{
				this.ACPanelHolidayMapList.AcceptChanges();
			}
			if (this.ACMainZoneList != null)
			{
				this.ACMainZoneList.AcceptChanges();
			}
			if (this.ACPanelFunctionCardMapList != null)
			{
				this.ACPanelFunctionCardMapList.AcceptChanges();
			}
			if (this.ACOutputGroupList != null)
			{
				this.ACOutputGroupList.AcceptChanges();
			}
			if (this.ACInputGroupList != null)
			{
				this.ACInputGroupList.AcceptChanges();
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACPanelData));
		}

		private bool InternalEquals(ACPanelData obj)
		{
			if (this.ACPanelPK.CompareTo(obj.ACPanelPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACPanelPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACPanel:");
			builder.AppendFormat("{0}|", this.ACPanelPK);
			return builder.ToString().TrimEnd('|');
		}

		public override bool IsDirty
		{
			get
			{
				if(base.IsDirty)
					return true;

				if (this.ACInputList != null && this.ACInputList.IsDirty)
				{
					return true;
				}
				if (this.ACSupervisoryList != null && this.ACSupervisoryList.IsDirty)
				{
					return true;
				}
				if (this.ACPanelHolidayMapList != null && this.ACPanelHolidayMapList.IsDirty)
				{
					return true;
				}
				if (this.ACMainZoneList != null && this.ACMainZoneList.IsDirty)
				{
					return true;
				}
				if (this.ACPanelFunctionCardMapList != null && this.ACPanelFunctionCardMapList.IsDirty)
				{
					return true;
				}
				if (this.ACOutputGroupList != null && this.ACOutputGroupList.IsDirty)
				{
					return true;
				}
				if (this.ACInputGroupList != null && this.ACInputGroupList.IsDirty)
				{
					return true;
				}

				return false;
			}
		}

		public override bool IsValid
		{
			get
			{
				if(!base.IsValid)
					return false;

				if (this.ACInputList != null && !this.ACInputList.IsValid)
				{
					return false;
				}
				if (this.ACSupervisoryList != null && !this.ACSupervisoryList.IsValid)
				{
					return false;
				}
				if (this.ACPanelHolidayMapList != null && !this.ACPanelHolidayMapList.IsValid)
				{
					return false;
				}
				if (this.ACMainZoneList != null && !this.ACMainZoneList.IsValid)
				{
					return false;
				}
				if (this.ACPanelFunctionCardMapList != null && !this.ACPanelFunctionCardMapList.IsValid)
				{
					return false;
				}
				if (this.ACOutputGroupList != null && !this.ACOutputGroupList.IsValid)
				{
					return false;
				}
				if (this.ACInputGroupList != null && !this.ACInputGroupList.IsValid)
				{
					return false;
				}

				return true;
			}
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACPanelPKChanged;
		private void OnACPanelPKChanged(EventArgs e)
		{
			if ((this.ACPanelPKChanged != null))
			{
				this.ACPanelPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UnitIDChanged;
		private void OnUnitIDChanged(EventArgs e)
		{
			if ((this.UnitIDChanged != null))
			{
				this.UnitIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDBuildingPKChanged;
		private void OnBDBuildingPKChanged(EventArgs e)
		{
			if ((this.BDBuildingPKChanged != null))
			{
				this.BDBuildingPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SerialNumberChanged;
		private void OnSerialNumberChanged(EventArgs e)
		{
			if ((this.SerialNumberChanged != null))
			{
				this.SerialNumberChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PanelNameChanged;
		private void OnPanelNameChanged(EventArgs e)
		{
			if ((this.PanelNameChanged != null))
			{
				this.PanelNameChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BufferSizeChanged;
		private void OnBufferSizeChanged(EventArgs e)
		{
			if ((this.BufferSizeChanged != null))
			{
				this.BufferSizeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DialUpChanged;
		private void OnDialUpChanged(EventArgs e)
		{
			if ((this.DialUpChanged != null))
			{
				this.DialUpChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UnitPhoneChanged;
		private void OnUnitPhoneChanged(EventArgs e)
		{
			if ((this.UnitPhoneChanged != null))
			{
				this.UnitPhoneChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UnitPhoneCallerIDChanged;
		private void OnUnitPhoneCallerIDChanged(EventArgs e)
		{
			if ((this.UnitPhoneCallerIDChanged != null))
			{
				this.UnitPhoneCallerIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UnitExtChanged;
		private void OnUnitExtChanged(EventArgs e)
		{
			if ((this.UnitExtChanged != null))
			{
				this.UnitExtChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LongDistanceChanged;
		private void OnLongDistanceChanged(EventArgs e)
		{
			if ((this.LongDistanceChanged != null))
			{
				this.LongDistanceChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModemInitStringChanged;
		private void OnModemInitStringChanged(EventArgs e)
		{
			if ((this.ModemInitStringChanged != null))
			{
				this.ModemInitStringChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BaudRateChanged;
		private void OnBaudRateChanged(EventArgs e)
		{
			if ((this.BaudRateChanged != null))
			{
				this.BaudRateChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler HistoryPhoneChanged;
		private void OnHistoryPhoneChanged(EventArgs e)
		{
			if ((this.HistoryPhoneChanged != null))
			{
				this.HistoryPhoneChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AlarmPhone1Changed;
		private void OnAlarmPhone1Changed(EventArgs e)
		{
			if ((this.AlarmPhone1Changed != null))
			{
				this.AlarmPhone1Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler AlarmPhone2Changed;
		private void OnAlarmPhone2Changed(EventArgs e)
		{
			if ((this.AlarmPhone2Changed != null))
			{
				this.AlarmPhone2Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DialingPrefixPanelChanged;
		private void OnDialingPrefixPanelChanged(EventArgs e)
		{
			if ((this.DialingPrefixPanelChanged != null))
			{
				this.DialingPrefixPanelChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DialingSuffixPanelChanged;
		private void OnDialingSuffixPanelChanged(EventArgs e)
		{
			if ((this.DialingSuffixPanelChanged != null))
			{
				this.DialingSuffixPanelChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DialOutEnabledChanged;
		private void OnDialOutEnabledChanged(EventArgs e)
		{
			if ((this.DialOutEnabledChanged != null))
			{
				this.DialOutEnabledChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DayLightSavingChanged;
		private void OnDayLightSavingChanged(EventArgs e)
		{
			if ((this.DayLightSavingChanged != null))
			{
				this.DayLightSavingChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler OnSiteMonitorChanged;
		private void OnOnSiteMonitorChanged(EventArgs e)
		{
			if ((this.OnSiteMonitorChanged != null))
			{
				this.OnSiteMonitorChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CentralDelayChanged;
		private void OnCentralDelayChanged(EventArgs e)
		{
			if ((this.CentralDelayChanged != null))
			{
				this.CentralDelayChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ElevPulseChanged;
		private void OnElevPulseChanged(EventArgs e)
		{
			if ((this.ElevPulseChanged != null))
			{
				this.ElevPulseChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PanelTypeIDChanged;
		private void OnPanelTypeIDChanged(EventArgs e)
		{
			if ((this.PanelTypeIDChanged != null))
			{
				this.PanelTypeIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UnbufferTCChanged;
		private void OnUnbufferTCChanged(EventArgs e)
		{
			if ((this.UnbufferTCChanged != null))
			{
				this.UnbufferTCChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler MandatoryUnbufferTCChanged;
		private void OnMandatoryUnbufferTCChanged(EventArgs e)
		{
			if ((this.MandatoryUnbufferTCChanged != null))
			{
				this.MandatoryUnbufferTCChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SwingerCountChanged;
		private void OnSwingerCountChanged(EventArgs e)
		{
			if ((this.SwingerCountChanged != null))
			{
				this.SwingerCountChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SwingerTimeChanged;
		private void OnSwingerTimeChanged(EventArgs e)
		{
			if ((this.SwingerTimeChanged != null))
			{
				this.SwingerTimeChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LoopNumbChanged;
		private void OnLoopNumbChanged(EventArgs e)
		{
			if ((this.LoopNumbChanged != null))
			{
				this.LoopNumbChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler PortNumbChanged;
		private void OnPortNumbChanged(EventArgs e)
		{
			if ((this.PortNumbChanged != null))
			{
				this.PortNumbChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NotesChanged;
		private void OnNotesChanged(EventArgs e)
		{
			if ((this.NotesChanged != null))
			{
				this.NotesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler TroubleChanged;
		private void OnTroubleChanged(EventArgs e)
		{
			if ((this.TroubleChanged != null))
			{
				this.TroubleChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NoVersionCheckChanged;
		private void OnNoVersionCheckChanged(EventArgs e)
		{
			if ((this.NoVersionCheckChanged != null))
			{
				this.NoVersionCheckChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DeviceIdChanged;
		private void OnDeviceIdChanged(EventArgs e)
		{
			if ((this.DeviceIdChanged != null))
			{
				this.DeviceIdChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DBSyncSecondsChanged;
		private void OnDBSyncSecondsChanged(EventArgs e)
		{
			if ((this.DBSyncSecondsChanged != null))
			{
				this.DBSyncSecondsChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DBSaveMinutesChanged;
		private void OnDBSaveMinutesChanged(EventArgs e)
		{
			if ((this.DBSaveMinutesChanged != null))
			{
				this.DBSaveMinutesChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler IsE150Changed;
		private void OnIsE150Changed(EventArgs e)
		{
			if ((this.IsE150Changed != null))
			{
				this.IsE150Changed(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler GroupIDChanged;
		private void OnGroupIDChanged(EventArgs e)
		{
			if ((this.GroupIDChanged != null))
			{
				this.GroupIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NoAutoDownloadChanged;
		private void OnNoAutoDownloadChanged(EventArgs e)
		{
			if ((this.NoAutoDownloadChanged != null))
			{
				this.NoAutoDownloadChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler NoAutoDownloadStartChanged;
		private void OnNoAutoDownloadStartChanged(EventArgs e)
		{
			if ((this.NoAutoDownloadStartChanged != null))
			{
				this.NoAutoDownloadStartChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler LockedChanged;
		private void OnLockedChanged(EventArgs e)
		{
			if ((this.LockedChanged != null))
			{
				this.LockedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler InDebugChanged;
		private void OnInDebugChanged(EventArgs e)
		{
			if ((this.InDebugChanged != null))
			{
				this.InDebugChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class UsrAccountDBRuleData : BusinessBase
	{
		#region Fields
		private Guid _usrAccountDBRulePK;
		private Guid _usrAccountPK;
		private Int32 _dBRuleID;
		private Boolean _selectable;
		private Boolean _insertable;
		private Boolean _editable;
		private Boolean _deletable;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _userID;

		#endregion

		#region Constructors
		public UsrAccountDBRuleData()
		{
			this._usrAccountDBRulePK = Guid.NewGuid();
			this._usrAccountPK = Guid.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._userID = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public UsrAccountDBRuleData(UsrAccountDBRuleData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid UsrAccountDBRulePK
		{
			get
			{
				return this._usrAccountDBRulePK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrAccountDBRulePK", value);
				if (this._usrAccountDBRulePK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrAccountDBRulePK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrAccountDBRulePKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid UsrAccountPK
		{
			get
			{
				return this._usrAccountPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrAccountPK", value);
				if (this._usrAccountPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrAccountPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrAccountPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 DBRuleID
		{
			get
			{
				return this._dBRuleID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("DBRuleID", value);
				if (this._dBRuleID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._dBRuleID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDBRuleIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Selectable
		{
			get
			{
				return this._selectable;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Selectable", value);
				if (this._selectable != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._selectable = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnSelectableChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Insertable
		{
			get
			{
				return this._insertable;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Insertable", value);
				if (this._insertable != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._insertable = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnInsertableChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Editable
		{
			get
			{
				return this._editable;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Editable", value);
				if (this._editable != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._editable = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnEditableChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Deletable
		{
			get
			{
				return this._deletable;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Deletable", value);
				if (this._deletable != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._deletable = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDeletableChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String UserID
		{
			get
			{
				return this._userID == null ? null : this._userID.Trim();
			}
			set
			{
				 this._userID = value == null ? null : value.Trim();
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "UsrAccountDBRule";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual UsrAccountData UsrAccount
		{
			get
			{
				UsrAccountData parent = new UsrAccountData();
				parent.UsrAccountPK = this.UsrAccountPK;
				parent.UserID = this.UserID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UsrAccountPK = value.UsrAccountPK;
				this.UserID = value.UserID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			UsrAccountDBRuleData data = entity as UsrAccountDBRuleData;
			if (data == null)
				return;

			this.UsrAccountPK = data.UsrAccountPK;
			this.DBRuleID = data.DBRuleID;
			this.Selectable = data.Selectable;
			this.Insertable = data.Insertable;
			this.Editable = data.Editable;
			this.Deletable = data.Deletable;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.UserID = data.UserID;
			if (all)
			{
				this.UsrAccountDBRulePK = data.UsrAccountDBRulePK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as UsrAccountDBRuleData));
		}

		private bool InternalEquals(UsrAccountDBRuleData obj)
		{
			if (this.UsrAccountDBRulePK.CompareTo(obj.UsrAccountDBRulePK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.UsrAccountDBRulePK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("UsrAccountDBRule:");
			builder.AppendFormat("{0}|", this.UsrAccountDBRulePK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrAccountDBRulePKChanged;
		private void OnUsrAccountDBRulePKChanged(EventArgs e)
		{
			if ((this.UsrAccountDBRulePKChanged != null))
			{
				this.UsrAccountDBRulePKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrAccountPKChanged;
		private void OnUsrAccountPKChanged(EventArgs e)
		{
			if ((this.UsrAccountPKChanged != null))
			{
				this.UsrAccountPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DBRuleIDChanged;
		private void OnDBRuleIDChanged(EventArgs e)
		{
			if ((this.DBRuleIDChanged != null))
			{
				this.DBRuleIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler SelectableChanged;
		private void OnSelectableChanged(EventArgs e)
		{
			if ((this.SelectableChanged != null))
			{
				this.SelectableChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler InsertableChanged;
		private void OnInsertableChanged(EventArgs e)
		{
			if ((this.InsertableChanged != null))
			{
				this.InsertableChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler EditableChanged;
		private void OnEditableChanged(EventArgs e)
		{
			if ((this.EditableChanged != null))
			{
				this.EditableChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DeletableChanged;
		private void OnDeletableChanged(EventArgs e)
		{
			if ((this.DeletableChanged != null))
			{
				this.DeletableChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class UsrGroupBRRuleData : BusinessBase
	{
		#region Fields
		private Guid _usrGroupBRRule;
		private Guid _usrGroupPK;
		private Int32 _bRRuleID;
		private Boolean _denied;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _usrGroupName;

		#endregion

		#region Constructors
		public UsrGroupBRRuleData()
		{
			this._usrGroupBRRule = Guid.NewGuid();
			this._usrGroupPK = Guid.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._usrGroupName = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public UsrGroupBRRuleData(UsrGroupBRRuleData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid UsrGroupBRRule
		{
			get
			{
				return this._usrGroupBRRule;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrGroupBRRule", value);
				if (this._usrGroupBRRule != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrGroupBRRule = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrGroupBRRuleChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid UsrGroupPK
		{
			get
			{
				return this._usrGroupPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrGroupPK", value);
				if (this._usrGroupPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrGroupPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrGroupPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 BRRuleID
		{
			get
			{
				return this._bRRuleID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BRRuleID", value);
				if (this._bRRuleID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bRRuleID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBRRuleIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Denied
		{
			get
			{
				return this._denied;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Denied", value);
				if (this._denied != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._denied = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDeniedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String UsrGroupName
		{
			get
			{
				return this._usrGroupName == null ? null : this._usrGroupName.Trim();
			}
			set
			{
				 this._usrGroupName = value == null ? null : value.Trim();
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "UsrGroupBRRule";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual UsrGroupData UsrGroup
		{
			get
			{
				UsrGroupData parent = new UsrGroupData();
				parent.UsrGroupPK = this.UsrGroupPK;
				parent.UsrGroupName = this.UsrGroupName;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UsrGroupPK = value.UsrGroupPK;
				this.UsrGroupName = value.UsrGroupName;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			UsrGroupBRRuleData data = entity as UsrGroupBRRuleData;
			if (data == null)
				return;

			this.UsrGroupPK = data.UsrGroupPK;
			this.BRRuleID = data.BRRuleID;
			this.Denied = data.Denied;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.UsrGroupName = data.UsrGroupName;
			if (all)
			{
				this.UsrGroupBRRule = data.UsrGroupBRRule;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as UsrGroupBRRuleData));
		}

		private bool InternalEquals(UsrGroupBRRuleData obj)
		{
			if (this.UsrGroupBRRule.CompareTo(obj.UsrGroupBRRule) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.UsrGroupBRRule);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("UsrGroupBRRule:");
			builder.AppendFormat("{0}|", this.UsrGroupBRRule);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrGroupBRRuleChanged;
		private void OnUsrGroupBRRuleChanged(EventArgs e)
		{
			if ((this.UsrGroupBRRuleChanged != null))
			{
				this.UsrGroupBRRuleChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrGroupPKChanged;
		private void OnUsrGroupPKChanged(EventArgs e)
		{
			if ((this.UsrGroupPKChanged != null))
			{
				this.UsrGroupPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BRRuleIDChanged;
		private void OnBRRuleIDChanged(EventArgs e)
		{
			if ((this.BRRuleIDChanged != null))
			{
				this.BRRuleIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DeniedChanged;
		private void OnDeniedChanged(EventArgs e)
		{
			if ((this.DeniedChanged != null))
			{
				this.DeniedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class ACInputGroupInputMapData : BusinessBase
	{
		#region Fields
		private Guid _aCInputGroupInputMapPK;
		private Guid _aCInputGroupPK;
		private Guid _aCInputPK;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private Byte _groupID;
		private Guid _aCPanelPK;
		private Byte _inputID;
		private Int32 _unitID;
		private String _address1;
		private Int32 _buildingID;
		private Guid _bDBuildingPK;

		#endregion

		#region Constructors
		public ACInputGroupInputMapData()
		{
			this._aCInputGroupInputMapPK = Guid.NewGuid();
			this._aCInputGroupPK = Guid.Empty;
			this._aCInputPK = Guid.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._aCPanelPK = Guid.Empty;
			this._address1 = string.Empty;
			this._bDBuildingPK = Guid.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public ACInputGroupInputMapData(ACInputGroupInputMapData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid ACInputGroupInputMapPK
		{
			get
			{
				return this._aCInputGroupInputMapPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACInputGroupInputMapPK", value);
				if (this._aCInputGroupInputMapPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCInputGroupInputMapPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACInputGroupInputMapPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACInputGroupPK
		{
			get
			{
				return this._aCInputGroupPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACInputGroupPK", value);
				if (this._aCInputGroupPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCInputGroupPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACInputGroupPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid ACInputPK
		{
			get
			{
				return this._aCInputPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("ACInputPK", value);
				if (this._aCInputPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._aCInputPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnACInputPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual Byte GroupID
		{
			get
			{
				return this._groupID;
			}
			set
			{
				this._groupID = value;
			}
		}

		public virtual Guid ACPanelPK
		{
			get
			{
				return this._aCPanelPK;
			}
			set
			{
				this._aCPanelPK = value;
			}
		}

		public virtual Byte InputID
		{
			get
			{
				return this._inputID;
			}
			set
			{
				this._inputID = value;
			}
		}

		public virtual Int32 UnitID
		{
			get
			{
				return this._unitID;
			}
			set
			{
				this._unitID = value;
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "ACInputGroupInputMap";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual ACInputData ACInput
		{
			get
			{
				ACInputData parent = new ACInputData();
				parent.ACInputPK = this.ACInputPK;
				parent.InputID = this.InputID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACInputPK = value.ACInputPK;
				this.InputID = value.InputID;
			}
		}

		public virtual ACInputGroupData ACInputGroup
		{
			get
			{
				ACInputGroupData parent = new ACInputGroupData();
				parent.ACInputGroupPK = this.ACInputGroupPK;
				parent.GroupID = this.GroupID;
				parent.ACPanelPK = this.ACPanelPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACInputGroupPK = value.ACInputGroupPK;
				this.GroupID = value.GroupID;
				this.ACPanelPK = value.ACPanelPK;
			}
		}

		public virtual ACPanelData ACPanel
		{
			get
			{
				ACPanelData parent = new ACPanelData();
				parent.ACPanelPK = this.ACPanelPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			ACInputGroupInputMapData data = entity as ACInputGroupInputMapData;
			if (data == null)
				return;

			this.ACInputGroupPK = data.ACInputGroupPK;
			this.ACInputPK = data.ACInputPK;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.GroupID = data.GroupID;
			this.ACPanelPK = data.ACPanelPK;
			this.InputID = data.InputID;
			this.UnitID = data.UnitID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			this.BDBuildingPK = data.BDBuildingPK;
			if (all)
			{
				this.ACInputGroupInputMapPK = data.ACInputGroupInputMapPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as ACInputGroupInputMapData));
		}

		private bool InternalEquals(ACInputGroupInputMapData obj)
		{
			if (this.ACInputGroupInputMapPK.CompareTo(obj.ACInputGroupInputMapPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.ACInputGroupInputMapPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("ACInputGroupInputMap:");
			builder.AppendFormat("{0}|", this.ACInputGroupInputMapPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler ACInputGroupInputMapPKChanged;
		private void OnACInputGroupInputMapPKChanged(EventArgs e)
		{
			if ((this.ACInputGroupInputMapPKChanged != null))
			{
				this.ACInputGroupInputMapPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACInputGroupPKChanged;
		private void OnACInputGroupPKChanged(EventArgs e)
		{
			if ((this.ACInputGroupPKChanged != null))
			{
				this.ACInputGroupPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ACInputPKChanged;
		private void OnACInputPKChanged(EventArgs e)
		{
			if ((this.ACInputPKChanged != null))
			{
				this.ACInputPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class UsrAccountBRRuleData : BusinessBase
	{
		#region Fields
		private Guid _usrAccountBRRulePK;
		private Guid _usrAccountPK;
		private Int32 _bRRuleID;
		private Boolean _denied;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _userID;

		#endregion

		#region Constructors
		public UsrAccountBRRuleData()
		{
			this._usrAccountBRRulePK = Guid.NewGuid();
			this._usrAccountPK = Guid.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._userID = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public UsrAccountBRRuleData(UsrAccountBRRuleData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid UsrAccountBRRulePK
		{
			get
			{
				return this._usrAccountBRRulePK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrAccountBRRulePK", value);
				if (this._usrAccountBRRulePK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrAccountBRRulePK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrAccountBRRulePKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid UsrAccountPK
		{
			get
			{
				return this._usrAccountPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrAccountPK", value);
				if (this._usrAccountPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrAccountPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrAccountPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Int32 BRRuleID
		{
			get
			{
				return this._bRRuleID;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BRRuleID", value);
				if (this._bRRuleID != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bRRuleID = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBRRuleIDChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Boolean Denied
		{
			get
			{
				return this._denied;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("Denied", value);
				if (this._denied != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._denied = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnDeniedChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String UserID
		{
			get
			{
				return this._userID == null ? null : this._userID.Trim();
			}
			set
			{
				 this._userID = value == null ? null : value.Trim();
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "UsrAccountBRRule";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual UsrAccountData UsrAccount
		{
			get
			{
				UsrAccountData parent = new UsrAccountData();
				parent.UsrAccountPK = this.UsrAccountPK;
				parent.UserID = this.UserID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UsrAccountPK = value.UsrAccountPK;
				this.UserID = value.UserID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			UsrAccountBRRuleData data = entity as UsrAccountBRRuleData;
			if (data == null)
				return;

			this.UsrAccountPK = data.UsrAccountPK;
			this.BRRuleID = data.BRRuleID;
			this.Denied = data.Denied;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.UserID = data.UserID;
			if (all)
			{
				this.UsrAccountBRRulePK = data.UsrAccountBRRulePK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as UsrAccountBRRuleData));
		}

		private bool InternalEquals(UsrAccountBRRuleData obj)
		{
			if (this.UsrAccountBRRulePK.CompareTo(obj.UsrAccountBRRulePK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.UsrAccountBRRulePK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("UsrAccountBRRule:");
			builder.AppendFormat("{0}|", this.UsrAccountBRRulePK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrAccountBRRulePKChanged;
		private void OnUsrAccountBRRulePKChanged(EventArgs e)
		{
			if ((this.UsrAccountBRRulePKChanged != null))
			{
				this.UsrAccountBRRulePKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrAccountPKChanged;
		private void OnUsrAccountPKChanged(EventArgs e)
		{
			if ((this.UsrAccountPKChanged != null))
			{
				this.UsrAccountPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BRRuleIDChanged;
		private void OnBRRuleIDChanged(EventArgs e)
		{
			if ((this.BRRuleIDChanged != null))
			{
				this.BRRuleIDChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler DeniedChanged;
		private void OnDeniedChanged(EventArgs e)
		{
			if ((this.DeniedChanged != null))
			{
				this.DeniedChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public partial class UsrAccountTenantMapData : BusinessBase
	{
		#region Fields
		private Guid _usrAccountTenantMapPK;
		private Guid _usrAccountPK;
		private Guid _bDTenantPK;
		private Byte[] _rowVersion;
		private DateTime _createdOn;
		private String _createdBy;
		private DateTime _modifiedOn;
		private String _modifiedBy;
		private String _tenant;
		private Guid _bDBuildingPK;
		private String _userID;
		private String _address1;
		private Int32 _buildingID;

		#endregion

		#region Constructors
		public UsrAccountTenantMapData()
		{
			this._usrAccountTenantMapPK = Guid.NewGuid();
			this._usrAccountPK = Guid.Empty;
			this._bDTenantPK = Guid.Empty;
			this._createdOn = DateTime.Now;
			this._createdBy = string.Empty;
			this._modifiedOn = DateTime.Now;
			this._modifiedBy = string.Empty;
			this._tenant = string.Empty;
			this._bDBuildingPK = Guid.Empty;
			this._userID = string.Empty;
			this._address1 = string.Empty;

			base.MarkNew();
			this.InitMemberVariables();
		}

		public UsrAccountTenantMapData(UsrAccountTenantMapData data)
		{
			this.CopyFrom(data, true);
			this.CloneChildren(data);
		}
		#endregion

		#region Properties
		public virtual Guid UsrAccountTenantMapPK
		{
			get
			{
				return this._usrAccountTenantMapPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrAccountTenantMapPK", value);
				if (this._usrAccountTenantMapPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrAccountTenantMapPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrAccountTenantMapPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid UsrAccountPK
		{
			get
			{
				return this._usrAccountPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("UsrAccountPK", value);
				if (this._usrAccountPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._usrAccountPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnUsrAccountPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public virtual Guid BDTenantPK
		{
			get
			{
				return this._bDTenantPK;
			}
			set
			{
				EntityEventArgs e = new EntityEventArgs("BDTenantPK", value);
				if (this._bDTenantPK != value)
				{
					this.OnBeforeChanged(e);
					if (!e.Cancel)
					{
						this._bDTenantPK = value;
						base.MarkDirty();
						this.OnAfterChanged(e);
						this.OnBDTenantPKChanged(EventArgs.Empty);
					}
				}
			}
		}

		public override Byte[] RowVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		public override DateTime CreatedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._createdOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._createdOn = value.ToUniversalTime();
			}
		}

		public override String CreatedBy
		{
			get
			{
				return this._createdBy == null ? null : this._createdBy.Trim();
			}
			set
			{
				 this._createdBy = value == null ? null : value.Trim();
			}
		}

		public override DateTime ModifiedOn
		{
			get
			{
				System.DateTime utcTime = new System.DateTime(this._modifiedOn.Ticks, DateTimeKind.Utc);
				return utcTime.ToLocalTime();
			}
			set
			{
				 this._modifiedOn = value.ToUniversalTime();
			}
		}

		public override String ModifiedBy
		{
			get
			{
				return this._modifiedBy == null ? null : this._modifiedBy.Trim();
			}
			set
			{
				 this._modifiedBy = value == null ? null : value.Trim();
			}
		}

		public virtual String Tenant
		{
			get
			{
				return this._tenant == null ? null : this._tenant.Trim();
			}
			set
			{
				 this._tenant = value == null ? null : value.Trim();
			}
		}

		public virtual Guid BDBuildingPK
		{
			get
			{
				return this._bDBuildingPK;
			}
			set
			{
				this._bDBuildingPK = value;
			}
		}

		public virtual String UserID
		{
			get
			{
				return this._userID == null ? null : this._userID.Trim();
			}
			set
			{
				 this._userID = value == null ? null : value.Trim();
			}
		}

		public virtual String Address1
		{
			get
			{
				return this._address1 == null ? null : this._address1.Trim();
			}
			set
			{
				 this._address1 = value == null ? null : value.Trim();
			}
		}

		public virtual Int32 BuildingID
		{
			get
			{
				return this._buildingID;
			}
			set
			{
				this._buildingID = value;
			}
		}

		#endregion

		#region TableName
		public override string TableName
		{
			get
			{
				return "UsrAccountTenantMap";
			}
		}
		#endregion

		#region Children
		#endregion

		#region Parents
		public virtual BDBuildingData BDBuilding
		{
			get
			{
				BDBuildingData parent = new BDBuildingData();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual BDTenantData BDTenant
		{
			get
			{
				BDTenantData parent = new BDTenantData();
				parent.BDTenantPK = this.BDTenantPK;
				parent.Tenant = this.Tenant;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDTenantPK = value.BDTenantPK;
				this.Tenant = value.Tenant;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		public virtual UsrAccountData UsrAccount
		{
			get
			{
				UsrAccountData parent = new UsrAccountData();
				parent.UsrAccountPK = this.UsrAccountPK;
				parent.UserID = this.UserID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UsrAccountPK = value.UsrAccountPK;
				this.UserID = value.UserID;
			}
		}

		#endregion

		public override void CopyFrom(BusinessBase entity, bool all)
		{
			UsrAccountTenantMapData data = entity as UsrAccountTenantMapData;
			if (data == null)
				return;

			this.UsrAccountPK = data.UsrAccountPK;
			this.BDTenantPK = data.BDTenantPK;
			this.RowVersion = data.RowVersion;
			this.CreatedOn = data.CreatedOn;
			this.CreatedBy = data.CreatedBy;
			this.ModifiedOn = data.ModifiedOn;
			this.ModifiedBy = data.ModifiedBy;
			this.Tenant = data.Tenant;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UserID = data.UserID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			if (all)
			{
				this.UsrAccountTenantMapPK = data.UsrAccountTenantMapPK;
				base._objectID = data.ObjectID;
				base.MarkOld();
				if (data.IsNew)
				{
					base.MarkNew();
				}
				if (data.IsDeleted)
				{
					base.MarkDeleted();
				}
				if (data.IsSelfDirty)
				{
					base.MarkDirty();
				}
			}
		}

		public override bool Equals(object obj)
		{
			return ((obj.GetType() == this.GetType()) && this.InternalEquals(obj as UsrAccountTenantMapData));
		}

		private bool InternalEquals(UsrAccountTenantMapData obj)
		{
			if (this.UsrAccountTenantMapPK.CompareTo(obj.UsrAccountTenantMapPK) != 0)
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public override string PKString
		{
			get
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat("{0}|", this.UsrAccountTenantMapPK);
				return builder.ToString().TrimEnd('|');
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("UsrAccountTenantMap:");
			builder.AppendFormat("{0}|", this.UsrAccountTenantMapPK);
			return builder.ToString().TrimEnd('|');
		}

		#region Binding Events
		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrAccountTenantMapPKChanged;
		private void OnUsrAccountTenantMapPKChanged(EventArgs e)
		{
			if ((this.UsrAccountTenantMapPKChanged != null))
			{
				this.UsrAccountTenantMapPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler UsrAccountPKChanged;
		private void OnUsrAccountPKChanged(EventArgs e)
		{
			if ((this.UsrAccountPKChanged != null))
			{
				this.UsrAccountPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler BDTenantPKChanged;
		private void OnBDTenantPKChanged(EventArgs e)
		{
			if ((this.BDTenantPKChanged != null))
			{
				this.BDTenantPKChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler RowVersionChanged;
		private void OnRowVersionChanged(EventArgs e)
		{
			if ((this.RowVersionChanged != null))
			{
				this.RowVersionChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedOnChanged;
		private void OnCreatedOnChanged(EventArgs e)
		{
			if ((this.CreatedOnChanged != null))
			{
				this.CreatedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler CreatedByChanged;
		private void OnCreatedByChanged(EventArgs e)
		{
			if ((this.CreatedByChanged != null))
			{
				this.CreatedByChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedOnChanged;
		private void OnModifiedOnChanged(EventArgs e)
		{
			if ((this.ModifiedOnChanged != null))
			{
				this.ModifiedOnChanged(this, e);
			}
		}

		[field: NonSerialized, NotUndoable]
		public event EventHandler ModifiedByChanged;
		private void OnModifiedByChanged(EventArgs e)
		{
			if ((this.ModifiedByChanged != null))
			{
				this.ModifiedByChanged(this, e);
			}
		}

		#endregion

	}
	[Serializable]
	public class ACIntvalHolidayMapDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACIntvalHolidayMapDataCollection()
		{
			base._itemType = typeof(ACIntvalHolidayMapData);
		}

		public ACIntvalHolidayMapDataCollection(ACIntvalHolidayMapDataCollection list)
		{
			base._itemType = typeof(ACIntvalHolidayMapData);
			foreach(ACIntvalHolidayMapData item in list)
			{
				this.Add(new ACIntvalHolidayMapData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACIntvalHolidayMapData item in deletedList)
			{
				ACIntvalHolidayMapData entity = new ACIntvalHolidayMapData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACIntvalHolidayMap"; }
		}

		#endregion

		public void Add(ACIntvalHolidayMapData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACIntvalHolidayMapDataCollection list)
		{
			foreach(ACIntvalHolidayMapData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACIntvalHolidayMapData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACIntvalHolidayMapData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACIntvalHolidayMapData item)
		{
			foreach (ACIntvalHolidayMapData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACIntvalHolidayMapData item)
		{
			foreach (ACIntvalHolidayMapData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACIntvalHolidayMapData this[int index]
		{
			get
			{
				return (ACIntvalHolidayMapData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACIntvalHolidayMapData");
			}
		}

	}
	[Serializable]
	public class ACAccessLevelDetailDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACAccessLevelDetailDataCollection()
		{
			base._itemType = typeof(ACAccessLevelDetailData);
		}

		public ACAccessLevelDetailDataCollection(ACAccessLevelDetailDataCollection list)
		{
			base._itemType = typeof(ACAccessLevelDetailData);
			foreach(ACAccessLevelDetailData item in list)
			{
				this.Add(new ACAccessLevelDetailData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACAccessLevelDetailData item in deletedList)
			{
				ACAccessLevelDetailData entity = new ACAccessLevelDetailData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACAccessLevelDetail"; }
		}

		#endregion

		public void Add(ACAccessLevelDetailData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACAccessLevelDetailDataCollection list)
		{
			foreach(ACAccessLevelDetailData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACAccessLevelDetailData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACAccessLevelDetailData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACAccessLevelDetailData item)
		{
			foreach (ACAccessLevelDetailData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACAccessLevelDetailData item)
		{
			foreach (ACAccessLevelDetailData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACAccessLevelDetailData this[int index]
		{
			get
			{
				return (ACAccessLevelDetailData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACAccessLevelDetailData");
			}
		}

	}
	[Serializable]
	public class UsrAccountBuildingMapDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public UsrAccountBuildingMapDataCollection()
		{
			base._itemType = typeof(UsrAccountBuildingMapData);
		}

		public UsrAccountBuildingMapDataCollection(UsrAccountBuildingMapDataCollection list)
		{
			base._itemType = typeof(UsrAccountBuildingMapData);
			foreach(UsrAccountBuildingMapData item in list)
			{
				this.Add(new UsrAccountBuildingMapData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrAccountBuildingMapData item in deletedList)
			{
				UsrAccountBuildingMapData entity = new UsrAccountBuildingMapData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "UsrAccountBuildingMap"; }
		}

		#endregion

		public void Add(UsrAccountBuildingMapData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrAccountBuildingMapDataCollection list)
		{
			foreach(UsrAccountBuildingMapData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrAccountBuildingMapData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrAccountBuildingMapData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrAccountBuildingMapData item)
		{
			foreach (UsrAccountBuildingMapData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrAccountBuildingMapData item)
		{
			foreach (UsrAccountBuildingMapData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrAccountBuildingMapData this[int index]
		{
			get
			{
				return (UsrAccountBuildingMapData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of UsrAccountBuildingMapData");
			}
		}

	}
	[Serializable]
	public class BDBuildingDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public BDBuildingDataCollection()
		{
			base._itemType = typeof(BDBuildingData);
		}

		public BDBuildingDataCollection(BDBuildingDataCollection list)
		{
			base._itemType = typeof(BDBuildingData);
			foreach(BDBuildingData item in list)
			{
				this.Add(new BDBuildingData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(BDBuildingData item in deletedList)
			{
				BDBuildingData entity = new BDBuildingData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "BDBuilding"; }
		}

		#endregion

		public void Add(BDBuildingData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(BDBuildingDataCollection list)
		{
			foreach(BDBuildingData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(BDBuildingData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, BDBuildingData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(BDBuildingData item)
		{
			foreach (BDBuildingData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(BDBuildingData item)
		{
			foreach (BDBuildingData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new BDBuildingData this[int index]
		{
			get
			{
				return (BDBuildingData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of BDBuildingData");
			}
		}

	}
	[Serializable]
	public class BDTenantDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public BDTenantDataCollection()
		{
			base._itemType = typeof(BDTenantData);
		}

		public BDTenantDataCollection(BDTenantDataCollection list)
		{
			base._itemType = typeof(BDTenantData);
			foreach(BDTenantData item in list)
			{
				this.Add(new BDTenantData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(BDTenantData item in deletedList)
			{
				BDTenantData entity = new BDTenantData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "BDTenant"; }
		}

		#endregion

		public void Add(BDTenantData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(BDTenantDataCollection list)
		{
			foreach(BDTenantData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(BDTenantData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, BDTenantData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(BDTenantData item)
		{
			foreach (BDTenantData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(BDTenantData item)
		{
			foreach (BDTenantData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new BDTenantData this[int index]
		{
			get
			{
				return (BDTenantData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of BDTenantData");
			}
		}

	}
	[Serializable]
	public class UtilSettingCategoryDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public UtilSettingCategoryDataCollection()
		{
			base._itemType = typeof(UtilSettingCategoryData);
		}

		public UtilSettingCategoryDataCollection(UtilSettingCategoryDataCollection list)
		{
			base._itemType = typeof(UtilSettingCategoryData);
			foreach(UtilSettingCategoryData item in list)
			{
				this.Add(new UtilSettingCategoryData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UtilSettingCategoryData item in deletedList)
			{
				UtilSettingCategoryData entity = new UtilSettingCategoryData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "UtilSettingCategory"; }
		}

		#endregion

		public void Add(UtilSettingCategoryData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UtilSettingCategoryDataCollection list)
		{
			foreach(UtilSettingCategoryData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UtilSettingCategoryData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UtilSettingCategoryData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UtilSettingCategoryData item)
		{
			foreach (UtilSettingCategoryData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UtilSettingCategoryData item)
		{
			foreach (UtilSettingCategoryData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UtilSettingCategoryData this[int index]
		{
			get
			{
				return (UtilSettingCategoryData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of UtilSettingCategoryData");
			}
		}

	}
	[Serializable]
	public class UtilSettingDetailDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public UtilSettingDetailDataCollection()
		{
			base._itemType = typeof(UtilSettingDetailData);
		}

		public UtilSettingDetailDataCollection(UtilSettingDetailDataCollection list)
		{
			base._itemType = typeof(UtilSettingDetailData);
			foreach(UtilSettingDetailData item in list)
			{
				this.Add(new UtilSettingDetailData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UtilSettingDetailData item in deletedList)
			{
				UtilSettingDetailData entity = new UtilSettingDetailData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "UtilSettingDetail"; }
		}

		#endregion

		public void Add(UtilSettingDetailData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UtilSettingDetailDataCollection list)
		{
			foreach(UtilSettingDetailData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UtilSettingDetailData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UtilSettingDetailData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UtilSettingDetailData item)
		{
			foreach (UtilSettingDetailData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UtilSettingDetailData item)
		{
			foreach (UtilSettingDetailData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UtilSettingDetailData this[int index]
		{
			get
			{
				return (UtilSettingDetailData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of UtilSettingDetailData");
			}
		}

	}
	[Serializable]
	public class ACOutputGroupMainZoneMapDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACOutputGroupMainZoneMapDataCollection()
		{
			base._itemType = typeof(ACOutputGroupMainZoneMapData);
		}

		public ACOutputGroupMainZoneMapDataCollection(ACOutputGroupMainZoneMapDataCollection list)
		{
			base._itemType = typeof(ACOutputGroupMainZoneMapData);
			foreach(ACOutputGroupMainZoneMapData item in list)
			{
				this.Add(new ACOutputGroupMainZoneMapData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACOutputGroupMainZoneMapData item in deletedList)
			{
				ACOutputGroupMainZoneMapData entity = new ACOutputGroupMainZoneMapData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACOutputGroupMainZoneMap"; }
		}

		#endregion

		public void Add(ACOutputGroupMainZoneMapData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACOutputGroupMainZoneMapDataCollection list)
		{
			foreach(ACOutputGroupMainZoneMapData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACOutputGroupMainZoneMapData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACOutputGroupMainZoneMapData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACOutputGroupMainZoneMapData item)
		{
			foreach (ACOutputGroupMainZoneMapData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACOutputGroupMainZoneMapData item)
		{
			foreach (ACOutputGroupMainZoneMapData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACOutputGroupMainZoneMapData this[int index]
		{
			get
			{
				return (ACOutputGroupMainZoneMapData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACOutputGroupMainZoneMapData");
			}
		}

	}
	[Serializable]
	public class ACCardHolderDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACCardHolderDataCollection()
		{
			base._itemType = typeof(ACCardHolderData);
		}

		public ACCardHolderDataCollection(ACCardHolderDataCollection list)
		{
			base._itemType = typeof(ACCardHolderData);
			foreach(ACCardHolderData item in list)
			{
				this.Add(new ACCardHolderData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACCardHolderData item in deletedList)
			{
				ACCardHolderData entity = new ACCardHolderData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACCardHolder"; }
		}

		#endregion

		public void Add(ACCardHolderData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACCardHolderDataCollection list)
		{
			foreach(ACCardHolderData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACCardHolderData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACCardHolderData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACCardHolderData item)
		{
			foreach (ACCardHolderData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACCardHolderData item)
		{
			foreach (ACCardHolderData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACCardHolderData this[int index]
		{
			get
			{
				return (ACCardHolderData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACCardHolderData");
			}
		}

	}
	[Serializable]
	public class ACMainZoneDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACMainZoneDataCollection()
		{
			base._itemType = typeof(ACMainZoneData);
		}

		public ACMainZoneDataCollection(ACMainZoneDataCollection list)
		{
			base._itemType = typeof(ACMainZoneData);
			foreach(ACMainZoneData item in list)
			{
				this.Add(new ACMainZoneData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACMainZoneData item in deletedList)
			{
				ACMainZoneData entity = new ACMainZoneData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACMainZone"; }
		}

		#endregion

		public void Add(ACMainZoneData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACMainZoneDataCollection list)
		{
			foreach(ACMainZoneData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACMainZoneData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACMainZoneData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACMainZoneData item)
		{
			foreach (ACMainZoneData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACMainZoneData item)
		{
			foreach (ACMainZoneData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACMainZoneData this[int index]
		{
			get
			{
				return (ACMainZoneData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACMainZoneData");
			}
		}

	}
	[Serializable]
	public class ACIntervalDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACIntervalDataCollection()
		{
			base._itemType = typeof(ACIntervalData);
		}

		public ACIntervalDataCollection(ACIntervalDataCollection list)
		{
			base._itemType = typeof(ACIntervalData);
			foreach(ACIntervalData item in list)
			{
				this.Add(new ACIntervalData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACIntervalData item in deletedList)
			{
				ACIntervalData entity = new ACIntervalData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACInterval"; }
		}

		#endregion

		public void Add(ACIntervalData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACIntervalDataCollection list)
		{
			foreach(ACIntervalData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACIntervalData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACIntervalData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACIntervalData item)
		{
			foreach (ACIntervalData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACIntervalData item)
		{
			foreach (ACIntervalData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACIntervalData this[int index]
		{
			get
			{
				return (ACIntervalData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACIntervalData");
			}
		}

	}
	[Serializable]
	public class ACPanelHolidayMapDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACPanelHolidayMapDataCollection()
		{
			base._itemType = typeof(ACPanelHolidayMapData);
		}

		public ACPanelHolidayMapDataCollection(ACPanelHolidayMapDataCollection list)
		{
			base._itemType = typeof(ACPanelHolidayMapData);
			foreach(ACPanelHolidayMapData item in list)
			{
				this.Add(new ACPanelHolidayMapData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACPanelHolidayMapData item in deletedList)
			{
				ACPanelHolidayMapData entity = new ACPanelHolidayMapData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACPanelHolidayMap"; }
		}

		#endregion

		public void Add(ACPanelHolidayMapData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACPanelHolidayMapDataCollection list)
		{
			foreach(ACPanelHolidayMapData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACPanelHolidayMapData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACPanelHolidayMapData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACPanelHolidayMapData item)
		{
			foreach (ACPanelHolidayMapData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACPanelHolidayMapData item)
		{
			foreach (ACPanelHolidayMapData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACPanelHolidayMapData this[int index]
		{
			get
			{
				return (ACPanelHolidayMapData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACPanelHolidayMapData");
			}
		}

	}
	[Serializable]
	public class ACTimecodeDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACTimecodeDataCollection()
		{
			base._itemType = typeof(ACTimecodeData);
		}

		public ACTimecodeDataCollection(ACTimecodeDataCollection list)
		{
			base._itemType = typeof(ACTimecodeData);
			foreach(ACTimecodeData item in list)
			{
				this.Add(new ACTimecodeData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACTimecodeData item in deletedList)
			{
				ACTimecodeData entity = new ACTimecodeData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACTimecode"; }
		}

		#endregion

		public void Add(ACTimecodeData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACTimecodeDataCollection list)
		{
			foreach(ACTimecodeData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACTimecodeData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACTimecodeData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACTimecodeData item)
		{
			foreach (ACTimecodeData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACTimecodeData item)
		{
			foreach (ACTimecodeData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACTimecodeData this[int index]
		{
			get
			{
				return (ACTimecodeData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACTimecodeData");
			}
		}

	}
	[Serializable]
	public class ACTimecodeIntervalMapDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACTimecodeIntervalMapDataCollection()
		{
			base._itemType = typeof(ACTimecodeIntervalMapData);
		}

		public ACTimecodeIntervalMapDataCollection(ACTimecodeIntervalMapDataCollection list)
		{
			base._itemType = typeof(ACTimecodeIntervalMapData);
			foreach(ACTimecodeIntervalMapData item in list)
			{
				this.Add(new ACTimecodeIntervalMapData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACTimecodeIntervalMapData item in deletedList)
			{
				ACTimecodeIntervalMapData entity = new ACTimecodeIntervalMapData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACTimecodeIntervalMap"; }
		}

		#endregion

		public void Add(ACTimecodeIntervalMapData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACTimecodeIntervalMapDataCollection list)
		{
			foreach(ACTimecodeIntervalMapData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACTimecodeIntervalMapData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACTimecodeIntervalMapData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACTimecodeIntervalMapData item)
		{
			foreach (ACTimecodeIntervalMapData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACTimecodeIntervalMapData item)
		{
			foreach (ACTimecodeIntervalMapData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACTimecodeIntervalMapData this[int index]
		{
			get
			{
				return (ACTimecodeIntervalMapData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACTimecodeIntervalMapData");
			}
		}

	}
	[Serializable]
	public class ACAMFormatDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACAMFormatDataCollection()
		{
			base._itemType = typeof(ACAMFormatData);
		}

		public ACAMFormatDataCollection(ACAMFormatDataCollection list)
		{
			base._itemType = typeof(ACAMFormatData);
			foreach(ACAMFormatData item in list)
			{
				this.Add(new ACAMFormatData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACAMFormatData item in deletedList)
			{
				ACAMFormatData entity = new ACAMFormatData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACAMFormat"; }
		}

		#endregion

		public void Add(ACAMFormatData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACAMFormatDataCollection list)
		{
			foreach(ACAMFormatData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACAMFormatData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACAMFormatData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACAMFormatData item)
		{
			foreach (ACAMFormatData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACAMFormatData item)
		{
			foreach (ACAMFormatData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACAMFormatData this[int index]
		{
			get
			{
				return (ACAMFormatData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACAMFormatData");
			}
		}

	}
	[Serializable]
	public class BDBuildingHolidayMapDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public BDBuildingHolidayMapDataCollection()
		{
			base._itemType = typeof(BDBuildingHolidayMapData);
		}

		public BDBuildingHolidayMapDataCollection(BDBuildingHolidayMapDataCollection list)
		{
			base._itemType = typeof(BDBuildingHolidayMapData);
			foreach(BDBuildingHolidayMapData item in list)
			{
				this.Add(new BDBuildingHolidayMapData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(BDBuildingHolidayMapData item in deletedList)
			{
				BDBuildingHolidayMapData entity = new BDBuildingHolidayMapData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "BDBuildingHolidayMap"; }
		}

		#endregion

		public void Add(BDBuildingHolidayMapData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(BDBuildingHolidayMapDataCollection list)
		{
			foreach(BDBuildingHolidayMapData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(BDBuildingHolidayMapData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, BDBuildingHolidayMapData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(BDBuildingHolidayMapData item)
		{
			foreach (BDBuildingHolidayMapData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(BDBuildingHolidayMapData item)
		{
			foreach (BDBuildingHolidayMapData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new BDBuildingHolidayMapData this[int index]
		{
			get
			{
				return (BDBuildingHolidayMapData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of BDBuildingHolidayMapData");
			}
		}

	}
	[Serializable]
	public class ACOutputGroupDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACOutputGroupDataCollection()
		{
			base._itemType = typeof(ACOutputGroupData);
		}

		public ACOutputGroupDataCollection(ACOutputGroupDataCollection list)
		{
			base._itemType = typeof(ACOutputGroupData);
			foreach(ACOutputGroupData item in list)
			{
				this.Add(new ACOutputGroupData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACOutputGroupData item in deletedList)
			{
				ACOutputGroupData entity = new ACOutputGroupData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACOutputGroup"; }
		}

		#endregion

		public void Add(ACOutputGroupData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACOutputGroupDataCollection list)
		{
			foreach(ACOutputGroupData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACOutputGroupData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACOutputGroupData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACOutputGroupData item)
		{
			foreach (ACOutputGroupData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACOutputGroupData item)
		{
			foreach (ACOutputGroupData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACOutputGroupData this[int index]
		{
			get
			{
				return (ACOutputGroupData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACOutputGroupData");
			}
		}

	}
	[Serializable]
	public class BDTenantHolidayMapDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public BDTenantHolidayMapDataCollection()
		{
			base._itemType = typeof(BDTenantHolidayMapData);
		}

		public BDTenantHolidayMapDataCollection(BDTenantHolidayMapDataCollection list)
		{
			base._itemType = typeof(BDTenantHolidayMapData);
			foreach(BDTenantHolidayMapData item in list)
			{
				this.Add(new BDTenantHolidayMapData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(BDTenantHolidayMapData item in deletedList)
			{
				BDTenantHolidayMapData entity = new BDTenantHolidayMapData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "BDTenantHolidayMap"; }
		}

		#endregion

		public void Add(BDTenantHolidayMapData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(BDTenantHolidayMapDataCollection list)
		{
			foreach(BDTenantHolidayMapData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(BDTenantHolidayMapData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, BDTenantHolidayMapData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(BDTenantHolidayMapData item)
		{
			foreach (BDTenantHolidayMapData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(BDTenantHolidayMapData item)
		{
			foreach (BDTenantHolidayMapData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new BDTenantHolidayMapData this[int index]
		{
			get
			{
				return (BDTenantHolidayMapData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of BDTenantHolidayMapData");
			}
		}

	}
	[Serializable]
	public class LogRowsCountDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public LogRowsCountDataCollection()
		{
			base._itemType = typeof(LogRowsCountData);
		}

		public LogRowsCountDataCollection(LogRowsCountDataCollection list)
		{
			base._itemType = typeof(LogRowsCountData);
			foreach(LogRowsCountData item in list)
			{
				this.Add(new LogRowsCountData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(LogRowsCountData item in deletedList)
			{
				LogRowsCountData entity = new LogRowsCountData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "LogRowsCount"; }
		}

		#endregion

		public void Add(LogRowsCountData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(LogRowsCountDataCollection list)
		{
			foreach(LogRowsCountData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(LogRowsCountData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, LogRowsCountData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(LogRowsCountData item)
		{
			foreach (LogRowsCountData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(LogRowsCountData item)
		{
			foreach (LogRowsCountData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new LogRowsCountData this[int index]
		{
			get
			{
				return (LogRowsCountData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of LogRowsCountData");
			}
		}

	}
	[Serializable]
	public class ACInputGroupDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACInputGroupDataCollection()
		{
			base._itemType = typeof(ACInputGroupData);
		}

		public ACInputGroupDataCollection(ACInputGroupDataCollection list)
		{
			base._itemType = typeof(ACInputGroupData);
			foreach(ACInputGroupData item in list)
			{
				this.Add(new ACInputGroupData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACInputGroupData item in deletedList)
			{
				ACInputGroupData entity = new ACInputGroupData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACInputGroup"; }
		}

		#endregion

		public void Add(ACInputGroupData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACInputGroupDataCollection list)
		{
			foreach(ACInputGroupData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACInputGroupData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACInputGroupData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACInputGroupData item)
		{
			foreach (ACInputGroupData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACInputGroupData item)
		{
			foreach (ACInputGroupData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACInputGroupData this[int index]
		{
			get
			{
				return (ACInputGroupData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACInputGroupData");
			}
		}

	}
	[Serializable]
	public class ACInputDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACInputDataCollection()
		{
			base._itemType = typeof(ACInputData);
		}

		public ACInputDataCollection(ACInputDataCollection list)
		{
			base._itemType = typeof(ACInputData);
			foreach(ACInputData item in list)
			{
				this.Add(new ACInputData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACInputData item in deletedList)
			{
				ACInputData entity = new ACInputData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACInput"; }
		}

		#endregion

		public void Add(ACInputData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACInputDataCollection list)
		{
			foreach(ACInputData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACInputData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACInputData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACInputData item)
		{
			foreach (ACInputData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACInputData item)
		{
			foreach (ACInputData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACInputData this[int index]
		{
			get
			{
				return (ACInputData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACInputData");
			}
		}

	}
	[Serializable]
	public class ACFunctionCardDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACFunctionCardDataCollection()
		{
			base._itemType = typeof(ACFunctionCardData);
		}

		public ACFunctionCardDataCollection(ACFunctionCardDataCollection list)
		{
			base._itemType = typeof(ACFunctionCardData);
			foreach(ACFunctionCardData item in list)
			{
				this.Add(new ACFunctionCardData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACFunctionCardData item in deletedList)
			{
				ACFunctionCardData entity = new ACFunctionCardData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACFunctionCard"; }
		}

		#endregion

		public void Add(ACFunctionCardData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACFunctionCardDataCollection list)
		{
			foreach(ACFunctionCardData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACFunctionCardData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACFunctionCardData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACFunctionCardData item)
		{
			foreach (ACFunctionCardData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACFunctionCardData item)
		{
			foreach (ACFunctionCardData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACFunctionCardData this[int index]
		{
			get
			{
				return (ACFunctionCardData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACFunctionCardData");
			}
		}

	}
	[Serializable]
	public class UtilHolidayDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public UtilHolidayDataCollection()
		{
			base._itemType = typeof(UtilHolidayData);
		}

		public UtilHolidayDataCollection(UtilHolidayDataCollection list)
		{
			base._itemType = typeof(UtilHolidayData);
			foreach(UtilHolidayData item in list)
			{
				this.Add(new UtilHolidayData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UtilHolidayData item in deletedList)
			{
				UtilHolidayData entity = new UtilHolidayData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "UtilHoliday"; }
		}

		#endregion

		public void Add(UtilHolidayData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UtilHolidayDataCollection list)
		{
			foreach(UtilHolidayData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UtilHolidayData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UtilHolidayData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UtilHolidayData item)
		{
			foreach (UtilHolidayData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UtilHolidayData item)
		{
			foreach (UtilHolidayData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UtilHolidayData this[int index]
		{
			get
			{
				return (UtilHolidayData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of UtilHolidayData");
			}
		}

	}
	[Serializable]
	public class ACAccessLevelDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACAccessLevelDataCollection()
		{
			base._itemType = typeof(ACAccessLevelData);
		}

		public ACAccessLevelDataCollection(ACAccessLevelDataCollection list)
		{
			base._itemType = typeof(ACAccessLevelData);
			foreach(ACAccessLevelData item in list)
			{
				this.Add(new ACAccessLevelData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACAccessLevelData item in deletedList)
			{
				ACAccessLevelData entity = new ACAccessLevelData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACAccessLevel"; }
		}

		#endregion

		public void Add(ACAccessLevelData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACAccessLevelDataCollection list)
		{
			foreach(ACAccessLevelData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACAccessLevelData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACAccessLevelData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACAccessLevelData item)
		{
			foreach (ACAccessLevelData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACAccessLevelData item)
		{
			foreach (ACAccessLevelData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACAccessLevelData this[int index]
		{
			get
			{
				return (ACAccessLevelData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACAccessLevelData");
			}
		}

	}
	[Serializable]
	public class ACPanelFunctionCardMapDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACPanelFunctionCardMapDataCollection()
		{
			base._itemType = typeof(ACPanelFunctionCardMapData);
		}

		public ACPanelFunctionCardMapDataCollection(ACPanelFunctionCardMapDataCollection list)
		{
			base._itemType = typeof(ACPanelFunctionCardMapData);
			foreach(ACPanelFunctionCardMapData item in list)
			{
				this.Add(new ACPanelFunctionCardMapData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACPanelFunctionCardMapData item in deletedList)
			{
				ACPanelFunctionCardMapData entity = new ACPanelFunctionCardMapData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACPanelFunctionCardMap"; }
		}

		#endregion

		public void Add(ACPanelFunctionCardMapData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACPanelFunctionCardMapDataCollection list)
		{
			foreach(ACPanelFunctionCardMapData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACPanelFunctionCardMapData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACPanelFunctionCardMapData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACPanelFunctionCardMapData item)
		{
			foreach (ACPanelFunctionCardMapData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACPanelFunctionCardMapData item)
		{
			foreach (ACPanelFunctionCardMapData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACPanelFunctionCardMapData this[int index]
		{
			get
			{
				return (ACPanelFunctionCardMapData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACPanelFunctionCardMapData");
			}
		}

	}
	[Serializable]
	public class LogDBDeleteActivityDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public LogDBDeleteActivityDataCollection()
		{
			base._itemType = typeof(LogDBDeleteActivityData);
		}

		public LogDBDeleteActivityDataCollection(LogDBDeleteActivityDataCollection list)
		{
			base._itemType = typeof(LogDBDeleteActivityData);
			foreach(LogDBDeleteActivityData item in list)
			{
				this.Add(new LogDBDeleteActivityData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(LogDBDeleteActivityData item in deletedList)
			{
				LogDBDeleteActivityData entity = new LogDBDeleteActivityData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "LogDBDeleteActivity"; }
		}

		#endregion

		public void Add(LogDBDeleteActivityData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(LogDBDeleteActivityDataCollection list)
		{
			foreach(LogDBDeleteActivityData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(LogDBDeleteActivityData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, LogDBDeleteActivityData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(LogDBDeleteActivityData item)
		{
			foreach (LogDBDeleteActivityData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(LogDBDeleteActivityData item)
		{
			foreach (LogDBDeleteActivityData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new LogDBDeleteActivityData this[int index]
		{
			get
			{
				return (LogDBDeleteActivityData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of LogDBDeleteActivityData");
			}
		}

	}
	[Serializable]
	public class UsrAccountDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public UsrAccountDataCollection()
		{
			base._itemType = typeof(UsrAccountData);
		}

		public UsrAccountDataCollection(UsrAccountDataCollection list)
		{
			base._itemType = typeof(UsrAccountData);
			foreach(UsrAccountData item in list)
			{
				this.Add(new UsrAccountData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrAccountData item in deletedList)
			{
				UsrAccountData entity = new UsrAccountData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "UsrAccount"; }
		}

		#endregion

		public void Add(UsrAccountData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrAccountDataCollection list)
		{
			foreach(UsrAccountData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrAccountData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrAccountData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrAccountData item)
		{
			foreach (UsrAccountData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrAccountData item)
		{
			foreach (UsrAccountData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrAccountData this[int index]
		{
			get
			{
				return (UsrAccountData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of UsrAccountData");
			}
		}

	}
	[Serializable]
	public class LogDBEditActivityDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public LogDBEditActivityDataCollection()
		{
			base._itemType = typeof(LogDBEditActivityData);
		}

		public LogDBEditActivityDataCollection(LogDBEditActivityDataCollection list)
		{
			base._itemType = typeof(LogDBEditActivityData);
			foreach(LogDBEditActivityData item in list)
			{
				this.Add(new LogDBEditActivityData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(LogDBEditActivityData item in deletedList)
			{
				LogDBEditActivityData entity = new LogDBEditActivityData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "LogDBEditActivity"; }
		}

		#endregion

		public void Add(LogDBEditActivityData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(LogDBEditActivityDataCollection list)
		{
			foreach(LogDBEditActivityData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(LogDBEditActivityData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, LogDBEditActivityData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(LogDBEditActivityData item)
		{
			foreach (LogDBEditActivityData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(LogDBEditActivityData item)
		{
			foreach (LogDBEditActivityData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new LogDBEditActivityData this[int index]
		{
			get
			{
				return (LogDBEditActivityData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of LogDBEditActivityData");
			}
		}

	}
	[Serializable]
	public class ACMasterCardDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACMasterCardDataCollection()
		{
			base._itemType = typeof(ACMasterCardData);
		}

		public ACMasterCardDataCollection(ACMasterCardDataCollection list)
		{
			base._itemType = typeof(ACMasterCardData);
			foreach(ACMasterCardData item in list)
			{
				this.Add(new ACMasterCardData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACMasterCardData item in deletedList)
			{
				ACMasterCardData entity = new ACMasterCardData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACMasterCard"; }
		}

		#endregion

		public void Add(ACMasterCardData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACMasterCardDataCollection list)
		{
			foreach(ACMasterCardData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACMasterCardData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACMasterCardData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACMasterCardData item)
		{
			foreach (ACMasterCardData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACMasterCardData item)
		{
			foreach (ACMasterCardData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACMasterCardData this[int index]
		{
			get
			{
				return (ACMasterCardData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACMasterCardData");
			}
		}

	}
	[Serializable]
	public class ACSupervisoryDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACSupervisoryDataCollection()
		{
			base._itemType = typeof(ACSupervisoryData);
		}

		public ACSupervisoryDataCollection(ACSupervisoryDataCollection list)
		{
			base._itemType = typeof(ACSupervisoryData);
			foreach(ACSupervisoryData item in list)
			{
				this.Add(new ACSupervisoryData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACSupervisoryData item in deletedList)
			{
				ACSupervisoryData entity = new ACSupervisoryData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACSupervisory"; }
		}

		#endregion

		public void Add(ACSupervisoryData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACSupervisoryDataCollection list)
		{
			foreach(ACSupervisoryData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACSupervisoryData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACSupervisoryData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACSupervisoryData item)
		{
			foreach (ACSupervisoryData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACSupervisoryData item)
		{
			foreach (ACSupervisoryData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACSupervisoryData this[int index]
		{
			get
			{
				return (ACSupervisoryData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACSupervisoryData");
			}
		}

	}
	[Serializable]
	public class UsrGroupDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public UsrGroupDataCollection()
		{
			base._itemType = typeof(UsrGroupData);
		}

		public UsrGroupDataCollection(UsrGroupDataCollection list)
		{
			base._itemType = typeof(UsrGroupData);
			foreach(UsrGroupData item in list)
			{
				this.Add(new UsrGroupData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrGroupData item in deletedList)
			{
				UsrGroupData entity = new UsrGroupData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "UsrGroup"; }
		}

		#endregion

		public void Add(UsrGroupData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrGroupDataCollection list)
		{
			foreach(UsrGroupData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrGroupData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrGroupData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrGroupData item)
		{
			foreach (UsrGroupData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrGroupData item)
		{
			foreach (UsrGroupData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrGroupData this[int index]
		{
			get
			{
				return (UsrGroupData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of UsrGroupData");
			}
		}

	}
	[Serializable]
	public class ACCardHolderBuildingMapDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACCardHolderBuildingMapDataCollection()
		{
			base._itemType = typeof(ACCardHolderBuildingMapData);
		}

		public ACCardHolderBuildingMapDataCollection(ACCardHolderBuildingMapDataCollection list)
		{
			base._itemType = typeof(ACCardHolderBuildingMapData);
			foreach(ACCardHolderBuildingMapData item in list)
			{
				this.Add(new ACCardHolderBuildingMapData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACCardHolderBuildingMapData item in deletedList)
			{
				ACCardHolderBuildingMapData entity = new ACCardHolderBuildingMapData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACCardHolderBuildingMap"; }
		}

		#endregion

		public void Add(ACCardHolderBuildingMapData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACCardHolderBuildingMapDataCollection list)
		{
			foreach(ACCardHolderBuildingMapData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACCardHolderBuildingMapData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACCardHolderBuildingMapData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACCardHolderBuildingMapData item)
		{
			foreach (ACCardHolderBuildingMapData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACCardHolderBuildingMapData item)
		{
			foreach (ACCardHolderBuildingMapData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACCardHolderBuildingMapData this[int index]
		{
			get
			{
				return (ACCardHolderBuildingMapData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACCardHolderBuildingMapData");
			}
		}

	}
	[Serializable]
	public class BDVisitorDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public BDVisitorDataCollection()
		{
			base._itemType = typeof(BDVisitorData);
		}

		public BDVisitorDataCollection(BDVisitorDataCollection list)
		{
			base._itemType = typeof(BDVisitorData);
			foreach(BDVisitorData item in list)
			{
				this.Add(new BDVisitorData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(BDVisitorData item in deletedList)
			{
				BDVisitorData entity = new BDVisitorData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "BDVisitor"; }
		}

		#endregion

		public void Add(BDVisitorData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(BDVisitorDataCollection list)
		{
			foreach(BDVisitorData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(BDVisitorData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, BDVisitorData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(BDVisitorData item)
		{
			foreach (BDVisitorData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(BDVisitorData item)
		{
			foreach (BDVisitorData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new BDVisitorData this[int index]
		{
			get
			{
				return (BDVisitorData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of BDVisitorData");
			}
		}

	}
	[Serializable]
	public class UsrGroupDBRuleDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public UsrGroupDBRuleDataCollection()
		{
			base._itemType = typeof(UsrGroupDBRuleData);
		}

		public UsrGroupDBRuleDataCollection(UsrGroupDBRuleDataCollection list)
		{
			base._itemType = typeof(UsrGroupDBRuleData);
			foreach(UsrGroupDBRuleData item in list)
			{
				this.Add(new UsrGroupDBRuleData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrGroupDBRuleData item in deletedList)
			{
				UsrGroupDBRuleData entity = new UsrGroupDBRuleData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "UsrGroupDBRule"; }
		}

		#endregion

		public void Add(UsrGroupDBRuleData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrGroupDBRuleDataCollection list)
		{
			foreach(UsrGroupDBRuleData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrGroupDBRuleData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrGroupDBRuleData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrGroupDBRuleData item)
		{
			foreach (UsrGroupDBRuleData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrGroupDBRuleData item)
		{
			foreach (UsrGroupDBRuleData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrGroupDBRuleData this[int index]
		{
			get
			{
				return (UsrGroupDBRuleData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of UsrGroupDBRuleData");
			}
		}

	}
	[Serializable]
	public class ACPanelDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACPanelDataCollection()
		{
			base._itemType = typeof(ACPanelData);
		}

		public ACPanelDataCollection(ACPanelDataCollection list)
		{
			base._itemType = typeof(ACPanelData);
			foreach(ACPanelData item in list)
			{
				this.Add(new ACPanelData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACPanelData item in deletedList)
			{
				ACPanelData entity = new ACPanelData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACPanel"; }
		}

		#endregion

		public void Add(ACPanelData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACPanelDataCollection list)
		{
			foreach(ACPanelData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACPanelData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACPanelData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACPanelData item)
		{
			foreach (ACPanelData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACPanelData item)
		{
			foreach (ACPanelData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACPanelData this[int index]
		{
			get
			{
				return (ACPanelData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACPanelData");
			}
		}

	}
	[Serializable]
	public class UsrAccountDBRuleDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public UsrAccountDBRuleDataCollection()
		{
			base._itemType = typeof(UsrAccountDBRuleData);
		}

		public UsrAccountDBRuleDataCollection(UsrAccountDBRuleDataCollection list)
		{
			base._itemType = typeof(UsrAccountDBRuleData);
			foreach(UsrAccountDBRuleData item in list)
			{
				this.Add(new UsrAccountDBRuleData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrAccountDBRuleData item in deletedList)
			{
				UsrAccountDBRuleData entity = new UsrAccountDBRuleData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "UsrAccountDBRule"; }
		}

		#endregion

		public void Add(UsrAccountDBRuleData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrAccountDBRuleDataCollection list)
		{
			foreach(UsrAccountDBRuleData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrAccountDBRuleData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrAccountDBRuleData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrAccountDBRuleData item)
		{
			foreach (UsrAccountDBRuleData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrAccountDBRuleData item)
		{
			foreach (UsrAccountDBRuleData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrAccountDBRuleData this[int index]
		{
			get
			{
				return (UsrAccountDBRuleData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of UsrAccountDBRuleData");
			}
		}

	}
	[Serializable]
	public class UsrGroupBRRuleDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public UsrGroupBRRuleDataCollection()
		{
			base._itemType = typeof(UsrGroupBRRuleData);
		}

		public UsrGroupBRRuleDataCollection(UsrGroupBRRuleDataCollection list)
		{
			base._itemType = typeof(UsrGroupBRRuleData);
			foreach(UsrGroupBRRuleData item in list)
			{
				this.Add(new UsrGroupBRRuleData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrGroupBRRuleData item in deletedList)
			{
				UsrGroupBRRuleData entity = new UsrGroupBRRuleData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "UsrGroupBRRule"; }
		}

		#endregion

		public void Add(UsrGroupBRRuleData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrGroupBRRuleDataCollection list)
		{
			foreach(UsrGroupBRRuleData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrGroupBRRuleData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrGroupBRRuleData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrGroupBRRuleData item)
		{
			foreach (UsrGroupBRRuleData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrGroupBRRuleData item)
		{
			foreach (UsrGroupBRRuleData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrGroupBRRuleData this[int index]
		{
			get
			{
				return (UsrGroupBRRuleData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of UsrGroupBRRuleData");
			}
		}

	}
	[Serializable]
	public class ACInputGroupInputMapDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public ACInputGroupInputMapDataCollection()
		{
			base._itemType = typeof(ACInputGroupInputMapData);
		}

		public ACInputGroupInputMapDataCollection(ACInputGroupInputMapDataCollection list)
		{
			base._itemType = typeof(ACInputGroupInputMapData);
			foreach(ACInputGroupInputMapData item in list)
			{
				this.Add(new ACInputGroupInputMapData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACInputGroupInputMapData item in deletedList)
			{
				ACInputGroupInputMapData entity = new ACInputGroupInputMapData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "ACInputGroupInputMap"; }
		}

		#endregion

		public void Add(ACInputGroupInputMapData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACInputGroupInputMapDataCollection list)
		{
			foreach(ACInputGroupInputMapData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACInputGroupInputMapData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACInputGroupInputMapData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACInputGroupInputMapData item)
		{
			foreach (ACInputGroupInputMapData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACInputGroupInputMapData item)
		{
			foreach (ACInputGroupInputMapData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACInputGroupInputMapData this[int index]
		{
			get
			{
				return (ACInputGroupInputMapData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of ACInputGroupInputMapData");
			}
		}

	}
	[Serializable]
	public class UsrAccountBRRuleDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public UsrAccountBRRuleDataCollection()
		{
			base._itemType = typeof(UsrAccountBRRuleData);
		}

		public UsrAccountBRRuleDataCollection(UsrAccountBRRuleDataCollection list)
		{
			base._itemType = typeof(UsrAccountBRRuleData);
			foreach(UsrAccountBRRuleData item in list)
			{
				this.Add(new UsrAccountBRRuleData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrAccountBRRuleData item in deletedList)
			{
				UsrAccountBRRuleData entity = new UsrAccountBRRuleData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "UsrAccountBRRule"; }
		}

		#endregion

		public void Add(UsrAccountBRRuleData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrAccountBRRuleDataCollection list)
		{
			foreach(UsrAccountBRRuleData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrAccountBRRuleData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrAccountBRRuleData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrAccountBRRuleData item)
		{
			foreach (UsrAccountBRRuleData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrAccountBRRuleData item)
		{
			foreach (UsrAccountBRRuleData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrAccountBRRuleData this[int index]
		{
			get
			{
				return (UsrAccountBRRuleData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of UsrAccountBRRuleData");
			}
		}

	}
	[Serializable]
	public class UsrAccountTenantMapDataCollection : BusinessCollectionBase
	{
		#region Constructors
		public UsrAccountTenantMapDataCollection()
		{
			base._itemType = typeof(UsrAccountTenantMapData);
		}

		public UsrAccountTenantMapDataCollection(UsrAccountTenantMapDataCollection list)
		{
			base._itemType = typeof(UsrAccountTenantMapData);
			foreach(UsrAccountTenantMapData item in list)
			{
				this.Add(new UsrAccountTenantMapData(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrAccountTenantMapData item in deletedList)
			{
				UsrAccountTenantMapData entity = new UsrAccountTenantMapData(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		public override string TableName
		{
			get { return "UsrAccountTenantMap"; }
		}

		#endregion

		public void Add(UsrAccountTenantMapData obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrAccountTenantMapDataCollection list)
		{
			foreach(UsrAccountTenantMapData item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrAccountTenantMapData obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrAccountTenantMapData obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrAccountTenantMapData item)
		{
			foreach (UsrAccountTenantMapData data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrAccountTenantMapData item)
		{
			foreach (UsrAccountTenantMapData data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrAccountTenantMapData this[int index]
		{
			get
			{
				return (UsrAccountTenantMapData) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		protected override void OnValidate(object item)
		{
			System.Type t = item.GetType();
			if (t != base._itemType && !t.IsSubclassOf(base._itemType))
			{
				throw new ArgumentException("The item must be a type of UsrAccountTenantMapData");
			}
		}

	}
}
