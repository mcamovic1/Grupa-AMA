using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AMA_cosmetics.Models
{
    public class PremiumKorisnik: Korisnik
    {
        [Key]
        public int ID { get; set; }
        public string Lozinka { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public PremiumKorisnik() { }

    }
}
