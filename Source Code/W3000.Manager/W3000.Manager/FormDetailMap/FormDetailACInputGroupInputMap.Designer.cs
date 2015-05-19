namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailACInputGroupInputMap
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
            this.txtUnitID = new Cheke.WinCtrl.Common.TextEditEx();
            this.txtGroupID = new Cheke.WinCtrl.Common.TextEditEx();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.txtUnitID);
            this.pnlContent.Controls.Add(this.txtGroupID);
            // 
            // txtUnitID
            // 
            this.txtUnitID.EditValue = "";
            this.txtUnitID.Location = new System.Drawing.Point(5, 0);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.Properties.Mask.EditMask = "n0";
            this.txtUnitID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtUnitID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtUnitID.Properties.ReadOnly = true;
            this.txtUnitID.ReadOnly = true;
            this.txtUnitID.Size = new System.Drawing.Size(150, 35);
            this.txtUnitID.TabIndex = 0;
            this.txtUnitID.Title = "UnitID";
            // 
            // txtGroupID
            // 
            this.txtGroupID.EditValue = "";
            this.txtGroupID.Location = new System.Drawing.Point(5, 40);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Properties.Mask.EditMask = "n0";
            this.txtGroupID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGroupID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtGroupID.Properties.ReadOnly = true;
            this.txtGroupID.ReadOnly = true;
            this.txtGroupID.Size = new System.Drawing.Size(150, 35);
            this.txtGroupID.TabIndex = 1;
            this.txtGroupID.Title = "GroupID";
            // 
            // FormDetailACInputGroupInputMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(470, 380);
            this.Name = "FormDetailACInputGroupInputMap";
            this.Text = "ACInputGroupInputMap Detail";
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupID.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtUnitID;
        private Cheke.WinCtrl.Common.TextEditEx txtGroupID;
	}
}
