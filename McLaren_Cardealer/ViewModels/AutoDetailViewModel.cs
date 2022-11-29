using McLaren_Cardealer.Models;
using System.Collections.Generic;

namespace McLaren_Cardealer.ViewModels
{
    public class AutoDetailViewModel
    {
        public int AutoId { get; set; }
        public string Naam { get; set; }
        public int Prijs { get; set; }
        public string Kilogram { get; set; }
        public string Kleur { get; set; }
        public string Foto { get; set; }
        public ICollection<Motor> Motoren { get; set; }
        public ICollection<Wielen> Wielen { get; set; }
    }
}
