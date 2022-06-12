using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Database
{
    public class NextGameDBContext : DbContext
    {
        public NextGameDBContext(DbContextOptions<NextGameDBContext> objekt):base(objekt)
        {

        }
        public DbSet<Igrica> Igrice { get; set; }
        public DbSet<IzdavackaKuca> IzdavackeKuce { get; set; }
        public DbSet<Komentar> Komentari { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<ListaIgrica> ListaIgrica { get; set; }
        public DbSet<Objava> Objave { get; set; }
        public DbSet<Recenzija> Recenzije { get; set; }
        public DbSet<SystemRequirements> SystemRequirements { get; set; }
        public DbSet<Uloga> Uloge { get; set; }
        public DbSet<Adresa> Adrese { get; set; }
        public DbSet<Kontakt> Kontakti { get; set; }
        public DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public DbSet<Zanr> Zanrovi { get; set; }
        public DbSet<Tip> Tipovi { get; set; }
        public DbSet<Platforma> Platforme { get; set; }
        public DbSet<IgricaZanr> IgriceZanrovi { get; set; }
        public DbSet<IgricaPlatforma> IgricePlatforme { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IgricaZanr>().HasKey(nameof(IgricaZanr.IgricaId), nameof(IgricaZanr.ZanrId));
            modelBuilder.Entity<IgricaPlatforma>().HasKey(nameof(IgricaPlatforma.IgricaId), nameof(IgricaPlatforma.PlatformaId));
        }
    }
}
