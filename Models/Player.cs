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
        public int PlayerID { get; set; }
        [Required(ErrorMessage = "Please enter a player name")]
        public string PlayerName { get; set; }
        [Range(16, 55, ErrorMessage ="Player should be between 16 and 55 years old")]
        public int? Age { get; set; }
        //[MinLength(5, ErrorMessage = "Minimum length is 3 characters")]
        public string CountryOfBirth { get; set; } 
        public string PlayingPosition { get; set; }
        public int ClubID { get; set; }
        
    }
}
