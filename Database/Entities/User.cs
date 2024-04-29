using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class User : BaseEntity
    {
        [StringLength(64)]
        public string FirstName { get; set; } = null!;

        [StringLength(64)]
        public string? MiddleName { get; set; }

        [StringLength(64)]
        public string LastName { get; set; } = null!;

        [StringLength(12)]
        public string Phone { get; set; } = null!;

        [StringLength(64)]
        public string Email { get; set; } = null!;

        [StringLength(32)]
        public string Login { get; set; } = null!;

        [StringLength(32)]
        public string Password { get; set; } = null!;

        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }

        public Role Role { get; set; }
    }
}
