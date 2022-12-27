using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.Models
{
    public class AutoMotor
    {
        [Key]
        public int AutoMotorId { get; set; }
        public Auto Auto { get; set; }
        public int AutoId { get; set; }
        public Motor Motor { get; set; }
        public int MotorId { get; set; }
    }
}
