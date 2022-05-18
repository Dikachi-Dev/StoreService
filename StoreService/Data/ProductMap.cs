//using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreService.Data
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Name).IsRequired();
            entityTypeBuilder.Property(t => t.Description).IsRequired();
            entityTypeBuilder.Property(t => t.Created).IsRequired();
            entityTypeBuilder.Property(t => t.Price).IsRequired();
            entityTypeBuilder.Property(t => t.Qty);
        }
    }
}
