using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Utils;
using W3000.Schema;

namespace W3000.Manager.FormPickup
{
	public partial class FormPickupDBRule : FormPickupBase
	{
		private readonly SortedList<int, int> _excludeList = null;
        private List<DBRuleConstant> _list = null;

		public FormPickupDBRule()
		{
			InitializeComponent();
		}

        public FormPickupDBRule(SortedList<int, int> excludeList)
		{
			InitializeComponent();

            this._excludeList = excludeList;
		}

        public List<DBRuleConstant> DBRuleList
		{
			get{ return this._list; }
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();

			SortedList<string, DBRuleConstant> sortedIndex = new SortedList<string, DBRuleConstant>();
            DBRuleConstant[] list = DBRuleConstant.GetAll();
            foreach (DBRuleConstant item in list)
			{
                if (this._excludeList != null && this._excludeList.ContainsKey(item.ID))
					continue;

                if (sortedIndex.ContainsKey(item.Description))
                    continue;

                sortedIndex.Add(item.Description, item);
			}

            List<DBRuleConstant> dataSource = new List<DBRuleConstant>();
		    foreach (KeyValuePair<string, DBRuleConstant> pair in sortedIndex)
		    {
		        dataSource.Add(pair.Value);
		    }

			if (dataSource.Count == 0)
			{
				this.CanPickup = false;
				return;
			}

            this.ListBox.DisplayMember = DBRuleConstantSchema.Description;
			this.ListBox.DataSource = dataSource;
		}

		protected override void Pickup()
		{
			this._list = new List<DBRuleConstant>();
			foreach (object item in this.ListBox.CheckedItems)
			{
                DBRuleConstant entity = item as DBRuleConstant;
				if (entity == null)
					continue;

				this._list.Add(entity);
			}
		}
	}
}
