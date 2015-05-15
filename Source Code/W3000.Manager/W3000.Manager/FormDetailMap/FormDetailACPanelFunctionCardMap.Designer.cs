namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailACPanelFunctionCardMap
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
			this.txtSitecode = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtEmbossed = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtCardTypeID = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtEncoded = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtUnitID = new Cheke.WinCtrl.Common.TextEditEx();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtSitecode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmbossed.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCardTypeID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEncoded.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUnitID.Properties)).BeginInit();
			this.SuspendLayout();
			//
			// pnlContent
			//
			this.pnlContent.Controls.Add(this.txtSitecode);
			this.pnlContent.Controls.Add(this.txtEmbossed);
			this.pnlContent.Controls.Add(this.txtCardTypeID);
			this.pnlContent.Controls.Add(this.txtEncoded);
			this.pnlContent.Controls.Add(this.txtUnitID);
			//
			// txtSitecode
			//
			this.txtSitecode.EditValue = "";
			this.txtSitecode.Location = new System.Drawing.Point(5, 0);
			this.txtSitecode.Name = "txtSitecode";
			this.txtSitecode.ReadOnly = true;
			this.txtSitecode.TabIndex = 0;
			this.txtSitecode.Title = "Sitecode";
			this.txtSitecode.Properties.Mask.EditMask = "n0";
			this.txtSitecode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtSitecode.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtEmbossed
			//
			this.txtEmbossed.EditValue = "";
			this.txtEmbossed.Location = new System.Drawing.Point(5, 40);
			this.txtEmbossed.Name = "txtEmbossed";
			this.txtEmbossed.ReadOnly = true;
			this.txtEmbossed.TabIndex = 1;
			this.txtEmbossed.Title = "Embossed";
			this.txtEmbossed.Properties.Mask.EditMask = "n0";
			this.txtEmbossed.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtEmbossed.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtCardTypeID
			//
			this.txtCardTypeID.EditValue = "";
			this.txtCardTypeID.Location = new System.Drawing.Point(5, 80);
			this.txtCardTypeID.Name = "txtCardTypeID";
			this.txtCardTypeID.ReadOnly = true;
			this.txtCardTypeID.TabIndex = 2;
			this.txtCardTypeID.Title = "CardTypeID";
			this.txtCardTypeID.Properties.Mask.EditMask = "n0";
			this.txtCardTypeID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtCardTypeID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtEncoded
			//
			this.txtEncoded.EditValue = "";
			this.txtEncoded.Location = new System.Drawing.Point(5, 120);
			this.txtEncoded.Name = "txtEncoded";
			this.txtEncoded.ReadOnly = true;
			this.txtEncoded.TabIndex = 3;
			this.txtEncoded.Title = "Encoded";
			this.txtEncoded.Properties.Mask.EditMask = "n0";
			this.txtEncoded.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtEncoded.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtUnitID
			//
			this.txtUnitID.EditValue = "";
			this.txtUnitID.Location = new System.Drawing.Point(5, 160);
			this.txtUnitID.Name = "txtUnitID";
			this.txtUnitID.ReadOnly = true;
			this.txtUnitID.TabIndex = 4;
			this.txtUnitID.Title = "UnitID";
			this.txtUnitID.Properties.Mask.EditMask = "n0";
			this.txtUnitID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtUnitID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// FormDetailACPanelFunctionCardMap
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailACPanelFunctionCardMap";
			this.Text = "ACPanelFunctionCardMap Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtSitecode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmbossed.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCardTypeID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEncoded.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUnitID.Properties)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtSitecode;
		private Cheke.WinCtrl.Common.TextEditEx txtEmbossed;
		private Cheke.WinCtrl.Common.TextEditEx txtCardTypeID;
		private Cheke.WinCtrl.Common.TextEditEx txtEncoded;
		private Cheke.WinCtrl.Common.TextEditEx txtUnitID;
	}
}
