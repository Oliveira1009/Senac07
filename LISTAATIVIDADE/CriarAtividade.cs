using LISTAATIVIDADE.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTAATIVIDADE
{
    public partial class CriarAtividade : Form
    {
        public CriarAtividade()
        {
            InitializeComponent();
        }

        private void buttonDescartar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonCriar_Click_1(object sender, EventArgs e)
        {
            atividade atividade = new atividade()
            {
                titulo = textBoxTitulo.Text
            };

            if (!atividade.Criar())
            {
                labelErro.Text = "não foi possivel criar a atividade.";
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CriarAtividade_Load_1(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;
        }
    }
}
