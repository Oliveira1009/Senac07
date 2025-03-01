namespace WinFormsApp1
{
    partial class form1
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
            BoxNome = new TextBox();
            BoxAcesso = new TextBox();
            BoxEntrar = new Button();
            BoxUsuario = new Label();
            BoxSenha = new Label();
            BoxLogin = new Label();
            labelResultado = new Label();
            ok = new Button();
            label1 = new Label();
            textBoxSenha = new TextBox();
            textBoxAcesso = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // BoxNome
            // 
            BoxNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoxNome.Location = new Point(86, 65);
            BoxNome.Name = "BoxNome";
            BoxNome.Size = new Size(186, 25);
            BoxNome.TabIndex = 0;
            BoxNome.TextChanged += textBox1_TextChanged;
            // 
            // BoxAcesso
            // 
            BoxAcesso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoxAcesso.Location = new Point(86, 113);
            BoxAcesso.Name = "BoxAcesso";
            BoxAcesso.Size = new Size(186, 25);
            BoxAcesso.TabIndex = 1;
            // 
            // BoxEntrar
            // 
            BoxEntrar.BackColor = SystemColors.Control;
            BoxEntrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BoxEntrar.ForeColor = Color.Crimson;
            BoxEntrar.Location = new Point(145, 144);
            BoxEntrar.Name = "BoxEntrar";
            BoxEntrar.Size = new Size(75, 23);
            BoxEntrar.TabIndex = 2;
            BoxEntrar.Text = "Entrar";
            BoxEntrar.UseVisualStyleBackColor = false;
            BoxEntrar.Click += Entrar_Click;
            // 
            // BoxUsuario
            // 
            BoxUsuario.AutoSize = true;
            BoxUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BoxUsuario.ForeColor = Color.Crimson;
            BoxUsuario.Location = new Point(12, 68);
            BoxUsuario.Name = "BoxUsuario";
            BoxUsuario.Size = new Size(59, 17);
            BoxUsuario.TabIndex = 3;
            BoxUsuario.Text = "Usuario:";
            BoxUsuario.Click += label1_Click_1;
            // 
            // BoxSenha
            // 
            BoxSenha.AutoSize = true;
            BoxSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BoxSenha.ForeColor = Color.Crimson;
            BoxSenha.Location = new Point(12, 121);
            BoxSenha.Name = "BoxSenha";
            BoxSenha.Size = new Size(49, 17);
            BoxSenha.TabIndex = 4;
            BoxSenha.Text = "Senha:";
            // 
            // BoxLogin
            // 
            BoxLogin.AutoSize = true;
            BoxLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BoxLogin.ForeColor = Color.Crimson;
            BoxLogin.Location = new Point(145, 30);
            BoxLogin.Name = "BoxLogin";
            BoxLogin.Size = new Size(43, 17);
            BoxLogin.TabIndex = 5;
            BoxLogin.Text = "Login";
            BoxLogin.Click += label3_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.BackColor = SystemColors.MenuText;
            labelResultado.Location = new Point(272, 228);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 7;
            // 
            // ok
            // 
            ok.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ok.ForeColor = Color.Brown;
            ok.Location = new Point(145, 283);
            ok.Name = "ok";
            ok.Size = new Size(83, 25);
            ok.TabIndex = 8;
            ok.Text = "Ok";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(20, 208);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 9;
            label1.Text = "Nome1";
            label1.Click += label1_Click;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(86, 241);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(186, 23);
            textBoxSenha.TabIndex = 10;
            textBoxSenha.TextChanged += textBox1_TextChanged_2;
            // 
            // textBoxAcesso
            // 
            textBoxAcesso.Location = new Point(86, 202);
            textBoxAcesso.Name = "textBoxAcesso";
            textBoxAcesso.Size = new Size(186, 23);
            textBoxAcesso.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(145, 179);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 12;
            label2.Text = "Login";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 13;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 14;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 15;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Brown;
            label6.Location = new Point(22, 247);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 16;
            label6.Text = "Senha:";
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(591, 320);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxAcesso);
            Controls.Add(textBoxSenha);
            Controls.Add(label1);
            Controls.Add(ok);
            Controls.Add(labelResultado);
            Controls.Add(BoxLogin);
            Controls.Add(BoxSenha);
            Controls.Add(BoxUsuario);
            Controls.Add(BoxEntrar);
            Controls.Add(BoxAcesso);
            Controls.Add(BoxNome);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "form1";
            Text = "LOGIN";
            Load += form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BoxNome;
        private TextBox BoxAcesso;
        private Button BoxEntrar;
        private Label BoxUsuario;
        private Label BoxSenha;
        private Label BoxLogin;
        private Label labelResultado;
        private Button ok;
        private Label label1;
        private TextBox textBoxSenha;
        private TextBox textBoxAcesso;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
