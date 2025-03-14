namespace calculadora
{
    partial class Form4
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
            label1 = new Label();
            textBoxRaio = new TextBox();
            labelResultado = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 53);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Raio";
            // 
            // textBoxRaio
            // 
            textBoxRaio.Location = new Point(87, 50);
            textBoxRaio.Name = "textBoxRaio";
            textBoxRaio.Size = new Size(100, 24);
            textBoxRaio.TabIndex = 1;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(392, 53);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(64, 15);
            labelResultado.TabIndex = 2;
            labelResultado.Text = "Resultadi";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(241, 51);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 3;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(buttonCalcular);
            Controls.Add(labelResultado);
            Controls.Add(textBoxRaio);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxRaio;
        private Label labelResultado;
        private Button buttonCalcular;
    }
}