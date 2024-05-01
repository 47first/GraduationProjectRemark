using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Database.Entities
{
    public class Request : BaseEntity
    {
        public int ServiceId { get; set; }

        public int UserId { get; set; }

        public int? EmployeeId { get; set; }

        public decimal Price { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ServedDate { get; set; }

        public DateTime ServiceStartDate { get; set; }

        public DateTime ServiceEndDate { get; set; }

        [ForeignKey(nameof(ServiceId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Service Service { get; set; }

        [ForeignKey(nameof(UserId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public User User { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Employee Employee { get; set; }
    }
}
