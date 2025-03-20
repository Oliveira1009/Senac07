namespace Cadastro_Cliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();

        public Form1()
        {
            InitializeComponent();

            EnderecoCliente enderecoClienteTamires = new EnderecoCliente() { logradouro = "Endereco da Tamires", número = "15", cep = "0491350", bairro = "jdsantaedwiges", municipio ="Ibiúna", estado = "Ibiúna", complemento = "CasaA1" };
            Cliente Tamires = new Cliente() { Id = 1, Nome = "TamiresOliveira", DataNascimento = "24/03/01", etnia = Etnia.Pardo, tipo = TipoCliente.PF, EnderecoCliente =  enderecoClienteTamires, telefone = "1958977549", email = "tamiresoliveira17@gmail.com" , genero = Genero.Feminino };
            clientes.Add(Tamires);


            EnderecoCliente enderecoClienteKaique = new EnderecoCliente() { logradouro = "Endereco do kaique", número = "46", cep = "0123459", bairro = "jdpresidente", municipio = "Salvador", estado = "Bahia", complemento = "Viela" };
            Cliente kaique = new Cliente() { Id = 5, Nome = "kaique", DataNascimento = "31/08/99", etnia = Etnia.Pardo, tipo = TipoCliente.PF, EnderecoCliente = enderecoClienteKaique, telefone= "983888450", email ="kaiquesilva@gmail.com",  genero = Genero.Masculino };
            clientes.Add(kaique);

            EnderecoCliente enderecoClienteLarissa = new EnderecoCliente() { logradouro = "Endereco da larissa", número = "45", cep = "457896", bairro = "Alvares", municipio ="São Paulo", estado = "SP", complemento = "Casa"};
            Cliente Larissa = new Cliente() { Id = 6, Nome = "larissa", DataNascimento = "21/02/2000", etnia = Etnia.Pardo, tipo = TipoCliente.PF, EnderecoCliente = enderecoClienteKaique, telefone = "983888455", email = "larieilva@gmail.com", genero = Genero.Feminino };
            clientes.Add(Larissa);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CADASTRARbutton_Click(object sender, EventArgs e)
        {

            string nome = Nometextbox.Text;

            string telefone = NúmeromaskedTextBox1.Text;

            string cep = CeptextBox4.Text;

            string datanascimento = NascimentomaskedTextBox.Text;

            string nomesocial = NomeSocialtextBox.Text;

            string genero = GenerocomboBox2.Text;

            string email = EmailtextBox.Text;

            string longradouro = LogradourotextBox.Text;

            string complemento = ComplementotextBox.Text;

            string bairro = BairrotextBox.Text;

            string numero = NúmerotextBox.Text;

            string municipio = MunicipiotextBox9.Text;

            string estado = EstadocomboBox3.Text;

            bool PF = FísicaradioButton.Checked;

            bool PJ = JuridicaradioButton.Checked;

            bool estrangeiro = SimcheckBox.Checked;

            

            if (ValidarDados(nome, email, telefone))

            {


                Cliente novoCliente = new Cliente

                {

                    Nome = nome,

                    email = email,

                    telefone = telefone

                };


                clientes.Add(novoCliente);

                MessageBox.Show("Cliente adicionado com sucesso!");


                LimparFormulario();

            }

            else

            {

                MessageBox.Show("Por favor, preencha todos os campos corretamente.");

            }



        }




        private bool ValidarDados(string nome, string email, string telefone)

        {


            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telefone))

            {

                return false;

            }



            if (!ValidarEmail(email))

            {

                MessageBox.Show("O email fornecido não é válido.");

                return false;

            }



            if (ValidarTelefone(telefone))

            {

                MessageBox.Show("O telefone fornecido não é válido.");

                return false;

            }

            return true;

        }

        private bool ValidarEmail(string email)

        {

            if (!ValidarTelefone(email))

            {



                return true;

            }

            else

            {

                return false;

            }

        }

        private bool ValidarTelefone(string telefone)

        {



            return telefone.All(char.IsDigit) && (telefone.Length == 10);

        }

        private void LimparFormulario()

        {

            Nometextbox.Clear();

            EmailtextBox.Clear();

            NúmerotextBox.Clear();

            {



            }

        }


        private bool ValidarDados(string nome)

        {

            throw new NotImplementedException();

        }

        private void groupBox2_Enter(object sender, EventArgs e)

        {

        }

    }

}
 
   
