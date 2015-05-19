using System;

namespace W3000.Data
{
	public partial class ACCardHolderBuildingMapData
	{
		public string FullName
		{
			get
			{
				if (String.IsNullOrEmpty(this.FirstName))
					return this.LastName;

				return string.Format("{0}, {1}", this.LastName, this.FirstName);
			}
		}
	}
	public partial class ACCardHolderData
	{
		public string FullName
		{
			get
			{
				if (String.IsNullOrEmpty(this.FirstName))
					return this.LastName;

				return string.Format("{0}, {1}", this.LastName, this.FirstName);
			}
		}
	}
	public partial class ACFunctionCardData
	{
		public string FullName
		{
			get
			{
				if (String.IsNullOrEmpty(this.FirstName))
					return this.LastName;

				return string.Format("{0}, {1}", this.LastName, this.FirstName);
			}
		}
	}
	public partial class ACMasterCardData
	{
		public string FullName
		{
			get
			{
				if (String.IsNullOrEmpty(this.FirstName))
					return this.LastName;

				return string.Format("{0}, {1}", this.LastName, this.FirstName);
			}
		}
	}
	public partial class BDVisitorData
	{
		public string FullName
		{
			get
			{
				if (String.IsNullOrEmpty(this.FirstName))
					return this.LastName;

				return string.Format("{0}, {1}", this.LastName, this.FirstName);
			}
		}
	}

	public partial class UsrAccountData
	{
		public string FullName
		{
			get
			{
				if (String.IsNullOrEmpty(this.FirstName))
					return this.LastName;

				return string.Format("{0}, {1}", this.LastName, this.FirstName);
			}
		}
	}

}
