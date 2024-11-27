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
    public partial class FormCategorias : Form
    {
        private List<Categoria> listaCategorias = new List<Categoria>();

        public FormCategorias()
        {
            InitializeComponent();
        }

        private void btnAdicionarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria(
            id: listaCategorias.Count + 1,
            nome: txtNomeCategoria.Text,
            descricao: txtDescricaoCategoria.Text
        );
            categoria.CadastrarCategoria(listaCategorias);
            AtualizarGridCategorias();
            LimparCampos();
        }

        private void btnAtualizarCategoria_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdCategoria.Text);
            Categoria categoria = new Categoria(
                id: id,
                nome: txtNomeCategoria.Text,
                descricao: txtDescricaoCategoria.Text
            );
            categoria.AtualizarCategoria(listaCategorias);
            AtualizarGridCategorias();
            LimparCampos();
        }

        private void btnRemoverCategoria_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdCategoria.Text);
            Categoria categoria = new Categoria(id, "", "");
            categoria.RemoverCategoria(listaCategorias);
            AtualizarGridCategorias();
            LimparCampos();
        }
        private void AtualizarGridCategorias()
        {
            dataGridViewCategorias.DataSource = null;
            dataGridViewCategorias.DataSource = listaCategorias;
        }

        private void LimparCampos()
        {
            txtIdCategoria.Clear();
            txtNomeCategoria.Clear();
            txtDescricaoCategoria.Clear();
        }
    }
}
