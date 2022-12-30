using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.ViewModels
{
    public class GebruikerEditViewModel
    {
        [Required]
        public string Naam { get; set; }
        [Required]
        public string Email { get; set; }
        public string GebruikerId { get; set; }
    }
}
