using System.Collections.Generic;

namespace McLaren_Cardealer.Models
{
    public class Wielen
    {
        public int WielenId { get; set; }
        public string Naam { get; set; }
        public string Kleur { get; set; }
        public ICollection<Auto> Autos { get; set; }
    }
}
