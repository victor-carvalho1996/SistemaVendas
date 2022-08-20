using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VendasSolutto.Models
{
    public class RetornoRelatorioPizza
    {
        [Key]
        public string produto_nome { get; set; }
        public double valor_vendido { get; set; }
    }
}
