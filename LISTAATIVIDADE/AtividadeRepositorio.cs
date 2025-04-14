using LISTAATIVIDADE.BANCODEDADOS;
using MySql.Data.MySqlClient;

namespace LISTAATIVIDADE
{
    internal class AtividadeRepositorio
    {
        public void Criar(string titulo)
        {
            using (var con = Database.GetConnectin())
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
            using (var con = Database.GetConnectin())
            {

                con.Open();

               
                string query = "UPDATE ATIVIDADE SET situacao =@situacao WHERE id = @id;";

                //E aqui?
                using (var cmd = new MySqlCommand())
                {
                    cmd.Parameters.AddWithValue("@situacao", novaSituacao);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}