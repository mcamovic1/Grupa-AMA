using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace AMA_cosmetics.Models
{
    public class RegistrovaniKorisnik: Korisnik
    {
        public DateTime DatumRegistracije { get; set; }
        public string Lozinka { get; set; }
        public RegistrovaniKorisnik() { }
    }
}
