using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL.Persistence
{
    public class ClienteDal
    {
        public void Salvar(Cliente c)
        {
            try
            {
                Conexao Con = new Conexao(); //Classe do DbContext
                Con.Cliente.Add(c); //insert do objeto Cliente -> c
                Con.SaveChanges();  //executar
            }
            catch(Exception e)
            {
                throw new Exception("Erro ao cadastrar Cliente: " + e.Message);
            }
        }
    }
}
