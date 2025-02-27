namespace WinFormsApp1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            string usuario = BoxNome.Text;
            string senha = BoxAcesso.Text;

            if (usuario == null || usuario == "" || string.IsNullOrWhiteSpace (usuario))
            {
                labelResultado.Text = "usuario eh obrgatorio!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            
            if (usuario == null || senha == "")
            {
                labelResultado.Text = "Senha necessaria!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (usuario == "tamiresoliveira" && senha == "0707")
            {
                labelResultado.Text = "Autenticado com sucesso !";
                labelResultado.ForeColor = Color.Green;

            }
            else if (usuario == "tamiresoliveira" && senha == "")
            {
                labelResultado.Text = " Você deve colocar senha para acesso";
                labelResultado.ForeColor = Color.Violet;
            }
            else
            {
                labelResultado.Text = "usuario ou senha incorretos...";
                labelResultado.ForeColor = Color.Red;
            }
        }
    }
}

   