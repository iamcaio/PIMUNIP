namespace GestaoDeProdutos
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProdutos
            // 
            this.btnProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProdutos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnProdutos.Location = new System.Drawing.Point(12, 264);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(5);
            this.btnProdutos.Size = new System.Drawing.Size(140, 50);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.Text = "Gerenciar Produtos";
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategorias.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCategorias.Location = new System.Drawing.Point(176, 264);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(5);
            this.btnCategorias.Size = new System.Drawing.Size(140, 50);
            this.btnCategorias.TabIndex = 1;
            this.btnCategorias.Text = "Gerenciar Categorias";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFornecedores.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnFornecedores.Location = new System.Drawing.Point(340, 264);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Padding = new System.Windows.Forms.Padding(5);
            this.btnFornecedores.Size = new System.Drawing.Size(140, 50);
            this.btnFornecedores.TabIndex = 2;
            this.btnFornecedores.Text = "Gerenciar Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = false;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClientes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnClientes.Location = new System.Drawing.Point(504, 264);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(5);
            this.btnClientes.Size = new System.Drawing.Size(140, 50);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Gerenciar Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPedidos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPedidos.Location = new System.Drawing.Point(668, 264);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(5);
            this.btnPedidos.Size = new System.Drawing.Size(140, 50);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.Text = "Gerenciar Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 66);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(270, 69);
            this.label1.TabIndex = 5;
            this.label1.Text = "Systemize";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 135);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gestão de Produtos";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 165);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(155, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "UNIP | Universidade Paulista";
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(819, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnProdutos);
            this.MinimumSize = new System.Drawing.Size(835, 431);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systemize | Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

