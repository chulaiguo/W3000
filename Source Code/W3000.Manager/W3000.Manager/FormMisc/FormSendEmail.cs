using System;
using Cheke.EmailData;
using Cheke.WinCtrl;
using System.Windows.Forms;
using W3000.Manager.FormSelect;
using W3000.ViewObj;
using System.Text;

namespace W3000.Manager.FormMisc
{
    public partial class FormSendEmail : FormMiscBase
    {
        private readonly string _userId = string.Empty;
        private readonly string _attachedName = string.Empty;
        private readonly byte[] _attached = null;

        public FormSendEmail()
        {
            InitializeComponent();
        }

        public FormSendEmail(string userid, Exception ex)
        {
            InitializeComponent();

            this._userId = userid;

            this.txtTo.Text = "chulaiguo@qq.com";

            this.txtSubject.Text = "Fatal Error Found";
            this.txtSubject.Properties.ReadOnly = true;

            this.lblAttached.Visible = false;
            this.txtAttached.Visible = false;

            this.txtBody.Text = string.Format("{0}{1}{2}", ex.Message, Environment.NewLine, ex.StackTrace);
            this.txtBody.Properties.ReadOnly = true;
        }

        public FormSendEmail(string userid, string attachedName, byte[] attached)
        {
            InitializeComponent();

            this._userId = userid;
            this._attachedName = attachedName;
            this._attached = attached;
            this.txtAttached.Text = this._attachedName;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if(this.txtTo.Text.Length == 0)
            {
                base.ShowWarningMessage("There must be at least one email in the Sendto box.");
                return;
            }

            try
            {
                EmailMessageData message = new EmailMessageData();
                if(!string.IsNullOrEmpty(FormMain.Instance.User.Email))
                {
                    message.From = FormMain.Instance.User.Email;
                    message.FromDisplayName = string.Format("{0} {1}", FormMain.Instance.User.LastName, FormMain.Instance.User.FirstName);
                }

                message.To = this.txtTo.Text;
                message.Subject = this.txtSubject.Text;
                message.Body = this.txtBody.Text;
                message.AddAttachment(this._attachedName, this._attached);

                string error = BizEmail.SendEmail(message);
                if(error.Length > 0)
                {
                    base.ShowErrorMessage(error);
                    return;
                }
            }
            catch (Exception ex)
            {
                base.ShowErrorMessage(ex.Message);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            try
            {
                FormSelectUsrAccount dlg = new FormSelectUsrAccount(this._userId);
                dlg.MultiSelect = true;
                if(dlg.ShowDialog() != DialogResult.OK)
                    return;

                StringBuilder builder = new StringBuilder();
                foreach (UsrAccount item in dlg.UsrAccountList)
                {
                    if(item.Email.Length == 0)
                        continue;

                    builder.AppendFormat("{0};", item.Email);
                }

                string oldTo = this.txtTo.Text.Trim();
                this.txtTo.Text = string.Format("{0}{1}", builder, oldTo);
            }
            catch (Exception ex)
            {
                base.ShowErrorMessage(ex.Message);
            }
        }
    }
}