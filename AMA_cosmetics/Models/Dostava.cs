using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMA_cosmetics.Models
{
    public class Dostava
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Narudzba")]
        public int NarudzbaID { get; set; }
        public Narudzba Narudzba { get; set; }
        public Vrsta KurirskaSluzba { get; set; }
        public double CijenaDostave { get; set; }
        public string AdresaDostave { get; set; }
        public DateTime DatumSlanja { get; set; }
        public DateTime DatumIsporuke { get; set; }
        public StatusPosiljke status { get; set; }
        public Dostava() { }
    }
}
