using System;
using Cheke;
using Cheke.Log;

namespace W3000.FacadeService
{
    public abstract class ServiceBase
    {
        protected static readonly ApplicationLog _SysLog = new ApplicationLog();

        private readonly SecurityToken _trustableToken = null;
        private readonly SecurityToken _originalToken = null;
        private readonly SecurityToken _anonymousToken = null;

        protected ServiceBase(SecurityToken token)
        {
            this._originalToken = token;

            this._trustableToken = SecurityToken.CreateDuplicateToken(token, true);
            this._trustableToken.SetAsTrusted("HelloDataServiceEx");

            this._anonymousToken = new SecurityToken("anonymous", "anonymous", "HelloDataServiceEx");
        }

        protected string UserId
        {
            get { return this._originalToken.UserId; }
        }

        protected SecurityToken TrustableToken
        {
            get { return this._trustableToken; }
        }

        protected SecurityToken OriginalToken
        {
            get { return this._originalToken; }
        }

        protected SecurityToken AnonymousToken
        {
            get { return _anonymousToken; }
        }

        #region Log
        protected void WriteError(string error)
        {
            _SysLog.WriteError(error);
        }

        protected void WriteError(string error, Exception ex)
        {
            _SysLog.WriteError(error, ex);
        }

        protected void WriteDebug(string message)
        {
            _SysLog.WriteDebug(message);
        }

        protected void WriteInfo(string info)
        {
            _SysLog.WriteInfo(info);
        }

        #endregion
    }
}