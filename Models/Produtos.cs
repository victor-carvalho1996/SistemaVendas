using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VendasSolutto.Models
{
    public class Produtos
    {
        public int id { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string produto_nome { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public double valor_unitario { get; set; }

        public Produtos()
        {

        }

        public Produtos(int id, string produto_nome, double valor_unitario)
        {
            this.id = id;
            this.produto_nome = produto_nome;
            this.valor_unitario = valor_unitario;
        }
    }
}
