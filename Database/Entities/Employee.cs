using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class Employee : BaseEntity
    {
        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public Position Position { get; set; }

        public User User { get; set; }
    }
}
