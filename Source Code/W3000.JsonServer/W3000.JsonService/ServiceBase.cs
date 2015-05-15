using Cheke;

namespace W3000.JsonService
{
    public abstract class ServiceBase
    {
        private readonly SecurityToken _token = null;

        protected ServiceBase()
        {
            this._token = new SecurityToken(this.AnonymousUser, this.AnonymousPassword, this.AppsToken);
        }

        protected SecurityToken Token
        {
            get { return _token; }
        }

        private string AppsToken
        {
            get { return "HelloDataServiceEx"; }
        }

        private string AnonymousUser
        {
            get { return "anonymous"; }
        }

        private string AnonymousPassword
        {
            get { return "anonymous"; }
        }
    }
}