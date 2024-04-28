using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class Request : BaseEntity
    {
        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        //[ForeignKey(nameof(Employee))]
        //public int EmployeeId { get; set; }

        public decimal Price { get; set; }

        public bool IsCompleted { get; set; }

        public DateOnly CreatedDate { get; set; }

        public DateOnly ServedDate { get; set; }

        public DateTime ServiceStartDate { get; set; }

        public DateTime ServiceEndDate { get; set; }

        public Service Service { get; set; }

        public User User { get; set; }

        //public Employee Employee { get; set; }
    }
}
