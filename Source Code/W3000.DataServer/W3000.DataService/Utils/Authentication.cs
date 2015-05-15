using Cheke;
using W3000.Data;

namespace W3000.DataService.Utils
{
    internal static class Authentication
    {
        public static bool IsAuthenticated(SecurityToken securityToken)
        {
            if (string.IsNullOrEmpty(securityToken.UserId) || string.IsNullOrEmpty(securityToken.Password))
                return false;

            UsrAccountData admin = UsrAccountDataService.GetByUserID(securityToken.UserId, DataServiceFactory.ConnectionString);
            if (admin == null)
                return false;

            SecurityToken userToken = new SecurityToken(admin.UserID, admin.Password, string.Empty, securityToken.Ticks);
            if (!securityToken.Equals(userToken))
                return false;

            if ( admin.IsAdmin)
            {
                securityToken.SetAsTrusted("HelloDataServiceEx");
            }

            securityToken.UserAccount = admin;
            securityToken.Permissions = null;

            return true;
        }
    }
}