namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailACTimecodeIntervalMap
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
			this.txtTCID = new Cheke.WinCtrl.Common.TextEditEx();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBuildingID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtIVID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTCID.Properties)).BeginInit();
			this.SuspendLayout();
			//
			// pnlContent
			//
			this.pnlContent.Controls.Add(this.txtAddress1);
			this.pnlContent.Controls.Add(this.txtBuildingID);
			this.pnlContent.Controls.Add(this.txtIVID);
			this.pnlContent.Controls.Add(this.txtTCID);
			//
			// txtAddress1
			//
			this.txtAddress1.EditValue = "";
			this.txtAddress1.Location = new System.Drawing.Point(5, 0);
			this.txtAddress1.Name = "txtAddress1";
			this.txtAddress1.ReadOnly = true;
			this.txtAddress1.TabIndex = 0;
			this.txtAddress1.Title = "Address1";
			//
			// txtBuildingID
			//
			this.txtBuildingID.EditValue = "";
			this.txtBuildingID.Location = new System.Drawing.Point(5, 40);
			this.txtBuildingID.Name = "txtBuildingID";
			this.txtBuildingID.ReadOnly = true;
			this.txtBuildingID.TabIndex = 1;
			this.txtBuildingID.Title = "BuildingID";
			this.txtBuildingID.Properties.Mask.EditMask = "n0";
			this.txtBuildingID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtBuildingID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtIVID
			//
			this.txtIVID.EditValue = "";
			this.txtIVID.Location = new System.Drawing.Point(5, 80);
			this.txtIVID.Name = "txtIVID";
			this.txtIVID.ReadOnly = true;
			this.txtIVID.TabIndex = 2;
			this.txtIVID.Title = "IVID";
			this.txtIVID.Properties.Mask.EditMask = "n0";
			this.txtIVID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtIVID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtTCID
			//
			this.txtTCID.EditValue = "";
			this.txtTCID.Location = new System.Drawing.Point(5, 120);
			this.txtTCID.Name = "txtTCID";
			this.txtTCID.ReadOnly = true;
			this.txtTCID.TabIndex = 3;
			this.txtTCID.Title = "TCID";
			this.txtTCID.Properties.Mask.EditMask = "n0";
			this.txtTCID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtTCID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// FormDetailACTimecodeIntervalMap
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailACTimecodeIntervalMap";
			this.Text = "ACTimecodeIntervalMap Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBuildingID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtIVID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTCID.Properties)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtAddress1;
		private Cheke.WinCtrl.Common.TextEditEx txtBuildingID;
		private Cheke.WinCtrl.Common.TextEditEx txtIVID;
		private Cheke.WinCtrl.Common.TextEditEx txtTCID;
	}
}
