using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTry.Models
{
    public class Animal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Breed> Breed { get; set; }
        public DateTime DateBorn { get; set; }
        public Gender Gender { get; set; }
        public bool Registered { get; set; }
        public string Color { get; set; }
        public string Photo { get; set; }
    }
}
