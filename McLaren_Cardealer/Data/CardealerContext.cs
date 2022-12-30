using McLaren_Cardealer.Areas.Identity.Data;
using McLaren_Cardealer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace McLaren_Cardealer.Data
{
    public class CardealerContext : IdentityDbContext<CustomUser>
    {

        public DbSet<Auto> Autos { get; set; }
        public DbSet<AutoMotor> AutoMotors { get; set; }
        public DbSet<Factuur> Facturen { get; set; }
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Motor> Motoren { get; set; }
        public DbSet<Wielen> Wielen { get; set; }

        public CardealerContext(DbContextOptions<CardealerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Auto>().ToTable("Autos");
            modelBuilder.Entity<AutoMotor>().ToTable("AutoMotors");
            modelBuilder.Entity<Factuur>().ToTable("Facturen");
            modelBuilder.Entity<Klant>().ToTable("Klanten");
            modelBuilder.Entity<Motor>().ToTable("Motoren");
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
