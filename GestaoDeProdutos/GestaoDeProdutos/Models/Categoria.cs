using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Models
{
    internal class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Categoria(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

        public void CadastrarCategoria(List<Categoria> listaCategorias)
        {
            listaCategorias.Add(this);
            Console.WriteLine("Categoria cadastrada com sucesso!");
        }

        public void AtualizarCategoria(List<Categoria> listaCategorias)
        {
            var categoria = listaCategorias.Find(c => c.Id == this.Id);
            if (categoria != null)
            {
                categoria.Nome = this.Nome;
                categoria.Descricao = this.Descricao;
                Console.WriteLine("Categoria atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Categoria não encontrada!");
            }
        }

        public void RemoverCategoria(List<Categoria> listaCategorias)
        {
            var categoria = listaCategorias.Find(c => c.Id == this.Id);
            if (categoria != null)
            {
                listaCategorias.Remove(categoria);
                Console.WriteLine("Categoria removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Categoria não encontrada!");
            }
        }
    }
}
