using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.Models
{
    public class AutoMotor
    {
        [Key]
        public string AutoMotorId { get; set; }
        public Auto Auto { get; set; }
        public string AutoId { get; set; }
        public Motor Motor { get; set; }
        public string MotorId { get; set; }
    }
}
