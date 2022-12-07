using McLaren_Cardealer.Models;
using Microsoft.EntityFrameworkCore;

namespace McLaren_Cardealer.Data
{
    public class CardealerContext : DbContext
    {

        public DbSet<Auto> Autos { get; set; }
        public DbSet<Factuur> Facturen { get; set; }
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Motor> Motoren { get; set; }
        public DbSet<Wielen> Wielen { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>().ToTable("Auto");
            modelBuilder.Entity<AutoMotor>().ToTable("AutoMotor");
            modelBuilder.Entity<Factuur>().ToTable("Factuur");
            modelBuilder.Entity<Klant>().ToTable("Klant");
            modelBuilder.Entity<Motor>().ToTable("Motor");
            modelBuilder.Entity<Wielen>().ToTable("Wielen");

            
            modelBuilder.Entity<AutoMotor>()
                .HasOne(p => p.Auto)
                .WithMany(x => x.autoMotors)
                .HasForeignKey(p => p.AutoId)
                .IsRequired();

            modelBuilder.Entity<AutoMotor>()
                .HasOne(p => p.Motor)
                .WithMany(x => x.AutoMotors)
                .HasForeignKey(p => p.MotorId)
                .IsRequired();

            modelBuilder.Entity<Auto>()
                .HasOne(p => p.Wielen)
                .WithMany(x => x.Autos)
                .HasForeignKey(p => p.WielenId)
                .IsRequired();

            modelBuilder.Entity<Factuur>()
                .HasOne(p => p.Auto)
                .WithMany(x => x.Facturen)
                .HasForeignKey(p => p.AutoId)
                .IsRequired();

            modelBuilder.Entity<Factuur>()
                .HasOne(p => p.Klant)
                .WithMany(x => x.Facturen)
                .HasForeignKey(p => p.KlantId)
                .IsRequired();
        }


    }
}
