using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMA_cosmetics.Models
{
    public class DodeljeniPopusti
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("PremiumKorisnik")] 
        public int IDKorisnika { get; set; }
       
        [ForeignKey("Popust")] 
        public int IDPopust { get; set; }

        public PremiumKorisnik PremiumKorisnik { get; set; }
        public Popust Popust { get; set; }
    }
}
