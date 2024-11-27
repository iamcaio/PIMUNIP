namespace GestaoDeProdutos
{
    partial class FormCategorias
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
            this.dataGridViewCategorias = new System.Windows.Forms.DataGridView();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.txtDescricaoCategoria = new System.Windows.Forms.TextBox();
            this.btnAdicionarCategoria = new System.Windows.Forms.Button();
            this.btnAtualizarCategoria = new System.Windows.Forms.Button();
            this.btnRemoverCategoria = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategorias
            // 
            this.dataGridViewCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorias.Location = new System.Drawing.Point(386, 28);
            this.dataGridViewCategorias.Name = "dataGridViewCategorias";
            this.dataGridViewCategorias.Size = new System.Drawing.Size(407, 352);
            this.dataGridViewCategorias.TabIndex = 0;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(75, 96);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(74, 20);
            this.txtIdCategoria.TabIndex = 1;
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(75, 139);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(74, 20);
            this.txtNomeCategoria.TabIndex = 2;
            // 
            // txtDescricaoCategoria
            // 
            this.txtDescricaoCategoria.Location = new System.Drawing.Point(75, 181);
            this.txtDescricaoCategoria.Name = "txtDescricaoCategoria";
            this.txtDescricaoCategoria.Size = new System.Drawing.Size(74, 20);
            this.txtDescricaoCategoria.TabIndex = 3;
            // 
            // btnAdicionarCategoria
            // 
            this.btnAdicionarCategoria.Location = new System.Drawing.Point(277, 57);
            this.btnAdicionarCategoria.Name = "btnAdicionarCategoria";
            this.btnAdicionarCategoria.Size = new System.Drawing.Size(103, 57);
            this.btnAdicionarCategoria.TabIndex = 4;
            this.btnAdicionarCategoria.Text = "Adicionar";
            this.btnAdicionarCategoria.UseVisualStyleBackColor = true;
            this.btnAdicionarCategoria.Click += new System.EventHandler(this.btnAdicionarCategoria_Click);
            // 
            // btnAtualizarCategoria
            // 
            this.btnAtualizarCategoria.Location = new System.Drawing.Point(277, 124);
            this.btnAtualizarCategoria.Name = "btnAtualizarCategoria";
            this.btnAtualizarCategoria.Size = new System.Drawing.Size(103, 57);
            this.btnAtualizarCategoria.TabIndex = 5;
            this.btnAtualizarCategoria.Text = "Atualizar";
            this.btnAtualizarCategoria.UseVisualStyleBackColor = true;
            this.btnAtualizarCategoria.Click += new System.EventHandler(this.btnAtualizarCategoria_Click);
            // 
            // btnRemoverCategoria
            // 
            this.btnRemoverCategoria.Location = new System.Drawing.Point(277, 191);
            this.btnRemoverCategoria.Name = "btnRemoverCategoria";
            this.btnRemoverCategoria.Size = new System.Drawing.Size(103, 57);
            this.btnRemoverCategoria.TabIndex = 6;
            this.btnRemoverCategoria.Text = "Remover";
            this.btnRemoverCategoria.UseVisualStyleBackColor = true;
            this.btnRemoverCategoria.Click += new System.EventHandler(this.btnRemoverCategoria_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Descriçao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id";
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoverCategoria);
            this.Controls.Add(this.btnAtualizarCategoria);
            this.Controls.Add(this.btnAdicionarCategoria);
            this.Controls.Add(this.txtDescricaoCategoria);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.dataGridViewCategorias);
            this.Name = "FormCategorias";
            this.Text = "formCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategorias;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.TextBox txtDescricaoCategoria;
        private System.Windows.Forms.Button btnAdicionarCategoria;
        private System.Windows.Forms.Button btnAtualizarCategoria;
        private System.Windows.Forms.Button btnRemoverCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}