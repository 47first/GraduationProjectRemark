using System.Text.Json;
using Database;
using WinFormsApplication.Exceptions;

namespace WinFormsApplication.Services.Impl
{
    public class AuthorizationService : IAuthorizationService
    {
        private static IAuthorizationService _instance;
        private string _dataPath;

        public AuthorizationService()
        {
            _dataPath = Path.Combine(Environment.CurrentDirectory, "Temp", "lg.ini");

            if (File.Exists(_dataPath))
            {
                try
                {
                    var data = JsonSerializer.Deserialize<AuthorizeData>(File.ReadAllText(_dataPath));

                    SingIn(data.Login, data.Password);
                }
                catch(AuthorizationException ex)
                {
                }
            }

            IsAuthorized = false;
        }

        public static IAuthorizationService Instance => _instance ?? (_instance = new AuthorizationService());

        public bool IsAuthorized { get; private set; }

        public int? UserId { get; private set; }

        public void Logout()
        {
            UserId = null;

            IsAuthorized = false;

            if (File.Exists(_dataPath))
            {
                File.Delete(_dataPath);
            }
        }

        public void SingIn(string login, string password)
        {
            using var dbContext = new DatabaseContext();

            var user = dbContext.Users.FirstOrDefault(x => x.Password == password && x.Login == login);

            if (user is not null)
            {
                IsAuthorized = true;

                UserId = user.Id;
            }
            else
            {
                throw new AuthorizationException();
            }
        }

        private struct AuthorizeData
        {
            public string Login;

            public string Password;
        }
    }
}
