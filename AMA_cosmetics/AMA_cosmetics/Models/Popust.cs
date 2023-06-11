using System;
using System.ComponentModel.DataAnnotations;

namespace AMA_cosmetics.Models
{
    public class Popust
    {
        [Key]
        public int ID { get; set; }
        public StatusPopusta StanjePopusta { get; set; }
        public string KodPopista { get; set; }
        public double Iznos { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumIsteka { get; set; }
        public Popust() { }

    }
}
