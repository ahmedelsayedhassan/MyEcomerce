using Ecommerce.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL.Interfaces
{
    public interface ICustomerRepository 
    {
        public Task<IEnumerable<Product>> GetProductsByCusomerId(int customerId); 
    }
}
