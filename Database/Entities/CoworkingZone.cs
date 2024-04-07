namespace Database.Entities
{
    public class CoworkingZone : BaseEntity
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string ContactNumber { get; set; } = null!;
    }
}
