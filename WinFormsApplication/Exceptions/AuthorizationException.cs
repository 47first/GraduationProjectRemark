namespace WinFormsApplication.Exceptions
{
    public class AuthorizationException : Exception
    {
        public AuthorizationException() : base("Непрвильный логин или пароль")
        {
        }
    }
}
