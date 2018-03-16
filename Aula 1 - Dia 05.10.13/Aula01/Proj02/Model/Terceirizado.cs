using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proj02.Model
{
    public class Terceirizado : Funcionario
    {
        //[propfull] + 2x[tab]
        private string tipo;

        public Terceirizado()
        {
            //Construtor default
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        
    }
}
