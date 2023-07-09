using Alura.Loja.Testes.ConsoleApp.Models;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp.Data
{
    public interface IProdutoDAO
    {
        void Adicionar(Produto produto);
        List<Produto> Listar();
        void Atualizar(Produto produto);
        void Deletar(Produto produto);
    }
}
