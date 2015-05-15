using System.Drawing;
using Cheke;
using Cheke.BusinessEntity;
using Cheke.WinCtrl.Login;
using W3000.ViewObj;

namespace W3000.Manager
{
    public class LoginService : ILogin
    {
        public void PrepareLogin()
        {
        }

        public Result Login(string userId, string password)
        {
            Identity.SetToken(userId, password);
            return BizLogin.Login();
        }

        public Result ChangePassword(string userId, string oldPassword, string newPassword)
        {
            Result result = BizLogin.ChangePassword(newPassword);
            if (result.OK)
            {
                Identity.SetToken(userId, newPassword);
            }

            return result;
        }

        public Result RecoverPassword(string userId)
        {
            Identity.SetToken(userId, string.Empty);
            return BizLogin.RecoverPassword(userId);
        }

        public int MaxTryCount
        {
            get { return 3; }
        }

        public Image LoginImage
        {
            get { return null; }
        }
    }
}