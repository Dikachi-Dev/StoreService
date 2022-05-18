using StoreService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreService.Models
{
    public class Category : BaseEntity
    {
        //public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
