namespace W3000.Manager.FormWorkList
{
	public partial class FormWorkACMainZoneList
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
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			//
			// pnlContent
			//
			this.pnlContent.Controls.Add(this.gridControl1);
			//
			// gridControl1
			//
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.EmbeddedNavigator.Name = "";
			this.gridControl1.Location = new System.Drawing.Point(2, 2);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
			this.gridView1});
			//
			// gridView1
			//
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			//
			// FormWorkACMainZoneList
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormWorkACMainZoneList";
			this.Text = "ACMainZone List";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}
