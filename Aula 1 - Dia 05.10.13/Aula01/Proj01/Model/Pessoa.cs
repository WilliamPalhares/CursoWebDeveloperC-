//importações de bibliotecas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//localização da Classe dentro do Projeto
namespace Proj01.Model
{
    //Definição da Classe
    //Modificador de visibilidade
    //public  -> acesso total (não há restrições para acesso)
    //private -> acesso somente é permitido dentro da própria Classe
    public class Pessoa
    {
        //Atributos (dados)
        private int idPessoa;
        private string nome;
        private string email;

        //Construtor padrão da Classe
        //[ctor] + 2x[tab]
        public Pessoa()
        {
            //Vazio (default)
        }

        public Pessoa(int idPessoa, string nome, string email)
        {
            this.idPessoa = idPessoa;
            this.nome = nome;
            this.email = email;
        }

        //Encapsulamento
        //Métodos para controlar a entrada e saída de
        //dados para os atributos privados
        public int IdPessoa
        {
            set { idPessoa = value; } //entrada
            get { return idPessoa; } //saída
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }
    }
}
