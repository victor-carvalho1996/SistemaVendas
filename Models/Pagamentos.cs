using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VendasSolutto.Models
{
    public class Pagamentos
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_pagamento { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_vencimento { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public double valor_pago { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string descricao_pagamento { get; set; }
        public Vendas vendas { get; set; }

        public Pagamentos()
        {

        }

        public Pagamentos(int id, DateTime data_pagamento, DateTime data_vencimento, double valor_pago, string descricao_pagamento, Vendas vendas)
        {
            this.id = id;
            this.data_pagamento = data_pagamento;
            this.data_vencimento = data_vencimento;
            this.valor_pago = valor_pago;
            this.descricao_pagamento = descricao_pagamento;
            this.vendas = vendas;
        }
    }
}
