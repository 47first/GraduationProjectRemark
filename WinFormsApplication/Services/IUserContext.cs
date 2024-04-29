using Database.Entities;

namespace WinFormsApplication.Services
{
    public interface IUserContext
    {
        public User CurrentUser { get; }
    }
}
