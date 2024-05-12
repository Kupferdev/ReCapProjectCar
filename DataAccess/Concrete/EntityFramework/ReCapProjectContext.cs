using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = ReCapProject; Trusted_Connection = true");
        }

        public DbSet<Car> cars { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Color> colors { get; set; }
    }
}
