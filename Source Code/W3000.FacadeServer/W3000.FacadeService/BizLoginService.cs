using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Cheke;
using Cheke.BusinessEntity;
using Cheke.Email;
using Cheke.EmailData;
using W3000.BasicServiceWrapper;
using W3000.BizData;
using W3000.Data;

namespace W3000.FacadeService
{
    public class BizLoginService : ServiceBase
    {
        public BizLoginService(SecurityToken token) : base(token)
        {
        }

        public Result Login()
        {
            try
            {
                UsrAccountData user = UsrAccountWrapper.GetByUserID(base.UserId, base.AnonymousToken);
                if (user == null)
                {
                    string error = string.Format("The userid [{0}] you provided does not exist in the database.",base.UserId);
                    return new Result(error);
                }

                SecurityToken userToken = new SecurityToken(user.UserID, user.Password, string.Empty, base.OriginalToken.Ticks);
                if(!userToken.Equals(base.OriginalToken))
                {
                    string error = "The UserId/Password is not valid. Please try it again.";
                    return new Result(error);
                }
                user.LastLogin = DateTime.Now;
                user.TotalUsage += 1;
                Result result = UsrAccountWrapper.Save(user, base.AnonymousToken);
                if (!result.OK)
                    return result;

                result.Tag = this.GetPasswordExpiringDays(user);
                return result;
            }
            catch(Exception ex)
            {
                return new Result(ex);
            }
        }

        private int GetPasswordExpiringDays(UsrAccountData user)
        {
            TimeSpan span = user.PwdExpireDate - DateTime.Now;
            return (int)span.TotalDays;
        }

        public Result LoginByWeb(string userId, string md5Password)
        {
            try
            {
                UsrAccountData user = UsrAccountWrapper.GetByUserID(userId, base.AnonymousToken);
                if (user == null)
                {
                    string error = "The UserId/Password is not valid.";
                    return new Result(error);
                }

                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
                string cryptPassword = BitConverter.ToString(data);
                cryptPassword = cryptPassword.Replace("-", "");
                
                if (String.Compare(md5Password, cryptPassword, StringComparison.OrdinalIgnoreCase) != 0)
                {
                    string error = "The UserId/Password is not valid.";
                    return new Result(error);
                }

                user.LastLogin = DateTime.Now;
                user.TotalUsage += 1;
                Result result = UsrAccountWrapper.Save(user, base.AnonymousToken);
                if (!result.OK)
                    return result;

                result.Tag = user.Password;
                return result;
            }
            catch (Exception ex)
            {
                return new Result(ex);
            }
        }

        public Result RecoverPassword(string userId)
        {
            try
            {
                UsrAccountData user = UsrAccountWrapper.GetByUserID(userId, base.AnonymousToken);
                if (user != null)
                {
                    if (string.IsNullOrEmpty(user.Email))
                    {
                        return new Result("The email address is invalid.");
                    }

                    EmailMessageData data = new EmailMessageData();
                    data.To = user.Email;
                    data.TemplateName = "Template:RetrivePassword";
                    data.AddTemplateKeyValue("%USERID%", user.UserID);
                    data.AddTemplateKeyValue("%PASSWORD%", user.Password);
                    string error = EmailSender.SendEmail(data);
                    if (error.Length > 0)
                    {
                        return new Result(error);
                    }

                    return new Result(true);
                }

                return new Result(string.Format("The userid [{0}] you provided does not exist in the database.", userId));
            }
            catch (Exception ex)
            {
                return new Result(ex);
            }
        }

        public Result ChangePassword(string newPassword)
        {
            UsrAccountData user = UsrAccountWrapper.GetByUserID(base.UserId, base.TrustableToken);
            if (user == null)
            {
                string error = string.Format("Username and password do not match. (You provided {0})", base.UserId);
                return new Result(error);
            }

            user.Password = newPassword;
            user.PwdExpireDate = DateTime.Now.AddMonths(3);
            
            user.ModifiedBy = base.UserId;
            user.ModifiedOn = DateTime.Now;
            return UsrAccountWrapper.Save(user, base.TrustableToken);
        }

