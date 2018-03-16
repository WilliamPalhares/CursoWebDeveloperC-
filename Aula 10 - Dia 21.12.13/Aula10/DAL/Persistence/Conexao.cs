using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity; //DbContext e DbSet
using System.Configuration; //referência da ConnectionString
using DAL.Model; //Classes mapeadas

namespace DAL.Persistence
{
    //Para que esta classe possa conectar-se a uma base de dados
    //é necessário que façamos uma herança de System.Data.Entity.DbContext
    public class Conexao : DbContext
    {
        //[ctor] + 2x[tab]
        public Conexao() //Construtor da subclasse chamar o da SuperClasse
            : base(ConfigurationManager.ConnectionStrings["AULA"].ConnectionString)
        {
            //O construtor da Classe Conexão inicializa o Construtor da Classe
            //DbContext enviado o caminho da connectionstring do \Web.config.xml
        }

        //declarar atributos para cada Classe mapeada
        //DbSet -> dá suporte às operações de CRUD (insert, delete, update, etc...)
        public DbSet<Loja> Loja { get; set; }
        public DbSet<Venda> Venda { get; set; }
    }    
}
