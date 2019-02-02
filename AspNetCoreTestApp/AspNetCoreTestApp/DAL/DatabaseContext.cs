using AspNetCoreTestApp.Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AspNetCoreTestApp.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductChangeLogs> ProductChangeLogs { get; set; }
    }

}