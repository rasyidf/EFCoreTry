using System.Collections.Generic;

namespace EFCoreTry
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } 

        public List<Tag> Tags { get; set; }
        public decimal Price { get; set; } 
        public List<Vet> Vets { get; set; } = new List<Vet>();
        public List<Customer> Customer { get; set; } = new List<Customer>();
    }
}

