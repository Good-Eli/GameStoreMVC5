using GameStore.WebUI.Infrastructure.Abstract;
using System.Web.Security;

namespace GameStore.WebUI.Infrastructure.Concrete
{
    public class FormAuthProvider : IAuthProvider
    {
        public bool Authenticate(string username, string password)
        {
#pragma warning disable CS0618 // 'FormsAuthentication.Authenticate(string, string)" является устаревшим: 'The recommended alternative is to use the Membership APIs, such as Membership.ValidateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.'
            bool result = FormsAuthentication.Authenticate(username, password);
#pragma warning restore CS0618 // 'FormsAuthentication.Authenticate(string, string)" является устаревшим: 'The recommended alternative is to use the Membership APIs, such as Membership.ValidateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.'
            if (result)
                FormsAuthentication.SetAuthCookie(username, false);
            return result;
        }
    }
}