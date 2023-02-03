using Ecommerce.BLL.Interfaces;
using Ecommerce.DAL.Context;
using Ecommerce.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly EcommerceContext _context;

        public CustomerRepository(EcommerceContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> GetProductsByCusomerId(int customerId)
        {
            var data = await _context.Customers.Where(x => x.Id == customerId).Join(
                _context.OrderProducts,
                a => a.Id,
                b => b.Order.CustomerId,
                (a, b) => new Product()
                {
                    Id = b.Product.Id,
                    Name = b.Product.Name,
                    Color = b.Product.Color,
                    Size = b.Product.Size,
                    Price = b.Product.Price,
                    Quantity = b.Product.Quantity,
                    Description = b.Product.Description,
                    ProductUser = b.Product.ProductUser
                }
                ).ToListAsync();
            return data;
        }
    }
}
