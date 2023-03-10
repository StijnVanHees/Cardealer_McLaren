using McLaren_Cardealer.Models;
using System.Collections.Generic;
using System;

namespace McLaren_Cardealer.ViewModels
{
    public class DeleteAutoViewModel
    {
        public int AutoId { get; set; }
        public string Naam { get; set; }
        public int Prijs { get; set; }
        public string Kilogram { get; set; }
        public string Kleur { get; set; }
        public string CodeNaam { get; set; }
        public int PK { get; set; }
        public int Torque { get; set; }
        public string Configuratie { get; set; }
        public DateTime ProductieJaar { get; set; }
        //public ICollection<Wielen> Wielen { get; set; }
        public List<Motor> Motors { get; set; }
        public List<AutoMotor> AutoMotoren { get; set; }
        //public List<Wielen> Wielens { get; set; }
    }
}
