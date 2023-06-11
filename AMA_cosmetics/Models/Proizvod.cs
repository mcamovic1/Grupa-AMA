using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMA_cosmetics.Models
{
    public class Proizvod
    {
        [Key]
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public double Cijena { get; set; }
        public string Kolicina { get; set; }
        public string Kategorija { get; set; }
        [DisplayName("Slika proizvoda")]
        public string SlikaPutanja { get; set; }
        public StatusProizvoda Status { get; set; }
        public int Raspolozivost { get; set; }
        
        public Proizvod() { }

    }
}
