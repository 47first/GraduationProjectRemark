using Database.Entities;

namespace WinFormsApplication.Services
{
    public interface IUserAccessor
    {
        public User CurrentUser { get; set; }
    }
}
