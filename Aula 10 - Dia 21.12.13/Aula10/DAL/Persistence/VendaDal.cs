using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Model;
using DAL.Dto; //Data Transfer Object

namespace DAL.Persistence
{
    public class VendaDal : IDisposable
    {
        //Atributo para a Classe de conexão
        private Conexao Con; //null

        //[ctor] + 2x[tab]
        public VendaDal() //construtor default
        {
            //inicialização do atributo Conexao
            Con = new Conexao(); //espaço de memória
        }

        //Método para listar todos as vendas por um intervalo de datas
        public List<VendaDto> ListarVendas(DateTime DataInicio, DateTime DataTermino)
        {
            try
            {
                //LINQ -> Language Integrated Query
                //linguagem de consultas nativa do C# aplicada a SQL
                var query = from v in Con.Venda
                            join l in Con.Loja
                            on v.IdLojaFK equals l.IdLoja
                            where v.DataVenda >= DataInicio
                               && v.DataVenda <= DataTermino
                            select v;

                List<VendaDto> lista = new List<VendaDto>(); //lista vazia

                foreach(var registro in query.ToList()) //varrendo a query
                {
                    VendaDto dto = new VendaDto()
                    {
                        Codigo  = registro.IdVenda,
                        Data    = registro.DataVenda,
                        Valor   = registro.Valor,
                        Loja    = registro.Loja.Nome
                    };

                    lista.Add(dto); //adiciono na lista
                }

                return lista; //retornar a lista
            }
            catch(Exception e)
            {
                throw new Exception("Erro ao consultar: " + e.Message);
            }
        }


        //Método destrutor
        public void Dispose()
        {
            Con.Dispose(); //liberar a conexão de memória
        }
    }

}
