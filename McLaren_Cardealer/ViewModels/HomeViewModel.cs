using McLaren_Cardealer.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.ViewModels
{
    public class HomeViewModel
    {
        public int BerichtId { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public List<Auto> autos { get; set; }
    }
}

