using EFCoreTry.Models;

using System.Collections.Generic;

namespace EFCoreTry.Models
{
    public class Customer : Person
    {
        public List<Animal> Pets { get; set; } 
    }
}

