using homeservice.api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeservice.api.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryType> CategoryTypes { get; set; }
        public DbSet<CategoryServices> CategoryServices { get; set; }
        public DbSet<ServiceRequests> ServiceRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData
            (
                new Category { CategoryId = 1, CategoryName = "Cleaning" },
                new Category { CategoryId = 2, CategoryName = "Repair" },
                new Category { CategoryId = 3, CategoryName = "Salon" },
                new Category { CategoryId = 4, CategoryName = "Pest Control" }
            );

            builder.Entity<CategoryType>().HasData
            (
                new CategoryType { CategoryTypeId = 1, CategoryId = 4, CategoryTypeName = "House Type" },
                new CategoryType { CategoryTypeId = 2, CategoryId = 4, CategoryTypeName = "Control Type" },
                new CategoryType { CategoryTypeId = 3, CategoryId = 2, CategoryTypeName = "Repair Type" },
                new CategoryType { CategoryTypeId = 4, CategoryId = 2, CategoryTypeName = "Laptop" },
                new CategoryType { CategoryTypeId = 5, CategoryId = 1, CategoryTypeName = "House" },
                new CategoryType { CategoryTypeId = 6, CategoryId = 1, CategoryTypeName = "Office" },
                new CategoryType { CategoryTypeId = 7, CategoryId = 3, CategoryTypeName = "Gents" },
                new CategoryType { CategoryTypeId = 8, CategoryId = 3, CategoryTypeName = "Ladies" }
            );

            builder.Entity<CategoryServices>().HasData
           (
               new CategoryServices { CategoryServiceId = 1, CategoryTypeId = 1, CategoryServiceName = "Termite" },
               new CategoryServices { CategoryServiceId = 2, CategoryTypeId = 2, CategoryServiceName = "Mosquito" },
               new CategoryServices { CategoryServiceId = 3, CategoryTypeId = 3, CategoryServiceName = "Laptop" },
               new CategoryServices { CategoryServiceId = 4, CategoryTypeId = 3, CategoryServiceName = "Washing" },
               new CategoryServices { CategoryServiceId = 5, CategoryTypeId = 4, CategoryServiceName = "HP" },
               new CategoryServices { CategoryServiceId = 6, CategoryTypeId = 5, CategoryServiceName = "Floor" },
               new CategoryServices { CategoryServiceId = 7, CategoryTypeId = 5, CategoryServiceName = "Washroom" },
               new CategoryServices { CategoryServiceId = 8, CategoryTypeId = 6, CategoryServiceName = "Window" },
               new CategoryServices { CategoryServiceId = 9, CategoryTypeId = 7, CategoryServiceName = "Hair Cut" },
               new CategoryServices { CategoryServiceId = 10, CategoryTypeId = 7, CategoryServiceName = "Shaving" },
               new CategoryServices { CategoryServiceId = 11, CategoryTypeId = 8, CategoryServiceName = "Pedicure" },
               new CategoryServices { CategoryServiceId = 12, CategoryTypeId = 8, CategoryServiceName = "Manicure" }
           );

        }
    }
}
