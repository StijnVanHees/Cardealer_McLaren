using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.Models

{
    public class Auto
    {
        [Key]
        public int AutoId { get; set; }
        [Required(ErrorMessage ="Gelieve een autonaam in te vullen")]
        [MaxLength(50, ErrorMessage = "De ingevulde naam is te lang. Maximale lengte is 50.")]
        public string Naam { get; set; }
        [Required(ErrorMessage ="Gelieve een prijs in te vullen")]
        public int Prijs { get; set; }
        [Required(ErrorMessage ="Gelieve de massa van het voertuig in te vullen")]
        public string Kilogram { get; set; }
        [Required(ErrorMessage ="Gelieve de kleur van het voertuig in te vullen")]
        public string Kleur { get; set; }
        public string Foto { get; set; }
        public ICollection<AutoMotor> autoMotors { get; set; }

        public ICollection<Factuur> Facturen { get; set; }
        public Wielen Wielen { get; set; }
        public int WielenId { get; set; }

    }
}
