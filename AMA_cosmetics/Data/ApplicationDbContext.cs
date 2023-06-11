using System;
using System.Collections.Generic;
using System.Text;
using AMA_cosmetics.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AMA_cosmetics.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<RegistrovaniKorisnik> RegistrovaniKorisnik { get; set; }
        //public DbSet<NeregistrovaniKorisnik> NeregistrovaniKorisnik { get; set; }
        public DbSet<PremiumKorisnik> PremiumKorisnik { get; set; }
        public DbSet<Proizvod> Prizvod{ get; set; }
        public DbSet<NaruceniProizvodi> NaruceniProizvodi { get; set; }
        public DbSet<Recenzija> Recenzija { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<Dostava> Dostava { get; set; }
        public DbSet<Popust> Popust { get; set; }
        public DbSet<DodeljeniPopusti> DodeljeniPopusti { get; set; }
        public DbSet<Korpa> Korpa { get; set; }
        public DbSet<ListaZelja> ListaZelja { get; set; }
        public DbSet<Pomoc> Pomoc { get; set; }
        public DbSet<Placanje> Placanje { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            //modelBuilder.Entity<NeregistrovaniKorisnik>().ToTable("NeregistroavniKorisnik");
            modelBuilder.Entity<RegistrovaniKorisnik>().ToTable("RegistroavniKorisnik");
            modelBuilder.Entity<PremiumKorisnik>().ToTable("PremiumKorisnik");
            modelBuilder.Entity<Proizvod>().ToTable("Proizvod");
            modelBuilder.Entity<NaruceniProizvodi>().ToTable("NaruceniProizvodi");
            modelBuilder.Entity<Recenzija>().ToTable("Recenzija");
            modelBuilder.Entity<Narudzba>().ToTable("Narudzba");
            modelBuilder.Entity<Dostava>().ToTable("Dostava");
            modelBuilder.Entity<Popust>().ToTable("Popust");
            modelBuilder.Entity<DodeljeniPopusti>().ToTable("DodeljeniPopusti");
            modelBuilder.Entity<Korpa>().ToTable("Korpa"); 
            modelBuilder.Entity<ListaZelja>().ToTable("ListaZelja");
            modelBuilder.Entity<Pomoc>().ToTable("Pomoc");
            modelBuilder.Entity<Placanje>().ToTable("Placanje");
            base.OnModelCreating(modelBuilder);
        }





    }
}
