using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace C229_G1.Models
{
    public class Log
    {
        [Key]
        public int logID { get; set; }
        public string user { get; set; }
        public DateTime datetime{ get; set; }
        public string action { get; set; }

    }
}
