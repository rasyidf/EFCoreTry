using EFCoreTry.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTry.Models
{
    public abstract class Product
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }  
        public List<Tag> Tags { get; set; }
        public List<Category> Categories { get; set; }
        public decimal Price { get; set; } 
        public List<Vet> Vets { get; set; } = new List<Vet>();
        public List<Customer> Customer { get; set; } = new List<Customer>();
    }
}

