namespace tela_login
{
    partial class telalogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telalogin));
            this.bt_entrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_Usuário = new System.Windows.Forms.TextBox();
            this.lk_esqueciminhasenha = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_entrar
            // 
            this.bt_entrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bt_entrar.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.bt_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_entrar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_entrar.ForeColor = System.Drawing.Color.White;
            this.bt_entrar.Location = new System.Drawing.Point(304, 319);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(156, 34);
            this.bt_entrar.TabIndex = 0;
            this.bt_entrar.Text = "Entrar";
            this.bt_entrar.UseVisualStyleBackColor = false;
            this.bt_entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.AllowDrop = true;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(270, 260);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Senha";
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // tb_Usuário
            // 
            this.tb_Usuário.AcceptsReturn = true;
            this.tb_Usuário.AcceptsTab = true;
            this.tb_Usuário.AllowDrop = true;
            this.tb_Usuário.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Usuário.Location = new System.Drawing.Point(270, 225);
            this.tb_Usuário.MaxLength = 100;
            this.tb_Usuário.Name = "tb_Usuário";
            this.tb_Usuário.Size = new System.Drawing.Size(215, 25);
            this.tb_Usuário.TabIndex = 1;
            this.tb_Usuário.Text = "Usuário";
            // 
            // lk_esqueciminhasenha
            // 
            this.lk_esqueciminhasenha.AutoSize = true;
            this.lk_esqueciminhasenha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lk_esqueciminhasenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(189)))), ((int)(((byte)(103)))));
            this.lk_esqueciminhasenha.Location = new System.Drawing.Point(270, 287);
            this.lk_esqueciminhasenha.Name = "lk_esqueciminhasenha";
            this.lk_esqueciminhasenha.Size = new System.Drawing.Size(121, 15);
            this.lk_esqueciminhasenha.TabIndex = 2;
            this.lk_esqueciminhasenha.TabStop = true;
            this.lk_esqueciminhasenha.Text = "Esqueci minha senha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 146);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // telalogin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lk_esqueciminhasenha);
            this.Controls.Add(this.tb_Usuário);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_entrar);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "telalogin";
            this.Tag = "";
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.telalogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_entrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_Usuário;
        private System.Windows.Forms.LinkLabel lk_esqueciminhasenha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

