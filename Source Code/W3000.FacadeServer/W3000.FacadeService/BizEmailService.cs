using Cheke;
using Cheke.Email;
using Cheke.EmailData;

namespace W3000.FacadeService
{
    public class BizEmailService : ServiceBase
    {
        public BizEmailService(SecurityToken token)
            : base(token)
        {
        }

        public string SendEmail(EmailMessageData data)
        {
            return EmailSender.SendEmail(data);
        }
    }
}