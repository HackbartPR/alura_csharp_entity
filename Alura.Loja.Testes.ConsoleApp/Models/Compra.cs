using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp.Models
{
    public class Compra
    {
        public int Id { get; internal set; }
        public int Quantidade { get; internal set; }
        public double Preco { get; internal set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; internal set; }

        public Compra(Produto produto, int quantidade)
        {
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.Preco = SetPreco();
        }

        private double SetPreco()
        {
            return this.Produto.PrecoUnitario * this.Quantidade;
        }
    }
}
