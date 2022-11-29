namespace McLaren_Cardealer.Models

{
    public class Auto
    {
        public int AutoId { get; set; }
        public string Naam { get; set; }
        public int Prijs { get; set; }
        public string Kilogram { get; set; }
        public string Kleur { get; set; }
        public string Foto { get; set; }
        public Motor Motor { get; set; }
        public Wielen Wielen { get; set; }

    }
}
