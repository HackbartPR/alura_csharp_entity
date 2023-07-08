using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GravarUsandoEntity();
            
            Console.WriteLine("Produto Salvo no Banco de Dados:\n");
            ListarProdutos();

            Console.WriteLine("\nAlterando Nome do Produto Salvo:\n");
            AtualizarProduto();
            ListarProdutos();

            Console.WriteLine("\nDeletando Produto Salvo:\n");
            DeletarProduto();            
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var context = new Context())
            {
                context.Add(p);
                context.SaveChanges();
            }
        }

        private static void ListarProdutos()
        {
            using (var context = new Context())
            {
                List<Produto> list = context.Produtos.ToList();

                list.ForEach(produto => Console.WriteLine($"{produto.Id} - {produto.Nome} - {produto.Categoria}"));
            }
        }

        private static void DeletarProduto()
        {
            using (var context = new Context())
            {
                Produto produto = context.Produtos.First(prod => prod.Nome.Equals("Harry Potter e a Ordem da Fênix (Editado)"));

                context.Remove(produto);
                context.SaveChanges();
            }
        }

        private static void AtualizarProduto()
        {
            using ( var context = new Context())
            {
                Produto produto = context.Produtos.First(prod => prod.Nome.Equals("Harry Potter e a Ordem da Fênix"));
                produto.Nome = "Harry Potter e a Ordem da Fênix (Editado)";

                context.Update(produto);
                context.SaveChanges();
            }
        }
    }
}
