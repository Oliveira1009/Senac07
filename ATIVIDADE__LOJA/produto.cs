using estoque;

namespace ATIVIDADE__LOJA
{
    public partial class PRODUTO : Form
    {

        public PRODUTO()
        {
            InitializeComponent();
        }



        private void PRODUTO_Load(object sender, EventArgs e)
        {
            using (PRODUTO Estoque = new PRODUTO())
                Estoque.Show();
        }

        private void btn_venda_Click(object sender, EventArgs e)
        {

        }
    }
}
