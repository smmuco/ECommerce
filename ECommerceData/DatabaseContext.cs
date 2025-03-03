using System.Reflection;
using ECommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet <AppUser> AppUsers { get; set; }
        public DbSet <Brand> Brands { get; set;}
        public DbSet <Category> Categories { get; set; }
        public DbSet <Contact> Contacts { get; set; }
        public DbSet <News> News { get; set; }
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
