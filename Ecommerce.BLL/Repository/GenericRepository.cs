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
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly EcommerceContext _context;

        public GenericRepository(EcommerceContext context)
        {
            _context = context;
        }
        public async Task<int> Create(T obj)
        {
            _context.Set<T>().Add(obj);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            if (typeof(T) == typeof(Order))
            {
                return (IEnumerable<T>)await _context.Set<Order>().Include(E => E.Customer).Include(P => P.OrderProducts).ThenInclude(p => p.Product).Distinct().ToListAsync();
            }
            else
            {
                return await _context.Set<T>().ToListAsync();
            }
        }
        

        public async Task<T> GetById(int? id)
            => await _context.Set<T>().FindAsync(id);

        public async Task<int> Update(T obj)
        {
            _context.Set<T>().Update(obj);
            return await _context.SaveChangesAsync();
        }
    }
}
