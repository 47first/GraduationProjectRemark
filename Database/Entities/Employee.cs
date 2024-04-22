using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; } = null!;

        public string? MiddleName { get; set; }

        public string LastName { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }

        public Position Position { get; set; }
    }
}
