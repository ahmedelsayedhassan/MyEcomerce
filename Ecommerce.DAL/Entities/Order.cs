using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL.Entities
{
    [Index(nameof(CustomerId), IsUnique = false)]
    public class Order: BaseEntity
    {
        public Order()
        {
            this.OrderTime = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime OrderTime { get; set; } 

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();
    }
}
