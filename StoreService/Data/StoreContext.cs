//using Microsoft.EntityFrameworkCore;
//using StoreService.Models;

//namespace StoreService.Data
//{
//    public class StoreContext : DbContext
//    {


//        public StoreContext (DbContextOptions<StoreContext> options)
//            : base(options)
//        {
//        }

//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    base.OnModelCreating(modelBuilder);
//    new ProductMap(modelBuilder.Entity<Product>());
//    new CategoryMap(modelBuilder.Entity<Category>());
//}

//        //public DbSet<StoreServices.Models.Product> Products { get; set; }
//        //public DbSet<StoreServices.Models.Category> Categories { get; set; }
//    }
//}
