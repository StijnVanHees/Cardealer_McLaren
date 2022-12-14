using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.Models
{
    public class Klant
    {
        [Key]
        public int KlantId { get; set; }
        [Required(ErrorMessage ="Gelieve een klantnaam in te vullen") ,MaxLength(50, ErrorMessage ="De ingevulde naam is te lang. Maximale lengte is 50 letters")]
        public string Naam { get; set; }
        [Required]
        public string Voornaam { get; set; }
        public string Gemeente { get; set; }
        [Required]
        public string Rekeningnummer { get; set; }

        public ICollection<Factuur> Facturen { get; set; }
    }
}
