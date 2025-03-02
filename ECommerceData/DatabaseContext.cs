using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Core.Entities;
using ECommerce.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet <AppUser> AppUsers { get; set; }
        public DbSet <Category> Brands { get; set;}
        public DbSet <Category> Categories { get; set; }
        public DbSet <Product> Contacts { get; set; }
        public DbSet <Product> News { get; set; }
        public DbSet <Product> Products { get;set;}
        public DbSet <Slider> Sliders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8T03MF4\SQLEXPRESS; Database=ECommerceDb; Trusted_Connection=True; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
