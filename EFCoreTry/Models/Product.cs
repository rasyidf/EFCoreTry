using EFCoreTry.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTry.Models
{
    public abstract class Product
    { 
        public Guid Id { get; set; } 
        public string Name { get; set; }  
        public List<Tag> Tags { get; set; }
        public List<Category> Categories { get; set; }
        public decimal Price { get; set; } 
    }
}

