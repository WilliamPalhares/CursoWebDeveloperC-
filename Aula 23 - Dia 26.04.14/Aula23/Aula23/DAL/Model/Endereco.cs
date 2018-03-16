using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public int IdCliente { get; set; }

        public Cliente Morador { get; set; }
    }
}
