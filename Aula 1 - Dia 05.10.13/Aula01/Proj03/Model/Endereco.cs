using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proj03.Model
{
    public class Endereco
    {
        private int idEndereco;
        private string logradouro;        

        public Endereco()
        {
            //Construtor default
        }

        public int IdEndereco
        {
            get { return idEndereco; }
            set { idEndereco = value; }
        }

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }
    }
}
