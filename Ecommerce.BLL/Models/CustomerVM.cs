using Ecommerce.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL.Models
{
    public class CustomerVM
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Max Length is 50 chars")]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        public Order Order { get; set; }
    }
}
