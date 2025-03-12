namespace calculadora
{
    partial class Form2
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SUB = new RadioButton();
            DIVISÃO = new RadioButton();
            MULTI = new RadioButton();
            radioButtonSoma = new RadioButton();
            button1 = new Button();
            LabelErro = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(379, 186);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 22;
            label2.Text = "     ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(407, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 20;
            // 
            // SUB
            // 
            SUB.AutoSize = true;
            SUB.Location = new Point(435, 237);
            SUB.Name = "SUB";
            SUB.Size = new Size(46, 19);
            SUB.TabIndex = 19;
            SUB.TabStop = true;
            SUB.Text = "SUB";
            SUB.UseVisualStyleBackColor = true;
            // 
            // DIVISÃO
            // 
            DIVISÃO.AutoSize = true;
            DIVISÃO.Location = new Point(435, 212);
            DIVISÃO.Name = "DIVISÃO";
            DIVISÃO.Size = new Size(69, 19);
            DIVISÃO.TabIndex = 18;
            DIVISÃO.TabStop = true;
            DIVISÃO.Text = "DIVISÃO";
            DIVISÃO.UseVisualStyleBackColor = true;
            DIVISÃO.CheckedChanged += DIVISÃO_CheckedChanged;
            // 
            // MULTI
            // 
            MULTI.AutoSize = true;
            MULTI.Location = new Point(303, 237);
            MULTI.Name = "MULTI";
            MULTI.Size = new Size(58, 19);
            MULTI.TabIndex = 17;
            MULTI.TabStop = true;
            MULTI.Text = "MULTI";
            MULTI.UseVisualStyleBackColor = true;
            MULTI.CheckedChanged += MULTI_CheckedChanged;
            // 
            // radioButtonSoma
            // 
            radioButtonSoma.AutoSize = true;
            radioButtonSoma.Location = new Point(303, 212);
            radioButtonSoma.Name = "radioButtonSoma";
            radioButtonSoma.Size = new Size(59, 19);
            radioButtonSoma.TabIndex = 16;
            radioButtonSoma.TabStop = true;
            radioButtonSoma.Text = "SOMA";
            radioButtonSoma.UseVisualStyleBackColor = true;
            radioButtonSoma.CheckedChanged += radioButtonSoma_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(511, 253);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 23;
            button1.Text = "CONFIRMA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LabelErro
            // 
            LabelErro.AutoSize = true;
            LabelErro.Location = new Point(446, 302);
            LabelErro.Name = "LabelErro";
            LabelErro.Size = new Size(38, 15);
            LabelErro.TabIndex = 24;
            LabelErro.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(522, 186);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 25;
            label1.Text = "     ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(LabelErro);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(SUB);
            Controls.Add(DIVISÃO);
            Controls.Add(MULTI);
            Controls.Add(radioButtonSoma);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton SUB;
        private RadioButton DIVISÃO;
        private RadioButton MULTI;
        private RadioButton radioButtonSoma;
        private Button button1;
        private Label LabelErro;
        private Label label1;
    }
}