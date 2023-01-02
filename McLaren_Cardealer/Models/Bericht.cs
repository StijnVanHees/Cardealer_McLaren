using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.Models
{
    public class Bericht
    {
        [Key]
        public int BerichtId { get; set; }
        public string Email { get; set; }
        [Required]
        [MaxLength(500)]
        public string Message { get; set; }
    }
}
