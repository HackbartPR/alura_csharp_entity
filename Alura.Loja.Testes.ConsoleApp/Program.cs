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
            Cliente cliente = new Cliente() 
            {
                Nome = "Carlos",
                Endereco = new Endereco()
                {
                    Numero = 1,
                    Logradouro = "Rua Sem Nome",
                    Bairro = "Centro",
                    Cidade = "Toledo"                    
                }
            };

            using(var context = new Context())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }
        
        public static void RelacionamentoManyToMany()
        {
            Produto pao = new Produto()
            {
                Nome = "Pão Francês",
                PrecoUnitario = 0.40,
                Categoria = "Padaria",
                Unidade = "UND"
            };

            Produto sabonete = new Produto()
            {
                Nome = "Sabonete",
                PrecoUnitario = 3.40,
                Categoria = "Higiêne",
                Unidade = "UND"
            };

            Produto cereal = new Produto()
            {
                Nome = "Cereal",
                PrecoUnitario = 10.00,
                Categoria = "Café da Manhã",
                Unidade = "Gramas"
            };

            Promocao promocao = new Promocao()
            {
                Nome = "Dia das Mães",
                DataInicio = DateTime.Now,
                DataFim = DateTime.Now.AddMonths(2),
            };

            promocao.IncluirProdutos(pao);
            promocao.IncluirProdutos(sabonete);
            promocao.IncluirProdutos(cereal);

            using (var context = new Context())
            {
                context.Promocoes.Add(promocao);
                context.SaveChanges();
            }
        }
    }
}
