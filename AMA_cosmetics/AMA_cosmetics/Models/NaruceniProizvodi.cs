using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace AMA_cosmetics.Models
{
    public class NaruceniProizvodi
    {
        [Key]
        public int ID {get; set;}
        [ForeignKey ("Proizvod")]
        public int IDProizvod { get; set; }
        public Proizvod Proizvod { get; set; }
        public int  Kolicina { get; set; }
        [ForeignKey("Narudzba")]
        public int IDNarudzba { get; set; }
        public Narudzba Narudzba { get; set; }
        public NaruceniProizvodi() { }


    }
}
