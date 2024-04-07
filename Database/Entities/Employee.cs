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

        public int PositionId { get; set; }
    }
}
