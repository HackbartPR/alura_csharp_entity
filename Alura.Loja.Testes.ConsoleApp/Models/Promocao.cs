using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp.Models
{
    public class Promocao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public ICollection<PromocaoProduto> Produtos { get; set; }

        public Promocao() 
        {
            this.Produtos = new List<PromocaoProduto>();
        }

        public void IncluirProdutos(Produto produto)
        {
            this.Produtos.Add( new PromocaoProduto() { Produto = produto });
        }
    }
}
