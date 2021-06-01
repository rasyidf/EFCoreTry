using Microsoft.EntityFrameworkCore;

using System;
using System.Linq;

namespace EFCoreTry
{
    public class PetShopDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=PetShop.db");
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Appointment> Appoinment { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Vet> Characters { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region seed data 
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}

