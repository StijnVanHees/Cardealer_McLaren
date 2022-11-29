using System;
using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.Models
{
    public class Motor
    {
        public int MotorId { get; set; }
        public string CodeNaam { get; set; }
        public int PK { get; set; }
        public int Torque { get; set; }
        public string Configuratie { get; set; }
        [DataType(DataType.Date)]
        public DateTime ProductieJaar { get; set; }
        public Auto Auto { get; set; }  
    }
}
