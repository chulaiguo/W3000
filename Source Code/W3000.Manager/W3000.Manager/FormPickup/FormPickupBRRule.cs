using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Utils;
using W3000.Schema;

namespace W3000.Manager.FormPickup
{
	public partial class FormPickupBRRule : FormPickupBase
	{
		private readonly SortedList<int, int> _excludeList = null;
        private List<BRRuleConstant> _list = null;

		public FormPickupBRRule()
		{
			InitializeComponent();
		}

        public FormPickupBRRule(SortedList<int, int> excludeList)
		{
			InitializeComponent();

            this._excludeList = excludeList;
		}

        public List<BRRuleConstant> BRRuleList
		{
			get{ return this._list; }
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();

            SortedList<string, BRRuleConstant> sortedIndex = new SortedList<string, BRRuleConstant>();
            BRRuleConstant[] list = BRRuleConstant.GetAll();
            foreach (BRRuleConstant item in list)
			{
                if (this._excludeList != null && this._excludeList.ContainsKey(item.ID))
					continue;

				if(sortedIndex.ContainsKey(item.Description))
                    continue;

                sortedIndex.Add(item.Description, item);
			}

            List<BRRuleConstant> dataSource = new List<BRRuleConstant>();
		    foreach (KeyValuePair<string, BRRuleConstant> pair in sortedIndex)
		    {
		        dataSource.Add(pair.Value);
		    }

			if (dataSource.Count == 0)
			{
				this.CanPickup = false;
				return;
			}

            this.ListBox.DisplayMember = BRRuleConstantSchema.Description;
			this.ListBox.DataSource = dataSource;
		}

		protected override void Pickup()
		{
			this._list = new List<BRRuleConstant>();
			foreach (object item in this.ListBox.CheckedItems)
			{
                BRRuleConstant entity = item as BRRuleConstant;
				if (entity == null)
					continue;

				this._list.Add(entity);
			}
		}
	}
}
