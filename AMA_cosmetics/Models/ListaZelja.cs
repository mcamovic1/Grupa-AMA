using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AMA_cosmetics.Models
{
    public class ListaZelja
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("PremiumKorisnik")]
        public int KorisnikID { get; set; }
        public PremiumKorisnik PremiumKorisnik { get; set; }

        [ForeignKey("Proizvod")]
        public int ProizvodID { get; set; }
        public Proizvod Proizvod { get; set; }

        public ListaZelja() { }
    }
}
