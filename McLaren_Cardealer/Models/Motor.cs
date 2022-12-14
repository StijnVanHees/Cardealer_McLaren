using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.Models
{
    public class Motor
    {
        [Key]
        public int MotorId { get; set; }
        public string CodeNaam { get; set; }
        [Required(ErrorMessage ="Gelieve het aantal PK in te vullen")]
        public int PK { get; set; }
        public int Torque { get; set; }
        [Required(ErrorMessage ="Gelieve de configuraie in te vullen")]
        public string Configuratie { get; set; }
        [DataType(DataType.Date)]
        public DateTime ProductieJaar { get; set; }
        public ICollection<AutoMotor> AutoMotors { get; set; }  
    }
}
