using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VendasSolutto.Models
{
    public class RetornoRelatorioBarra
    {
        [Key]
        public DateTime data { get; set; }
        public double total_dia { get; set; }
    }
}
