using McLaren_Cardealer.Models;
using System.Collections.Generic;

namespace McLaren_Cardealer.ViewModels
{
    public class OrderOverviewViewModel
    {
        public List<Factuur> facturen { get; set; }
        public List<Auto> autos { get; set; }
    }
}
