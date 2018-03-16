using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    public class ClienteDal : Conexao
    {
        //Método para cadastrar Cliente e Endereco
        public void Salvar(Cliente c)
        {

        }

        //Método para listar os Clientes e Enderecos
        public List<Cliente> ListarTodos()
        {
            return null;
        }
    }
}
