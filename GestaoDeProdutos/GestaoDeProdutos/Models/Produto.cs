using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Models
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public Produto(int id, string nome, string descricao, decimal preco, int quantidadeEstoque)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public void CadastrarProduto(List<Produto> listaProdutos)
        {
            listaProdutos.Add(this);
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        public void AtualizarProduto(List<Produto> listaProdutos)
        {
            var produto = listaProdutos.Find(p => p.Id == this.Id);
            if (produto != null)
            {
                produto.Nome = this.Nome;
                produto.Descricao = this.Descricao;
                produto.Preco = this.Preco;
                produto.QuantidadeEstoque = this.QuantidadeEstoque;
                Console.WriteLine("Produto atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }
        }

        public void RemoverProduto(List<Produto> listaProdutos)
        {
            var produto = listaProdutos.Find(p => p.Id == this.Id);
            if (produto != null)
            {
                listaProdutos.Remove(produto);
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }
        }
    }
}
