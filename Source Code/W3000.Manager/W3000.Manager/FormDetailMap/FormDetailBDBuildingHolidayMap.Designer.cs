namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailBDBuildingHolidayMap
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
            this.txtActionID = new Cheke.WinCtrl.Common.TextEditEx();
            this.txtNotes = new Cheke.WinCtrl.Common.MemoEditEx();
            this.txtAddress1 = new Cheke.WinCtrl.Common.TextEditEx();
            this.txtBuildingID = new Cheke.WinCtrl.Common.TextEditEx();
            this.txtHoliday = new Cheke.WinCtrl.Common.TextEditEx();
            this.dateDate = new Cheke.WinCtrl.Common.DateEditEx();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActionID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuildingID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoliday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.txtActionID);
            this.pnlContent.Controls.Add(this.txtNotes);
            this.pnlContent.Controls.Add(this.txtAddress1);
            this.pnlContent.Controls.Add(this.txtBuildingID);
            this.pnlContent.Controls.Add(this.txtHoliday);
            this.pnlContent.Controls.Add(this.dateDate);
            // 
            // txtActionID
            // 
            this.txtActionID.EditValue = "";
            this.txtActionID.Location = new System.Drawing.Point(5, 0);
            this.txtActionID.Name = "txtActionID";
            this.txtActionID.Properties.Mask.EditMask = "n0";
            this.txtActionID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtActionID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtActionID.ReadOnly = false;
            this.txtActionID.Size = new System.Drawing.Size(150, 35);
            this.txtActionID.TabIndex = 0;
            this.txtActionID.Title = "ActionID";
            // 
            // txtNotes
            // 
            this.txtNotes.EditValue = "";
            this.txtNotes.Location = new System.Drawing.Point(5, 40);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = false;
            this.txtNotes.Size = new System.Drawing.Size(150, 150);
            this.txtNotes.TabIndex = 1;
            this.txtNotes.Title = "Notes";
            // 
            // txtAddress1
            // 
            this.txtAddress1.EditValue = "";
            this.txtAddress1.Location = new System.Drawing.Point(5, 200);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Properties.ReadOnly = true;
            this.txtAddress1.ReadOnly = true;
            this.txtAddress1.Size = new System.Drawing.Size(150, 35);
            this.txtAddress1.TabIndex = 2;
            this.txtAddress1.Title = "Address1";
            // 
            // txtBuildingID
            // 
            this.txtBuildingID.EditValue = "";
            this.txtBuildingID.Location = new System.Drawing.Point(5, 240);
            this.txtBuildingID.Name = "txtBuildingID";
            this.txtBuildingID.Properties.Mask.EditMask = "n0";
            this.txtBuildingID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBuildingID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBuildingID.Properties.ReadOnly = true;
            this.txtBuildingID.ReadOnly = true;
            this.txtBuildingID.Size = new System.Drawing.Size(150, 35);
            this.txtBuildingID.TabIndex = 3;
            this.txtBuildingID.Title = "BuildingID";
            // 
            // txtHoliday
            // 
            this.txtHoliday.EditValue = "";
            this.txtHoliday.Location = new System.Drawing.Point(160, 0);
            this.txtHoliday.Name = "txtHoliday";
            this.txtHoliday.Properties.ReadOnly = true;
            this.txtHoliday.ReadOnly = true;
            this.txtHoliday.Size = new System.Drawing.Size(150, 35);
            this.txtHoliday.TabIndex = 5;
            this.txtHoliday.Title = "Holiday";
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateDate.Location = new System.Drawing.Point(160, 40);
            this.dateDate.Name = "dateDate";
            this.dateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDate.Properties.ReadOnly = true;
            this.dateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateDate.ReadOnly = true;
            this.dateDate.Size = new System.Drawing.Size(150, 35);
            this.dateDate.TabIndex = 6;
            this.dateDate.Title = "Date";
            // 
            // FormDetailBDBuildingHolidayMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(470, 380);
            this.Name = "FormDetailBDBuildingHolidayMap";
            this.Text = "BDBuildingHolidayMap Detail";
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActionID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuildingID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoliday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtActionID;
		private Cheke.WinCtrl.Common.MemoEditEx txtNotes;
		private Cheke.WinCtrl.Common.TextEditEx txtAddress1;
        private Cheke.WinCtrl.Common.TextEditEx txtBuildingID;
		private Cheke.WinCtrl.Common.TextEditEx txtHoliday;
		private Cheke.WinCtrl.Common.DateEditEx dateDate;
	}
}
