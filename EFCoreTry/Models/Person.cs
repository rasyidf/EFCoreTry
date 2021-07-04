
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EFCoreTry.Models
{
    public abstract class Person
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Birthplace { get; set; }
        public DateTime Birthday { get; set; }
        public string PID { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public City City { get; set; }
        public List<ContactInfo> Contact { get; set; }
    }
}

