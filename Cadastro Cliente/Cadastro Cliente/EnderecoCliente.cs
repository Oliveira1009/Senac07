using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Cliente
{
    internal class EnderecoCliente
    {
        public string logradouro { get; set; } 
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string municipio { get; set; }  
        public string estado { get; set; }
        public string cep { get; set; }
        public int número { get; set; }



    }
}
