namespace WFormUNIP
{
    partial class telaLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxUser = new System.Windows.Forms.TextBox();
            this.tboxSenha = new System.Windows.Forms.TextBox();
            this.btentrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faça Login com seu usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha";
            // 
            // tboxUser
            // 
            this.tboxUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tboxUser.Location = new System.Drawing.Point(112, 216);
            this.tboxUser.MaxLength = 12;
            this.tboxUser.Name = "tboxUser";
            this.tboxUser.Size = new System.Drawing.Size(271, 20);
            this.tboxUser.TabIndex = 4;
            this.tboxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxUser_KeyPress);
            // 
            // tboxSenha
            // 
            this.tboxSenha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tboxSenha.Location = new System.Drawing.Point(112, 294);
            this.tboxSenha.Name = "tboxSenha";
            this.tboxSenha.Size = new System.Drawing.Size(271, 20);
            this.tboxSenha.TabIndex = 5;
            this.tboxSenha.UseSystemPasswordChar = true;
            // 
            // btentrar
            // 
            this.btentrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btentrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btentrar.FlatAppearance.BorderSize = 4;
            this.btentrar.Location = new System.Drawing.Point(171, 396);
            this.btentrar.Name = "btentrar";
            this.btentrar.Size = new System.Drawing.Size(160, 38);
            this.btentrar.TabIndex = 6;
            this.btentrar.Text = "Entrar";
            this.btentrar.UseVisualStyleBackColor = false;
            this.btentrar.Click += new System.EventHandler(this.btentrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Systemize";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gestão de Produtos";
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(498, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btentrar);
            this.Controls.Add(this.tboxSenha);
            this.Controls.Add(this.tboxUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "telaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systemize | Gestão de produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxUser;
        private System.Windows.Forms.TextBox tboxSenha;
        private System.Windows.Forms.Button btentrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}