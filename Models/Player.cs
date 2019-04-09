using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace C229_G1.Models
{
    public class Player
    {
        [Key]
        [Required(ErrorMessage = "*The name of the player is missing")]
        public string PlayerName { get; set; }
        public int? Age { get; set; }
        public string CountryOfBirth { get; set; } 
        public string PlayingPosition { get; set; }
        public string ClubFullName { get; set; }
        
    }
}
