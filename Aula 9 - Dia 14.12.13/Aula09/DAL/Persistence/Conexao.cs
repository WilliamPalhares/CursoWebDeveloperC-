using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //para pegar a conexão do Web.config.xml
using System.Data.Entity; //Classes do EF => DbContext e DbSet
using DAL.Model; //namespace das classes mapeadas (entidades)

namespace DAL.Persistence
{
    //Para que a Classe de conexão possa suportar as operações do EF
    //é necessário que esta classe herde System.Data.Entity.DbContext
    //é o DbContext quem gerencia conexão e operações na BD
    public class Conexao : DbContext
    {
        //Para que a Classe DbContext possa receber o caminho da ConnectionString
        //é necessário que passemos essa referência por construtor
        //[ctor] + 2x[tab] -> Construtor default (vazio)
        public Conexao()
            : base(ConfigurationManager.ConnectionStrings["AULA"].ConnectionString)
        {
            //Iremos passar para o construtor da Classe PAI (DbContext) o caminho
            //do BD, para que quando a Classe Conexao seja instanciada, o DbContext
            //imediatamente receba a connectionstring
        }

        //DbSet -> Permitir que as Classes mapeadas sejam manipuladas pelo EF
        //já com operações de INSERT, DELETE, UPDATE E SELECT definidas
        public DbSet<Cliente> Cliente { get; set; }
    }
}
