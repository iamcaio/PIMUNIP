using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Models
{
    internal class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public Cliente ClienteSelecionado { get; }
        public Produto ProdutoSelecionado { get; }
        public Cliente Cliente { get; internal set; }
        public Produto Produto { get; internal set; }

        public Pedido(int id, int clienteId, int produtoId, int quantidade)
        {
            Id = id;
            ClienteId = clienteId;
            ProdutoId = produtoId;
            Quantidade = quantidade;
        }

        public Pedido(Cliente clienteSelecionado, Produto produtoSelecionado, int quantidade)
        {
            ClienteSelecionado = clienteSelecionado;
            ProdutoSelecionado = produtoSelecionado;
            Quantidade = quantidade;
        }

        public void CadastrarPedido(List<Pedido> listaPedidos)
        {
            listaPedidos.Add(this);
            Console.WriteLine("Pedido cadastrado com sucesso!");
        }

        public void AtualizarPedido(List<Pedido> listaPedidos)
        {
            var pedido = listaPedidos.Find(p => p.Id == this.Id);
            if (pedido != null)
            {
                pedido.ClienteId = this.ClienteId;
                pedido.ProdutoId = this.ProdutoId;
                pedido.Quantidade = this.Quantidade;
                Console.WriteLine("Pedido atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Pedido não encontrado!");
            }
        }

        public void RemoverPedido(List<Pedido> listaPedidos)
        {
            var pedido = listaPedidos.Find(p => p.Id == this.Id);
            if (pedido != null)
            {
                listaPedidos.Remove(pedido);
                Console.WriteLine("Pedido removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Pedido não encontrado!");
            }
        }
    }
}
