using Ecommerce.BLL.Interfaces;
using Ecommerce.DAL.Context;
using Ecommerce.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL.Repository
{
    public class OrderProductRepo : IOrderProductRepo
    {
        private readonly EcommerceContext _context;

        public OrderProductRepo(EcommerceContext context)
        {
            _context = context;
        }
        public async Task Create(int OrderId, int ProductId)
        {
            var data = new OrderProduct() { OrderId = OrderId, ProductId = ProductId };
            await _context.OrderProducts.AddAsync(data);
            await _context.SaveChangesAsync();
        }
    }
}
