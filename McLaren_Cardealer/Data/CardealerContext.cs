using McLaren_Cardealer.Models;
using Microsoft.EntityFrameworkCore;

namespace McLaren_Cardealer.Data
{
    public class CardealerContext 
    {

        public DbSet<Auto> Autos { get; set; }
        public DbSet<Factuur> Facturen { get; set; }
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Motor> Motoren { get; set; }
        public DbSet<Wielen> Wielen { get; set; }


    }
}
