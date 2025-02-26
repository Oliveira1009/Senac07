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
            string usuario = textBox1.Text;
            string senha = textBox2.Text;

            if (usuario == "tamiresoliveira" && senha == "0707")
            {

                labelResultado.Text = "Autenticado com sucesso !";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "usuario ou senha incorretos...";
                labelResultado.ForeColor = Color.Red;
            }
        }
    }
}
    
   