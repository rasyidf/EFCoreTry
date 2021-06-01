
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCoreTry
{
    public abstract class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Birthplace { get; set; }
        public DateTime Birthday { get; set; }
        public string PID { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}

