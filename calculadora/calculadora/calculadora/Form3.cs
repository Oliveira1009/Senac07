using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculadora
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.Add("area");
            comboBox1.Items.Add("perimetro");
            comboBox1.Items.Add("volume");
            comboBox1.SelectedIndex = 0;

        }

        private void Ativar_Click(object sender, EventArgs e)
        {

            try
            {   

                
                double lado;

                if (!double.TryParse(textBox1.Text, out lado) || lado <= 0)

                {

                    MessageBox.Show("Por favor, Insira um Valor válido para lado do quadrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string operacao = comboBox1.SelectedItem.ToString();

                double resultado = 0;

                switch (operacao)

                {

                    case "perimetro":

                        resultado = 4 * lado;

                        break;

                    case "area":

                        resultado = lado * lado;

                        break;

                    case "volume":

                        resultado = lado * lado * lado;

                        break;

                }
                RESULTADO.Text = $"Resultado: {resultado}";

            }
            catch(Exception ex)
            {
                MessageBox.Show("Selecione uma opção valída.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
