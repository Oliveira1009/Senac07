using panorama.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panorama.dominio
{
    internal class cliente
    {

        private readonly Cadastrocliente cadastrocliente = new();

        public int id {  get; set; }
        public string nome { get; set; }

        public string telefone { get; set; }

    }
}
