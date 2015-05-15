namespace W3000.Manager.FormWorkSearch
{
	public partial class FormWorkACCardHolderSearch
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
			this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.pnlSearchCriteria)).BeginInit();
			this.pnlSearchCriteria.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			this.SuspendLayout();
			//
			// pnlSearchCriteria
			//
			this.pnlSearchCriteria.Controls.Add(this.btnSearch);
			//
			// btnSearch
			//
			this.btnSearch.Location = new System.Drawing.Point(300, 27);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 0;
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			//
			// FormWorkACCardHolderSearch
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoScrollMinSize = new System.Drawing.Size(800, 610);
			this.ClientSize = new System.Drawing.Size(800, 670);
			this.Name = "FormWorkACCardHolderSearch";
			this.Text = "ACCardHolder Search";
			((System.ComponentModel.ISupportInitialize)(this.pnlSearchCriteria)).EndInit();
			this.pnlSearchCriteria.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton btnSearch;
	}
}
