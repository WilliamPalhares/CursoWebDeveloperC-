using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proj03.Model
{
    public class Cliente
    {
        private int idCliente;
        private string nome;
        private Endereco residencia; //Associação (TER-1)

        public Cliente()
        {
            //Construtor default
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }       

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Endereco Residencia
        {
            get { return residencia; }
            set { residencia = value; }
        }
    }
}
