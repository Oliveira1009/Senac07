using Cadastro_Cliente.banco_de_dados;
using Cadastro_Cliente.dominio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Cliente.repositorio
{
    internal class ClienteRepositorio
    {
        public List<Cliente> ListarClientes()
        {
            var clientes = new List<Cliente>();

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = "SELECT c.*, e.logradouro,e.numero, e.complemento,e.bairro, e.municipio, e.estado, e.cep FROM cliente c JOIN endereco e ON c.id_endereco =e.id;";

                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var nomeSocial = !reader.IsDBNull("nome_social") ? reader.GetString("nome_social") : "";
                    var complemento = !reader.IsDBNull("complemento") ? reader.GetString("complemento") : "";

                    clientes.Add(new Cliente
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        nomesocial = nomeSocial,
                        DataNascimento = reader.GetDateTime("data_nascimento"),
                        email = reader.GetString("email"),
                        telefone = reader.GetString("telefone"),
                        tipo = (TipoCliente)reader.GetInt32("tipo"),
                        etnia = (Etnia)reader.GetInt32("entnia"),
                        genero = (Genero)reader.GetInt32("genero"),
                        estrageiro = reader.GetBoolean("estrageiro"),
                        EnderecoCliente = new EnderecoCliente
                        {
                            Id = reader.GetInt32("id_endereco"),
                            logradouro = reader.GetString("logradouro"),
                            número = reader.GetString("número"),
                            complemento = complemento,
                            bairro = reader.GetString("bairro"),
                            municipio = reader.GetString("municipio"),
                            estado = reader.GetString("estado"),
                            cep = reader.GetString("cep")
                        }
                    });
                }
            }

            return clientes;
        }
        public void InserirCliente(Cliente novoCliente)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string queryEndereco = "INSERT INTO endereco (logradouro, numero, bairro, municipio, estado, cep, complemento)" +
                    "VALUES (@logradouro, @numero, @bairro, @municipio, @estado, @cep, @complemento);";

                using (var cmd = new MySqlCommand(queryEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@logradouro", novoCliente.EnderecoCliente.logradouro);
                    cmd.Parameters.AddWithValue("@numero", novoCliente.EnderecoCliente.número);
                    cmd.Parameters.AddWithValue("@bairro", novoCliente.EnderecoCliente.bairro);
                    cmd.Parameters.AddWithValue("@municipio", novoCliente.EnderecoCliente.municipio);
                    cmd.Parameters.AddWithValue("@estado", novoCliente.EnderecoCliente.estado);
                    cmd.Parameters.AddWithValue("@cep", novoCliente.EnderecoCliente.cep);
                    cmd.Parameters.AddWithValue("@complemento", novoCliente.EnderecoCliente.complemento);
                    cmd.ExecuteNonQuery();
                }

                int idEndereco = -1;
                string queryIdEndereco = "SELECT id FROM endereco" +
                    "where logradouro = @logradouro" +
                    "AND numero = @numero" +
                    "AND bairro = @bairro" +
                    "AND municipio = @municipio" +
                    "AND estado = @estado" +
                    "AND cep = @cep" +
                    "AND complemento = @complemento;";

                using (var cmd = new MySqlCommand(queryIdEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@logradouro", novoCliente.EnderecoCliente.logradouro);
                    cmd.Parameters.AddWithValue("@numero", novoCliente.EnderecoCliente.número);
                    cmd.Parameters.AddWithValue("@bairro", novoCliente.EnderecoCliente.bairro);
                    cmd.Parameters.AddWithValue("@municipio", novoCliente.EnderecoCliente.municipio);
                    cmd.Parameters.AddWithValue("@estado", novoCliente.EnderecoCliente.estado);
                    cmd.Parameters.AddWithValue("@cep", novoCliente.EnderecoCliente.cep);
                    cmd.Parameters.AddWithValue("@complemento", novoCliente.EnderecoCliente.complemento);
                    using (var reader = cmd.ExecuteReader())
                    {
                        idEndereco = reader.Read() ? reader.GetInt32("id") : -1;
                    }
                }

                string query = "INSERT INTO cliente(nome,nome_social,data_nascimento,email,telefone,tipo,etnia, genero , estrangeiro, id_endereco)" +
                    "VALUES (@Nome,@nomeSocial,@DataNascimento,@email,@telefone,@tipo,@etnia, @genero ,@estrangeiro,@id_endereco);";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", novoCliente.Nome);
                    cmd.Parameters.AddWithValue("@nome_social", novoCliente.nomesocial);
                    cmd.Parameters.AddWithValue("@data_nascimento", novoCliente.DataNascimento);
                   cmd.Parameters.AddWithValue("@email", novoCliente.email);
                   cmd.Parameters.AddWithValue("@telefone", novoCliente.telefone);
                    cmd.Parameters.AddWithValue("@tipo", novoCliente.tipo);
                    cmd.Parameters.AddWithValue("@etnia", novoCliente.etnia);
                    cmd.Parameters.AddWithValue("@genero", novoCliente.genero);
                    cmd.Parameters.AddWithValue("@estrangeiro", novoCliente.estrageiro);
                    cmd.Parameters.AddWithValue("@id_endereco", idEndereco);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}
