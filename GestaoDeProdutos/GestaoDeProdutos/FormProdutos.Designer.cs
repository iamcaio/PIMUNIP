namespace GestaoDeProdutos
{
    partial class FormProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.numPrecoProduto = new System.Windows.Forms.NumericUpDown();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.numQuantidadeProduto = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnAtualizarProduto = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnListarProdutos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(391, 12);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(401, 368);
            this.dataGridViewProdutos.TabIndex = 0;
            this.dataGridViewProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellClick);
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(76, 77);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(89, 20);
            this.txtIdProduto.TabIndex = 1;
            // 
            // numPrecoProduto
            // 
            this.numPrecoProduto.Location = new System.Drawing.Point(76, 215);
            this.numPrecoProduto.Name = "numPrecoProduto";
            this.numPrecoProduto.Size = new System.Drawing.Size(89, 20);
            this.numPrecoProduto.TabIndex = 2;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(76, 123);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(89, 20);
            this.txtNomeProduto.TabIndex = 3;
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(76, 169);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(89, 20);
            this.txtDescricaoProduto.TabIndex = 4;
            // 
            // numQuantidadeProduto
            // 
            this.numQuantidadeProduto.Location = new System.Drawing.Point(76, 261);
            this.numQuantidadeProduto.Name = "numQuantidadeProduto";
            this.numQuantidadeProduto.Size = new System.Drawing.Size(89, 20);
            this.numQuantidadeProduto.TabIndex = 5;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(240, 38);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(93, 59);
            this.btnAdicionarProduto.TabIndex = 6;
            this.btnAdicionarProduto.Text = "Adicionar";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnAtualizarProduto
            // 
            this.btnAtualizarProduto.Location = new System.Drawing.Point(240, 106);
            this.btnAtualizarProduto.Name = "btnAtualizarProduto";
            this.btnAtualizarProduto.Size = new System.Drawing.Size(93, 59);
            this.btnAtualizarProduto.TabIndex = 7;
            this.btnAtualizarProduto.Text = "Atualizar";
            this.btnAtualizarProduto.UseVisualStyleBackColor = true;
            this.btnAtualizarProduto.Click += new System.EventHandler(this.btnAtualizarProduto_Click);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(240, 174);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(93, 59);
            this.btnRemoverProduto.TabIndex = 8;
            this.btnRemoverProduto.Text = "Remover";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // btnListarProdutos
            // 
            this.btnListarProdutos.Location = new System.Drawing.Point(240, 242);
            this.btnListarProdutos.Name = "btnListarProdutos";
            this.btnListarProdutos.Size = new System.Drawing.Size(93, 59);
            this.btnListarProdutos.TabIndex = 9;
            this.btnListarProdutos.Text = "Listar";
            this.btnListarProdutos.UseVisualStyleBackColor = true;
            this.btnListarProdutos.Click += new System.EventHandler(this.btnListarProdutos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 392);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarProdutos);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.btnAtualizarProduto);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.numQuantidadeProduto);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.numPrecoProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Name = "FormProdutos";
            this.Text = "formProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.NumericUpDown numPrecoProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.NumericUpDown numQuantidadeProduto;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnAtualizarProduto;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnListarProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}