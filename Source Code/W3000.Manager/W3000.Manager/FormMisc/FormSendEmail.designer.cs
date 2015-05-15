namespace W3000.Manager.FormMisc
{
    partial class FormSendEmail
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
            this.pnlClient = new DevExpress.XtraEditors.PanelControl();
            this.txtBody = new DevExpress.XtraEditors.MemoEdit();
            this.lblAttached = new DevExpress.XtraEditors.LabelControl();
            this.txtAttached = new DevExpress.XtraEditors.TextEdit();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.txtSubject = new DevExpress.XtraEditors.TextEdit();
            this.txtTo = new DevExpress.XtraEditors.TextEdit();
            this.btnTo = new DevExpress.XtraEditors.SimpleButton();
            this.btnSendEmail = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlClient)).BeginInit();
            this.pnlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBody.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAttached.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.txtBody);
            this.pnlClient.Controls.Add(this.lblAttached);
            this.pnlClient.Controls.Add(this.txtAttached);
            this.pnlClient.Controls.Add(this.lblSubject);
            this.pnlClient.Controls.Add(this.txtSubject);
            this.pnlClient.Controls.Add(this.txtTo);
            this.pnlClient.Controls.Add(this.btnTo);
            this.pnlClient.Controls.Add(this.btnSendEmail);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClient.Location = new System.Drawing.Point(0, 0);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(698, 485);
            this.pnlClient.TabIndex = 0;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(12, 155);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(670, 319);
            this.txtBody.TabIndex = 15;
            // 
            // lblAttached
            // 
            this.lblAttached.Location = new System.Drawing.Point(107, 107);
            this.lblAttached.Name = "lblAttached";
            this.lblAttached.Size = new System.Drawing.Size(48, 13);
            this.lblAttached.TabIndex = 14;
            this.lblAttached.Text = "Attached:";
            // 
            // txtAttached
            // 
            this.txtAttached.Location = new System.Drawing.Point(161, 104);
            this.txtAttached.Name = "txtAttached";
            this.txtAttached.Size = new System.Drawing.Size(521, 20);
            this.txtAttached.TabIndex = 13;
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(107, 70);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(40, 13);
            this.lblSubject.TabIndex = 12;
            this.lblSubject.Text = "Subject:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(161, 67);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(521, 20);
            this.txtSubject.TabIndex = 11;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(161, 27);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(521, 20);
            this.txtTo.TabIndex = 10;
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(107, 24);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(48, 23);
            this.btnTo.TabIndex = 9;
            this.btnTo.Text = "To...";
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSendEmail.Location = new System.Drawing.Point(12, 24);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(79, 100);
            this.btnSendEmail.TabIndex = 1;
            this.btnSendEmail.Text = "Send";
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // FormSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 485);
            this.Controls.Add(this.pnlClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSendEmail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Email";
            ((System.ComponentModel.ISupportInitialize)(this.pnlClient)).EndInit();
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBody.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAttached.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlClient;
        private DevExpress.XtraEditors.SimpleButton btnSendEmail;
        private DevExpress.XtraEditors.SimpleButton btnTo;
        private DevExpress.XtraEditors.MemoEdit txtBody;
        private DevExpress.XtraEditors.LabelControl lblAttached;
        private DevExpress.XtraEditors.TextEdit txtAttached;
        private DevExpress.XtraEditors.LabelControl lblSubject;
        private DevExpress.XtraEditors.TextEdit txtSubject;
        private DevExpress.XtraEditors.TextEdit txtTo;
    }
}