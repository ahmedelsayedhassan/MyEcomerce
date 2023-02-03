using Ecommerce.BLL.Interfaces;
using Ecommerce.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly EcommerceContext _context;

        public ProductRepository(EcommerceContext context)
        {
            _context = context;
        }
        public int ProductsInStock(int id)
        {
            var data = _context.Products.Where(p => p.Id == id).Select(p => p.Quantity).FirstOrDefault();
            return data;
        }
    }
}
