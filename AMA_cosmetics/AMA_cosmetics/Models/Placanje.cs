using System;
using System.ComponentModel.DataAnnotations;

namespace AMA_cosmetics.Models
{
    public class Placanje { 
        [Key]
        public int ID{ get; set; }
        public double Iznos { get; set; }
        public VstaPlacanja NacinPlacanja { get; set; }
        public string BrojKartice { get; set; }
        public string ImeVlasnikaKartice { get; set; }
        public DateTime DatumPlacanja { get; set; }
        public bool StatusPlacanja { get; set; }
        public Placanje() { }
}
}
