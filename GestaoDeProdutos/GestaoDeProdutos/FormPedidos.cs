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
    public partial class FormPedidos : Form
    {
        private List<Pedido> listaPedidos = new List<Pedido>();

        public FormPedidos()
        {
            InitializeComponent();
        }

        // Adiciona um novo pedido
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)cmbCliente.SelectedItem;
            Produto produtoSelecionado = (Produto)cmbProduto.SelectedItem;
            int quantidade = (int)nudQuantidade.Value;

            Pedido novoPedido = new Pedido(clienteSelecionado, produtoSelecionado, quantidade);
            listaPedidos.Add(novoPedido);

            LimparCampos();
            AtualizarGrid();
        }

        // Atualiza o pedido selecionado
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow != null)
            {
                int index = dgvPedidos.CurrentRow.Index;
                listaPedidos[index].Cliente = (Cliente)cmbCliente.SelectedItem;
                listaPedidos[index].Produto = (Produto)cmbProduto.SelectedItem;
                listaPedidos[index].Quantidade = (int)nudQuantidade.Value;

                LimparCampos();
                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um pedido para atualizar!");
            }
        }

        // Remove o pedido selecionado
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow != null)
            {
                int index = dgvPedidos.CurrentRow.Index;
                listaPedidos.RemoveAt(index);

                LimparCampos();
                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um pedido para remover!");
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
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = listaPedidos;
        }

        // Preenche os campos ao selecionar uma linha no DataGridView
        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cmbCliente.SelectedItem = listaPedidos[e.RowIndex].Cliente;
                cmbProduto.SelectedItem = listaPedidos[e.RowIndex].Produto;
                nudQuantidade.Value = listaPedidos[e.RowIndex].Quantidade;
            }
        }

        // Atualiza as ComboBoxes com os dados disponíveis
        private void AtualizarComboBox()
        {
            cmbCliente.DataSource = cmbCliente;
            cmbProduto.DataSource = cmbProduto;
        }

        // Limpa os campos
        private void LimparCampos()
        {
            cmbCliente.SelectedIndex = -1;
            cmbProduto.SelectedIndex = -1;
            nudQuantidade.Value = 1;
        }
    }
}
