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
    public partial class FormClientes : Form
    {
        private List<Cliente> listaClientes = new List<Cliente>();

        public FormClientes()
        {
            InitializeComponent();
        }

        // Adiciona um novo cliente
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCliente.Text;
            string cpf = txtCPF.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;
            string endereco = txtEndereco.Text;

            Cliente novoCliente = new Cliente(nome, cpf, email, telefone, endereco);
            listaClientes.Add(novoCliente);

            LimparCampos();
            AtualizarGrid();
        }

        // Atualiza o cliente selecionado
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                int index = dgvClientes.CurrentRow.Index;
                listaClientes[index].CPF = txtCPF.Text;
                listaClientes[index].Email = txtEmail.Text;
                listaClientes[index].Telefone = txtTelefone.Text;
                listaClientes[index].Endereco = txtEndereco.Text;

                LimparCampos();
                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para atualizar!");
            }
        }

        // Remove o cliente selecionado
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                int index = dgvClientes.CurrentRow.Index;
                listaClientes.RemoveAt(index);

                LimparCampos();
                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para remover!");
            }
        }

        // Limpa os campos de entrada
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Atualiza o DataGridView
        private void AtualizarGrid()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaClientes;
        }

        // Preenche os campos ao selecionar uma linha no DataGridView
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNomeCliente.Text = listaClientes[e.RowIndex].Nome;
                txtCPF.Text = listaClientes[e.RowIndex].CPF;
                txtEmail.Text = listaClientes[e.RowIndex].Email;
                txtTelefone.Text = listaClientes[e.RowIndex].Telefone;
                txtEndereco.Text = listaClientes[e.RowIndex].Endereco;
            }
        }

        // Limpa os campos
        private void LimparCampos()
        {
            txtNomeCliente.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
        }
    }
}
