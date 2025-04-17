using LISTAATIVIDADE.dominio;

namespace LISTAATIVIDADE
{
    public partial class ListaDeAtividade : Form
    {
        private atividade? atividadeEmAndamento;
        public ListaDeAtividade()
        {
            InitializeComponent();
        }

        private void ListaDeAtividade_Load(object sender, EventArgs e)
        {
           

            labelErro.Text = string.Empty;

            CarregarAtividadeEmAndamento();
            CarregarListaDeAtividades();


        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (atividadeEmAndamento! == null)
            {
                labelErro.Text = "não há atividade em andamento.";
                return;
            }

            if (!atividadeEmAndamento.AtualizarSituacao())
            {
                labelErro.Text = "não foi possivel finalizar a atividade";
                return;
            }
            labelErro.Text = string.Empty;
            CarregarAtividadeEmAndamento();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtividade.SelectedRows.Count <= 0)
            {
                labelErro.Text = "Seleciona uma atividade.";
                return;
            }

            var linhaSelecionada = dataGridViewAtividade.SelectedRows[0];

            atividade atividade = new()
            {
                id = (int)linhaSelecionada.Cells[0].Value,
                titulo = (string)linhaSelecionada.Cells[1].Value,
                Situacao = (Situacao)linhaSelecionada.Cells[2].Value,
            };

            if (!atividade.AtualizarSituacao())
            {
                labelErro.Text = "não foi possivel atualizar a atividade.";
            }

            labelErro.Text = string.Empty;
            CarregarAtividadeEmAndamento();
            CarregarListaDeAtividades();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            var resultado = new CriarAtividade().ShowDialog();

            if (resultado != DialogResult.OK)
            {
                labelErro.Text = "Criação da atividade não foi concluida.";
                return;
            }

            labelErro.Text = "Atividade criada com sucesso.";
            CarregarListaDeAtividades();
        }
        private void CarregarListaDeAtividades()
        {
            atividade atividade = new();

            var atividadesPendentes = atividade.ListarAtividadesPendentes();
            dataGridViewAtividade.DataSource = atividadesPendentes;
        }
        private  void CarregarAtividadeEmAndamento()
        {
            atividade atividade = new();

            atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            string textoAtividade = $"{atividadeEmAndamento.id} - {atividadeEmAndamento.titulo}";
            textBoxAtividadeEmAndamento.Text = atividadeEmAndamento.id > 0 ? textoAtividade : string.Empty;
        }
    }
}
