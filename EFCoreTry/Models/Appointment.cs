using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTry
{
    public class Appointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Vet Vet { get; set; }
        public int VetId { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
    }
}

