using ATIVIDADE__LOJA;

namespace estoque
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }
        private void btn_venda_Click(object sender, EventArgs e)
        {
            using (PRODUTO estoque = new PRODUTO())

                estoque.Show();
        }
    }
}
