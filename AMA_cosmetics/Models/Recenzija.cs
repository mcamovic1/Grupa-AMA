using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMA_cosmetics.Models
{
    public class Recenzija
    {
        [Key] public int ID { get; set; }
        [ForeignKey("Proizvod")]
        public int ProizvodID { get; set; }
        public Proizvod Proizvod { get; set; }
        public int Ocjena { get; set; }
        public string text_recenzije { get; set; }
        public DateTime DatumOcjenjivanja { get; set; }
        public bool StatusRecenzije { get; set; }
        [ForeignKey("PremiumKorisnik")]
        public int PisacRecenzijeID { get; set; }
        public PremiumKorisnik PremiumKorisnik { get; set; }
        public Recenzija() { }
    }
}
