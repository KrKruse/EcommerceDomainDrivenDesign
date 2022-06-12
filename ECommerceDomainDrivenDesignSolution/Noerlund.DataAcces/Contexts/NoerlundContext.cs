using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Noerlund.DataAcces.Models;

namespace Noerlund.DataAcces.Contexts
{
    public class NoerlundContext : DbContext
    {
        public DbSet<CustomerDto> CustomerDtos { get; set; }
        public DbSet<OrderDto> OrderDtos { get; set; }
        public DbSet<OrderItemDto> OrderItemDtos { get; set; }
        public DbSet<CategoryDto> CategoryDtos { get; set; }
        public DbSet<ProductDto> ProductDtos { get; set; }


        // connectionstring on build
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(Config.DbConnStr);
        }
    }
}
