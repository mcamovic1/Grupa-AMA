using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AMA_cosmetics.Models
{
    public abstract class Korisnik
    {
        [Key]
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public string Telefon { get; set; }
        UlogaKorisnika status { get; set; }
        public Korisnik() { }
       
    }
}
