namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailACAMFormat
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
			this.txtAMFID = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtSummary = new Cheke.WinCtrl.Common.MemoEditEx();
			this.txtNotes = new Cheke.WinCtrl.Common.MemoEditEx();
			this.txtReportTC = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtAlarmTC = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtPreAlarmTC = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtBDBuilding = new Cheke.WinCtrl.Common.ButtonEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtAMFID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSummary.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtReportTC.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAlarmTC.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPreAlarmTC.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBDBuilding.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			this.SuspendLayout();
			//
			// pnlContent
			//
			this.pnlContent.Controls.Add(this.xtraTabControl1);
			//
			// xtraTabControl1
			//
			this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.tabDetail;
			this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
			this.tabDetail});
			this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
			//
			// tabDetail
			//
			this.tabDetail.Controls.Add(this.txtAMFID);
			this.tabDetail.Controls.Add(this.txtSummary);
			this.tabDetail.Controls.Add(this.txtNotes);
			this.tabDetail.Controls.Add(this.txtReportTC);
			this.tabDetail.Controls.Add(this.txtAlarmTC);
			this.tabDetail.Controls.Add(this.txtPreAlarmTC);
			this.tabDetail.Controls.Add(this.txtBDBuilding);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// txtAMFID
			//
			this.txtAMFID.EditValue = "";
			this.txtAMFID.Location = new System.Drawing.Point(5, 0);
			this.txtAMFID.Name = "txtAMFID";
			this.txtAMFID.TabIndex = 0;
			this.txtAMFID.Title = "AMFID";
			this.txtAMFID.Properties.Mask.EditMask = "n0";
			this.txtAMFID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtAMFID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtSummary
			//
			this.txtSummary.EditValue = "";
			this.txtSummary.Location = new System.Drawing.Point(5, 40);
			this.txtSummary.Name = "txtSummary";
			this.txtSummary.TabIndex = 1;
			this.txtSummary.Title = "Summary";
			//
			// txtNotes
			//
			this.txtNotes.EditValue = "";
			this.txtNotes.Location = new System.Drawing.Point(5, 200);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.TabIndex = 2;
			this.txtNotes.Title = "Notes";
			//
			// txtReportTC
			//
			this.txtReportTC.EditValue = "";
			this.txtReportTC.Location = new System.Drawing.Point(160, 0);
			this.txtReportTC.Name = "txtReportTC";
			this.txtReportTC.TabIndex = 3;
			this.txtReportTC.Title = "ReportTC";
			this.txtReportTC.Properties.Mask.EditMask = "n0";
			this.txtReportTC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtReportTC.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtAlarmTC
			//
			this.txtAlarmTC.EditValue = "";
			this.txtAlarmTC.Location = new System.Drawing.Point(160, 40);
			this.txtAlarmTC.Name = "txtAlarmTC";
			this.txtAlarmTC.TabIndex = 4;
			this.txtAlarmTC.Title = "AlarmTC";
			this.txtAlarmTC.Properties.Mask.EditMask = "n0";
			this.txtAlarmTC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtAlarmTC.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtPreAlarmTC
			//
			this.txtPreAlarmTC.EditValue = "";
			this.txtPreAlarmTC.Location = new System.Drawing.Point(160, 80);
			this.txtPreAlarmTC.Name = "txtPreAlarmTC";
			this.txtPreAlarmTC.TabIndex = 5;
			this.txtPreAlarmTC.Title = "PreAlarmTC";
			this.txtPreAlarmTC.Properties.Mask.EditMask = "n0";
			this.txtPreAlarmTC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtPreAlarmTC.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtBDBuilding
			//
			this.txtBDBuilding.EditValue = "";
			this.txtBDBuilding.Location = new System.Drawing.Point(160, 120);
			this.txtBDBuilding.Name = "txtBDBuilding";
			this.txtBDBuilding.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] 
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.txtBDBuilding.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtBDBuilding.ReadOnly = false;
			this.txtBDBuilding.TabIndex = 6;
			this.txtBDBuilding.Title = "BDBuilding";
			this.txtBDBuilding.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtBDBuilding_ButtonClick);
			//
			// FormDetailACAMFormat
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailACAMFormat";
			this.Text = "ACAMFormat Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtAMFID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSummary.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtReportTC.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAlarmTC.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPreAlarmTC.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBDBuilding.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtAMFID;
		private Cheke.WinCtrl.Common.MemoEditEx txtSummary;
		private Cheke.WinCtrl.Common.MemoEditEx txtNotes;
		private Cheke.WinCtrl.Common.TextEditEx txtReportTC;
		private Cheke.WinCtrl.Common.TextEditEx txtAlarmTC;
		private Cheke.WinCtrl.Common.TextEditEx txtPreAlarmTC;
		private Cheke.WinCtrl.Common.ButtonEditEx txtBDBuilding;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
	}
}
