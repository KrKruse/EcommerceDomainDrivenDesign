using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Noerlund.DataAcces.Contexts
{
    public class NoerlundContext : DbContext
    {
        //public DbSet<> { get; set; }

        // connectionstring on build
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(Config.DbConnStr);
        }
    }
}
