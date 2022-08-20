using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VendasSolutto.Data;
using VendasSolutto.Models;

namespace VendasSolutto.Controllers
{
    public class RelatoriosController : Controller
    {
        private readonly VendasSoluttoContext _context;


        public RelatoriosController(VendasSoluttoContext context)
        {
            _context = context;
        }

        // POST: RelatoriosController/Create
        [HttpPost]
        public IActionResult RelatorioBarra(EntradaRelatorio datas)
        {
            var results = _context.retornoBarra.FromSqlRaw<RetornoRelatorioBarra>(String.Format("SELECT date(data_venda) as data, SUM(p.valor_unitario * i.quantidade) as total_dia " + 
                                                                                                "FROM vendas v " +
                                                                                                "INNER JOIN itensvenda i ON v.id = i.vendaid " + 
                                                                                                "INNER JOIN produtos p ON i.produtoid = p.id " + 
                                                                                                "WHERE date(data_venda) BETWEEN '{0}' and '{1}' " + 
                                                                                                "GROUP BY date(data_venda) " + 
                                                                                                "ORDER BY date(data_venda) DESC", 
                                                                                                datas.dataInicial, datas.dataFinal));
            

            if (results.Equals(null))
            {
                return NotFound();
            }


            return Ok(results);
        }

        [HttpPost]
        public IActionResult RelatorioPizza(EntradaRelatorio datas)
        {
            var results = _context.retornoPizza.FromSqlRaw<RetornoRelatorioPizza>(String.Format("SELECT	p.produto_nome as produto_nome, SUM(p.valor_unitario * i.quantidade) as valor_vendido " + 
                                                                                                "FROM vendas v " + 
                                                                                                "INNER JOIN itensvenda i ON v.id = i.vendaid " + 
                                                                                                "INNER JOIN produtos p ON i.produtoid = p.id " + 
                                                                                                "WHERE date(data_venda) BETWEEN '{0}' and '{1}' " + 
                                                                                                "GROUP BY p.produto_nome " + 
                                                                                                "ORDER BY p.produto_nome", 
                                                                                                datas.dataInicial, datas.dataFinal));


            if (results.Equals(null))
            {
                return NotFound();
            }


            return Ok(results);
        }
    }
}
