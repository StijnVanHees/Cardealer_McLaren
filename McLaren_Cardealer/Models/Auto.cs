﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.Models

{
    public class Auto
    {
        [Key]
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
