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
            pictureBox1 = new PictureBox();
            labelResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-99, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(741, 309);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.BackColor = SystemColors.MenuText;
            labelResultado.Location = new Point(345, 152);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 7;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(591, 320);
            Controls.Add(labelResultado);
            Controls.Add(BoxLogin);
            Controls.Add(BoxSenha);
            Controls.Add(BoxUsuario);
            Controls.Add(BoxEntrar);
            Controls.Add(BoxAcesso);
            Controls.Add(BoxNome);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "form1";
            Text = "LOGIN";
            Load += form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label labelResultado;
    }
}
