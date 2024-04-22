using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = null!;

        public string? MiddleName { get; set; }

        public string LastName { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }

        public Role Role { get; set; }
    }
}
