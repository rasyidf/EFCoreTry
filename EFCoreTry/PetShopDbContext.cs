using EFCoreTry.Models;

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
        public DbSet<Service> Services { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Animal> Animals { get; set; } 
        
        public DbSet<Person> People { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        // Misc
        public DbSet<Appointment> Appointments { get; set; } 
        public DbSet<Breed> Breeds { get; set; } 
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Tag> Tags { get; set; } 
        public DbSet<City> Cities { get; set; }
        public DbSet<ContactInfo> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region seed data 
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}

