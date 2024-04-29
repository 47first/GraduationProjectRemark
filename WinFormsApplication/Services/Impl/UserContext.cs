using Database.Entities;

namespace WinFormsApplication.Services.Impl
{
    public class UserContext : IUserContext, IUserAccessor
    {
        private static IUserContext _instance;

        private UserContext()
        {
        }

        public static IUserContext Instance => _instance ?? (_instance = new UserContext());

        public User CurrentUser { get; set; }
    }
}
