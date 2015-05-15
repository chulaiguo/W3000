namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailUsrAccountTenantMap
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
			this.txtTenant = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtUserID = new Cheke.WinCtrl.Common.TextEditEx();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBuildingID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTenant.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).BeginInit();
			this.SuspendLayout();
			//
			// pnlContent
			//
			this.pnlContent.Controls.Add(this.txtAddress1);
			this.pnlContent.Controls.Add(this.txtBuildingID);
			this.pnlContent.Controls.Add(this.txtTenant);
			this.pnlContent.Controls.Add(this.txtUserID);
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
			// txtTenant
			//
			this.txtTenant.EditValue = "";
			this.txtTenant.Location = new System.Drawing.Point(5, 80);
			this.txtTenant.Name = "txtTenant";
			this.txtTenant.ReadOnly = true;
			this.txtTenant.TabIndex = 2;
			this.txtTenant.Title = "Tenant";
			//
			// txtUserID
			//
			this.txtUserID.EditValue = "";
			this.txtUserID.Location = new System.Drawing.Point(5, 120);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.ReadOnly = true;
			this.txtUserID.TabIndex = 3;
			this.txtUserID.Title = "UserID";
			//
			// FormDetailUsrAccountTenantMap
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailUsrAccountTenantMap";
			this.Text = "UsrAccountTenantMap Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBuildingID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTenant.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtAddress1;
		private Cheke.WinCtrl.Common.TextEditEx txtBuildingID;
		private Cheke.WinCtrl.Common.TextEditEx txtTenant;
		private Cheke.WinCtrl.Common.TextEditEx txtUserID;
	}
}
