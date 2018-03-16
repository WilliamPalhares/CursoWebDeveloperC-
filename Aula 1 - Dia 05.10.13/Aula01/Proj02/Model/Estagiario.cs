using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proj02.Model
{
    //Estagiario É-UM Funcionario
    public class Estagiario : Funcionario
    {
        private string funcao;

        public Estagiario()
        {
            //Default
        }

        public string Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }
    }
}
