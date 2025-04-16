using LISTAATIVIDADE.dominio;

namespace LISTAATIVIDADE
{
    public partial class ListaDeAtividade : Form
    {
        public ListaDeAtividade()
        {
            InitializeComponent();
        }

        private void ListaDeAtividade_Load(object sender, EventArgs e)
        {
            atividade atividade = new();

            var atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();  
            textBoxAtividadeEmAndamento.Text = $"(atividadeEmAndamento.id) -(atividadeEmAndamento.titulo)";

         
            var atividadesPendentes = atividade.ListarAtividadesPendentes();
           dataGridViewAtividade.DataSource = atividadeEmAndamento; 

        }
    }
}
