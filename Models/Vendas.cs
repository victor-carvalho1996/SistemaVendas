using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VendasSolutto.Models
{
    public class Vendas
    {

        public int id { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string cliente_cnpj { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime data_venda { get; set; }
        public int quantidade_pagamentos { get; set; }

        public Vendas()
        {

        }

        public Vendas(int id, string cliente_cnpj, DateTime data_venda,  int quantidade_pagamentos)
        {
            this.id = id;
            this.cliente_cnpj = cliente_cnpj;
            this.data_venda = data_venda;
            this.quantidade_pagamentos = quantidade_pagamentos;
        }
    }
}
