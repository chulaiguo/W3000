using Cheke;

namespace W3000.CreatorService
{
    public abstract class BizBase
    {
        private readonly SecurityToken _trustableToken = null;
        private readonly SecurityToken _originalToken = null;
        private readonly SecurityToken _anonymousToken = null;

        protected BizBase(SecurityToken token)
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
    }
}