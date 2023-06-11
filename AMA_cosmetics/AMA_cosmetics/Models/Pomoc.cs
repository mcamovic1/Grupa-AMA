using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMA_cosmetics.Models
{
    public class Pomoc
    {
        [Key] public int ID {get; set;}
        [ForeignKey("Korisnik")]
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }
        public string Pitanje { get; set; }
        public DateTime DatumPostavljanja { get; set; }
        public  string Odgovor { get; set; }
        public DateTime DatumOdgovora { get; set; }
        public SatusPitanja statu { get; set; }
        public Pomoc() { }
    }
}
