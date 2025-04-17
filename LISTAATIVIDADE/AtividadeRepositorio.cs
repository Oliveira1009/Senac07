using LISTAATIVIDADE.BANCODEDADOS;
using LISTAATIVIDADE.dominio;
using MySql.Data.MySqlClient;

namespace LISTAATIVIDADE
{
    internal class AtividadeRepositorio
    {
        public void Criar(string titulo)
        {
            using (var con = Database.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO atividade(titulo) VALUES (@titulo);";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void AtualizarSituacao(int id, int novaSituacao)
        {
            using (var con = Database.GetConnection())
            {

                con.Open();


                string query = "UPDATE ATIVIDADE SET situacao =@situacao WHERE id = @id;";

                //E aqui?
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@situacao", novaSituacao);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public atividade BuscarAtividadeEmAndamento()
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                string query = $"SELECT * FROM atividade WHERE  situacao = {(int) Situacao.Realizado};";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            return new atividade()
                            {
                                id = reader.GetInt32("id"),
                                titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("Situacao")
                            };
                        }
                    }
                }
            }
            return new atividade();
        }
        public List<atividade> ListarAtividadesPendentes()
        {
            List<atividade> atividades = [];

            using (var con = Database.GetConnection())
            {
                con.Open();
                string query = $"SELECT * FROM atividade WHERE situacao = {(int) Situacao.Pendente};";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            atividades.Add(new atividade()
                            {
                                id = reader.GetInt32("id"),
                                titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("Situacao")
                            });
                        }
                    }
                }
            }
            return atividades;
        }
    }
}




       