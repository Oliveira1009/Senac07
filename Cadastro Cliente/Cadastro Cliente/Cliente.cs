using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Cliente
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string endereçodocliente { get; set; }
        public string nomesocial { get; set; }
        public bool estrateijo { get; set; }
        public TipoCliente tipo { get; set; }
        public EnderecoCliente local { get; set; }
        public Etnia etnia { get; set; }
        public Genero genero { get; set; }
    }
}
