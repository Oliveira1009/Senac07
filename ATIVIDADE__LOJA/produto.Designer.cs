namespace ATIVIDADE__LOJA
{
    partial class PRODUTO
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
            dataGridView1 = new DataGridView();
            btn_Atualizar = new Button();
            btn_venda = new Button();
            btn_adicionar = new Button();
            textBox1 = new TextBox();
            lbl_resposta = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(107, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(417, 269);
            dataGridView1.TabIndex = 0;
            // 
            // btn_Atualizar
            // 
            btn_Atualizar.Location = new Point(541, 64);
            btn_Atualizar.Name = "btn_Atualizar";
            btn_Atualizar.Size = new Size(75, 23);
            btn_Atualizar.TabIndex = 1;
            btn_Atualizar.Text = "Atualizar";
            btn_Atualizar.UseVisualStyleBackColor = true;
            // 
            // btn_venda
            // 
            btn_venda.Location = new Point(541, 93);
            btn_venda.Name = "btn_venda";
            btn_venda.Size = new Size(75, 43);
            btn_venda.TabIndex = 2;
            btn_venda.Text = "tabela estoque";
            btn_venda.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_venda.Click += btn_venda_Click;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(541, 35);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(75, 23);
            btn_adicionar.TabIndex = 3;
            btn_adicionar.Text = "adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 23);
            textBox1.TabIndex = 4;
            // 
            // lbl_resposta
            // 
            lbl_resposta.AutoSize = true;
            lbl_resposta.BackColor = SystemColors.ActiveBorder;
            lbl_resposta.Location = new Point(237, 345);
            lbl_resposta.Name = "lbl_resposta";
            lbl_resposta.Size = new Size(160, 15);
            lbl_resposta.TabIndex = 5;
            lbl_resposta.Text = "                                                   ";
            // 
            // PRODUTO
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
            Controls.Add(dataGridView1);
            Name = "PRODUTO";
            Text = " ";
            Load += PRODUTO_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_Atualizar;
        private Button btn_venda;
        private Button btn_adicionar;
        private TextBox textBox1;
        private Label lbl_resposta;
    }
}
