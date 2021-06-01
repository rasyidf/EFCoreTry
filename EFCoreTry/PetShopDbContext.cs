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
            var item = new Item[] {

            };
            var services = new Service[] {

            };
            var products = item
                .Cast<Product>()
                .Union(services)
                .ToList();
            modelBuilder.Entity<Item>().HasData(item);
            modelBuilder.Entity<Service>().HasData(services);
            // characters
            modelBuilder.Entity<Customer>().HasData(new Customer[]
            {
            });
            // actors
            modelBuilder.Entity<Vet>().HasData(new Vet[]
            {


            });
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}

