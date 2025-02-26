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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Entrar = new Button();
            Usur = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            labelResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(86, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 25);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(86, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 25);
            textBox2.TabIndex = 1;
            // 
            // Entrar
            // 
            Entrar.BackColor = SystemColors.Control;
            Entrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Entrar.ForeColor = Color.Crimson;
            Entrar.Location = new Point(145, 144);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(75, 23);
            Entrar.TabIndex = 2;
            Entrar.Text = "Entrar";
            Entrar.UseVisualStyleBackColor = false;
            Entrar.Click += Entrar_Click;
            // 
            // Usur
            // 
            Usur.AutoSize = true;
            Usur.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Usur.ForeColor = Color.Crimson;
            Usur.Location = new Point(12, 68);
            Usur.Name = "Usur";
            Usur.Size = new Size(59, 17);
            Usur.TabIndex = 3;
            Usur.Text = "Usuario:";
            Usur.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 4;
            label2.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(145, 30);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 5;
            label3.Text = "Login";
            label3.Click += label3_Click;
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
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Usur);
            Controls.Add(Entrar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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

        private TextBox textBox1;
        private TextBox textBox2;
        private Button Entrar;
        private Label Usur;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label labelResultado;
    }
}
