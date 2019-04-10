using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace C229_G1.Models
{
    public class Club
    {
        [Key]
        public int ClubID { get; set; }
        [Required(ErrorMessage = "Please enter a club name")]
        public string ClubFullName { get; set; }
        //[MinLength (5, ErrorMessage = "Minimum length is 3 characters")]
        public string Country { get; set; }
        public string HeadCoachName { get; set; }
        public string Ground { get; set; }
        public ICollection <Player> Players { get; set; }
    }
}
