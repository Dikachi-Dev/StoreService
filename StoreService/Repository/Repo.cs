//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StoreService.Data;
using StoreService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreService.Repository
{
    public class Repo<T> : IRepo<T> where T : BaseEntity
    {
        private readonly StoreServiceContext context;
        private DbSet<T> entities;



        public Repo(StoreServiceContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public async Task Create(T entity)
        {
            if (entity == null)
            {
                throw new NotImplementedException();
            }

            await entities.AddAsync(entity);
            await Save();


        }

        public async Task Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            await Save();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();

        }

        //public Task GetByFilter(string Filter)
        //{
        //    if (Filter == null)
        //    {
        //        throw new ArgumentNullException();
        //    }
        //    return entities.Find(Filter);
        //}

        public async Task<T> GetById(Guid Id)
        {
            return await entities.SingleOrDefaultAsync(s => s.Id == Id);
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            entities.Update(entity);

            await Save();
        }
    }
}
