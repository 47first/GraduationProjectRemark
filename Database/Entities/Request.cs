namespace Database.Entities
{
    public class Request : BaseEntity
    {
        public int ServiceId { get; set; }

        public int UserId { get; set; }

        public int EmployeeId { get; set; }

        public decimal Price { get; set; }

        public bool IsCompleted { get; set; }

        public DateOnly CreatedDate { get; set; }

        public DateOnly ServedDate { get; set; }

        public DateTime ServiceStartDate { get; set; }

        public DateTime ServiceEndDate { get; set; }
    }
}
