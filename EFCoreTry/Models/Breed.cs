using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTry.Models
{
    public class Breed
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
    }
}
