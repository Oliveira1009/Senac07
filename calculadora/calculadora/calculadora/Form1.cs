namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            string valor1 = textBoxValor1.Text;
            string valor2 = textBoxValores2.Text;

            if (!valor1.All(char.IsNumber))
            {
                Resultado.Text = " valor 1 deve ser um numero";
                return;
            }
            if (!valor2.All(char.IsNumber))
            {
                Resultado.Text = "valor 2 deve ser um numero";
                return;
            }

            double dubleValor1 = Convert.ToDouble(valor1);
            double dubleValor2 = Convert.ToDouble(valor2);

            double soma = dubleValor1 + dubleValor2;


            Resultado.Text = soma.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor1 = textBoxValor1.Text;
            string valor2 = textBoxValores2.Text;

            if (!valor1.All(char.IsNumber))
            {
                Resultado.Text = " valor 1 deve ser um numero";
                return;
            }
            if (!valor2.All(char.IsNumber))
            {
                Resultado.Text = "valor 2 deve ser um numero";
                return;
            }

            double dubleValor1 = Convert.ToDouble(valor1);
            double dubleValor2 = Convert.ToDouble(valor2);

            double multi = dubleValor1 * dubleValor2;

            Resultado.Text = multi.ToString();
        }

        private void Divisão_Click(object sender, EventArgs e)
        {
            string valor1 = textBoxValor1.Text;
            string valor2 = textBoxValores2.Text;

            if (!valor1.All(char.IsNumber))
            {
                Resultado.Text = " valor 1 deve ser um numero";
                return;
            }
            if (!valor2.All(char.IsNumber))
            {
                Resultado.Text = "valor 2 deve ser um numero";
                return;
            }

            double dubleValor1 = Convert.ToDouble(valor1);
            double dubleValor2 = Convert.ToDouble(valor2);

            double divisão = dubleValor1 / dubleValor2;
            Resultado.Text = divisão.ToString();
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            string valor1 = textBoxValor1.Text;
            string valor2 = textBoxValores2.Text;

            if (!valor1.All(char.IsNumber))
            {
                Resultado.Text = " valor 1 deve ser um numero";
                return;
            }
            if (!valor2.All(char.IsNumber))
            {
                Resultado.Text = "valor 2 deve ser um numero";
                return;
            }

            double dubleValor1 = Convert.ToDouble(valor1);
            double dubleValor2 = Convert.ToDouble(valor2);

            double sub = dubleValor1 - dubleValor2;
            Resultado.Text = sub.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void textBoxValores2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }
    }
}

                                                                                                                                

