using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proj02.Model
{
    public class Funcionario
    {
        //[#region] + 2x[tab]
        #region Atributos

        private int idFuncionario;
        private string nome;
        private double salario;

        #endregion

        #region Construtores
        
        //[ctor] + 2x[tab]
        public Funcionario()
        {
            //Default
        }

        public Funcionario(int idFuncionario, string nome, double salario)
        {
            this.idFuncionario = idFuncionario;
            this.nome = nome;
            this.salario = salario;
        }

        #endregion

        #region Encapsulamento

        public int IdFuncionario
        {
            set { idFuncionario = value; } //Entrada
            get { return idFuncionario; } //Saída
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public double Salario
        {
            set { salario = value; }
            get { return salario; }
        }

        #endregion
    }
}
