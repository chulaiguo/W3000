namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailACIntvalHolidayMap
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
            this.txtAddress1 = new Cheke.WinCtrl.Common.TextEditEx();
            this.txtBuildingID = new Cheke.WinCtrl.Common.TextEditEx();
            this.txtIVID = new Cheke.WinCtrl.Common.TextEditEx();
            this.txtHoliday = new Cheke.WinCtrl.Common.TextEditEx();
            this.dateDate = new Cheke.WinCtrl.Common.DateEditEx();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuildingID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoliday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.txtAddress1);
            this.pnlContent.Controls.Add(this.txtBuildingID);
            this.pnlContent.Controls.Add(this.txtIVID);
            this.pnlContent.Controls.Add(this.txtHoliday);
            this.pnlContent.Controls.Add(this.dateDate);
            // 
            // txtAddress1
            // 
            this.txtAddress1.EditValue = "";
            this.txtAddress1.Location = new System.Drawing.Point(5, 0);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Properties.ReadOnly = true;
            this.txtAddress1.ReadOnly = true;
            this.txtAddress1.Size = new System.Drawing.Size(150, 35);
            this.txtAddress1.TabIndex = 0;
            this.txtAddress1.Title = "Address1";
            // 
            // txtBuildingID
            // 
            this.txtBuildingID.EditValue = "";
            this.txtBuildingID.Location = new System.Drawing.Point(5, 40);
            this.txtBuildingID.Name = "txtBuildingID";
            this.txtBuildingID.Properties.Mask.EditMask = "n0";
            this.txtBuildingID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBuildingID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBuildingID.Properties.ReadOnly = true;
            this.txtBuildingID.ReadOnly = true;
            this.txtBuildingID.Size = new System.Drawing.Size(150, 35);
            this.txtBuildingID.TabIndex = 1;
            this.txtBuildingID.Title = "BuildingID";
            // 
            // txtIVID
            // 
            this.txtIVID.EditValue = "";
            this.txtIVID.Location = new System.Drawing.Point(5, 80);
            this.txtIVID.Name = "txtIVID";
            this.txtIVID.Properties.Mask.EditMask = "n0";
            this.txtIVID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIVID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtIVID.Properties.ReadOnly = true;
            this.txtIVID.ReadOnly = true;
            this.txtIVID.Size = new System.Drawing.Size(150, 35);
            this.txtIVID.TabIndex = 2;
            this.txtIVID.Title = "IVID";
            // 
            // txtHoliday
            // 
            this.txtHoliday.EditValue = "";
            this.txtHoliday.Location = new System.Drawing.Point(5, 160);
            this.txtHoliday.Name = "txtHoliday";
            this.txtHoliday.Properties.ReadOnly = true;
            this.txtHoliday.ReadOnly = true;
            this.txtHoliday.Size = new System.Drawing.Size(150, 35);
            this.txtHoliday.TabIndex = 4;
            this.txtHoliday.Title = "Holiday";
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateDate.Location = new System.Drawing.Point(5, 200);
            this.dateDate.Name = "dateDate";
            this.dateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDate.Properties.ReadOnly = true;
            this.dateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateDate.ReadOnly = true;
            this.dateDate.Size = new System.Drawing.Size(150, 35);
            this.dateDate.TabIndex = 5;
            this.dateDate.Title = "Date";
            // 
            // FormDetailACIntvalHolidayMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(470, 380);
            this.Name = "FormDetailACIntvalHolidayMap";
            this.Text = "ACIntvalHolidayMap Detail";
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuildingID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoliday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtAddress1;
		private Cheke.WinCtrl.Common.TextEditEx txtBuildingID;
        private Cheke.WinCtrl.Common.TextEditEx txtIVID;
		private Cheke.WinCtrl.Common.TextEditEx txtHoliday;
		private Cheke.WinCtrl.Common.DateEditEx dateDate;
	}
}