        public BizDBPermissionCollection GetDBPermission(string userID)
        {
            try
            {
                UsrAccountData user = UsrAccountWrapper.GetByUserID(base.UserId, base.AnonymousToken);
                if (user == null)
                    return new BizDBPermissionCollection();

                SortedList<int, BizDBPermission> permissionIndex = this.GetDBPermissionIndex(user);
                BizDBPermissionCollection retList = new BizDBPermissionCollection();
                foreach (KeyValuePair<int, BizDBPermission> pair in permissionIndex)
                {
                    retList.Add(pair.Value);
                }

                return retList;
            }
            catch
            {
                return new BizDBPermissionCollection();
            }
        }

        private SortedList<int, BizDBPermission> GetDBPermissionIndex(UsrAccountData user)
        {
            SortedList<int, BizDBPermission> retIndex = new SortedList<int, BizDBPermission>();

            //personal permission
            UsrAccountDBRuleDataCollection list = UsrAccountDBRuleWrapper.GetByUsrAccount(user.UsrAccountPK, base.TrustableToken);
            foreach (UsrAccountDBRuleData item in list)
            {
                if (retIndex.ContainsKey(item.DBRuleID))
                    continue;

                BizDBPermission entity = new BizDBPermission();
                entity.RuleID = item.DBRuleID;
                entity.TableName = item.TableName;
                entity.Selectable = item.Selectable;
                entity.Editable = item.Editable;
                entity.Insertable = item.Insertable;
                entity.Deletable = item.Deletable;
                retIndex.Add(item.DBRuleID, entity);
            }

            //group permission
            UsrGroupDBRuleDataCollection groupList = UsrGroupDBRuleWrapper.GetByUsrGroup(user.UsrGroupPK, base.TrustableToken);
            foreach (UsrGroupDBRuleData item in groupList)
            {
                if (retIndex.ContainsKey(item.DBRuleID))
                    continue;

                BizDBPermission entity = new BizDBPermission();
                entity.RuleID = item.DBRuleID;
                entity.TableName = item.TableName;
                entity.Selectable = item.Selectable;
                entity.Editable = item.Editable;
                entity.Insertable = item.Insertable;
                entity.Deletable = item.Deletable;
                retIndex.Add(item.DBRuleID, entity);
            }

            return retIndex;
        }

        public BizBRPermissionCollection GetBRPermission(string userID)
        {
            try
            {
                UsrAccountData user = UsrAccountWrapper.GetByUserID(base.UserId, base.AnonymousToken);
                if (user == null)
                    return new BizBRPermissionCollection();

                SortedList<int, BizBRPermission> permissionIndex = this.GetBRPermissionIndex(user);
                BizBRPermissionCollection retList = new BizBRPermissionCollection();
                foreach (KeyValuePair<int, BizBRPermission> pair in permissionIndex)
                {
                    retList.Add(pair.Value);
                }

                return retList;
            }
            catch
            {
                return new BizBRPermissionCollection();
            }
        }

        private SortedList<int, BizBRPermission> GetBRPermissionIndex(UsrAccountData user)
        {
            SortedList<int, BizBRPermission> retIndex = new SortedList<int, BizBRPermission>();

            //personal permission
            UsrAccountBRRuleDataCollection list = UsrAccountBRRuleWrapper.GetByUsrAccount(user.UsrAccountPK, base.TrustableToken);
            foreach (UsrAccountBRRuleData item in list)
            {
                if (retIndex.ContainsKey(item.BRRuleID))
                    continue;

                BizBRPermission entity = new BizBRPermission();
                entity.RuleID = item.BRRuleID;
                entity.Denied = item.Denied;
                retIndex.Add(item.BRRuleID, entity);
            }

            //group permission
            UsrGroupBRRuleDataCollection groupList = UsrGroupBRRuleWrapper.GetByUsrGroup(user.UsrGroupPK, base.TrustableToken);
            foreach (UsrGroupBRRuleData item in groupList)
            {
                if (retIndex.ContainsKey(item.BRRuleID))
                    continue;

                BizBRPermission entity = new BizBRPermission();
                entity.RuleID = item.BRRuleID;
                entity.Denied = item.Denied;
                retIndex.Add(item.BRRuleID, entity);
            }

            return retIndex;
        }
    }
}