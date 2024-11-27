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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos();
            formProdutos.Show();        
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FormCategorias formCategorias = new FormCategorias();
            formCategorias.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            FormFornecedores formFornecedores = new FormFornecedores();
            formFornecedores.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
        }
    }
}
