using Database;

namespace WinFormsApplication.Services
{
    public interface IAuthorizationService
    {
        public bool IsAuthorized { get; }

        public void SignIn(string login, string password, DatabaseContext context = null);

        public void Logout();
    }
}
