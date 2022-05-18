using StoreService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreService.Repository
{
    public interface IRepo<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid Id);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        //Task GetByFilter(string Filter);
        Task Save();

    }
}
