using System;

namespace W3000.Data
{
	[Serializable]
	public partial class UtilSettingDetailView
	{
		private System.Guid _utilSettingDetailPK = Guid.Empty;
		private System.Guid _utilSettingCategoryPK = Guid.Empty;
		private System.String _fieldName = string.Empty;
		//private System.String _fieldValue = string.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;

		public System.Guid UtilSettingDetailPK
		{
			get{ return this._utilSettingDetailPK; }
			set{ this._utilSettingDetailPK = value; }
		}

		public System.Guid UtilSettingCategoryPK
		{
			get{ return this._utilSettingCategoryPK; }
			set{ this._utilSettingCategoryPK = value; }
		}

		public System.String FieldName
		{
			get{ return this._fieldName; }
			set{ this._fieldName = value; }
		}

//		public System.String FieldValue
//		{
//			get{ return this._fieldValue; }
//			set{ this._fieldValue = value; }
//		}

//		public System.DateTime CreatedOn
//		{
//			get{ return this._createdOn.ToLocalTime(); }
//			set{ this._createdOn = value.ToUniversalTime(); }
//		}

//		public System.String CreatedBy
//		{
//			get{ return this._createdBy; }
//			set{ this._createdBy = value; }
//		}

//		public System.DateTime ModifiedOn
//		{
//			get{ return this._modifiedOn.ToLocalTime(); }
//			set{ this._modifiedOn = value.ToUniversalTime(); }
//		}

//		public System.String ModifiedBy
//		{
//			get{ return this._modifiedBy; }
//			set{ this._modifiedBy = value; }
//		}

		public UtilSettingDetailView()
		{
		}

		public UtilSettingDetailView(UtilSettingDetailData data)
		{
			this.UtilSettingDetailPK = data.UtilSettingDetailPK;
			this.UtilSettingCategoryPK = data.UtilSettingCategoryPK;
			this.FieldName = data.FieldName;
			//this.FieldValue = data.FieldValue;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
		}


		public UtilSettingDetailData ToUtilSettingDetailData()
		{
			UtilSettingDetailData entity = new UtilSettingDetailData();
			entity.UtilSettingDetailPK = this.UtilSettingDetailPK;
			entity.UtilSettingCategoryPK = this.UtilSettingCategoryPK;
			entity.FieldName = this.FieldName;
			//entity.FieldValue = this.FieldValue;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;

			return entity;
		}
	}
}
