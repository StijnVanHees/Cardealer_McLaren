using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.Models
{
    public class Factuur
    {
        [Key]
        public string FactuurId { get; set; }
        public Auto Auto { get; set; }
        public string AutoId { get; set; }  
        public Klant Klant { get; set; }
        public string KlantId { get; set; }

    }
}
