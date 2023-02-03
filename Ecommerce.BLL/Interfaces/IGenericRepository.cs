using Ecommerce.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        public Task<T> GetById(int? id);
        public Task<IEnumerable<T>> GetAll();
        public Task<int> Create(T obj);
        public Task<int> Update(T obj);
        public Task<int> Delete(T obj);
    }
}
