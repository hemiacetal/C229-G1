using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mariia_S_301052981.Models
{
    public class Club
    {   
        [Key]
        [Required(ErrorMessage = "*The name of the club is missing")]
        public string ClubFullName { get; set; }
        public string Country { get; set; }
        public string HeadCoachName { get; set; }
        public string Ground { get; set; }
        public ICollection <Player> Players { get; set; }
    }
}
