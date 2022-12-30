using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.ViewModels
{
    public class CreateGebruikerViewModel
    {
        public string Naam { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
