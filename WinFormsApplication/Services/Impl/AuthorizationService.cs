namespace WinFormsApplication.Services.Impl
{
    public class AuthorizationService : IAuthorizationService
    {
        private static IAuthorizationService _instance;

        public AuthorizationService()
        {

        }

        public static IAuthorizationService Instance => _instance ?? (_instance = new AuthorizationService());

        public bool IsAuthorized => false;
    }
}
