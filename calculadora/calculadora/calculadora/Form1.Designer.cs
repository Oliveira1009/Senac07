namespace calculadora
{
    partial class Form1
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
            textBoxValor1 = new TextBox();
            textBoxValores2 = new TextBox();
            Calcular = new Button();
            Resultado = new Label();
            button1 = new Button();
            Divisão = new Button();
            Sub = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxValor1
            // 
            textBoxValor1.Location = new Point(12, 30);
            textBoxValor1.Name = "textBoxValor1";
            textBoxValor1.Size = new Size(100, 23);
            textBoxValor1.TabIndex = 0;
            textBoxValor1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxValores2
            // 
            textBoxValores2.Location = new Point(183, 30);
            textBoxValores2.Name = "textBoxValores2";
            textBoxValores2.Size = new Size(100, 23);
            textBoxValores2.TabIndex = 1;
            textBoxValores2.TextChanged += textBoxValores2_TextChanged;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(12, 96);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(100, 23);
            Calcular.TabIndex = 2;
            Calcular.Text = "Soma";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(82, 151);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(90, 15);
            Resultado.TabIndex = 3;
            Resultado.Text = "Insira os Valores";
            Resultado.Click += Resultado_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 125);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 4;
            button1.Text = "Multi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Divisão
            // 
            Divisão.Location = new Point(145, 96);
            Divisão.Name = "Divisão";
            Divisão.Size = new Size(100, 23);
            Divisão.TabIndex = 5;
            Divisão.Text = "Divisão";
            Divisão.UseVisualStyleBackColor = true;
            Divisão.Click += Divisão_Click;
            // 
            // Sub
            // 
            Sub.Location = new Point(145, 125);
            Sub.Name = "Sub";
            Sub.Size = new Size(100, 23);
            Sub.TabIndex = 6;
            Sub.Text = "Sub";
            Sub.UseVisualStyleBackColor = true;
            Sub.Click += Sub_Click;
            // 
            // button2
            // 
            button2.Location = new Point(374, 111);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(button2);
            Controls.Add(Sub);
            Controls.Add(Divisão);
            Controls.Add(button1);
            Controls.Add(Resultado);
            Controls.Add(Calcular);
            Controls.Add(textBoxValores2);
            Controls.Add(textBoxValor1);
            Name = "Form1";
            Text = "Calcular";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxValor1;
        private TextBox textBoxValores2;
        private Button Calcular;
        private Label Resultado;
        private Button button1;
        private Button Divisão;
        private Button Sub;
        private Button button2;
    }
}
