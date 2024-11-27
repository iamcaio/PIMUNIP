using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public Fornecedor(int id, string nome, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }

        public Fornecedor(string nome, string email, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }

        public void CadastrarFornecedor(List<Fornecedor> listaFornecedores)
        {
            listaFornecedores.Add(this);
            Console.WriteLine("Fornecedor cadastrado com sucesso!");
        }

        public void AtualizarFornecedor(List<Fornecedor> listaFornecedores)
        {
            var fornecedor = listaFornecedores.Find(f => f.Id == this.Id);
            if (fornecedor != null)
            {
                fornecedor.Nome = this.Nome;
                fornecedor.Email = this.Email;
                fornecedor.Telefone = this.Telefone;
                Console.WriteLine("Fornecedor atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Fornecedor não encontrado!");
            }
        }

        public void RemoverFornecedor(List<Fornecedor> listaFornecedores)
        {
            var fornecedor = listaFornecedores.Find(f => f.Id == this.Id);
            if (fornecedor != null)
            {
                listaFornecedores.Remove(fornecedor);
                Console.WriteLine("Fornecedor removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Fornecedor não encontrado!");
            }
        }
    }
}
