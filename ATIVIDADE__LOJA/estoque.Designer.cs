namespace estoque
{
    partial class Estoque
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
            btn_adicionar = new Button();
            btn_venda = new Button();
            btn_Atualizar = new Button();
            dataGridView2 = new DataGridView();
            lbl_resposta = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 23);
            textBox1.TabIndex = 9;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(536, 49);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(75, 23);
            btn_adicionar.TabIndex = 8;
            btn_adicionar.Text = "adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            // 
            // btn_venda
            // 
            btn_venda.Location = new Point(536, 107);
            btn_venda.Name = "btn_venda";
            btn_venda.Size = new Size(75, 43);
            btn_venda.TabIndex = 7;
            btn_venda.Text = "tabela produto";
            btn_venda.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_venda.UseVisualStyleBackColor = true;
            btn_venda.Click += btn_venda_Click;
            // 
            // btn_Atualizar
            // 
            btn_Atualizar.Location = new Point(536, 78);
            btn_Atualizar.Name = "btn_Atualizar";
            btn_Atualizar.Size = new Size(75, 23);
            btn_Atualizar.TabIndex = 6;
            btn_Atualizar.Text = "Atualizar";
            btn_Atualizar.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(102, 78);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(417, 269);
            dataGridView2.TabIndex = 5;
            // 
            // lbl_resposta
            // 
            lbl_resposta.AutoSize = true;
            lbl_resposta.BackColor = SystemColors.ActiveBorder;
            lbl_resposta.Location = new Point(226, 360);
            lbl_resposta.Name = "lbl_resposta";
            lbl_resposta.Size = new Size(160, 15);
            lbl_resposta.TabIndex = 10;
            lbl_resposta.Text = "                                                   ";
            // 
            // estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_resposta);
            Controls.Add(textBox1);
            Controls.Add(btn_adicionar);
            Controls.Add(btn_venda);
            Controls.Add(btn_Atualizar);
            Controls.Add(dataGridView2);
            Name = "estoque";
            Text = "estoque";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn_adicionar;
        private Button btn_venda;
        private Button btn_Atualizar;
        private DataGridView dataGridView2;
        private Label lbl_resposta;
    }
}
