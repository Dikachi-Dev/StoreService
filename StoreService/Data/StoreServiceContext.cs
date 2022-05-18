using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreService.Models;

namespace StoreService.Data
{
    public class StoreServiceContext : DbContext
    {
        public StoreServiceContext (DbContextOptions<StoreServiceContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new ProductMap(modelBuilder.Entity<Product>());
            new CategoryMap(modelBuilder.Entity<Category>());
        }

        //public DbSet<StoreService.Models.Product> Product { get; set; }
    }
}
