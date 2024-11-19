using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormUNIP
{
    public partial class telaPrinc : Form
    {
        private Estoque estoque;

        private void AtualizarGrid()
        {
            dataGridViewProdutos.DataSource = null;
            dataGridViewProdutos.DataSource = estoque.Produtos;
        }        

        public telaPrinc()
        {
            InitializeComponent();
            estoque = new Estoque();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var produto = new Produto()
            {
                Id = int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Preco = double.Parse(txtPreco.Text),
                Quantidade = int.Parse(txtQuantidade.Text),
                Categoria = (Categoria)cmbCategoria.SelectedItem,
                Fornecedor = (Fornecedor)cmbFornecedor.SelectedItem
            };

            estoque.AdicionarProduto(produto);
            MessageBox.Show("Produto adicionado com sucesso!", "Atenção",MessageBoxButtons.OK ,MessageBoxIcon.Information);
            AtualizarGrid();
        }

        private void btAtt_Click(object sender, EventArgs e)
        {
            var produtoAtualizado = new Produto()
            {
                Id = int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Preco = double.Parse(txtPreco.Text),
                Quantidade = int.Parse(txtQuantidade.Text),
                Categoria = (Categoria)cmbCategoria.SelectedItem,
                Fornecedor = (Fornecedor)cmbFornecedor.SelectedItem
            };
            estoque.AtualizarProduto(produtoAtualizado);
            MessageBox.Show("Produto atualizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AtualizarGrid();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtId.Text);

            estoque.RemoverProduto(Id);
            MessageBox.Show("Produto removido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AtualizarGrid();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void telaPrinc_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add(new Categoria(1, "Derivados"));
            cmbCategoria.Items.Add(new Categoria(2, "Verduras"));
            cmbCategoria.Items.Add(new Categoria(3, "Legumes"));
            cmbCategoria.Items.Add(new Categoria(4, "Grãos"));
            cmbCategoria.Items.Add(new Categoria(5, "Carnes"));

            cmbFornecedor.Items.Add(new Fornecedor(1, "Forne1", "contato@forne1.com", "14895"));
            cmbFornecedor.Items.Add(new Fornecedor(2, "Forne2", "contato@forne2.com", "74839"));
            cmbFornecedor.Items.Add(new Fornecedor(3, "Forne3", "contato@forne3.com", "45378"));
        }
    }

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public Categoria Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Produto() { }

        public Produto(int id, string nome, double preco, int quantidade, Categoria categoria, Fornecedor fornecedor)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Categoria = categoria;
            Fornecedor = fornecedor;
        }

        public void AtualizarPreco (double novoPreco)
        {
            Preco = novoPreco;
        }
        public void AtualizarQuantidade (int novaQuantidade)
        { 
            Quantidade = novaQuantidade;
        }
        public double CalcularValorEstoque()
        {
            return Quantidade * Preco;
        }
        public override string ToString()
        {
            return $"Produto: {Nome}, Preco: {Preco}, Quantidade: {Quantidade}";
        }
    }

    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Categoria() { }
        public Categoria (int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }

        public Fornecedor() { }
        public Fornecedor(int id, string nome, string contato, string telefone)
        {
            Id = id;
            Nome = nome;
            Contato = contato;
            Telefone = telefone;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
    public class Estoque
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();
        public Estoque() { }
        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }
        public void RemoverProduto(int id)
        {
            Produtos.RemoveAll(p => p.Id == id);
        }
        public Produto BuscarProdutoPorId(int id)
        {
            return Produtos.FirstOrDefault(p => p.Id == id);
        }
        public List<Produto> BuscarProdutosPorCategoria(Categoria categoria)
        {
            return Produtos.Where(p => p.Categoria.Id == categoria.Id).ToList();
        }
        public void AtualizarProduto(Produto produtoAtualizado)
        {
            var produto = BuscarProdutoPorId(produtoAtualizado.Id);
            if (produto != null)
            {
                produto.Nome = produtoAtualizado.Nome;
                produto.Preco = produtoAtualizado.Preco;
                produto.Quantidade = produtoAtualizado.Quantidade;
                produto.Categoria = produtoAtualizado.Categoria;
                produto.Fornecedor = produtoAtualizado.Fornecedor;
            }
        }
        public double CalcularValorTotalEstoque()
        {
            return Produtos.Sum(p => p.CalcularValorEstoque());
        }
        public void ListarProdutos()
        {
            foreach (var produto in Produtos)
            {
                Console.WriteLine(produto);
            }
        }
    }
}
