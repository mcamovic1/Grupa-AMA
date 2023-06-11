using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AMA_cosmetics.Models
{
    public class Narudzba
    {
        [Key]
        public int ID { get; set; }
        //[ForeignKey("Korisnik")]
        //public int NarucilacID { get; set; }
        //public Korisnik Korisnik { get; set; }
        public string UserName { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Grad { get; set; }
        public string Adresa { get; set; }
        [DisplayName("Broj telefona")]
        public string BrojTeleona { get; set; }
        [DisplayName("Ukupna cijena")]
        public double UkupnaCijena { get; set; }
        [ForeignKey("Placanje")]
        public int PlacanjeID { get; set; }
        public Placanje Placanje { get; set; }
        [DisplayName("Odabir načina plaćanja")]
        public VstaPlacanja vrsta { get; set; }
        [DisplayName("Datum kreiranja narudžbe")]
        public  DateTime DatumKreiranja { get; set; }
        public  StatusNarudzbe status { get; set; }
        public Narudzba() { }

    }
}
