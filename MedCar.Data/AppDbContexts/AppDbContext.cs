using MedCarDomin.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MedCarDomin.AppDbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Belgisi> Belgilari { get; set; }
        public DbSet<DavoUsuli> DavoUsulLari { get; set; }
        public DbSet<DavolanishJadvali> DavolanishJadvallari { get; set; }
        public DbSet<KasalikNomi> KasalikNomlari { get; set; }
        public DbSet<KasalikSababi> KasalikSabablari { get; set; }
        public DbSet<Klinika> KlinikaLar { get; set; }
        public DbSet<KutilganKasalik> KutilganKasaliklar { get; set; }
        public DbSet<ParhezTaom> ParhezTaomlar { get; set; }
        public DbSet<Sanatoriya> Sanatoriyalar { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KasalikNomi>()
                .HasOne(e => e.DavolanishJadvali)
            .WithOne(e => e.KasalikNomi)
                .HasForeignKey<DavolanishJadvali>(e => e.KasalikNomiId)
                .IsRequired();
            modelBuilder.Entity<KasalikNomi>()
                .HasOne(e => e.DavoUsuli)
                .WithOne(e => e.KasalikNomi)
                .HasForeignKey<DavoUsuli>(e => e.KasalikNomiId)
                .IsRequired();
            modelBuilder.Entity<KasalikNomi>()
               .HasOne(e => e.KasalikSababi)
               .WithOne(e => e.KasalikNomi)
               .HasForeignKey<KasalikSababi>(e => e.KasalikNomiId)
               .IsRequired();
        }
    }
}
