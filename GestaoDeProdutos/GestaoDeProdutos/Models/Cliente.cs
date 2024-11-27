using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Models
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Nome { get; set; }

        public Cliente(int id, string nome, string cpf, string email, string telefone)
        {
            Id = id;
            NomeCliente = nome;
            CPF = cpf;
            Email = email;
            Telefone = telefone;
        }

        public Cliente(string nome, string cpf, string email, string telefone, string endereco)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }

        public void CadastrarCliente(List<Cliente> listaClientes)
        {
            listaClientes.Add(this);
            Console.WriteLine("Cliente cadastrado com sucesso!");
        }

        public void AtualizarCliente(List<Cliente> listaClientes)
        {
            var cliente = listaClientes.Find(c => c.Id == this.Id);
            if (cliente != null)
            {
                cliente.NomeCliente = this.NomeCliente;
                cliente.CPF = this.CPF;
                cliente.Email = this.Email;
                cliente.Telefone = this.Telefone;
                Console.WriteLine("Cliente atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");
            }
        }

        public void RemoverCliente(List<Cliente> listaClientes)
        {
            var cliente = listaClientes.Find(c => c.Id == this.Id);
            if (cliente != null)
            {
                listaClientes.Remove(cliente);
                Console.WriteLine("Cliente removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");
            }
        }
    }
}
