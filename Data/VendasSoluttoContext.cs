using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VendasSolutto.Models;

namespace VendasSolutto.Data
{
    public class VendasSoluttoContext : DbContext
    {
        public VendasSoluttoContext (DbContextOptions<VendasSoluttoContext> options)
            : base(options)
        {
        }

        public DbSet<VendasSolutto.Models.Vendas> Vendas { get; set; }

        public DbSet<VendasSolutto.Models.Produtos> Produtos { get; set; }

        public DbSet<VendasSolutto.Models.ItensVenda> ItensVenda { get; set; }

        public DbSet<VendasSolutto.Models.Pagamentos> Pagamentos { get; set; }

        public DbSet<RetornoRelatorioBarra> retornoBarra { get; set; }

        public DbSet<RetornoRelatorioPizza> retornoPizza { get; set; }


    }
}
