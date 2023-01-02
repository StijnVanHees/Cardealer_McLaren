using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.Models
{
    public class Factuur
    {
        [Key]
        public int FactuurId { get; set; }
        public Auto Auto { get; set; }
        [Required]
        public int AutoId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int reservationnumber { get; set; }

    }
}
