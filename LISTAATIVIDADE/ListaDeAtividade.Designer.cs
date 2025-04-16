namespace LISTAATIVIDADE
{
    partial class ListaDeAtividade
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
            buttonFinalizar = new Button();
            textBoxAtividadeEmAndamento = new TextBox();
            dataGridViewAtividade = new DataGridView();
            buttonAtualizar = new Button();
            buttonCriar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtividade).BeginInit();
            SuspendLayout();
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFinalizar.Location = new Point(389, 12);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(139, 23);
            buttonFinalizar.TabIndex = 1;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            // 
            // textBoxAtividadeEmAndamento
            // 
            textBoxAtividadeEmAndamento.Location = new Point(12, 12);
            textBoxAtividadeEmAndamento.Name = "textBoxAtividadeEmAndamento";
            textBoxAtividadeEmAndamento.ReadOnly = true;
            textBoxAtividadeEmAndamento.Size = new Size(347, 23);
            textBoxAtividadeEmAndamento.TabIndex = 0;
            // 
            // dataGridViewAtividade
            // 
            dataGridViewAtividade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAtividade.Location = new Point(12, 83);
            dataGridViewAtividade.Name = "dataGridViewAtividade";
            dataGridViewAtividade.Size = new Size(347, 355);
            dataGridViewAtividade.TabIndex = 5;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(389, 83);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(139, 23);
            buttonAtualizar.TabIndex = 6;
            buttonAtualizar.Text = "Atulizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(389, 415);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(139, 23);
            buttonCriar.TabIndex = 7;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            // 
            // ListaDeAtividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCriar);
            Controls.Add(buttonAtualizar);
            Controls.Add(dataGridViewAtividade);
            Controls.Add(buttonFinalizar);
            Controls.Add(textBoxAtividadeEmAndamento);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "ListaDeAtividade";
            Text = "Lista De Atividades";
            Load += ListaDeAtividade_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtividade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonFinalizar;
        private TextBox textBoxAtividadeEmAndamento;
        private DataGridView dataGridViewAtividade;
        private Button buttonAtualizar;
        private Button buttonCriar;
    }
}
