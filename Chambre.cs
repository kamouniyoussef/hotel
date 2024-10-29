using System.ComponentModel.DataAnnotations;

namespace gestion_hotel.Models
{
    public class Chambre
    {
        [Key]
        public int  Id {get; set;}
        [Required]  
        public required string Nom { get; set; }
        public required string Prenom { get; set; }

    }
}
