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

            using (ProdutoDAOEntity entity = new ProdutoDAOEntity())
            {
                entity.Adicionar(p);
            }                            
        }

        private static void ListarProdutos()
        {
            using (ProdutoDAOEntity entity = new ProdutoDAOEntity())
            {
                List<Produto> list = entity.Listar();

                list.ForEach(produto => Console.WriteLine($"{produto.Id} - {produto.Nome} - {produto.Categoria}"));
            }
        }

        private static void DeletarProduto()
        {
            using (ProdutoDAOEntity entity = new ProdutoDAOEntity())
            {
                Produto produto = entity.context.Produtos.First(prod => prod.Nome.Equals("Harry Potter e a Ordem da Fênix (Editado)"));

                entity.Deletar(produto);
            }
        }

        private static void AtualizarProduto()
        {
            using (ProdutoDAOEntity entity = new ProdutoDAOEntity())
            {
                Produto produto = entity.context.Produtos.First(prod => prod.Nome.Equals("Harry Potter e a Ordem da Fênix"));
                produto.Nome = "Harry Potter e a Ordem da Fênix (Editado)";

                entity.Atualizar(produto);
            }
        }
    }
}
