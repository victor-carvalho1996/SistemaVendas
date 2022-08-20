using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasSolutto.Models;

namespace VendasSolutto.Data
{
    public class DadosService
    {
        private VendasSoluttoContext _context;

        public DadosService(VendasSoluttoContext context)
        {
            _context = context;
        }

        public void Popula()
        {
            if (_context.Vendas.Any() || _context.ItensVenda.Any() || _context.Pagamentos.Any() || _context.Produtos.Any())
            {
                return; // Database já populado
            }

            Produtos p1 = new Produtos(1, "Agua", 1.50);
            Produtos p2 = new Produtos(2, "Manteiga", 4.30);
            Produtos p3 = new Produtos(3, "Biscoito", 2.70);
            Produtos p4 = new Produtos(4, "Leite Caixa", 6.00);
            Produtos p5 = new Produtos(5, "Celular", 800.00);

            Vendas v1 = new Vendas(1, "79578606000169", new DateTime(2021, 07, 08, 10, 35, 20), 4);
            Vendas v2 = new Vendas(2, "90696383000177", new DateTime(2021, 07, 08, 11, 45, 10), 5);
            Vendas v3 = new Vendas(3, "70593032000123", new DateTime(2021, 07, 08, 12, 37, 20), 5);
            Vendas v4 = new Vendas(4, "77186956000154", new DateTime(2021, 07, 09, 08, 14, 25), 5);
            Vendas v5 = new Vendas(5, "32936237000175", new DateTime(2021, 07, 09, 10, 15, 27), 2);
            Vendas v6 = new Vendas(6, "69019692000116", new DateTime(2021, 07, 09, 14, 35, 23), 3);
            Vendas v7 = new Vendas(7, "48904605000133", new DateTime(2021, 07, 11, 11, 35, 20), 2);
            Vendas v8 = new Vendas(8, "30968224000152", new DateTime(2021, 07, 11, 15, 43, 10), 2);
            Vendas v9 = new Vendas(9, "09822427000140", new DateTime(2021, 07, 11, 16, 15, 19), 1);
            Vendas v10 = new Vendas(10, "92866905000167", new DateTime(2021, 07, 12, 10, 15, 15), 1);
            Vendas v11 = new Vendas(11, "53426558000108", new DateTime(2021, 07, 12, 14, 35, 23), 1);
            Vendas v12 = new Vendas(12, "71995766000100", new DateTime(2021, 07, 13, 11, 35, 20), 2);
            Vendas v13 = new Vendas(13, "25894017000160", new DateTime(2021, 07, 14, 10, 15, 15), 2);
            Vendas v14 = new Vendas(14, "98657851000106", new DateTime(2021, 07, 15, 10, 32, 15), 1);

            ItensVenda iv1 = new ItensVenda(1, p1, 10.0, v1);
            ItensVenda iv2 = new ItensVenda(2, p2, 15.0, v1); //79,50

            ItensVenda iv3 = new ItensVenda(3, p3, 15.0, v2);
            ItensVenda iv4 = new ItensVenda(4, p2, 20.0, v2); //126,5

            ItensVenda iv5 = new ItensVenda(5, p1, 9.0, v3); //74,90
            ItensVenda iv6 = new ItensVenda(6, p2, 8.0, v3);
            ItensVenda iv7 = new ItensVenda(7, p3, 10.0, v3);

            ItensVenda iv8 = new ItensVenda(10, p2, 10.0, v4);
            ItensVenda iv9 = new ItensVenda(11, p4, 15.0, v4); // 158,5
            ItensVenda iv10 = new ItensVenda(12, p1, 8.0, v4);
            ItensVenda iv11 = new ItensVenda(13, p3, 5.0, v4);

            ItensVenda iv12 = new ItensVenda(8, p4, 13.0, v5); // 98,00
            ItensVenda iv13 = new ItensVenda(9, p1, 20.0, v5);

            ItensVenda iv14 = new ItensVenda(14, p2, 20.0, v6); // 108
            ItensVenda iv15 = new ItensVenda(15, p3, 5.0, v6);

            ItensVenda iv16 = new ItensVenda(16, p2, 20.0, v7); //107,00
            ItensVenda iv17 = new ItensVenda(17, p3, 5.0, v7);
            ItensVenda iv18 = new ItensVenda(18, p1, 5.0, v7);

            ItensVenda iv19 = new ItensVenda(19, p2, 20.0, v8); // 119,0
            ItensVenda iv20 = new ItensVenda(20, p3, 5.0, v8);
            ItensVenda iv21 = new ItensVenda(21, p1, 5.0, v8);
            ItensVenda iv22 = new ItensVenda(22, p4, 2.0, v8);

            ItensVenda iv23 = new ItensVenda(23, p2, 30.0, v9); // 129

            ItensVenda iv24 = new ItensVenda(24, p3, 25.0, v10); // 67,5

            ItensVenda iv25 = new ItensVenda(25, p1, 25.0, v11); // 67,5
            ItensVenda iv26 = new ItensVenda(26, p2, 30.0, v11); // 67,5

            ItensVenda iv27 = new ItensVenda(27, p3, 25.0, v12); // 67,5
            ItensVenda iv28 = new ItensVenda(28, p5, 2.0, v12); // 67,5

            ItensVenda iv29 = new ItensVenda(29, p5, 1.0, v13); // 67,5
            ItensVenda iv30 = new ItensVenda(30, p3, 10.0, v13); // 67,5
            ItensVenda iv31 = new ItensVenda(31, p1, 3.0, v13); // 67,5

            ItensVenda iv32 = new ItensVenda(32, p5, 2.0, v14); // 67,5
            ItensVenda iv33 = new ItensVenda(33, p3, 10.0, v14); // 67,5
            ItensVenda iv34 = new ItensVenda(34, p1, 8.0, v14); // 67,5

            Pagamentos pg1 = new Pagamentos(1, new DateTime(2021, 08, 5), new DateTime(2021, 08, 8), 19.87, "Parcela 1 de 4", v1);
            Pagamentos pg2 = new Pagamentos(2, new DateTime(2021, 09, 4), new DateTime(2021, 09, 8), 19.87, "Parcela 2 de 4", v1);
            Pagamentos pg3 = new Pagamentos(3, new DateTime(2021, 10, 5), new DateTime(2021, 10, 8), 19.87, "Parcela 3 de 4", v1);
            Pagamentos pg4 = new Pagamentos(4, new DateTime(2021, 11, 6), new DateTime(2021, 11, 8), 19.89, "Parcela 4 de 4", v1);

            Pagamentos pg5 = new Pagamentos(5, new DateTime(2021, 08, 12), new DateTime(2021, 08, 13), 25.30, "Parcela 1 de 5", v2);
            Pagamentos pg6 = new Pagamentos(6, new DateTime(2021, 09, 10), new DateTime(2021, 09, 13), 25.30, "Parcela 2 de 5", v2);
            Pagamentos pg7 = new Pagamentos(7, new DateTime(2021, 10, 09), new DateTime(2021, 10, 13), 25.30, "Parcela 3 de 5", v2);
            Pagamentos pg8 = new Pagamentos(8, new DateTime(2021, 11, 08), new DateTime(2021, 11, 13), 25.30, "Parcela 4 de 5", v2);
            Pagamentos pg9 = new Pagamentos(9, new DateTime(2021, 12, 07), new DateTime(2021, 12, 13), 25.30, "Parcela 5 de 5", v2);

            Pagamentos pg10 = new Pagamentos(10, new DateTime(2021, 08, 12), new DateTime(2021, 08, 13), 14.98, "Parcela 1 de 5", v3);
            Pagamentos pg11 = new Pagamentos(11, new DateTime(2021, 09, 10), new DateTime(2021, 09, 13), 14.98, "Parcela 2 de 5", v3);
            Pagamentos pg12 = new Pagamentos(12, new DateTime(2021, 10, 09), new DateTime(2021, 10, 13), 14.98, "Parcela 3 de 5", v3);
            Pagamentos pg13 = new Pagamentos(13, new DateTime(2021, 11, 08), new DateTime(2021, 11, 13), 14.98, "Parcela 4 de 5", v3);
            Pagamentos pg14 = new Pagamentos(14, new DateTime(2021, 12, 07), new DateTime(2021, 12, 13), 14.98, "Parcela 5 de 5", v3);

            Pagamentos pg15 = new Pagamentos(15, new DateTime(2021, 09, 07), new DateTime(2021, 09, 09), 31.70, "Parcela 1 de 5", v4);
            Pagamentos pg16 = new Pagamentos(16, new DateTime(2021, 10, 08), new DateTime(2021, 10, 09), 31.70, "Parcela 2 de 5", v4);
            Pagamentos pg17 = new Pagamentos(17, new DateTime(2021, 11, 05), new DateTime(2021, 11, 09), 31.70, "Parcela 3 de 5", v4);
            Pagamentos pg18 = new Pagamentos(18, new DateTime(2021, 12, 04), new DateTime(2021, 12, 09), 31.70, "Parcela 4 de 5", v4);
            Pagamentos pg19 = new Pagamentos(19, new DateTime(2022, 01, 06), new DateTime(2022, 01, 09), 31.70, "Parcela 5 de 5", v4);

            Pagamentos pg20 = new Pagamentos(20, new DateTime(2021, 09, 12), new DateTime(2021, 09, 13), 54.00, "Parcela 1 de 2", v5);
            Pagamentos pg21 = new Pagamentos(21, new DateTime(2021, 10, 10), new DateTime(2021, 10, 13), 54.00, "Parcela 2 de 2", v5);

            Pagamentos pg22 = new Pagamentos(22, new DateTime(2021, 09, 12), new DateTime(2021, 09, 13), 33.16, "Parcela 1 de 3", v6);
            Pagamentos pg23 = new Pagamentos(23, new DateTime(2021, 10, 10), new DateTime(2021, 10, 13), 33.16, "Parcela 2 de 3", v6);
            Pagamentos pg24 = new Pagamentos(24, new DateTime(2021, 11, 09), new DateTime(2021, 11, 13), 33.18, "Parcela 3 de 3", v6);

            Pagamentos pg25 = new Pagamentos(25, new DateTime(2021, 08, 07), new DateTime(2021, 08, 10), 53.50, "Parcela 1 de 2", v7);
            Pagamentos pg26 = new Pagamentos(26, new DateTime(2021, 09, 09), new DateTime(2021, 09, 10), 53.50, "Parcela 2 de 2", v7);

            Pagamentos pg27 = new Pagamentos(27, new DateTime(2021, 08, 07), new DateTime(2021, 08, 11), 59.50, "Parcela 1 de 2", v8);
            Pagamentos pg28 = new Pagamentos(28, new DateTime(2021, 09, 09), new DateTime(2021, 09, 11), 59.50, "Parcela 2 de 2", v8);

            Pagamentos pg29 = new Pagamentos(29, new DateTime(2021, 08, 12), new DateTime(2021, 08, 12), 129.00, "Parcela 1 de 1", v9);

            Pagamentos pg30 = new Pagamentos(30, new DateTime(2021, 07, 12), new DateTime(2021, 07, 12), 67.50, "Parcela 1 de 1", v10);

            Pagamentos pg31 = new Pagamentos(31, new DateTime(2021, 07, 12), new DateTime(2021, 07, 12), 166.50, "Parcela 1 de 1", v11);

            Pagamentos pg32 = new Pagamentos(32, new DateTime(2021, 08, 10), new DateTime(2021, 08, 12), 833.75, "Parcela 1 de 2", v12);
            Pagamentos pg33 = new Pagamentos(33, new DateTime(2021, 09, 08), new DateTime(2021, 09, 12), 833.75, "Parcela 2 de 2", v12);

            Pagamentos pg34 = new Pagamentos(34, new DateTime(2021, 08, 10), new DateTime(2021, 08, 12), 415.75, "Parcela 1 de 2", v13);
            Pagamentos pg35 = new Pagamentos(35, new DateTime(2021, 09, 08), new DateTime(2021, 09, 12), 415.75, "Parcela 2 de 2", v13);

            Pagamentos pg36 = new Pagamentos(36, new DateTime(2021, 07, 12), new DateTime(2021, 07, 12), 1639.00, "Parcela 1 de 1", v11);

            _context.Produtos.AddRange(p1, p2, p3, p4);
            _context.Vendas.AddRange(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14);
            _context.ItensVenda.AddRange(iv1, iv2, iv3, iv4, iv5, iv6, iv7, iv8, iv9, iv10, iv11, iv12,
                iv13, iv14, iv15, iv16, iv17, iv18, iv19, iv20, iv21, iv22, iv23, iv24, iv25, iv26, iv27, 
                iv28, iv29, iv30, iv30, iv31, iv32, iv33, iv34);

            _context.Pagamentos.AddRange(pg1, pg2, pg3, pg4, pg5, pg6, pg7, pg8, pg9, pg10, pg11, pg12, pg13, pg14, pg15,
                pg16, pg17, pg18, pg19, pg20, pg21, pg22, pg23, pg24, pg25, pg26, pg27, pg28, pg29, pg30, pg31, pg32, pg33, pg34, pg35, pg36);

            _context.SaveChanges();
        }
    }
}
