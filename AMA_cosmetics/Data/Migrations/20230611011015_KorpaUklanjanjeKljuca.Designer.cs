﻿// <auto-generated />
using System;
using AMA_cosmetics.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AMA_cosmetics.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230611011015_KorpaUklanjanjeKljuca")]
    partial class KorpaUklanjanjeKljuca
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AMA_cosmetics.Models.DodeljeniPopusti", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDKorisnika")
                        .HasColumnType("int");

                    b.Property<int>("IDPopust")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDKorisnika");

                    b.HasIndex("IDPopust");

                    b.ToTable("DodeljeniPopusti");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.Dostava", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdresaDostave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CijenaDostave")
                        .HasColumnType("float");

                    b.Property<DateTime>("DatumIsporuke")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumSlanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("KurirskaSluzba")
                        .HasColumnType("int");

                    b.Property<int>("NarudzbaID")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("NarudzbaID");

                    b.ToTable("Dostava");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.Korisnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.Korpa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cijena")
                        .HasColumnType("int");

                    b.Property<string>("IDKorisnik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDProizvod")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("kolicina")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IDProizvod");

                    b.ToTable("Korpa");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.ListaZelja", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("ProizvodID");

                    b.ToTable("ListaZelja");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.NaruceniProizvodi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDNarudzba")
                        .HasColumnType("int");

                    b.Property<int>("IDProizvod")
                        .HasColumnType("int");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDNarudzba");

                    b.HasIndex("IDProizvod");

                    b.ToTable("NaruceniProizvodi");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.Narudzba", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTeleona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Grad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NarucilacID")
                        .HasColumnType("int");

                    b.Property<int>("PlacanjeID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UkupnaCijena")
                        .HasColumnType("float");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("NarucilacID");

                    b.HasIndex("PlacanjeID");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.Placanje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojKartice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumPlacanja")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImeVlasnikaKartice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Iznos")
                        .HasColumnType("float");

                    b.Property<int>("NacinPlacanja")
                        .HasColumnType("int");

                    b.Property<bool>("StatusPlacanja")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Placanje");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.Pomoc", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumOdgovora")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPostavljanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Odgovor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pitanje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("statu")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Pomoc");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.Popust", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIsteka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPocetka")
                        .HasColumnType("datetime2");

                    b.Property<double>("Iznos")
                        .HasColumnType("float");

                    b.Property<string>("KodPopista")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StanjePopusta")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Popust");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.Proizvod", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<string>("Kategorija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kolicina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Raspolozivost")
                        .HasColumnType("int");

                    b.Property<string>("SlikaPutanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.Recenzija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumOcjenjivanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.Property<int>("PisacRecenzijeID")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodID")
                        .HasColumnType("int");

                    b.Property<bool>("StatusRecenzije")
                        .HasColumnType("bit");

                    b.Property<string>("text_recenzije")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PisacRecenzijeID");

                    b.HasIndex("ProizvodID");

                    b.ToTable("Recenzija");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.NeregistrovaniKorisnik", b =>
                {
                    b.HasBaseType("AMA_cosmetics.Models.Korisnik");

                    b.ToTable("NeregistroavniKorisnik");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.PremiumKorisnik", b =>
                {
                    b.HasBaseType("AMA_cosmetics.Models.Korisnik");

                    b.Property<DateTime>("DatumRegistracije")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("PremiumKorisnik");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.RegistrovaniKorisnik", b =>
                {
                    b.HasBaseType("AMA_cosmetics.Models.Korisnik");

                    b.Property<DateTime>("DatumRegistracije")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("RegistroavniKorisnik");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.DodeljeniPopusti", b =>
                {
                    b.HasOne("AMA_cosmetics.Models.PremiumKorisnik", "PremiumKorisnik")
                        .WithMany()
                        .HasForeignKey("IDKorisnika")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AMA_cosmetics.Models.Popust", "Popust")
                        .WithMany()
                        .HasForeignKey("IDPopust")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Popust");

                    b.Navigation("PremiumKorisnik");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.Dostava", b =>
                {
                    b.HasOne("AMA_cosmetics.Models.Narudzba", "Narudzba")
                        .WithMany()
                        .HasForeignKey("NarudzbaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Narudzba");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.Korpa", b =>
                {
                    b.HasOne("AMA_cosmetics.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("IDProizvod")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.ListaZelja", b =>
                {
                    b.HasOne("AMA_cosmetics.Models.PremiumKorisnik", "PremiumKorisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AMA_cosmetics.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PremiumKorisnik");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.NaruceniProizvodi", b =>
                {
                    b.HasOne("AMA_cosmetics.Models.Narudzba", "Narudzba")
                        .WithMany()
                        .HasForeignKey("IDNarudzba")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AMA_cosmetics.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("IDProizvod")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Narudzba");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.Narudzba", b =>
                {
                    b.HasOne("AMA_cosmetics.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("NarucilacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AMA_cosmetics.Models.Placanje", "Placanje")
                        .WithMany()
                        .HasForeignKey("PlacanjeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Placanje");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.Pomoc", b =>
                {
                    b.HasOne("AMA_cosmetics.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("AMA_cosmetics.Models.Recenzija", b =>
                {
                    b.HasOne("AMA_cosmetics.Models.PremiumKorisnik", "PremiumKorisnik")
                        .WithMany()
                        .HasForeignKey("PisacRecenzijeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AMA_cosmetics.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PremiumKorisnik");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AMA_cosmetics.Models.NeregistrovaniKorisnik", b =>
                {
                    b.HasOne("AMA_cosmetics.Models.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("AMA_cosmetics.Models.NeregistrovaniKorisnik", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AMA_cosmetics.Models.PremiumKorisnik", b =>
                {
                    b.HasOne("AMA_cosmetics.Models.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("AMA_cosmetics.Models.PremiumKorisnik", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AMA_cosmetics.Models.RegistrovaniKorisnik", b =>
                {
                    b.HasOne("AMA_cosmetics.Models.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("AMA_cosmetics.Models.RegistrovaniKorisnik", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
