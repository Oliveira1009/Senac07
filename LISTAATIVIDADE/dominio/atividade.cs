namespace LISTAATIVIDADE.dominio
{
    internal class atividade
    {


        public int id { get; set; }

        public string titulo { get; set; }

        public Situacao Situacao { get; set; }

        private readonly AtividadeRepositorio repositorio = new();

        public bool Criar()

        {

            if (!ValidarTitulo())

            {

                return false;

            }


            repositorio.Criar(titulo);

            return true;

        }

        public bool AtualizarSituacao()

        {

            if (!ValidarID())

            {

                return false;

            }

            atividade atividadeEmAndamento = BuscarAtividadeEmAndamento();

            Situacao novaSituacao = BuscarProximaSituacao();

            if (atividadeEmAndamento.id > 0 && atividadeEmAndamento.Situacao == novaSituacao)

            {

                return false;

            }

            repositorio.AtualizarSituacao(id, (int)novaSituacao);

            return true;

        }

        public atividade BuscarAtividadeEmAndamento()

        {

            return repositorio.BuscarAtividadeEmAndamento();

        }

        public List<atividade> ListarAtividadesPendentes()

        {

            return repositorio.ListarAtividadesPendentes();

        }

        private bool ValidarID()

        {

            return id > 0;

        }

        private bool ValidarTitulo()

        {

            return !string.IsNullOrEmpty(titulo);

        }

        private bool ValidarSituacao()

        {

            return Situacao != Situacao.Concluido;

        }

        private Situacao BuscarProximaSituacao()

        {

            // if ( Situacao == Situacao.Pendente)

            //  {

            //     return Situacao.Realizando;

            // }

            //  return Situacao.Concluido;

            return Situacao == Situacao.Pendente ? Situacao.Realizado : Situacao.Concluido;

        }

    }

}


       

