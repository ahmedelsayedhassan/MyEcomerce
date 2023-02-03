using System.ComponentModel.DataAnnotations;

namespace Ecommerce.DAL.Entities
{
    public class Customer: BaseEntity
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        public Order Order { get; set; }
    }
}