namespace WinFormsApp1
{
    public partial class form1 : Form
    {
        List<string> listaUsuarios = new List<string>() { "lari.Matos", "kaique", "mickael" };
        List<string> Listasenha = new List<string>() { "1717", "0707", "0303" };

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
            string usuarioBuscado = BoxNome.Text;
            string senha = BoxAcesso.Text;

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = "usuario eh obrgatorio!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (senha == null || senha == "")
            {
                labelResultado.Text = "Senha necessaria!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            int posicaoUsuarioEncontrado = -1;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuarioBuscado == listaUsuarios[i])
                {
                    posicaoUsuarioEncontrado = i;
                }
            }

            if (posicaoUsuarioEncontrado > -1 && senha == Listasenha[posicaoUsuarioEncontrado])
            {
                labelResultado.Text = "Autenticado com sucesso !";
                labelResultado.ForeColor = Color.Green;
            }

            else if (usuarioBuscado == "tamiresoliveira" && senha == "")
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            string Novo = textBoxAcesso.Text;
            string NovaSenha = textBoxSenha.Text;

            bool usuarioEncontrado = false;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (Novo == listaUsuarios[i])
                {
                    usuarioEncontrado = true;
                }
            }
            if (!usuarioEncontrado)
            {
                listaUsuarios.Add(Novo);
                Listasenha.Add(NovaSenha);
                labelResultado.Text = "Sucesso";
            }
            else { labelResultado.Text = "Errado"; }

        }
    }
}
   