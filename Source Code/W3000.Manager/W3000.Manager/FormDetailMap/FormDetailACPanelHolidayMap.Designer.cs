namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailACPanelHolidayMap
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtCountryID = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtHoliday = new Cheke.WinCtrl.Common.TextEditEx();
			this.dateDate = new Cheke.WinCtrl.Common.DateEditEx();
			this.txtUnitID = new Cheke.WinCtrl.Common.TextEditEx();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtCountryID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHoliday.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUnitID.Properties)).BeginInit();
			this.SuspendLayout();
			//
			// pnlContent
			//
			this.pnlContent.Controls.Add(this.txtCountryID);
			this.pnlContent.Controls.Add(this.txtHoliday);
			this.pnlContent.Controls.Add(this.dateDate);
			this.pnlContent.Controls.Add(this.txtUnitID);
			//
			// txtCountryID
			//
			this.txtCountryID.EditValue = "";
			this.txtCountryID.Location = new System.Drawing.Point(5, 0);
			this.txtCountryID.Name = "txtCountryID";
			this.txtCountryID.ReadOnly = true;
			this.txtCountryID.TabIndex = 0;
			this.txtCountryID.Title = "CountryID";
			this.txtCountryID.Properties.Mask.EditMask = "n0";
			this.txtCountryID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtCountryID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtHoliday
			//
			this.txtHoliday.EditValue = "";
			this.txtHoliday.Location = new System.Drawing.Point(5, 40);
			this.txtHoliday.Name = "txtHoliday";
			this.txtHoliday.ReadOnly = true;
			this.txtHoliday.TabIndex = 1;
			this.txtHoliday.Title = "Holiday";
			//
			// dateDate
			//
			this.dateDate.EditValue =  new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
			this.dateDate.Location = new System.Drawing.Point(5, 80);
			this.dateDate.Name = "dateDate";
			this.dateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
				});
			this.dateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.dateDate.ReadOnly = true;
			this.dateDate.TabIndex = 2;
			this.dateDate.Title = "Date";
			//
			// txtUnitID
			//
			this.txtUnitID.EditValue = "";
			this.txtUnitID.Location = new System.Drawing.Point(5, 120);
			this.txtUnitID.Name = "txtUnitID";
			this.txtUnitID.ReadOnly = true;
			this.txtUnitID.TabIndex = 3;
			this.txtUnitID.Title = "UnitID";
			this.txtUnitID.Properties.Mask.EditMask = "n0";
			this.txtUnitID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtUnitID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// FormDetailACPanelHolidayMap
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailACPanelHolidayMap";
			this.Text = "ACPanelHolidayMap Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtCountryID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHoliday.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUnitID.Properties)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtCountryID;
		private Cheke.WinCtrl.Common.TextEditEx txtHoliday;
		private Cheke.WinCtrl.Common.DateEditEx dateDate;
		private Cheke.WinCtrl.Common.TextEditEx txtUnitID;
	}
}
