namespace GestaoDeProdutos
{
    partial class FormFornecedores
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
            this.dataGridViewFornecedores = new System.Windows.Forms.DataGridView();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.txtEmailFornecedor = new System.Windows.Forms.TextBox();
            this.txtTelefoneFornecedor = new System.Windows.Forms.TextBox();
            this.btnAdicionarFornecedor1 = new System.Windows.Forms.Button();
            this.btnAtualizarFornecedor = new System.Windows.Forms.Button();
            this.btnRemoverFornecedor = new System.Windows.Forms.Button();
            this.btnListarFornecedores = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFornecedores
            // 
            this.dataGridViewFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedores.Location = new System.Drawing.Point(428, 12);
            this.dataGridViewFornecedores.Name = "dataGridViewFornecedores";
            this.dataGridViewFornecedores.Size = new System.Drawing.Size(348, 368);
            this.dataGridViewFornecedores.TabIndex = 0;
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Location = new System.Drawing.Point(65, 75);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(126, 20);
            this.txtIdFornecedor.TabIndex = 1;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(65, 119);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(126, 20);
            this.txtNomeFornecedor.TabIndex = 2;
            // 
            // txtEmailFornecedor
            // 
            this.txtEmailFornecedor.Location = new System.Drawing.Point(65, 163);
            this.txtEmailFornecedor.Name = "txtEmailFornecedor";
            this.txtEmailFornecedor.Size = new System.Drawing.Size(126, 20);
            this.txtEmailFornecedor.TabIndex = 3;
            // 
            // txtTelefoneFornecedor
            // 
            this.txtTelefoneFornecedor.Location = new System.Drawing.Point(65, 207);
            this.txtTelefoneFornecedor.Name = "txtTelefoneFornecedor";
            this.txtTelefoneFornecedor.Size = new System.Drawing.Size(126, 20);
            this.txtTelefoneFornecedor.TabIndex = 4;
            // 
            // btnAdicionarFornecedor1
            // 
            this.btnAdicionarFornecedor1.Location = new System.Drawing.Point(295, 50);
            this.btnAdicionarFornecedor1.Name = "btnAdicionarFornecedor1";
            this.btnAdicionarFornecedor1.Size = new System.Drawing.Size(75, 50);
            this.btnAdicionarFornecedor1.TabIndex = 5;
            this.btnAdicionarFornecedor1.Text = "Adicionar";
            this.btnAdicionarFornecedor1.UseVisualStyleBackColor = true;
            this.btnAdicionarFornecedor1.Click += new System.EventHandler(this.btnAdicionarFornecedor_Click);
            // 
            // btnAtualizarFornecedor
            // 
            this.btnAtualizarFornecedor.Location = new System.Drawing.Point(295, 107);
            this.btnAtualizarFornecedor.Name = "btnAtualizarFornecedor";
            this.btnAtualizarFornecedor.Size = new System.Drawing.Size(75, 50);
            this.btnAtualizarFornecedor.TabIndex = 6;
            this.btnAtualizarFornecedor.Text = "Atualizar";
            this.btnAtualizarFornecedor.UseVisualStyleBackColor = true;
            this.btnAtualizarFornecedor.Click += new System.EventHandler(this.btnAtualizarFornecedor_Click);
            // 
            // btnRemoverFornecedor
            // 
            this.btnRemoverFornecedor.Location = new System.Drawing.Point(295, 164);
            this.btnRemoverFornecedor.Name = "btnRemoverFornecedor";
            this.btnRemoverFornecedor.Size = new System.Drawing.Size(75, 50);
            this.btnRemoverFornecedor.TabIndex = 7;
            this.btnRemoverFornecedor.Text = "Remover";
            this.btnRemoverFornecedor.UseVisualStyleBackColor = true;
            this.btnRemoverFornecedor.Click += new System.EventHandler(this.btnRemoverFornecedor_Click);
            // 
            // btnListarFornecedores
            // 
            this.btnListarFornecedores.Location = new System.Drawing.Point(295, 221);
            this.btnListarFornecedores.Name = "btnListarFornecedores";
            this.btnListarFornecedores.Size = new System.Drawing.Size(75, 50);
            this.btnListarFornecedores.TabIndex = 8;
            this.btnListarFornecedores.Text = "Listar";
            this.btnListarFornecedores.UseVisualStyleBackColor = true;
            this.btnListarFornecedores.Click += new System.EventHandler(this.btnListarFornecedores_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 392);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarFornecedores);
            this.Controls.Add(this.btnRemoverFornecedor);
            this.Controls.Add(this.btnAtualizarFornecedor);
            this.Controls.Add(this.btnAdicionarFornecedor1);
            this.Controls.Add(this.txtTelefoneFornecedor);
            this.Controls.Add(this.txtEmailFornecedor);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(this.dataGridViewFornecedores);
            this.Name = "FormFornecedores";
            this.Text = "FormFornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFornecedores;
        private System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.TextBox txtEmailFornecedor;
        private System.Windows.Forms.TextBox txtTelefoneFornecedor;
        private System.Windows.Forms.Button btnAdicionarFornecedor1;
        private System.Windows.Forms.Button btnAtualizarFornecedor;
        private System.Windows.Forms.Button btnRemoverFornecedor;
        private System.Windows.Forms.Button btnListarFornecedores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}