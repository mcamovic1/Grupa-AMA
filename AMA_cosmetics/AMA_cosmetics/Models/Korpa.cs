using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMA_cosmetics.Models
{
    public class Korpa
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Proizvod")]
        public int IDProizvod { get; set; }
        public Proizvod Proizvod { get; set; }
        public string UserName { get; set; }
        //[ForeignKey("Korisnik")]
        public string IDKorisnik { get; set; }
       // public Korisnik Korisnik { get; set; }
        public int Cijena { get; set; }
        [DisplayName("Kolicina")]
        public int kolicina { get; set; }
        public Korpa() { }
    }
}
