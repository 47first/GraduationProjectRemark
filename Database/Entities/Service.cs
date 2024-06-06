using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Database.Enums;

namespace Database.Entities
{
    public class Service : BaseEntity
    {
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        [StringLength(32)]
        public string Name { get; set; } = null!;

        [StringLength(64)]
        public string Description { get; set; } = null!;

        public int Amount { get; set; }

        public decimal Price { get; set; }

        public PaymentType PaymentType { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(64)]
        public string? ImagePath { get; set; }

        public Category Category { get; set; }
    }
}
