using System;
using System.Collections.Generic;
using Cheke.WinCtrl.Login;

namespace W3000.Manager
{
    public partial class FormLogin : FormLoginBase
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public FormLogin(ILogin login)
            : base(login)
        {
            InitializeComponent();
        }

        private void txtPassword_EditValueChanged(object sender, EventArgs e)
        {
            this.UpdateUI();
        }

        private void cboEdUserName_EditValueChanged(object sender, EventArgs e)
        {
            this.UpdateUI();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = this.cboUserName.Text.Trim();
            string password = this.txtPassword.Text;

            this.SignIn(userId, password);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CancelSignIn();
        }

        protected override void LoadLoginName()
        {
            List<string> list = base.LoadLoginHistory();
            this.cboUserName.Properties.Items.AddRange(list);
        }

        protected override void SaveLoginName()
        {
            if (!this.cboUserName.Properties.Items.Contains(this.cboUserName.Text))
            {
                this.cboUserName.Properties.Items.Add(this.cboUserName.Text);
            }

            List<string> list = new List<string>();
            for (int i = 0; i < this.cboUserName.Properties.Items.Count; i++)
            {
                list.Add(this.cboUserName.Properties.Items[i].ToString());
            }

            base.SaveLoginHistory(list);
        }

        #region Helper functions

        private void UpdateUI()
        {
            if (this.txtPassword.Text.Length > 0 && this.cboUserName.Text.Length > 0)
            {
                this.btnLogin.Enabled = true;
            }
            else
            {
                this.btnLogin.Enabled = false;
            }
        }

        #endregion

        private void lnkForgotPassword_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            this.ShowRecoverPassword();
        }
    }
}