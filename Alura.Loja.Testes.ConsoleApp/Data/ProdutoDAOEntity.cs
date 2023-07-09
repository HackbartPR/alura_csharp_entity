using System;
using System.Linq;
using System.Data.Common;
using System.Collections.Generic;
using Alura.Loja.Testes.ConsoleApp.Models;

namespace Alura.Loja.Testes.ConsoleApp.Data
{
    internal class ProdutoDAOEntity : IDisposable, IProdutoDAO
    {
        public Context context;

        public ProdutoDAOEntity()
        {
            this.context = new Context();    
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public void Adicionar(Produto produto)
        {
            try
            {
                context.Produtos.Add(produto);
                context.SaveChanges();

            } catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Produto> Listar()
        {
            try
            {
                List<Produto> list = context.Produtos.ToList();                
                return list;                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        public void Atualizar(Produto produto)
        {
            try
            {
                context.Produtos.Update(produto);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Deletar(Produto produto)
        {
            try
            {
                context.Produtos.Remove(produto);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
