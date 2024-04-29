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
            _dataPath = Path.Combine(Environment.CurrentDirectory, "lg.ini");

            if (File.Exists(_dataPath))
            {
                try
                {
                    var data = JsonSerializer.Deserialize<AuthorizeData>(File.ReadAllText(_dataPath));

                    SignIn(data.Login, data.Password);

                    return;
                }
                catch(AuthorizationException ex)
                {
                }
            }

            IsAuthorized = false;
        }

        public static IAuthorizationService Instance => _instance ?? (_instance = new AuthorizationService());

        public bool IsAuthorized { get; private set; }

        public void Logout()
        {
            IsAuthorized = false;

            if (File.Exists(_dataPath))
            {
                File.Delete(_dataPath);
            }
        }

        public void SignIn(string login, string password, DatabaseContext context = null)
        {
            var dbContext = context ?? new DatabaseContext();

            var user = dbContext.Users.FirstOrDefault(x => x.Password == password && x.Login == login);

            if (user is null)
            {
                throw new AuthorizationException();
            }

            IsAuthorized = true;

            if (UserContext.Instance is IUserAccessor accessor)
            {
                accessor.CurrentUser = user;
            }
            else
            {
                throw new NotImplementedException();
            }

            if (File.Exists(_dataPath) == false)
            {
                var fileStream = File.Create(_dataPath);

                fileStream.Dispose();
            }

            var data = new AuthorizeData
            {
                Login = login,
                Password = password
            };
            var serializedData = JsonSerializer.Serialize(data);

            File.WriteAllText(_dataPath, serializedData);

            if (context is null)
            {
                dbContext.Dispose();
            }
        }

        private class AuthorizeData
        {
            public string Login { get; set; }

            public string Password { get; set; }
        }
    }
}
