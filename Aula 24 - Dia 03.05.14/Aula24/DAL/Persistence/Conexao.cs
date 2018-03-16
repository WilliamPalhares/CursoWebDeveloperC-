using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //acesso nativo ao sqlserver
using System.Configuration; //acessar a connectionstring

namespace DAL.Persistence
{
    public class Conexao
    {
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;
        protected SqlTransaction Tr; //Commit, Rollback

        protected void AbrirConexao()
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_PROD"].ConnectionString);
            Con.Open();
        }

        protected void FecharConexao()
        {
            Con.Close();
        }
    }
}
