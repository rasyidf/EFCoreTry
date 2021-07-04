using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTry.Models
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public Vet Vet { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
    }
}

