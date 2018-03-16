using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class ClienteModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
    }
}