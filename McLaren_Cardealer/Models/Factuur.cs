using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.Models
{
    public class Factuur
    {
        [Key]
        public int FactuurId { get; set; }
        public Auto Auto { get; set; }
        public int AutoId { get; set; }  
        public Klant Klant { get; set; }
        public int KlantId { get; set; }

    }
}
