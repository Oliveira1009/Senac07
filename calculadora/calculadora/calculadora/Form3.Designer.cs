namespace calculadora
{
    partial class Form3
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
            textBox3 = new TextBox();
            Ativar = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            RESULTADO = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(29, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // Ativar
            // 
            Ativar.Location = new Point(29, 180);
            Ativar.Name = "Ativar";
            Ativar.Size = new Size(75, 23);
            Ativar.TabIndex = 3;
            Ativar.Text = "button1";
            Ativar.UseVisualStyleBackColor = true;
            Ativar.Click += Ativar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(321, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // RESULTADO
            // 
            RESULTADO.AutoSize = true;
            RESULTADO.Location = new Point(330, 145);
            RESULTADO.Name = "RESULTADO";
            RESULTADO.Size = new Size(38, 15);
            RESULTADO.TabIndex = 6;
            RESULTADO.Text = "label1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RESULTADO);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(Ativar);
            Controls.Add(textBox3);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private Button Ativar;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label RESULTADO;
    }
}