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
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void btentrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tboxUser.Text == "caio" && tboxSenha.Text == "123")
                {
                    var menu = new telaPrinc();
                    menu.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Atencao",
                                    "Usuario ou senha incorretos",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    tboxUser.Focus();
                    tboxSenha.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro",
                                    ex.Message,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void tboxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 08)
            {
                e.Handled = true;
                MessageBox.Show("Digite letras ou números", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                tboxUser.SelectionStart = 0;
                tboxUser.SelectionLength = tboxUser.Text.Length;

                tboxUser.Focus();
            }
        }
    }
}