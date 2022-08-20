using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VendasSolutto.Models
{
    public class ItensVenda
    {
        public int id { get; set; }
        public Produtos produto { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public double quantidade { get; set; }
        public Vendas venda { get; set; }

        public ItensVenda()
        {

        }

        public ItensVenda(int id, Produtos produto, double quantidade, Vendas venda)
        {
            this.id = id;
            this.produto = produto;
            this.quantidade = quantidade;
            this.venda = venda;
        }

    }
}
