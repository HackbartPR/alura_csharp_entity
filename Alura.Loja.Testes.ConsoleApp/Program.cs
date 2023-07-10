using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.Loja.Testes.ConsoleApp.Data;
using Alura.Loja.Testes.ConsoleApp.Models;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto pao = new Produto()
            {
                Nome = "Pão Francês",
                PrecoUnitario = 0.40,
                Categoria = "Padaria",
                Unidade = "UND"
            };

            Compra compra = new Compra(produto: pao, quantidade: 5);

            using(var context = new Context())
            {
                context.Compras.Add(compra);
                context.SaveChanges();
            }
        }       
    }
}
