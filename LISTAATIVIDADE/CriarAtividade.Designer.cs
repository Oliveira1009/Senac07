﻿namespace LISTAATIVIDADE
{
    partial class CriarAtividade
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
            groupBox1 = new GroupBox();
            labelErro = new Label();
            buttonCriar = new Button();
            buttonDescartar = new Button();
            textBoxTitulo = new TextBox();
            labelTitulo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelErro);
            groupBox1.Controls.Add(buttonCriar);
            groupBox1.Controls.Add(buttonDescartar);
            groupBox1.Controls.Add(textBoxTitulo);
            groupBox1.Controls.Add(labelTitulo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(757, 426);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(0, 408);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 9;
            labelErro.Text = "label2";
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(318, 242);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(83, 23);
            buttonCriar.TabIndex = 8;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click_1;
            // 
            // buttonDescartar
            // 
            buttonDescartar.Location = new Point(179, 242);
            buttonDescartar.Name = "buttonDescartar";
            buttonDescartar.Size = new Size(75, 23);
            buttonDescartar.TabIndex = 7;
            buttonDescartar.Text = "Descartar";
            buttonDescartar.UseVisualStyleBackColor = true;
            buttonDescartar.Click += buttonDescartar_Click_1;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(245, 213);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(100, 23);
            textBoxTitulo.TabIndex = 6;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(277, 185);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(37, 15);
            labelTitulo.TabIndex = 5;
            labelTitulo.Text = "Titulo";
            // 
            // CriarAtividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "CriarAtividade";
            Text = "CriarAtividade";
            Load += CriarAtividade_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label labelErro;
        private Button buttonCriar;
        private Button buttonDescartar;
        private TextBox textBoxTitulo;
        private Label labelTitulo;
    }
}