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
    public partial class FormFornecedores : Form
    {
        private List<Fornecedor> listaFornecedores = new List<Fornecedor>();

        public FormFornecedores()
        {
            InitializeComponent();
        }

        // Adiciona um novo fornecedor

        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            string nome = txtNomeFornecedor.Text;
            string email = txtEmailFornecedor.Text;
            string telefone = txtTelefoneFornecedor.Text;

            Fornecedor novoFornecedor = new Fornecedor(nome, email, telefone);
            listaFornecedores.Add(novoFornecedor);

            LimparCampos();
            AtualizarGrid();
        }


        // Atualiza o fornecedor selecionado
        private void btnAtualizarFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewFornecedores.CurrentRow != null)
            {
                int index = dataGridViewFornecedores.CurrentRow.Index;
                listaFornecedores[index].Nome = txtNomeFornecedor.Text;
                listaFornecedores[index].Email = txtEmailFornecedor.Text;
                listaFornecedores[index].Telefone = txtTelefoneFornecedor.Text;

                LimparCampos();
                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para atualizar!");
            }
        }

        // Remove o fornecedor selecionado
        private void btnRemoverFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewFornecedores.CurrentRow != null)
            {
                int index = dataGridViewFornecedores.CurrentRow.Index;
                listaFornecedores.RemoveAt(index);

                LimparCampos();
                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para remover!");
            }
        }

        // Limpa os campos de entrada
        private void btnListarFornecedores_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        // Atualiza o DataGridView
        private void AtualizarGrid()
        {
            dataGridViewFornecedores.DataSource = null;
            dataGridViewFornecedores.DataSource = listaFornecedores;
        }

        // Preenche os campos ao selecionar uma linha no DataGridView
        private void dgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNomeFornecedor.Text = listaFornecedores[e.RowIndex].Nome;
                txtEmailFornecedor.Text = listaFornecedores[e.RowIndex].Email;
                txtTelefoneFornecedor.Text = listaFornecedores[e.RowIndex].Telefone;
            }
        }

        // Limpa os campos
        private void LimparCampos()
        {
            txtNomeFornecedor.Text = "";
            txtEmailFornecedor.Text = "";
            txtTelefoneFornecedor.Text = "";
        }
    }
}
