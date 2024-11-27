using GestaoDeProdutos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeProdutos
{
    public partial class FormProdutos : Form
    {
        private List<Produto> listaProdutos = new List<Produto>();

        public FormProdutos()
        {
            InitializeComponent();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
            id: listaProdutos.Count + 1,
            nome: txtNomeProduto.Text,
            descricao: txtDescricaoProduto.Text,
            preco: numPrecoProduto.Value,
            quantidadeEstoque: (int)numQuantidadeProduto.Value
        );

            produto.CadastrarProduto(listaProdutos);
            AtualizarGridProdutos();
            LimparCampos();
        }

        private void btnAtualizarProduto_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdProduto.Text);
            Produto produto = new Produto(
                id: id,
                nome: txtNomeProduto.Text,
                descricao: txtDescricaoProduto.Text,
                preco: numPrecoProduto.Value,
                quantidadeEstoque: (int)numQuantidadeProduto.Value
            );

            produto.AtualizarProduto(listaProdutos);
            AtualizarGridProdutos();
            LimparCampos();
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdProduto.Text);
            Produto produto = new Produto(id, "", "", 0, 0);
            produto.RemoverProduto(listaProdutos);
            AtualizarGridProdutos();
            LimparCampos();
        }

        private void btnListarProdutos_Click(object sender, EventArgs e)
        {
            AtualizarGridProdutos();
        }
        private void AtualizarGridProdutos()
        {
            dataGridViewProdutos.DataSource = null;
            dataGridViewProdutos.DataSource = listaProdutos;
        }
        private void LimparCampos()
        {
            txtIdProduto.Clear();
            txtNomeProduto.Clear();
            txtDescricaoProduto.Clear();
            numPrecoProduto.Value = 0;
            numQuantidadeProduto.Value = 0;
        }

        private void dataGridViewProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProdutos.Rows[e.RowIndex];
                txtIdProduto.Text = row.Cells["Id"].Value.ToString();
                txtNomeProduto.Text = row.Cells["Nome"].Value.ToString();
                txtDescricaoProduto.Text = row.Cells["Descricao"].Value.ToString();
                numPrecoProduto.Value = Convert.ToDecimal(row.Cells["Preco"].Value);
                numQuantidadeProduto.Value = Convert.ToInt32(row.Cells["QuantidadeEstoque"].Value);
            }
        }
    }
}
