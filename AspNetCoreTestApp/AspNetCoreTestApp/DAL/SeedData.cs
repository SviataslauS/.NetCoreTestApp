using AspNetCoreTestApp.Common;
using AspNetCoreTestApp.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AspNetCoreTestApp.Database
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DatabaseContext(
                serviceProvider.GetRequiredService<DbContextOptions<DatabaseContext>>()))
            {
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

                context.Products.AddRange(
                    new Product
                    {
                        Title = "HDD 1TB",
                        Unit = 55,
                        Price = 74.99
                    },

                    new Product
                    {
                        Title = "HDD SSD 512GB",
                        Unit = 104,
                        Price = 190.99
                    },
                    new Product
                    {
                        Title = "RAM DDR4 16GB",
                        Unit = 47,
                        Price = 79.99
                    }
                );

                var adminRole = new Role
                {
                    RoleId = (int)InternalRoleId.AdminId,
                    Title = "Admin"
                };
                var userRole =
                    new Role
                    {
                        RoleId = (int)InternalRoleId.UserId,
                        Title = "User"
                    };
                context.Roles.AddRange(adminRole, userRole);
                context.SaveChanges();

                var roles = context.Roles.Include(b => b).ToList();
                context.Users.AddRange(
                    new User
                    {
                        Name = "Administrator",
                        Role = roles.First(r => r.Title == adminRole.Title),
                        Password = "1111"
                    },
                    new User
                    {
                        Name = "Some User",
                        Role = roles.First(r => r.Title == userRole.Title),
                        Password = "0000"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}