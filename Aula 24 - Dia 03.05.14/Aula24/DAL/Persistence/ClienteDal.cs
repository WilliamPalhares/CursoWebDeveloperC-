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
            try
            {
                AbrirConexao();
                Tr = Con.BeginTransaction(); //iniciando uma transação

                //gravando os dados do Cliente
                Cmd = new SqlCommand("insert into Cliente(Nome, Email, DataCadastro) values(@v1, @v2, @v3)", Con, Tr);
                Cmd.Parameters.AddWithValue("@v1", c.Nome);
                Cmd.Parameters.AddWithValue("@v2", c.Email);
                Cmd.Parameters.AddWithValue("@v3", c.DataCadastro);
                Cmd.ExecuteNonQuery(); //executando

                //resgatar o id do cliente que foi cadastrado
                Cmd = new SqlCommand("select ident_current('Cliente') as Codigo", Con, Tr);
                Dr = Cmd.ExecuteReader(); //executa e retorna registros

                if (Dr.Read()) //verificando se o DataReader obteve algum registro
                {
                    int Codigo = Convert.ToInt32(Dr["Codigo"]); //leitura do Id do Cliente
                    Dr.Close(); //fechando o DataReader

                    //gravando o endereço
                    Cmd = new SqlCommand("insert into Endereco(Logradouro, Cep, IdCliente) values(@v1, @v2, @v3)", Con, Tr);
                    Cmd.Parameters.AddWithValue("@v1", c.Residencia.Logradouro);
                    Cmd.Parameters.AddWithValue("@v2", c.Residencia.Cep);
                    Cmd.Parameters.AddWithValue("@v3", Codigo); //chave estrangeira
                    Cmd.ExecuteNonQuery(); //executar
                }
                else
                {
                    throw new Exception(); //forçar um erro!
                }

                Tr.Commit(); //executando a transação
            }
            catch (Exception e)
            {
                Tr.Rollback(); //desfazer a transação
                throw new Exception("Erro ao salvar cliente: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para listar os Clientes e Enderecos
        public List<Cliente> ListarTodos()
        {
            return null;
        }
    }
}
