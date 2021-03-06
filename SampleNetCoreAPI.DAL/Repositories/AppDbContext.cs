using Microsoft.EntityFrameworkCore;
using SampleNetCoreAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleNetCoreAPI.DAL.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Electronics",
                    Description = "Electronic Items"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Clothes",
                    Description = "Dresses"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Grocery",
                    Description = "Grocery Items"
                });
        }
    }
}
