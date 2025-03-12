using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor1 = textBox1.Text;
            string valor2 = textBox2.Text;

            if (string.IsNullOrWhiteSpace(valor1))
            {
                LabelErro.Text = "valor1 não pode ser vazio";
                return;
            }

            if (string.IsNullOrWhiteSpace(valor2))
            {
                LabelErro.Text = "valor2 não pode ser vazio";
                return;
            }
            if (!valor1.All(char.IsNumber))
            {
                LabelErro.Text = "Precisa ser número valido";
                return;
            }
            if (!valor2.All(char.IsNumber))
            {
                LabelErro.Text = "Precisa ser número válido";
                return;
            }
            double dubleValor1 = Convert.ToDouble(valor1);
            double dubleValor2 = Convert.ToDouble(valor2);

            if (label2.Text == "+")
            {
                double soma = dubleValor1 + dubleValor2;

                label1.Text = soma.ToString();
            }
            if (label2.Text == "-")
            {
                double sub = dubleValor1 - dubleValor2;

                label1.Text = sub.ToString();
            }
            if (label2.Text == "/")
            {
                double divisão = dubleValor1 /  dubleValor2;

                label1.Text = divisão.ToString();
            }
            if (label2.Text == "*")
            {
                double muulti = dubleValor1 * dubleValor2;
            }
        }

        private void radioButtonSoma_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "+";
        }

        private void SUB_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "-";
        }
        private void MULTI_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "*";
        }

        private void DIVISÃO_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "/";
        }
    }
}
